using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TBA_Central
{
    public partial class TransactionsForm : Form
    {
        private string connStr = @"server=129.159.153.107;uid=bobish;pwd=C!%.1(f_bN}M:;database=TBA-Central-DB";
        private string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\Resources\";

        private int idUtilizator;
        private int idTranzactie;
        private bool statusTranzactie;

        private int timerTick;

        public TransactionsForm(int id)
        {
            InitializeComponent();

            idUtilizator = id;     
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            pbAnimatie.Image = Image.FromFile(resPath + "UI-Elements\\profile-anim.gif");
            AdaugaParinte(lblMesaj);
            AdaugaParinte(btnInapoi); AdaugaParinte(btnRestituire);
            
            // PopuleazaTabela();

            var con = new MySqlConnection(connStr); con.Open();
            var cmd = new MySqlCommand("SelectUtilizator", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", idUtilizator);

            var dr = cmd.ExecuteReader(); dr.Read();
            string eMail = dr[3].ToString();
            lblMesaj.Text = "GESTIONAȚI TRANZACȚIILE EFECTUATE PE CONTUL CU EMAIL-UL "
                    + eMail.ToUpper();

            dr.Close();

            cmd.Dispose();
            con.Close(); con.Dispose();
        }

        private void PopuleazaTabela()
        {
            var con = new MySqlConnection(connStr); con.Open();         
            var cmd = new MySqlCommand("SelectTranzactii", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", idUtilizator);
            var dr = cmd.ExecuteReader();

            var dt = new DataTable();
            dt.Load(dr);
            //dgwTranzactii.Columns.Clear();
            dgwTranzactii.DataSource = dt;
            dr.Close();

            cmd.Dispose();
            con.Close(); con.Dispose();

            //dgwTranzactii.Columns.Add("statusTranzactii", "Status");
            //dgwTranzactii.Columns["statusTranzactii"].ReadOnly = false;
            foreach (DataGridViewRow item in dgwTranzactii.Rows)
            {
                if (item.Cells["DataSosire"].Value?.ToString() == null)
                    continue;

                var data = (DateTime)item.Cells["DataSosire"].Value;
                var zileRamase = (int)(data - DateTime.Now).TotalDays;

                string mesaj = string.Empty; Color culoare = Color.White;

                switch (zileRamase)
                {
                    case var expresie when zileRamase <= 0:
                        mesaj = "✔ În garaj";
                        culoare = Color.ForestGreen;
                        break;

                    case 1:
                        mesaj = "⛟ În livrare";
                        culoare = Color.DodgerBlue;
                        break;

                    default:
                        mesaj = "🕐 În procesare";
                        culoare = Color.Gold;
                        break;
                }

                item.Cells["statusTranzactii"].Value = mesaj;
                item.Cells["statusTranzactii"].Style.BackColor = culoare;

            }
        }

        private void AdaugaParinte(Control ctrl)
        {
            var pos = ctrl.Parent.PointToScreen(ctrl.Location);
            pos = pbAnimatie.PointToClient(pos);
            ctrl.Parent = pbAnimatie;
            ctrl.Location = pos;

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestituire_Click(object sender, EventArgs e)
        {
            if (timerTick != 0 && timerTick != 8)
                return;

            timerTick = 0;
            timer.Start();

        }

        private void RestituieTranzactie()
        {
            var con = new MySqlConnection(connStr); con.Open();
            var cmd = new MySqlCommand("DeleteAllTranzactii", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_idU", idUtilizator);
            cmd.Parameters.AddWithValue("p_idT", idTranzactie);
            cmd.ExecuteNonQuery();

            con.Close(); con.Dispose();
            cmd.Dispose();
        }

        private void dgwTranzactii_SelectionChanged(object sender, EventArgs e)
        {
            idTranzactie = 0;
            var ok = int.TryParse(dgwTranzactii.CurrentRow.Cells["IdTranzactie"].
                    Value.ToString(), out idTranzactie);

            var culoare = dgwTranzactii.CurrentRow.Cells["statusTranzactii"].Style.BackColor;

            statusTranzactie = true;
            if (idTranzactie == 0 || culoare != Color.Gold)
                statusTranzactie = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (timerTick)
            {
                case 0:
                    btnRestituire.Text = string.Empty;
                    break;

                case int timer when timer < 5:
                    btnRestituire.Text += "· ";
                    break;

                case int timer when timer < 7:
                    if(!statusTranzactie)
                         btnRestituire.Text = "𝙓";
                    else btnRestituire.Text = "✔";

                    break;

                case 7:
                    btnRestituire.Text = "Restituire";
                    if (statusTranzactie)
                        RestituieTranzactie();
                    PopuleazaTabela();
                    timer.Stop();

                    break;
            }

            timerTick++;
        }

        private void TransactionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timerTick != 0 && timerTick != 8)
                e.Cancel = true;
        }

        private void form_MouseHover(object sender, EventArgs e)
        {
            if (idTranzactie != 0)
                return;

            PopuleazaTabela();
        }
    }
}
