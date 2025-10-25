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
    public partial class SelectionForm : Form
    {
        private string connStr = @"server=129.159.153.107;uid=bobish;pwd=C!%.1(f_bN}M:;database=TBA-Central-DB";
        private string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\Resources\";

        private int idUtilizator;
        private int tabIndex;

        private Color selectionColor = Color.FromArgb(81, 169, 255);
        Form childForm = new CreditsForm(0);

        private bool formChanged = true;

        public SelectionForm(int id, int tab)
        {
            InitializeComponent();

            idUtilizator = id;  tabIndex = tab;
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            pbProfil.Image = Image.FromFile(resPath + "UI-Elements\\profile.png");
            pbCredite.Image = Image.FromFile(resPath + "UI-Elements\\credits.png");
            pbTranzactii.Image = Image.FromFile(resPath + "UI-Elements\\transactions.png");
            pbAdmin.Image = Image.FromFile(resPath + "UI-Elements\\admin.png");

            var con = new MySqlConnection(connStr);  con.Open();
            var cmd = new MySqlCommand("SelectUtilizator", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", idUtilizator);
            var dr = cmd.ExecuteReader();  dr.Read();

            var privilegiat = (bool)dr[5];
            if (privilegiat)  panelAdmin.Enabled = true;

            con.Close();  con.Dispose();
            cmd.Dispose();
            dr.Close();

            SchimbaTab();

        }

        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            if(formChanged)  this.Close();
            formChanged = true;  SchimbaTab();

        }

        private void SchimbaTab()
        {
            childForm.Dispose();  panelForm.Controls.Clear();
            panelProfil.BackColor = panelCredite.BackColor = 
                panelTranzactii.BackColor = panelAdmin.BackColor = Color.DodgerBlue;
            childForm = new ProfileForm(idUtilizator);

            switch (tabIndex)
            {
                case 0:
                    panelProfil.BackColor = selectionColor;
                    break;

                case 1:
                    panelCredite.BackColor = selectionColor;
                    childForm = new CreditsForm(idUtilizator);
                    break;

                case 2:
                    panelTranzactii.BackColor = selectionColor;
                    childForm = new TransactionsForm(idUtilizator);
                    break;

                case 3:
                    panelAdmin.BackColor = selectionColor;
                    childForm = new AdministratorForm(idUtilizator);
                    break;

            }

            childForm.TopLevel = false;  childForm.Dock = DockStyle.Fill;
            childForm.FormClosed += new FormClosedEventHandler(ChildFormClosed);
            panelForm.Controls.Add(childForm);
            childForm.Show();
            childForm.BringToFront();
        }

        private void control_Click(object sender, EventArgs e)
        {
            int anterior = tabIndex;

            if (sender == pbProfil || sender == lblProfil)
                tabIndex = 0;

            else if (sender == pbCredite || sender == lblCredite)
                tabIndex = 1;

            else if (sender == pbTranzactii || sender == lblTranzactii)
                tabIndex = 2;

            else tabIndex = 3;

            if (tabIndex != anterior)
            {
                formChanged = false;
                childForm.Close();

                if (!formChanged)
                    tabIndex = anterior;
            }
        }
    }
}
