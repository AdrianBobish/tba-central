using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;

namespace TBA_Central
{
    public partial class InformationForm : Form
    {
        private string connStr = @"server=129.159.153.107;uid=bobish;pwd=C!%.1(f_bN}M:;database=TBA-Central-DB";
        private string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\Resources\";

        private int idUtilizator;
        private bool delogat;
        FileStream fs;

        private string taraSelect;
        private string brandSelect;

        private int n;
        private int[] idMasini = new int[8];
        private Label[] lblMasini = new Label[8];

        private int masinaSelect;
        private int idxImagine;
        private List<Image> imgMasina;
        private int m;
        private Label[] lblProgres = new Label[9];

        private int timerTick;
        private bool crediteSuficiente;

        public InformationForm(string brand, int id)
        {
            InitializeComponent();

            brandSelect = brand;
            idUtilizator = id;
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            IncarcaPozaProfil();

            pbBack.Image = Image.FromFile(resPath + @"UI-Elements\secondary.png");
            this.BackgroundImage = Image.FromFile(resPath + @"UI-Elements\brand-back.jpg");
            pbLogo.Parent = pbLogoBacklight;
            pbLogo.Location = new Point(93, 39);
            pbLogo.Image = Image.FromFile(resPath + $@"Brands\{brandSelect}.png");
            pbSlideshowRight.Image = Image.FromFile(resPath + @"UI-Elements\right.png");
            pbSlideshowLeft.Image = Image.FromFile(resPath + @"UI-Elements\left.png");
            lblBrand.Text = brandSelect.ToUpper();

            var con = new MySqlConnection(connStr);  con.Open();
            var cmd = new MySqlCommand("SelectMasini", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_brand", brandSelect);
            var dr = cmd.ExecuteReader();

            string tara = string.Empty;
            while(dr.Read())
            {
                if(tara == string.Empty)  tara = Convert.ToString(dr[0]);
                idMasini[n] = Convert.ToInt32(dr[1]);

                lblMasini[n] = new Label()
                {
                    AutoSize = true,
                    Name = $"lbl{n + 1}",
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    Font = new Font("Microsoft YaHei UI", 16, FontStyle.Bold),
                    Text = $"{n + 1}.  " + Convert.ToString(dr[2])
                };

                lblMasini[n].MouseHover += MouseHoverEvent;
                lblMasini[n].MouseLeave += MouseLeaveEvent;
                lblMasini[n].Click += ClickEvent;

                n++;
            }  pbSteag.Image = Image.FromFile(resPath + $@"Flags\{tara}.png");

            dr.Close();
            con.Close();  con.Dispose();
            cmd.Dispose();            

            var tbl = new TableLayoutPanel()
            {
                RowCount = n,
                ColumnCount = 1,
                Size = panelMasini.Size
                // Dock = DockStyle.Fill
            };

            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, panelMasini.Width));
            for (int i = 0; i < n; i++)
            {
                tbl.RowStyles.Add(new RowStyle(SizeType.Percent, panelMasini.Height / n));

                tbl.Controls.Add(lblMasini[i]);
            }

            panelMasini.Controls.Add(tbl);

            lblMasini[0].ForeColor = Color.Yellow;
            IncarcaInfoMasina();
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            if (timerTick != 0 && timerTick != 8)
                return;

            for (int i = 0; i < n; i++)
            {
                lblMasini[i].ForeColor = Color.White;

                if (lblMasini[i] == sender)
                {
                    lblMasini[i].ForeColor = Color.Yellow;
                    masinaSelect = i;
                    IncarcaInfoMasina();
                }
            }

        }

        private void MouseLeaveEvent(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
                if (lblMasini[i] == sender && lblMasini[i].ForeColor != Color.Yellow)
                    lblMasini[i].ForeColor = Color.White;
        }

        private void MouseHoverEvent(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
                if (lblMasini[i] == sender && lblMasini[i].ForeColor != Color.Yellow)
                    lblMasini[i].ForeColor = Color.LightGray;

        }

        private string SeparareNumere(string numar)
        {
            for (int i = numar.Length - 1, j = 1; i >= 1; i--, j++)
                if (j == 3)
                {
                    numar = numar.Insert(i, ".");

                    j = 0;
                }
                

            return numar;
        }

        private string InlocuireVirgula(string numar)
        {
            for (int i = numar.Length - 1, j = 1; i >= 1; i--, j++)
                if (numar[i] == '.' || numar[i] == ',')
                {
                    StringBuilder sb = new StringBuilder(numar);
                    sb[i] = ',';
                    try { sb[i + 3] = '\0'; } catch { }
                    numar = sb.ToString();

                    break;
                }

            return numar;
        }

        private void VerificaStoc(int id)
        {
            var con = new MySqlConnection(connStr); con.Open();
            var cmd = new MySqlCommand("SelectInfoMasina", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", id);
            var dr = cmd.ExecuteReader(); dr.Read();

            btnCumpara.Enabled = true;
            int stoc = (int)dr[8];
            if (stoc == 0)
            {
                btnCumpara.Enabled = false;
                lblStoc.ForeColor = Color.Firebrick;
                lblStoc.Text = "stoc epuizat!";
            }
            else if (stoc <= 5)
            {
                lblStoc.ForeColor = Color.Gold;
                lblStoc.Text = "stoc limitat";
            }
            else
            {
                lblStoc.ForeColor = Color.ForestGreen;
                lblStoc.Text = "în stoc";
            }

            dr.Close();
            con.Close(); con.Dispose();
            cmd.Dispose();
        }

        private void IncarcaInfoMasina()
        {
            int id = idMasini[masinaSelect];

            var con = new MySqlConnection(connStr); con.Open();
            var cmd = new MySqlCommand("SelectInfoMasina", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", id);
            var dr = cmd.ExecuteReader();  dr.Read();

            string denumire = dr[0].ToString(), capCil = dr[1].ToString(), tractiune = dr[2].ToString(),
                caiPutere = dr[3].ToString(), cupluMotor = dr[4].ToString(), tipMotor = dr[5].ToString(),
                greutate = dr[6].ToString(), dimensiune = dr[7].ToString(), pret = dr[9].ToString();

            capCil = SeparareNumere(capCil) + " cm³";  
            cupluMotor = InlocuireVirgula(cupluMotor) + " kgfm";
            greutate = SeparareNumere(greutate) + " kg";
            pret = SeparareNumere(pret);

            if (capCil == "0 cm³") capCil = " - ";
            if (cupluMotor == "0 kgfm") cupluMotor = " - ";

            lblDenumire.Text = denumire;  lblCapCilindrica.Text = capCil;  lblTipMotor.Text = tipMotor; 
            lblTractiune.Text = tractiune;  lblCaiPutere.Text = caiPutere;  lblCupluMotor.Text = cupluMotor;
                lblGreutate.Text = greutate; lblPret.Text = pret;

            var dimensiuni = dimensiune.Split("x\0".ToCharArray());
            int i = 0;
            foreach (var d in dimensiuni)
            {
                string aux = SeparareNumere(d) + " mm";

                switch(++i)
                {
                    case 1:
                        lblLungime.Text = aux; 
                        break;

                    case 2:
                        lblLatime.Text = aux;
                        break;

                    case 3:
                        lblInaltime.Text = aux;
                        break;
                }
            }

            dr.Close();
            con.Close(); con.Dispose();
            cmd.Dispose();

            VerificaStoc(id);

            rtxtInfo.Visible = true;
            btnInfo.PerformClick();
            IncarcaPozeMasina();
        }

        private void IncarcaPozeMasina()
        {
            pbSlideshow.Image = null;
            timerSlideShow.Stop();

            int id = idMasini[masinaSelect];
            idxImagine = 0;
            imgMasina = new List<Image>();

            string[] list = Directory.GetFiles(resPath + $@"Cars\{id}\", "*.png");
            foreach (var path in list)
            {
                var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                Image img = Image.FromStream(fileStream, false, false);

                imgMasina.Add(img);
            }

            m = imgMasina.Count;
            var tbl = new TableLayoutPanel()
            {
                RowCount = 1,
                ColumnCount = m,
                Dock = DockStyle.Fill,
            };

            tbl.RowStyles.Add(new RowStyle(SizeType.Percent, panelProgres.Height));
            lblProgres = new Label[9];
            panelProgres.Controls.Clear();
            for (int i = 0; i < m; i++)
            {
                tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, panelProgres.Width / m));

                lblProgres[i] = new Label()
                {
                    AutoSize = true,
                    BackColor = Color.Transparent,
                    ForeColor = SystemColors.ControlDarkDark,
                    Font = new Font("Microsoft YaHei UI", 15, FontStyle.Bold),
                    Text = "•"
                };
                lblProgres[i].Click += ProgressClickEvent;

                tbl.Controls.Add(lblProgres[i]);
            }  panelProgres.Controls.Add(tbl);
            lblProgres[0].ForeColor = SystemColors.Control;

            pbSlideshow.Image = imgMasina[idxImagine++];
            timerSlideShow.Start();
        }

        private void ProgressClickEvent(object sender, EventArgs e)
        {
            for (int i = 0; i < m; ++i)
            {
                lblProgres[i].ForeColor = SystemColors.ControlDarkDark;

                if (lblProgres[i] == sender)
                {
                    lblProgres[i].ForeColor = SystemColors.Control;

                    idxImagine = i;
                    pbSlideshow.Image = imgMasina[idxImagine];
                }
            }
        }

        private void NextImage()
        {
            if (idxImagine < 0)
                idxImagine += m;

            else if (idxImagine >= m)
                idxImagine -= m;

            for (int i = 0; i < m; ++i)
            {
                lblProgres[i].ForeColor = SystemColors.ControlDarkDark;
                if (i == idxImagine)
                    lblProgres[i].ForeColor = SystemColors.Control;
            }

            pbSlideshow.Image = imgMasina[idxImagine++];
        }

        private void timerSlideShow_Tick(object sender, EventArgs e)
        {
            NextImage();
        }

        private void pbSlideshowRight_Click(object sender, EventArgs e)
        {
            timerSlideShow.Stop();
            NextImage();
            timerSlideShow.Start();
        }

        private void pbSlideshowLeft_Click(object sender, EventArgs e)
        {
            timerSlideShow.Stop();
            idxImagine -= 2;
            NextImage();
            timerSlideShow.Start();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (rtxtInfo.Visible == false)
            {
                rtxtInfo.Text = File.ReadAllText(resPath + $@"Cars\{idMasini[masinaSelect]}\info.txt");
                rtxtInfo.Visible = true;

                btnInfo.BackColor = btnInfo.FlatAppearance.MouseOverBackColor = Color.White;
                btnInfo.ForeColor = Color.Black;
            }

            else
            {
                rtxtInfo.Text = null;
                rtxtInfo.Visible = false;

                btnInfo.BackColor = btnInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btnInfo.ForeColor = Color.White;
            }

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbProfil_Paint(object sender, PaintEventArgs e)
        {
            if (btnProfil.Visible == true)
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

        private void btnProfil_Click(object sender, EventArgs e)
        {
            int tabIndex = 0;

            if (sender == btnCredite)
                tabIndex = 1;
            
            else if (sender == btnTranzactii)
                tabIndex = 2;

            else if (sender == btnDelogare)
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

        private void InformationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timerTick != 0 && timerTick != 8)
                e.Cancel = true;

            if (MainForm.delogatForm == true || delogat == false)
                return;          

            var dr = MessageBox.Show("Sunteți sigur că doriți să vă delogați", "Întrebare", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;

                delogat = false;
            }

            else
            {
                MainForm.delogatForm = true;

                Application.Restart(); Application.DoEvents(); 
            }
        }

        private void btnCumpara_Click(object sender, EventArgs e)
        {
            if (timerTick != 0 && timerTick != 8)
                return;

            var con = new MySqlConnection(connStr);  con.Open();
            var cmd = new MySqlCommand("SelectUtilizator", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", idUtilizator);
            var dr = cmd.ExecuteReader();  dr.Read();
            int credite = (int)dr[6];

            con.Dispose();  con.Close();
            cmd.Dispose();
            dr.Close();

            int pretMasina = int.Parse(lblPret.Text.Replace(".", string.Empty));

            crediteSuficiente = false;
            if (pretMasina <= credite)
                crediteSuficiente = true;

            timerTick = 0;
            timerTranzactie.Start();

            if (crediteSuficiente == false)
                return;

            con = new MySqlConnection(connStr); con.Open();
            cmd = new MySqlCommand("UpdateCredite", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_credite", credite - pretMasina);
            cmd.Parameters.AddWithValue("p_id", idUtilizator);
            cmd.ExecuteNonQuery();

            cmd = new MySqlCommand("InsertTranzactie", con);
            cmd.CommandType = CommandType.StoredProcedure;

            var rand = new Random();

            // cmd.Parameters.AddWithValue("p_idT", rand.Next(10000, 99999));
            cmd.Parameters.AddWithValue("p_idU", idUtilizator);
            cmd.Parameters.AddWithValue("p_idM", idMasini[masinaSelect]);
            // cmd.Parameters.AddWithValue("p_credite", pretMasina);
            cmd.Parameters.AddWithValue("p_dataT", DateTime.Now);
            cmd.Parameters.AddWithValue("p_dataS", DateTime.Now.AddDays(rand.Next(3, 7)));

            cmd.ExecuteNonQuery();

            cmd = new MySqlCommand("UpdateStoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", idMasini[masinaSelect]);
            cmd.ExecuteNonQuery();

            con.Dispose(); con.Close();
            cmd.Dispose();
        }

        private void timerTranzactie_Tick(object sender, EventArgs e)
        {
            switch(timerTick) {
                case 0:
                    btnCumpara.Text = string.Empty;
                    break;

                case int timer when timer < 5:
                    btnCumpara.Text += "· ";
                    break;

                case int timer when timer < 7:
                    if(crediteSuficiente == false)
                          btnCumpara.Text = "𝙓";
                    else  btnCumpara.Text = "✔";

                    break;

                case 7:
                    btnCumpara.Text = "Cumpără";
                    VerificaStoc(idMasini[masinaSelect]);
                    timerTranzactie.Stop();
                    break;
            }

            timerTick++;
        }

        //private void MouseWheelSelect(object sender, MouseEventArgs e)
        //{
        //    if (e.Delta > 0) 
        //          panelMasini.Controls[0].Top += 7;

        //    else  panelMasini.Controls[0].Top -= 7;
        //}
    }
}
