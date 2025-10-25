using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBA_Central.CustomControls;
using MySql.Data.MySqlClient;

namespace TBA_Central
{
    public partial class CreditsForm : Form
    {
        private string connStr = @"server=129.159.153.107;uid=bobish;pwd=C!%.1(f_bN}M:;database=TBA-Central-DB";
        private string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\Resources\";

        private int timerTick;
        private int timerEroareTick;
        private int idEroare;

        private int idUtilizator;
        private int crediteActuale;
        private int crediteAdaugate;

        private bool tranzactieReusita;
        
        public CreditsForm(int id)
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

        private void CrediteForm_Load(object sender, EventArgs e)
        {
            Initializeaza();

        }

        private void Initializeaza()
        {
            lblAfisaj.ForeColor = Color.Firebrick;
            btnInapoi.Enabled = btnAdaugaCredite.Enabled = true;
            nmbSuma.Value = 0;

            lblCredite.Parent = lblMesaj;

            pbAnimatie1.Image = Image.FromFile(resPath + "UI-Elements\\profile-anim.gif");
            timer.Start();

            var con = new MySqlConnection(connStr); con.Open();
            var cmd = new MySqlCommand("SelectUtilizator", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", idUtilizator);

            var dr = cmd.ExecuteReader(); dr.Read();
            crediteActuale = crediteAdaugate = ((int)dr[6]);
            string credite = SeparareNumar(crediteActuale.ToString()), eMail = dr[3].ToString();

            lblCredite.Text = "CREDITE: " + credite + " €";
            lblMesaj.Text = "INTRODUCEȚI DATELE DE FACTURARE PENTRU CONTUL CU EMAIL-UL " + eMail.ToUpper();

            dr.Close();

            cmd = new MySqlCommand("SelectFacturi", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", idUtilizator);
            dr = cmd.ExecuteReader(); dr.Read();

            try
            {
                string nrCard = dr[1].ToString(), cvc = dr[3].ToString(), numeTitular = dr[4].ToString(),
                    numeFirma = dr[5].ToString(), cui = dr[6].ToString(), nrRegCom = dr[7].ToString();
                DateTime data = (DateTime)dr[2];

                int luna = int.Parse(data.ToString("MM"));
                int an = int.Parse(data.ToString("yy"));

                txtNumarCard.Texts = nrCard; txtLuna.Texts = luna.ToString(); txtAn.Texts = an.ToString();
                txtCVC.Texts = cvc; txtNumeTitular.Texts = numeTitular;

                if (numeFirma != string.Empty)
                {
                    chkPjuridica.Checked = true;

                    txtNumeFirma.Texts = numeFirma; txtCUI.Texts = cui;
                    txtNrRegCom.Texts = nrRegCom;
                }

            }
            catch
            {

            }

            con.Close(); con.Dispose();
            cmd.Dispose();
            dr.Close();

            tranzactieReusita = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (timerTick)
            {
                case 1:
                    pbAnimatie2.Image = Image.FromFile(resPath + "UI-Elements\\profile-anim.gif");
                    break;

                case 2:
                    pbAnimatie3.Image = Image.FromFile(resPath + "UI-Elements\\profile-anim.gif");
                    break;

                case 3:
                    pbAnimatie4.Image = Image.FromFile(resPath + "UI-Elements\\profile-anim.gif");
                    break;

                case 4:
                    timerTick = 0;
                    timer.Stop();
                    break;
            }

            timerTick++;
        }

        private void timerEroare_Tick(object sender, EventArgs e)
        {
            if (timerEroareTick == 3)
            {
                timer.Stop();
                lblAfisaj.Visible = false;

                if (idEroare == 0)
                    Initializeaza();
                    
            }
            
            timerEroareTick++;    
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxPfizica_CheckedChanged(object sender, EventArgs e)
        {
            if (tranzactieReusita) tranzactieReusita = false;

            if (chkPfizica.Checked == false) { chkPjuridica.Checked = true; return; }

            chkPjuridica.Checked = false;
            panel.Enabled = false;
        }

        private void cbxPjuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (tranzactieReusita) tranzactieReusita = false;

            if (chkPjuridica.Checked == false) { chkPfizica.Checked = true; return; }

            chkPfizica.Checked = false;
            panel.Enabled = true;
        }

        private void txtNumarCard__TextChanged(object sender, EventArgs e)
        {
            if (tranzactieReusita) tranzactieReusita = false;

            var textBox = (TextBox)sender;

            var rgx = new Regex("[^0-9]");
            var text = rgx.Replace(textBox.Text, "");

            textBox.Text = text;
        }


        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            if(tranzactieReusita)  tranzactieReusita = false;
        }

        private void nmbSuma_ValueChanged(object sender, EventArgs e)
        {
            if (tranzactieReusita) tranzactieReusita = false;

            crediteAdaugate = crediteActuale + (int)nmbSuma.Value;

            lblCredite.Text = "CREDITE: " + SeparareNumar(crediteAdaugate.ToString()) + " €";
        }

        private void btnAdaugaCredite_Click(object sender, EventArgs e)
        {
            idEroare = 0;

            string nrCard = txtNumarCard.Texts, cvc = txtCVC.Texts, numeTitular = txtNumeTitular.Texts, 
                numeFirma = txtNumeFirma.Texts, cui = txtCUI.Texts, nrRegCom = txtNrRegCom.Texts;

            int luna = 0, an = 0;
            int.TryParse(txtLuna.Texts, out luna);
            int.TryParse(txtAn.Texts, out an);

            if (crediteAdaugate == crediteActuale)
                idEroare = 1;

            else if (nrCard == "" || luna == 0 || an == 0 || cvc == "" || numeTitular == "" ||
                (chkPjuridica.Checked == true && (numeFirma == "" || cui == "" || nrRegCom == "")))
                idEroare = 2;

            else if(chkPjuridica.Checked && cui.Length < 8)
                idEroare = 3;

            else if(chkPjuridica.Checked && (nrRegCom.Count(c => c == '/') != 2 || 
                nrRegCom.Count(c => c == '.') != 2 || nrRegCom.Count(c => Char.IsDigit(c)) != 14 
                    || nrRegCom.Count(c => Char.IsLetter(c)) == 0))
                idEroare = 4;

            else if(nrCard.Length < 16)
                idEroare = 5;

            else if(an < int.Parse(DateTime.Now.ToString("yy")) || (an == int.Parse(DateTime.Now.ToString("yy"))
                && luna < int.Parse(DateTime.Now.ToString("MM"))))
                idEroare = 6;

            else if(cvc.Length < 3)
                idEroare = 7;

            timerEroareTick = 0; timerEroare.Start();
            lblAfisaj.Visible = true;

            switch (idEroare)
            {
                case 0:
                    lblAfisaj.Text = "Creditele au fost adăugate cu succes!";
                    lblAfisaj.ForeColor = Color.ForestGreen;
                    btnAdaugaCredite.Enabled = btnInapoi.Enabled = false;
                    break;

                case 1:
                    lblAfisaj.Text = "Suma introdusă nu trebuie să fie nulă!";
                    return;

                case 2:
                    lblAfisaj.Text = "Niciun câmp nu trebuie să fie nul!";
                    return;

                case 3:
                    lblAfisaj.Text = "CUI-ul este eronat";
                    return;

                case 4:
                    lblAfisaj.Text = "Numărul pentru registrul comerțului este eronat";
                    return;

                case 5:
                    lblAfisaj.Text = "Numărul cardului este invalid";
                    return;

                case 6:
                    lblAfisaj.Text = "Cardul este expirat";
                    return;

                case 7:
                    lblAfisaj.Text = "CVC-ul este invalid";
                    return;
            }

            var con = new MySqlConnection(connStr); con.Open();
            var cmd = new MySqlCommand("UpdateCredite", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_credite", crediteAdaugate);
            cmd.Parameters.AddWithValue("p_id", idUtilizator);

            cmd.ExecuteNonQuery();

            cmd = new MySqlCommand("SelectFacturi", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", idUtilizator);
            var dr = cmd.ExecuteReader(); dr.Read();

            bool executa = false;
            try
            {
                string nrCard1 = dr[1].ToString(), cvc1 = dr[3].ToString(), numeTitular1 = dr[4].ToString(),
                    numeFirma1 = dr[5].ToString(), cui1 = dr[6].ToString(), nrRegCom1 = dr[7].ToString();
                DateTime data = (DateTime)dr[2];

                int luna1 = int.Parse(data.ToString("MM"));
                int an1 = int.Parse(data.ToString("yy"));

                if(nrCard1 != nrCard || luna1 != luna || an1 != an || cvc1 != cvc || numeTitular1 != numeTitular || 
                    (chkPjuridica.Checked && (numeFirma1 != numeFirma || cui1 != cui || nrRegCom1 != nrRegCom)))
                {
                    var dialogR = MessageBox.Show("Doriți să înclocuiți datele de facturare salvate anterior cu cele introduse" +
                        " acum?", "Întrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(dialogR == DialogResult.Yes)
                    {
                        cmd = new MySqlCommand("UpdateFacturi", con);

                        executa = true;
                    }                  

                }  

            }  catch
            {
                var dialogR = MessageBox.Show("Doriți să salvați datele de facturare pentru tranzacții ulterioare?",
                    "Întrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(dialogR == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("InsertFacturi", con);

                    executa = true;
                }

            }

            dr.Close();

            if(executa)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_id", idUtilizator);
                cmd.Parameters.AddWithValue("p_nrCard", nrCard);
                cmd.Parameters.AddWithValue("p_data", DateTime.ParseExact($"{luna}/{an}", "M/yy",
                        System.Globalization.CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("p_cvc", cvc);
                cmd.Parameters.AddWithValue("p_numeTitular", numeTitular);

                if (chkPfizica.Checked)
                    numeFirma = cui = nrRegCom = string.Empty;

                cmd.Parameters.AddWithValue("p_numeFirma", numeFirma);
                cmd.Parameters.AddWithValue("p_cui", cui);
                cmd.Parameters.AddWithValue("p_nrRegCom", nrRegCom);

                cmd.ExecuteNonQuery();
            }            

            con.Close(); con.Dispose();
            cmd.Dispose();
        }

        private void CrediteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lblAfisaj.ForeColor == Color.ForestGreen)
                e.Cancel = true;

            if (tranzactieReusita)
                return;

            var dr = MessageBox.Show("Sunteți sigur(ă) că doriți să renunțați la această tranzacție?", "Întrebare",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.No) e.Cancel = true;
        }

    }
}
