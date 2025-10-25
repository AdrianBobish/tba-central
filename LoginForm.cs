using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail;
using System.Net;
using MySql.Data.MySqlClient;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace TBA_Central
{
    public partial class LoginForm : Form
    {
        private string connStr = "server=129.159.153.107;uid=bobish;pwd=C!%.1(f_bN}M:;database=TBA-Central-DB";
        private string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\Resources\";

        private int timerTick;
        private int codEroare;

        private int val;
        private string emailUtilizator;
        private string codSecret;

        public LoginForm()
        {
            InitializeComponent();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(resPath + @"UI-Elements\login-back.jpg");
            var conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();  conn.Close();
                conn.Dispose();
            }
            catch
            {
                MessageBox.Show("Conecțiunea cu server-ul a eșuat.\n\n     Aplicația va fi închisă", "Eroare", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (timerTick != 0 && timerTick != 5) return;
            if (btnLogare.Text == "Verificare")
            {
                codEroare = 1;
                if (txtEmail.Texts != codSecret)
                    codEroare = 3;

                timerTick = 0;  timerAfisaj.Start();
                return;
            }

            timerAfisaj.Stop();  timerTick = 0;

            var email = txtEmail.Texts;
            var parola = txtParola.Texts;

            var conn = new MySqlConnection(connStr);  conn.Open();
            var cmd = new MySqlCommand("ExistaUtilizator", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_email", email);
            cmd.Parameters.AddWithValue("p_parola", parola);
            int x = (int)(Int64)cmd.ExecuteScalar();

            conn.Close();  conn.Dispose();
            cmd.Dispose();

            if(x == 0)
            {
                txtEmail.Texts = txtParola.Texts = string.Empty;
                
                codEroare = 0;
            }

            else  codEroare = 1;
                
            timerAfisaj.Start();
        }

        private void timerEroare_Tick(object sender, EventArgs e)
        {
            if(timerTick == 0)
            {
                switch(codEroare)
                {
                    case 0:
                        lblAfisaj.ForeColor = Color.Firebrick;
                        lblAfisaj.Text = "eMail-ul sau parola sunt incorecte";
                        break;

                    case 1:
                        lblAfisaj.ForeColor = Color.ForestGreen;
                        lblAfisaj.Text = "Ați fost logat(ă) cu succes!";
                        btnLogare.Enabled = false;
                        break;

                    case 2:
                        lblAfisaj.ForeColor = Color.Firebrick;
                        lblAfisaj.Text = "Vă rugăm introduceți un eMail valid";
                        break;

                    case 3:
                        lblAfisaj.ForeColor = Color.Firebrick;
                        lblAfisaj.Text = "Codul introdus este incorect";
                        break;
                }

                lblAfisaj.Visible = true;
            }                

            timerTick++;

            if(timerTick == 5)  // PENTRU PROTOTIP !! (VALOARE NORMALA - 35)
            {
                lblAfisaj.Visible = false;
                timerAfisaj.Stop(); timerTick = 0;

                if(codEroare == 1)
                {
                    string email = txtEmail.Texts;
                    if (emailUtilizator != null)
                        email = emailUtilizator;

                    this.Visible = false;
                    var frm = new MainForm(email);
                    frm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (timerTick != 0 && timerTick != 5)  return;
            if (btnInregistrare.Text == "Înapoi")
            {
                val = -4;  timerTick = 0;
                timerAnimatie.Start();

                return;
            }

            var frm = new RegisterForm();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)  return;

            btnLogare.PerformClick();
        }

        private void timerAnimatie_Tick(object sender, EventArgs e)
        {
            if (timerTick == 0)
            {
                lblParola.Visible = txtParola.Visible =
                    lblRecuperare.Visible = false;
            }            

            lblLogo.Top += val;  lblMesaj.Top += val / 2;
            lblEmail.Top += val;  txtEmail.Top += val;
            lblAfisaj.Top -= val;  
            btnInregistrare.Top -= val;  btnLogare.Top -= val;

            timerTick++;

            if (timerTick == 5)
            {
                timerAnimatie.Stop();

                lblMesaj.Text = (val > 0) ? "Verificare" : "Logare";
                lblEmail.Text = (val > 0) ? "Cod de verificare: " : "eMail: ";
                txtEmail.Texts = txtParola.Texts = "";
                btnInregistrare.Text = (val > 0) ? "Înapoi" : "Înregistrare";
                btnLogare.Text = (val > 0) ? "Verificare" : "Logare";

                lblParola.Visible = txtParola.Visible =
                    lblRecuperare.Visible = (val > 0) ? false : true;

                Application.DoEvents();
                if (val > 0)  TrimiteCod();
            }
        }

        private void TrimiteCod()
        {
            var rand = new Random();
            var cod = (Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 6)
                .Select(s => s[rand.Next(s.Length)]).ToArray());
            codSecret = new string(cod);

            var mail = new MailMessage()
            {
                From = new MailAddress("adrian.teodor.bobis@cnlr.ro"),
                Subject = "TBA Central — Cod recuperare cont",
                Body = File.ReadAllText(resPath + "email-confirmation.html").Replace("{codSecret}", codSecret),
                IsBodyHtml = true
            }; mail.To.Add(emailUtilizator);

            var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("adrian.teodor.bobis@cnlr.ro", "Adrian6002#%"),
                EnableSsl = true
            };  smtp.Send(mail);

            mail.Dispose();  smtp.Dispose();
        }

        private void lblRecuperare_Click(object sender, EventArgs e)
        {
            lblRecuperare.ForeColor = Color.LightBlue;
            emailUtilizator = txtEmail.Texts;

            if(!emailUtilizator.Contains("@") || !emailUtilizator.Contains(".")) {
                codEroare = 2;
                timerTick = 0;  timerAfisaj.Start();

                return;
            }

            val = 4;  timerTick = 0;
            timerAnimatie.Start();
        }

        private void lblRecuperare_MouseHover(object sender, EventArgs e)
        {
            lblRecuperare.ForeColor = Color.SteelBlue;
        }

        private void lblRecuperare_MouseLeave(object sender, EventArgs e)
        {
            lblRecuperare.ForeColor = Color.DodgerBlue;
        }
    }
}
