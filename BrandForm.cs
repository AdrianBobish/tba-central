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

namespace TBA_Central
{
    public partial class BrandForm : Form
    {
        private string connStr = @"Data Source=(localdb)\Local;Initial Catalog=TBA-Central-DB;Integrated Security=True;MultipleActiveResultSets=true";
        private string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\Resources\";

        private int idUtilizator;

        private string regiuneForm;
        private PictureBox[,] pbBrand;
        private int n = 0, m = 0;

        public BrandForm(string regiune, int id)
        {
            InitializeComponent();

            regiuneForm = regiune;
            idUtilizator = id;
            pbBrand = new PictureBox[6, 10];
        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            lblRegiune.Text = Spatiere(regiuneForm);
            this.BackgroundImage = Image.FromFile(resPath + @"UI-Elements\brands-back.jpg");
            pbBack.Image = Image.FromFile(resPath + @"UI-Elements\secondary.png");

            var con = new SqlConnection(connStr); con.Open();
            var cmd = new SqlCommand("SelectTari", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@regiune", regiuneForm);
            var dr = cmd.ExecuteReader();

            int i = 0, j = 0;
            int yTitlu = -84, yBrand = -42;
            while (dr.Read())
            {
                string tara = dr[0].ToString();
                i++;

                var pbSteag = new PictureBox()
                {
                    Parent = panelBranduri,
                    Name = $"pbFlag{i}",
                    Image = Image.FromFile(resPath + $@"Flags\{tara}.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(17, yTitlu += 100),
                    Size = new Size(58, 36)
                };

                var lblTara = new Label()
                {
                    Parent = panelBranduri,
                    Name = $"lblTara{i}",
                    Font = new Font("Microsoft YaHei UI", 15, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.Transparent,
                    Text = Spatiere(tara),
                    Location = new Point(81, yTitlu),
                    Size = new Size(400, 23)
                };

                var panelBrand = new Panel()
                {
                    Parent = panelBranduri,
                    Name = $"panelBrand{i}",
                    BackColor = Color.Transparent,
                    BackgroundImage = Image.FromFile(resPath + "UI-Elements\\white-gradient-back.png"),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Location = new Point(51, yBrand += 100),
                    Size = new Size(425, 47)
                };  panelBrand.BringToFront();

                var cmd1 = new SqlCommand("SelectBranduri", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@tara", tara);
                var dr1 = cmd1.ExecuteReader();

                i--;
                j = 0;
                while (dr1.Read())
                {
                    string brand = dr1[0].ToString();
                    var fileStream = new FileStream(resPath + $@"Brands\{brand}.png", FileMode.Open, FileAccess.Read);
                    Image brandImage = Image.FromStream(fileStream);

                    int H = brandImage.Height;
                    float W = (float)panelBrand.Height * ((float)brandImage.Width / (float)H);

                    pbBrand[i, j] = new PictureBox()
                    {
                        Name = brand,
                        Image = brandImage,
                        BackColor = Color.Transparent,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Height = H,
                        Width = (int)W
                    };

                    pbBrand[i, j].Click += HandleClick;
                    j++;
                }

                dr1.Close();
                cmd1.Dispose();

                m = Math.Max(m, j);
                i++;
                var tbl = new TableLayoutPanel()
                {
                    Name = $"tbl{i}",
                    RowCount = 1,
                    ColumnCount = m,
                    Dock = DockStyle.Fill,
                    Padding = Padding.Empty
                };

                tbl.RowStyles.Add(new RowStyle(SizeType.Percent, panelBrand.Height));
                i--;
                for (j--; j >= 0; j--)
                {
                    tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, pbBrand[i, j].Width));

                    tbl.Controls.Add(pbBrand[i, j]);
                }

                panelBrand.Controls.Add(tbl);
                i++;
            }

            n = i;

            dr.Close();
            con.Close(); con.Dispose();
            cmd.Dispose();

        }

        private void HandleClick(object sender, EventArgs e)
        {
            string name = string.Empty;

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                    if (pbBrand[i, j] == sender)
                    {
                        name = pbBrand[i, j].Name;

                        break;
                    }

            if (name == string.Empty) return;

            this.Visible = false;
            var frm = new InformationForm(name, idUtilizator);
            frm.ShowDialog();
            this.Visible = true;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string Spatiere(string input)
        {
            string output = string.Empty;

            foreach (char c in input)
                output += char.ToUpper(c) + "  ";

            return output;
        }
    }
}
