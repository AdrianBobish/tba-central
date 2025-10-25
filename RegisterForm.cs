using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TBA_Central
{
    public partial class RegisterForm : Form
    {
        private string connStr = @"server=129.159.153.107;uid=bobish;pwd=C!%.1(f_bN}M:;database=TBA-Central-DB";
        private string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\Resources\";
        private string privPass = "C!%.1(f_bN}M:";

        private int timerTick;
        private int eroare;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(resPath + @"UI-Elements\register-back.jpg");

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Texts, prenume = txtPrenume.Texts, email = txtEmail.Texts;
            string parola = txtParola.Texts, confirmare = txtConfirmare.Texts, parolaPriv = txtPrivilegii.Texts;
            bool privilegiu = false;

            if (chkAfirmativ.Checked == true) 
                privilegiu = true;            

            if(nume == string.Empty || prenume == string.Empty || email == string.Empty 
                || (privilegiu == false && parola == string.Empty))
            {
                eroare = 1;

                timerAfisaj.Start();  return;
            }

            var con = new MySqlConnection(connStr); con.Open();
            var cmd = new MySqlCommand("ExistaEmail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_email", email);
            int x = (int)(Int64)cmd.ExecuteScalar();

            if (x != 0 || !email.Contains("@") || !email.Contains("."))
            {
                eroare = 4;

                timerAfisaj.Start();  return;
            }

            if (parola != confirmare)
            {
                eroare = 2;

                timerAfisaj.Start();  return;
            }

            if(privilegiu == true && parolaPriv != privPass)
            {
                eroare = 3;

                timerAfisaj.Start();  return;
            }            

            cmd = new MySqlCommand("IntroduUtilizator", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_nume", nume);
            cmd.Parameters.AddWithValue("p_prenume", prenume);
            cmd.Parameters.AddWithValue("p_email", email);
            cmd.Parameters.AddWithValue("p_parola", parola);
            cmd.Parameters.AddWithValue("p_privilegiu", privilegiu);
            cmd.Parameters.AddWithValue("p_credite", 0);
            cmd.ExecuteNonQuery();

            eroare = 0;  timerAfisaj.Start();            

            con.Close();  con.Dispose();
            cmd.Dispose();
        }

        private void timerAfisaj_Tick(object sender, EventArgs e)
        {
            if (timerTick == 0)
            {
                switch(eroare)
                {
                    case 1:
                        lblAfisaj.ForeColor = Color.DarkRed;
                        lblAfisaj.Text = "Câmpurile pentru nume, prenume, eMail și parolă nu trebuie să fie goale!";
                        break;

                    case 2:
                        lblAfisaj.ForeColor = Color.DarkRed;
                        lblAfisaj.Text = "Parola introdusă nu coincide cu confirmarea acesteia!";
                        break;

                    case 3:
                        lblAfisaj.ForeColor = Color.DarkRed;
                        lblAfisaj.Text = "_eroare_";
                        break;

                    case 4:
                        lblAfisaj.ForeColor = Color.DarkRed;
                        lblAfisaj.Text = "eMail-ul introdus nu este valid!";
                        txtEmail.Text = string.Empty;
                        break;

                    case 0:
                        lblAfisaj.ForeColor = Color.ForestGreen;
                        lblAfisaj.Text = "Ați fost înregistrat(ă) cu succes!";
                        btnInregistrare.Enabled = false;
                        break;
                }

                lblAfisaj.Visible = true;
            }

            timerTick++;

            if (timerTick == 45)
            {
                lblAfisaj.Visible = false;
                timerAfisaj.Stop(); timerTick = 0;

                if (eroare == 0)
                    this.Close();
            }
        }

        private void chkAfirmativ_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfirmativ.Checked == false) { chkNegativ.Checked = true; return; }

            chkNegativ.Checked = false;
            lblCod.Visible = txtPrivilegii.Visible = true;
        }

        private void chkNegativ_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNegativ.Checked == false) { chkAfirmativ.Checked = true; return; }

            chkAfirmativ.Checked = false;
            lblCod.Visible = txtPrivilegii.Visible = false;
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            btnInregistrare.PerformClick();
        }
    }
}
