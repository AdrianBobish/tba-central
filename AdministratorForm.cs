using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TBA_Central
{
    public partial class AdministratorForm : Form
    {
        private string connStr = @"server=129.159.153.107;uid=bobish;pwd=C!%.1(f_bN}M:;database=TBA-Central-DB";

        private int idSelectat;

        private List<int> idUpdateSus = new List<int>();
        private List<int> idUpdateJos = new List<int>();

        private List<int> idDeleteSus = new List<int>();
        private List<int> idDeleteJos = new List<int>();

        // ID-ul nu este necesar
        public AdministratorForm(int id)
        {
            InitializeComponent();

            cmbSus.SelectedIndex = 
                cmbJos.SelectedIndex = 0;
        }

        
        // Tabela principala
        private void cmbS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbJos.Items.Clear();
            cmbJos.Items.Add("");  cmbJos.SelectedIndex = 0;
            dgwJos.DataSource = null;

            btnActSus.Enabled = true;
            var idx = cmbSus.SelectedIndex;

            if (idx == 0)
            {
                btnActSus.Enabled = false;
                dgwSus.DataSource = null;

                return;
            }                

            PopuleazaTabelaSus(idx);
        }

        private void PopuleazaTabelaSus(int idx)
        {
            if (idx == 0) return;
            idUpdateSus.Clear(); idDeleteSus.Clear();

            var con = new MySqlConnection(connStr); con.Open();
            var cmd = new MySqlCommand("SelectAll" + cmbSus.Items[idx].ToString(), con);
            cmd.CommandType = CommandType.StoredProcedure;
            var dr = cmd.ExecuteReader();

            var dt = new DataTable();
            dt.Load(dr);
            dgwSus.DataSource = dt;
            dr.Close();

            cmd.Dispose();
            con.Close(); con.Dispose();

            cmbJos.Items.Clear();  cmbJos.Items.Add("");
            cmbJos.SelectedIndex = 0;

            if(idx == 1) cmbJos.Items.Add("Facturi");
            else         cmbJos.Items.Add("Specificatii");
            
                cmbJos.Items.Add("Tranzactii");

        }

        private void dgwS_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwSus.CurrentRow == null)
                return;

            idSelectat = 0;
            bool ok = int.TryParse(dgwSus.CurrentRow.Cells[0].Value.ToString(), 
                        out idSelectat);

            ActualizeazaTabSec();

        }


        // Tabela secundara
        private void cmbD_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizeazaTabSec();

        }

        private void PopuleazaTabelaJos(int idx, bool utilizator)
        {
            if (idx == 0) return;
            idUpdateJos.Clear();  idDeleteJos.Clear();

            var con = new MySqlConnection(connStr); con.Open();
            var cmd = new MySqlCommand("SelectAll" + cmbJos.Items[idx].ToString(), con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", idSelectat);
            if (idx == 2) cmd.Parameters.AddWithValue("p_utilizator", utilizator); // In cazul tranzactiilor
            var dr = cmd.ExecuteReader();

            var dt = new DataTable();
            dt.Load(dr);
            dgwJos.DataSource = dt;
            dr.Close();

            cmd.Dispose();
            con.Close(); con.Dispose();

        }

        private void ActualizeazaTabSec()
        {
            btnActJos.Enabled = true;
            var idx = cmbJos.SelectedIndex;
            var utilizator = false;

            if (cmbSus.SelectedIndex == 1)
                utilizator = true;

            if (idx == 0)
            {
                btnActJos.Enabled = false;
                dgwJos.DataSource = null;

                return;
            }


            PopuleazaTabelaJos(idx, utilizator);
        }


        // UPDATE
        private void btnAct_Click(object sender, EventArgs e)
        {
            int idxSus = cmbSus.SelectedIndex,
                    idxJos = cmbJos.SelectedIndex;

            var query = "UpdateAll";
            if (sender == btnActSus)
                 query += cmbSus.Items[idxSus].ToString();
            else query += cmbJos.Items[idxJos].ToString();

            var con = new MySqlConnection(connStr); con.Open();
            var cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;

            if(sender == btnActSus)
            {
                if (idxSus == 1)
                    foreach (DataGridViewRow item in dgwSus.Rows)
                    {
                        int id = 0;
                        int.TryParse(item.Cells[0].Value?.ToString(), out id);

                        if (!idUpdateSus.Contains(id))
                            continue;

                        string nume = item.Cells[1].Value?.ToString() ?? "", prenume = item.Cells[2].Value?.ToString() ?? "",
                            email = item.Cells[3].Value?.ToString() ?? "", parola = item.Cells[4].Value?.ToString() ?? "";
                        bool privilegiu = false;

                        if (!Convert.IsDBNull(item.Cells[5].Value))
                            privilegiu = Convert.ToBoolean(item.Cells[5].Value);

                        if (!privilegiu && parola == "")
                            continue;

                        int credite = 0;
                        int.TryParse(item.Cells[6].Value?.ToString(), out credite);

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("p_id", id);
                        cmd.Parameters.AddWithValue("p_nume", nume);
                        cmd.Parameters.AddWithValue("p_prenume", prenume);
                        cmd.Parameters.AddWithValue("p_email", email);
                        cmd.Parameters.AddWithValue("p_parola", parola);
                        cmd.Parameters.AddWithValue("p_privilegiu", privilegiu);
                        cmd.Parameters.AddWithValue("p_credite", credite);
                        cmd.ExecuteNonQuery();

                    }

                else
                    foreach (DataGridViewRow item in dgwSus.Rows)
                    {
                        int id = 0;
                        int.TryParse(item.Cells[0].Value?.ToString(), out id);

                        if (!idUpdateSus.Contains(id))
                            continue;

                        string regiune = item.Cells[1].Value?.ToString() ?? "", tara = item.Cells[2].Value?.ToString() ?? "",
                            brand = item.Cells[3].Value?.ToString() ?? "", denumire = item.Cells[4].Value?.ToString() ?? "";

                        int pret = 0, stoc = 0;
                        int.TryParse(item.Cells[5].Value?.ToString(), out pret);
                        int.TryParse(item.Cells[5].Value?.ToString(), out pret);
                        int.TryParse(item.Cells[6].Value?.ToString(), out stoc);

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("p_id", id);
                        cmd.Parameters.AddWithValue("p_regiune", regiune);
                        cmd.Parameters.AddWithValue("p_tara", tara);
                        cmd.Parameters.AddWithValue("p_brand", brand);
                        cmd.Parameters.AddWithValue("p_denumire", denumire);
                        cmd.Parameters.AddWithValue("p_pret", pret);
                        cmd.Parameters.AddWithValue("p_stoc", stoc);
                        cmd.ExecuteNonQuery();

                    }

            }

            else
            {
                if (idxSus == 1 && idxJos == 1)
                    foreach (DataGridViewRow item in dgwJos.Rows)
                    {
                        int id = 0;
                        int.TryParse(item.Cells[0].Value?.ToString(), out id);

                        if (!idUpdateJos.Contains(id))
                            continue;

                        string nrCard = item.Cells[1].Value?.ToString() ?? "", cvc = item.Cells[3].Value?.ToString() ?? "",
                            numeTitular = item.Cells[4].Value?.ToString() ?? "", numeFirma = item.Cells[5].Value?.ToString() ?? "",
                            cui = item.Cells[6].Value?.ToString() ?? "", nrRegCom = item.Cells[7].Value?.ToString() ?? "";

                        DateTime dataExp = DateTime.Now;
                        DateTime.TryParse(item.Cells[2].Value?.ToString(), out dataExp);

                        if (dataExp <= DateTime.Now)
                            continue;

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("p_idU", id);
                        cmd.Parameters.AddWithValue("p_nrCard", nrCard);
                        cmd.Parameters.AddWithValue("p_dataExp", dataExp);
                        cmd.Parameters.AddWithValue("p_cvc", cvc);
                        cmd.Parameters.AddWithValue("p_numeT", numeTitular);
                        cmd.Parameters.AddWithValue("p_numeF", numeFirma);
                        cmd.Parameters.AddWithValue("p_cui", cui);
                        cmd.Parameters.AddWithValue("p_nrRC", nrRegCom);
                        cmd.ExecuteNonQuery();

                    }

                else if (idxSus == 2 && idxJos == 1)
                    foreach (DataGridViewRow item in dgwJos.Rows)
                    {
                        int capCil = 0;
                        int.TryParse(item.Cells[0].Value?.ToString(), out capCil);

                        if (!idUpdateJos.Contains(capCil))
                            continue;

                        string tractiune = item.Cells[1].Value?.ToString() ?? "", tipMotor = item.Cells[4].Value?.ToString() ?? "",
                            dimensiune = item.Cells[6].Value?.ToString() ?? "";

                        //if (!new Regex("^[0-9999]x[0-9999]x[0-9999]$").IsMatch(dimensiune))
                        //    continue;

                        int caiPutere = 0, greutate = 0, idMasina = 0;
                        float cupluMotor = 0f;
                        int.TryParse(item.Cells[2].Value?.ToString(), out caiPutere);
                        float.TryParse(item.Cells[3].Value?.ToString(), out cupluMotor);
                        int.TryParse(item.Cells[5].Value?.ToString(), out greutate);
                        int.TryParse(item.Cells[7].Value?.ToString(), out idMasina);

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("p_capCil", capCil);
                        cmd.Parameters.AddWithValue("p_trac", tractiune);
                        cmd.Parameters.AddWithValue("p_caiP", caiPutere);
                        cmd.Parameters.AddWithValue("p_cupluM", (float)Math.Round(cupluMotor, 2));
                        cmd.Parameters.AddWithValue("p_tipM", tipMotor);
                        cmd.Parameters.AddWithValue("p_greut", greutate);
                        cmd.Parameters.AddWithValue("p_dimensiune", dimensiune);
                        cmd.Parameters.AddWithValue("p_idMasina", idMasina);
                        cmd.ExecuteNonQuery();

                    }

                else
                    foreach (DataGridViewRow item in dgwJos.Rows)
                    {
                        int idTranzactie = 0;
                        int.TryParse(item.Cells[0].Value?.ToString(), out idTranzactie);

                        if (!idUpdateJos.Contains(idTranzactie))
                            continue;

                        int idUtilizator = 0, idMasina = 0;
                        int.TryParse(item.Cells[1].Value?.ToString(), out idUtilizator);
                        int.TryParse(item.Cells[2].Value?.ToString(), out idMasina);

                        DateTime dataTranzactie = DateTime.Now, dataSosire = DateTime.Now;
                        DateTime.TryParse(item.Cells[3].Value?.ToString(), out dataTranzactie);
                        DateTime.TryParse(item.Cells[4].Value?.ToString(), out dataSosire);

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("p_idT", idTranzactie);
                        cmd.Parameters.AddWithValue("p_idU", idUtilizator);
                        cmd.Parameters.AddWithValue("p_idM", idMasina);
                        cmd.Parameters.AddWithValue("p_dataT", dataTranzactie);
                        cmd.Parameters.AddWithValue("p_dataS", dataSosire);
                        cmd.ExecuteNonQuery();

                    }

            }      

            query = "DeleteAll";
            if (sender == btnActSus)
                query += cmbSus.Items[idxSus].ToString();
            else query += cmbJos.Items[idxJos].ToString();

            cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;

            if (sender == btnActSus)
                foreach (int id in idDeleteSus)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("p_id", id);
                    cmd.ExecuteNonQuery();

                }

            else
                foreach (int id in idDeleteJos)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("p_id", id);
                    cmd.ExecuteNonQuery();

                }

            con.Close(); con.Dispose();
            cmd.Dispose();

            bool utilizator = false;
            if (idxSus == 1) utilizator = true;
            PopuleazaTabelaJos(idxJos, utilizator);
            PopuleazaTabelaSus(idxSus);
        }

        private void dgwSus_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = (int)dgwSus.Rows[e.RowIndex].Cells[0].Value;

                if (!idUpdateSus.Contains(id)) idUpdateSus.Add(id);
            }
            catch { }
        }

        private void dgwSus_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                idDeleteSus.Add((int)dgwSus.Rows[e.Row.Index].Cells[0].Value);
            }
            catch { }
        }

        private void dgwJos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = (int)dgwJos.Rows[e.RowIndex].Cells[0].Value;

                if (!idUpdateJos.Contains(id)) idUpdateJos.Add(id);
            } 
            catch { }
        }

        private void dgwJos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                idDeleteJos.Add((int)dgwJos.Rows[e.Row.Index].Cells[0].Value);
            }
            catch { }
        }


        // MISC
        private void AdministratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (idUpdateSus.Count == 0 && idDeleteSus.Count == 0 && 
                    idDeleteJos.Count == 0 && idDeleteSus.Count == 0)
                return;

            var test = cmbSus.SelectedIndex;
            var dr = MessageBox.Show("Sunteți sigur(ă) că doriți să renunțați la modificările efectuate?",
                    "Întrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
                e.Cancel = true;
        }

    }
}
