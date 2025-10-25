using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TBA_Central
{
    public partial class ProfileForm : Form
    {
        private string connStr = @"server=129.159.153.107;uid=bobish;pwd=C!%.1(f_bN}M:;database=TBA-Central-DB";
        private string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\Resources\";

        private bool privilegiu;
        private int idUtilizator;
        private int idEroare;

        private int timerTick;
        private int timerEroareTick;

        FileStream fs;

        private bool formClosing;

        public ProfileForm(int id)
        {
            InitializeComponent();

            idUtilizator = id;
        }

        private string SeparareNumar(string numar)
        {
            for (int i = numar.Length - 1, j = 1; i >= 1; i--, j++)
                if (j == 3)
                {
                    numar = numar.Insert(i, ".");

                    j = 0;
                }


            return numar;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {      
            var con = new MySqlConnection(connStr); con.Open();
            var cmd = new MySqlCommand("EsteAdministrator", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", idUtilizator);
            privilegiu = (bool)cmd.ExecuteScalar();

            con.Close();  con.Dispose();
            cmd.Dispose();

            pbAnimatie1.Image = Image.FromFile(resPath + "UI-Elements\\profile-anim.gif");
            timer.Start();

            AtribuireParent(lblAfisaj);
            AtribuireParent(btnInapoi);  AtribuireParent(btnEdit);

            var pos = lblCredite.Parent.PointToScreen(lblCredite.Location);
            pos = pbAnimatie5.PointToClient(pos);
            lblCredite.Parent = pbAnimatie5;
            lblCredite.Location = pos;

            Initializare();

            return;
        }

        private void AtribuireParent(Control ctrl)
        {
            var pos = ctrl.Parent.PointToScreen(ctrl.Location);
            pos = pbAnimatie1.PointToClient(pos);
            ctrl.Parent = pbAnimatie1;
            ctrl.Location = pos;

        }

        private void Initializare()
        {
            try
            {
                fs = new FileStream(resPath + $@"Users\{idUtilizator}.png",
                    FileMode.Open, FileAccess.Read);
            }
            catch
            {
                fs = new FileStream(resPath + $@"Users\generic.png",
                    FileMode.Open, FileAccess.Read);
            }

            pbProfil.Image = Image.FromStream(fs);
            fs.Close();

            btnInapoi.Enabled = btnEdit.Enabled = true;

            btnInapoi.Text = "Înapoi";
            btnEdit.Text = "Editați profilul";

            txtNume.ReadOnly = txtPrenume.ReadOnly =
                txtEmail.ReadOnly = txtParola.ReadOnly = true;
            txtNume.BorderSize = txtPrenume.BorderSize =
                txtEmail.BorderSize = txtParola.BorderSize = 0;
            txtParola.PasswordChar = true;
            btnSchimbaPoza.Visible = false;

            var con = new MySqlConnection(connStr); con.Open();
            var cmd = new MySqlCommand("SelectUtilizator", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", idUtilizator);

            var dr = cmd.ExecuteReader(); dr.Read();
            string credite = SeparareNumar(dr[6].ToString()) + " €", nume = dr[1].ToString(), prenume = dr[2].ToString(), eMail = dr[3].ToString(), parola = dr[4].ToString();

            lblCredite.Text = credite; txtNume.Texts = nume;
            txtPrenume.Texts = prenume; txtEmail.Texts = eMail;
            txtParola.Texts = parola;

            con.Close(); con.Dispose();
            cmd.Dispose();
            dr.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch(timerTick)
            {
                case 1:
                    pbAnimatie2.Image = Image.FromFile(resPath + "UI-Elements\\profile-anim.gif");
                    pbAnimatie2.Visible = true; 
                    break;

                case 2:
                    pbAnimatie3.Image = Image.FromFile(resPath + "UI-Elements\\profile-anim.gif");
                    pbAnimatie3.Visible = true;
                    break;

                case 3:
                    pbAnimatie4.Image = Image.FromFile(resPath + "UI-Elements\\profile-anim.gif");
                    pbAnimatie4.Visible = true;
                    break;

                case 4:
                    pbAnimatie5.Image = Image.FromFile(resPath + "UI-Elements\\profile-anim.gif");
                    pbAnimatie5.Visible = true;
                    timerTick = 0;
                    timer.Stop(); 
                    break;
            }

            timerTick++;
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            if (btnInapoi.Text == "Renunțați")
            {
                var dr = MessageBox.Show("Sunteți sigur(ă) că doriți să renunțați la modificările efectuate?",
                    "Întrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Initializare();

                    formClosing = true;
                }                    

                return;
            }

            this.Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Editați profilul")
            {
                btnInapoi.Text = "Renunțați";
                btnEdit.Text = "Salvați modif.";

                txtNume.ReadOnly = txtPrenume.ReadOnly =
                    txtEmail.ReadOnly = txtParola.ReadOnly = false;
                txtNume.BorderSize = txtPrenume.BorderSize =
                    txtEmail.BorderSize = txtParola.BorderSize = 2;
                txtParola.PasswordChar = false;
                btnSchimbaPoza.Enabled = true;
                btnSchimbaPoza.Visible = true;

                return;
            }

            timerEroareTick = 0;
            idEroare = -1;

            string nume = txtNume.Texts, prenume = txtPrenume.Texts,
                email = txtEmail.Texts, parola = txtParola.Texts;
            //string confirmare = txtConfirmare.Texts;

            if (nume == string.Empty || prenume == string.Empty ||
                    email == string.Empty || (parola == string.Empty && !privilegiu))
                idEroare = 0;

            else if (!EmailValid(email))
                idEroare = 1;

            //else if(parola != confirmare)
            //    idEroare = 2;

            else {
                var con = new MySqlConnection(connStr); con.Open();
                var cmd = new MySqlCommand("UpdateUtilizatori", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_nume", nume);
                cmd.Parameters.AddWithValue("p_prenume", prenume);
                cmd.Parameters.AddWithValue("p_email", email);
                cmd.Parameters.AddWithValue("p_parola", parola);
                cmd.Parameters.AddWithValue("p_id", idUtilizator);
                cmd.ExecuteNonQuery();

                con.Close(); con.Dispose();
                cmd.Dispose();

                idEroare = 3;
            }

            lblAfisaj.Visible = true;
            lblAfisaj.ForeColor = Color.Firebrick;

            switch (idEroare)
            {
                case 0:
                    lblAfisaj.Text = "Niciun câmp nu trebuie să fie nul!";
                    break;

                case 1:
                    lblAfisaj.Text = "eMail-ul nu este valid";
                    break;

                case 2:
                    lblAfisaj.Text = "Parola nu coincide cu confirmarea acesteia";
                    break;

                case 3:
                    lblAfisaj.Text = "Modificările au fost realizate cu succes!";
                    lblAfisaj.ForeColor = Color.Green;
                    btnInapoi.Enabled = btnSchimbaPoza.Enabled =
                        btnEdit.Enabled = false;
                    break;

            }

            timerEroare.Start();            

            try 
            {
                var img = pbProfil.Image;
                var filePath = resPath + $"Users\\{idUtilizator}.png";

                GC.Collect();
                GC.WaitForPendingFinalizers();
                if (File.Exists(filePath)) File.Delete(filePath);

                img.Save(filePath, ImageFormat.Png);
                img.Dispose();
            } catch { 
            
            }            
            
        }

        private void btnSchimbaPoza_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog() { 
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Filter = "Image files (*.png) | *.png",
                RestoreDirectory = true
            };

            if(openFileDialog.ShowDialog() == DialogResult.OK)
                pbProfil.Image = Image.FromFile(openFileDialog.FileName);
                
        }

        private bool EmailValid(string email)
        {
            if(!email.Contains("@") || !email.Contains("."))
                return false;

            var con = new MySqlConnection(connStr);  con.Open();
            var cmd = new MySqlCommand("ExistaEmailId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_email", email);
            cmd.Parameters.AddWithValue("p_id", idUtilizator);
            int x = (int)(Int64)cmd.ExecuteScalar();

            con.Close();  con.Dispose();
            cmd.Dispose();

            if (x != 0) 
                return false;
            return true;
        }        

        private void timerEroare_Tick(object sender, EventArgs e)
        {
            if(timerEroareTick == 3)
            {
                if (idEroare == 3)
                    Initializare();

                lblAfisaj.Visible = false;
                timerEroare.Stop();
            }

            timerEroareTick++;
        }

        private void txtNume_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)  return;

            btnEdit.PerformClick();
        }

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnInapoi.Text == "Renunțați")
            {
                formClosing = false; btnInapoi.PerformClick();

                if(!formClosing)  e.Cancel = true;
            }                

        }
    }
}
