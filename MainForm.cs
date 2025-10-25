using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TBA_Central
{
    public partial class MainForm : Form
    {
        private string connStr = @"server=129.159.153.107;uid=bobish;pwd=C!%.1(f_bN}M:;database=TBA-Central-DB";
        private string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\Resources\";

        private int idUtilizator;        
        public static bool delogatForm = false;
        private bool delogat = false;

        FileStream fs;

        public MainForm(string userEmail)
        {
            InitializeComponent();

            var con = new MySqlConnection(connStr); con.Open();
            var cmd = new MySqlCommand("SelectId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_email", userEmail);

            idUtilizator = (int)cmd.ExecuteScalar();

            con.Close();  con.Dispose();
            cmd.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panel.BackgroundImage = Image.FromFile(resPath + @"UI-Elements\world-map.jpg");
            pbSelectNA.Image = pbSelectEU.Image =
                pbSelectAS.Image = Image.FromFile(resPath + @"UI-Elements\selection-anim.gif");

            IncarcaPozaProfil();

        }

        private void IncarcaPozaProfil()
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
        }

        private void btnSelection_MouseHover(object sender, EventArgs e)
        {
            if(sender == btnInchide)
            {
                btnInchide.ForeColor = Color.White;

                return;
            }

            if (sender == btnAmericaN)
            {
                pbSelectNA.Visible = true;

                pbSelectEU.Visible = pbSelectAS.Visible = false;
            }

            else if (sender == btnEuropa)
            {
                pbSelectEU.Visible = true;

                pbSelectNA.Visible = pbSelectAS.Visible = false;
            }

            else if (sender == btnAsia)
            {
                pbSelectAS.Visible = true;

                pbSelectEU.Visible = pbSelectNA.Visible = false;
            }
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            if (sender == btnInchide)
            {
                this.Close();

                return;
            }                

            string regiune = string.Empty;

            if (sender == btnAmericaN) regiune = "America de Nord";
            else if (sender == btnEuropa) regiune = "Europa";
            else if (sender == btnAsia) regiune = "Asia";

            var frm = new BrandForm(regiune, idUtilizator);
            frm.ShowDialog();
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnInchide.ForeColor = Color.Firebrick;
        }

        private void pbProfile_Paint(object sender, PaintEventArgs e)
        {
            if(btnProfil.Visible == true)
            {
                var rect = new Rectangle(0, 0, pbProfil.Width, pbProfil.Height);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(new Pen(Color.Yellow, 3f), rect);
            }

            GraphicsPath grpath = new GraphicsPath();
            grpath.AddEllipse(0, 0, pbProfil.Width, pbProfil.Height);
            pbProfil.Region = new System.Drawing.Region(grpath);
            base.OnPaint(e);
        }

        private void pbProfil_Click(object sender, EventArgs e)
        {
            bool vizibil = false;
            if (btnProfil.Visible == false) 
                vizibil = true;

            btnProfil.Visible = btnCredite.Visible = 
                btnTranzactii.Visible = btnDelogare.Visible = vizibil;
            pbProfil.Invalidate();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {            
            int tabIndex = 0;

            if(sender == btnCredite) 
                tabIndex = 1;
            
            else if(sender == btnTranzactii) 
                tabIndex = 2;

            else if(sender == btnDelogare)
            {
                delogat = true;
                this.Close();

                return;
            }

            pbProfil.Image.Dispose();
            var frm = new SelectionForm(idUtilizator, tabIndex);
            frm.ShowDialog();
            IncarcaPozaProfil();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (delogatForm == true)
                return;

            var mesaj = "Sunteți sigur că doriți să ";

            if (delogat == false)   mesaj += "închideți aplicația?";
            else                    mesaj += "vă delogați?";

            var dr = MessageBox.Show(mesaj, "Întrebare", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;

                delogat = false;
            }

            else if (delogat == true)
            {
                delogatForm = true;

                Application.Restart(); Application.DoEvents(); Environment.Exit(0);
            }
        }
    }
}
