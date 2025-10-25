using System.Windows.Forms;

namespace TBA_Central
{
    partial class InformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            this.timerSlideShow = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.pbProfil = new System.Windows.Forms.PictureBox();
            this.btnTranzactii = new System.Windows.Forms.Button();
            this.btnDelogare = new System.Windows.Forms.Button();
            this.btnCredite = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnInfo = new TBA_Central.CustomControls.RoundButton();
            this.btnCumpara = new TBA_Central.CustomControls.RoundButton();
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.pbSlideshowLeft = new System.Windows.Forms.PictureBox();
            this.pbSlideshowRight = new System.Windows.Forms.PictureBox();
            this.pbSlideshow = new System.Windows.Forms.PictureBox();
            this.panelProgres = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblStoc = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblInaltime = new System.Windows.Forms.Label();
            this.lblLatime = new System.Windows.Forms.Label();
            this.lblLungime = new System.Windows.Forms.Label();
            this.lblGreutate = new System.Windows.Forms.Label();
            this.lblTipMotor = new System.Windows.Forms.Label();
            this.lblCupluMotor = new System.Windows.Forms.Label();
            this.lblCaiPutere = new System.Windows.Forms.Label();
            this.lblTractiune = new System.Windows.Forms.Label();
            this.lblCapCilindrica = new System.Windows.Forms.Label();
            this.pbSteag = new System.Windows.Forms.PictureBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMasini = new System.Windows.Forms.Panel();
            this.pbLogoBacklight = new System.Windows.Forms.PictureBox();
            this.timerTranzactie = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlideshowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlideshowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlideshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSteag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBacklight)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSlideShow
            // 
            this.timerSlideShow.Interval = 4500;
            this.timerSlideShow.Tick += new System.EventHandler(this.timerSlideShow_Tick);
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.pbProfil);
            this.panel.Controls.Add(this.btnTranzactii);
            this.panel.Controls.Add(this.btnDelogare);
            this.panel.Controls.Add(this.btnCredite);
            this.panel.Controls.Add(this.btnProfil);
            this.panel.Controls.Add(this.pbBack);
            this.panel.Controls.Add(this.pbLogo);
            this.panel.Controls.Add(this.btnInfo);
            this.panel.Controls.Add(this.btnCumpara);
            this.panel.Controls.Add(this.rtxtInfo);
            this.panel.Controls.Add(this.pbSlideshowLeft);
            this.panel.Controls.Add(this.pbSlideshowRight);
            this.panel.Controls.Add(this.pbSlideshow);
            this.panel.Controls.Add(this.panelProgres);
            this.panel.Controls.Add(this.label24);
            this.panel.Controls.Add(this.label22);
            this.panel.Controls.Add(this.label21);
            this.panel.Controls.Add(this.lblStoc);
            this.panel.Controls.Add(this.lblPret);
            this.panel.Controls.Add(this.lblInaltime);
            this.panel.Controls.Add(this.lblLatime);
            this.panel.Controls.Add(this.lblLungime);
            this.panel.Controls.Add(this.lblGreutate);
            this.panel.Controls.Add(this.lblTipMotor);
            this.panel.Controls.Add(this.lblCupluMotor);
            this.panel.Controls.Add(this.lblCaiPutere);
            this.panel.Controls.Add(this.lblTractiune);
            this.panel.Controls.Add(this.lblCapCilindrica);
            this.panel.Controls.Add(this.pbSteag);
            this.panel.Controls.Add(this.lblBrand);
            this.panel.Controls.Add(this.lblDenumire);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.panelMasini);
            this.panel.Controls.Add(this.pbLogoBacklight);
            this.panel.Location = new System.Drawing.Point(0, 4);
            this.panel.MinimumSize = new System.Drawing.Size(935, 590);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(935, 590);
            this.panel.TabIndex = 0;
            // 
            // pbProfil
            // 
            this.pbProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProfil.BackColor = System.Drawing.Color.Transparent;
            this.pbProfil.Location = new System.Drawing.Point(888, 3);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(35, 35);
            this.pbProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfil.TabIndex = 68;
            this.pbProfil.TabStop = false;
            this.pbProfil.Click += new System.EventHandler(this.pbProfil_Click);
            this.pbProfil.Paint += new System.Windows.Forms.PaintEventHandler(this.pbProfil_Paint);
            // 
            // btnTranzactii
            // 
            this.btnTranzactii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTranzactii.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTranzactii.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTranzactii.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnTranzactii.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnTranzactii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranzactii.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranzactii.Location = new System.Drawing.Point(796, 82);
            this.btnTranzactii.Name = "btnTranzactii";
            this.btnTranzactii.Size = new System.Drawing.Size(105, 32);
            this.btnTranzactii.TabIndex = 67;
            this.btnTranzactii.Text = "Tranzacții";
            this.btnTranzactii.UseVisualStyleBackColor = false;
            this.btnTranzactii.Visible = false;
            this.btnTranzactii.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnDelogare
            // 
            this.btnDelogare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelogare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelogare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelogare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDelogare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDelogare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelogare.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelogare.Location = new System.Drawing.Point(796, 114);
            this.btnDelogare.Name = "btnDelogare";
            this.btnDelogare.Size = new System.Drawing.Size(105, 32);
            this.btnDelogare.TabIndex = 67;
            this.btnDelogare.Text = "Delogare";
            this.btnDelogare.UseVisualStyleBackColor = false;
            this.btnDelogare.Visible = false;
            this.btnDelogare.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnCredite
            // 
            this.btnCredite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCredite.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCredite.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCredite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnCredite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCredite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredite.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredite.Location = new System.Drawing.Point(796, 52);
            this.btnCredite.Name = "btnCredite";
            this.btnCredite.Size = new System.Drawing.Size(105, 32);
            this.btnCredite.TabIndex = 66;
            this.btnCredite.Text = "Adăugați credite";
            this.btnCredite.UseVisualStyleBackColor = false;
            this.btnCredite.Visible = false;
            this.btnCredite.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProfil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnProfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfil.Location = new System.Drawing.Point(796, 22);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(105, 32);
            this.btnProfil.TabIndex = 65;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Visible = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.Location = new System.Drawing.Point(30, 502);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(65, 50);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 5;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(50, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(163, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 29;
            this.pbLogo.TabStop = false;
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnInfo.BorderColor = System.Drawing.Color.White;
            this.btnInfo.BorderRadius = 15;
            this.btnInfo.BorderSize = 2;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(698, 498);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(91, 32);
            this.btnInfo.TabIndex = 63;
            this.btnInfo.Text = "Informații";
            this.btnInfo.TextColor = System.Drawing.Color.White;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnCumpara
            // 
            this.btnCumpara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCumpara.BackColor = System.Drawing.Color.Black;
            this.btnCumpara.BackgroundColor = System.Drawing.Color.Black;
            this.btnCumpara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCumpara.BorderColor = System.Drawing.Color.White;
            this.btnCumpara.BorderRadius = 15;
            this.btnCumpara.BorderSize = 1;
            this.btnCumpara.FlatAppearance.BorderSize = 0;
            this.btnCumpara.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCumpara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCumpara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCumpara.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCumpara.ForeColor = System.Drawing.Color.White;
            this.btnCumpara.Location = new System.Drawing.Point(795, 498);
            this.btnCumpara.Name = "btnCumpara";
            this.btnCumpara.Size = new System.Drawing.Size(94, 32);
            this.btnCumpara.TabIndex = 62;
            this.btnCumpara.Text = "Cumpără";
            this.btnCumpara.TextColor = System.Drawing.Color.White;
            this.btnCumpara.UseVisualStyleBackColor = false;
            this.btnCumpara.Click += new System.EventHandler(this.btnCumpara_Click);
            // 
            // rtxtInfo
            // 
            this.rtxtInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtInfo.BackColor = System.Drawing.Color.White;
            this.rtxtInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtInfo.Location = new System.Drawing.Point(324, 434);
            this.rtxtInfo.Name = "rtxtInfo";
            this.rtxtInfo.Size = new System.Drawing.Size(292, 96);
            this.rtxtInfo.TabIndex = 61;
            this.rtxtInfo.Text = "";
            this.rtxtInfo.Visible = false;
            // 
            // pbSlideshowLeft
            // 
            this.pbSlideshowLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSlideshowLeft.BackColor = System.Drawing.Color.Transparent;
            this.pbSlideshowLeft.Location = new System.Drawing.Point(260, 248);
            this.pbSlideshowLeft.Name = "pbSlideshowLeft";
            this.pbSlideshowLeft.Size = new System.Drawing.Size(21, 35);
            this.pbSlideshowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlideshowLeft.TabIndex = 60;
            this.pbSlideshowLeft.TabStop = false;
            this.pbSlideshowLeft.Click += new System.EventHandler(this.pbSlideshowLeft_Click);
            // 
            // pbSlideshowRight
            // 
            this.pbSlideshowRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSlideshowRight.BackColor = System.Drawing.Color.Transparent;
            this.pbSlideshowRight.Location = new System.Drawing.Point(653, 248);
            this.pbSlideshowRight.Name = "pbSlideshowRight";
            this.pbSlideshowRight.Size = new System.Drawing.Size(21, 35);
            this.pbSlideshowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlideshowRight.TabIndex = 59;
            this.pbSlideshowRight.TabStop = false;
            this.pbSlideshowRight.Click += new System.EventHandler(this.pbSlideshowRight_Click);
            // 
            // pbSlideshow
            // 
            this.pbSlideshow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSlideshow.BackColor = System.Drawing.Color.Transparent;
            this.pbSlideshow.Location = new System.Drawing.Point(287, 131);
            this.pbSlideshow.Name = "pbSlideshow";
            this.pbSlideshow.Size = new System.Drawing.Size(362, 254);
            this.pbSlideshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlideshow.TabIndex = 30;
            this.pbSlideshow.TabStop = false;
            // 
            // panelProgres
            // 
            this.panelProgres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelProgres.BackColor = System.Drawing.Color.Transparent;
            this.panelProgres.Location = new System.Drawing.Point(382, 391);
            this.panelProgres.Name = "panelProgres";
            this.panelProgres.Size = new System.Drawing.Size(184, 22);
            this.panelProgres.TabIndex = 58;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(819, 465);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 19);
            this.label24.TabIndex = 57;
            this.label24.Text = "€";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label22.Location = new System.Drawing.Point(664, 465);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 19);
            this.label22.TabIndex = 56;
            this.label22.Text = "Preț autovehicul";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label21.Location = new System.Drawing.Point(669, 434);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 19);
            this.label21.TabIndex = 55;
            this.label21.Text = "Disponibilitate";
            // 
            // lblStoc
            // 
            this.lblStoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStoc.AutoSize = true;
            this.lblStoc.BackColor = System.Drawing.Color.Transparent;
            this.lblStoc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStoc.Location = new System.Drawing.Point(817, 434);
            this.lblStoc.Name = "lblStoc";
            this.lblStoc.Size = new System.Drawing.Size(50, 19);
            this.lblStoc.TabIndex = 53;
            this.lblStoc.Text = "în stoc";
            // 
            // lblPret
            // 
            this.lblPret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPret.AutoSize = true;
            this.lblPret.BackColor = System.Drawing.Color.Transparent;
            this.lblPret.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPret.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPret.Location = new System.Drawing.Point(837, 460);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(84, 27);
            this.lblPret.TabIndex = 52;
            this.lblPret.Text = "250000";
            // 
            // lblInaltime
            // 
            this.lblInaltime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInaltime.AutoSize = true;
            this.lblInaltime.BackColor = System.Drawing.Color.Transparent;
            this.lblInaltime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInaltime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInaltime.Location = new System.Drawing.Point(795, 380);
            this.lblInaltime.Name = "lblInaltime";
            this.lblInaltime.Size = new System.Drawing.Size(81, 21);
            this.lblInaltime.TabIndex = 51;
            this.lblInaltime.Text = "1450 mm";
            // 
            // lblLatime
            // 
            this.lblLatime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLatime.AutoSize = true;
            this.lblLatime.BackColor = System.Drawing.Color.Transparent;
            this.lblLatime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLatime.Location = new System.Drawing.Point(795, 347);
            this.lblLatime.Name = "lblLatime";
            this.lblLatime.Size = new System.Drawing.Size(81, 21);
            this.lblLatime.TabIndex = 50;
            this.lblLatime.Text = "1826 mm";
            // 
            // lblLungime
            // 
            this.lblLungime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLungime.AutoSize = true;
            this.lblLungime.BackColor = System.Drawing.Color.Transparent;
            this.lblLungime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLungime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLungime.Location = new System.Drawing.Point(795, 316);
            this.lblLungime.Name = "lblLungime";
            this.lblLungime.Size = new System.Drawing.Size(81, 21);
            this.lblLungime.TabIndex = 49;
            this.lblLungime.Text = "4520 mm";
            // 
            // lblGreutate
            // 
            this.lblGreutate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGreutate.AutoSize = true;
            this.lblGreutate.BackColor = System.Drawing.Color.Transparent;
            this.lblGreutate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreutate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGreutate.Location = new System.Drawing.Point(795, 284);
            this.lblGreutate.Name = "lblGreutate";
            this.lblGreutate.Size = new System.Drawing.Size(70, 21);
            this.lblGreutate.TabIndex = 48;
            this.lblGreutate.Text = "1782 kg";
            // 
            // lblTipMotor
            // 
            this.lblTipMotor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipMotor.AutoSize = true;
            this.lblTipMotor.BackColor = System.Drawing.Color.Transparent;
            this.lblTipMotor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipMotor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTipMotor.Location = new System.Drawing.Point(795, 252);
            this.lblTipMotor.Name = "lblTipMotor";
            this.lblTipMotor.Size = new System.Drawing.Size(19, 21);
            this.lblTipMotor.TabIndex = 47;
            this.lblTipMotor.Text = "T";
            // 
            // lblCupluMotor
            // 
            this.lblCupluMotor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCupluMotor.AutoSize = true;
            this.lblCupluMotor.BackColor = System.Drawing.Color.Transparent;
            this.lblCupluMotor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupluMotor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCupluMotor.Location = new System.Drawing.Point(795, 221);
            this.lblCupluMotor.Name = "lblCupluMotor";
            this.lblCupluMotor.Size = new System.Drawing.Size(86, 21);
            this.lblCupluMotor.TabIndex = 54;
            this.lblCupluMotor.Text = "40,7 kgfm";
            // 
            // lblCaiPutere
            // 
            this.lblCaiPutere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaiPutere.AutoSize = true;
            this.lblCaiPutere.BackColor = System.Drawing.Color.Transparent;
            this.lblCaiPutere.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaiPutere.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCaiPutere.Location = new System.Drawing.Point(795, 188);
            this.lblCaiPutere.Name = "lblCaiPutere";
            this.lblCaiPutere.Size = new System.Drawing.Size(37, 21);
            this.lblCaiPutere.TabIndex = 45;
            this.lblCaiPutere.Text = "250";
            // 
            // lblTractiune
            // 
            this.lblTractiune.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTractiune.AutoSize = true;
            this.lblTractiune.BackColor = System.Drawing.Color.Transparent;
            this.lblTractiune.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTractiune.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTractiune.Location = new System.Drawing.Point(795, 156);
            this.lblTractiune.Name = "lblTractiune";
            this.lblTractiune.Size = new System.Drawing.Size(28, 21);
            this.lblTractiune.TabIndex = 46;
            this.lblTractiune.Text = "FF";
            // 
            // lblCapCilindrica
            // 
            this.lblCapCilindrica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCapCilindrica.AutoSize = true;
            this.lblCapCilindrica.BackColor = System.Drawing.Color.Transparent;
            this.lblCapCilindrica.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapCilindrica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCapCilindrica.Location = new System.Drawing.Point(795, 127);
            this.lblCapCilindrica.Name = "lblCapCilindrica";
            this.lblCapCilindrica.Size = new System.Drawing.Size(80, 21);
            this.lblCapCilindrica.TabIndex = 44;
            this.lblCapCilindrica.Text = "2000 cm³";
            // 
            // pbSteag
            // 
            this.pbSteag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSteag.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbSteag.Image = ((System.Drawing.Image)(resources.GetObject("pbSteag.Image")));
            this.pbSteag.Location = new System.Drawing.Point(558, 8);
            this.pbSteag.Name = "pbSteag";
            this.pbSteag.Size = new System.Drawing.Size(34, 21);
            this.pbSteag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSteag.TabIndex = 43;
            this.pbSteag.TabStop = false;
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBrand.Location = new System.Drawing.Point(598, 8);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(62, 21);
            this.lblBrand.TabIndex = 42;
            this.lblBrand.Text = "Toyota";
            // 
            // lblDenumire
            // 
            this.lblDenumire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDenumire.BackColor = System.Drawing.Color.Transparent;
            this.lblDenumire.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenumire.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDenumire.Location = new System.Drawing.Point(543, 37);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(378, 71);
            this.lblDenumire.TabIndex = 41;
            this.lblDenumire.Text = "GR Yaris 1st Edition RZ \"High Performance\" \'20";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(736, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Înălțime";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(744, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Lățime";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(732, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Lungime";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(731, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Greutate";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(723, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tip motor";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(708, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cuplu motor";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(721, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Cai putere";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(729, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tracțiune";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(665, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Capacitate cilindrică";
            // 
            // panelMasini
            // 
            this.panelMasini.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMasini.BackColor = System.Drawing.Color.Transparent;
            this.panelMasini.Location = new System.Drawing.Point(22, 141);
            this.panelMasini.Name = "panelMasini";
            this.panelMasini.Size = new System.Drawing.Size(231, 380);
            this.panelMasini.TabIndex = 31;
            //this.panelMasini.MouseWheel += new MouseEventHandler(MouseWheelSelect);
            // 
            // pbLogoBacklight
            // 
            this.pbLogoBacklight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogoBacklight.BackColor = System.Drawing.Color.Transparent;
            this.pbLogoBacklight.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoBacklight.Image")));
            this.pbLogoBacklight.Location = new System.Drawing.Point(-43, -28);
            this.pbLogoBacklight.Name = "pbLogoBacklight";
            this.pbLogoBacklight.Size = new System.Drawing.Size(348, 176);
            this.pbLogoBacklight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoBacklight.TabIndex = 64;
            this.pbLogoBacklight.TabStop = false;
            // 
            // timerTranzactie
            // 
            this.timerTranzactie.Interval = 900;
            this.timerTranzactie.Tick += new System.EventHandler(this.timerTranzactie_Tick);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 568);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InformationForm_FormClosing);
            this.Load += new System.EventHandler(this.InformationForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlideshowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlideshowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlideshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSteag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBacklight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerSlideShow;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pbLogo;
        private CustomControls.RoundButton btnInfo;
        private CustomControls.RoundButton btnCumpara;
        private System.Windows.Forms.RichTextBox rtxtInfo;
        private System.Windows.Forms.PictureBox pbSlideshowLeft;
        private System.Windows.Forms.PictureBox pbSlideshowRight;
        private System.Windows.Forms.PictureBox pbSlideshow;
        private System.Windows.Forms.Panel panelProgres;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblStoc;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblInaltime;
        private System.Windows.Forms.Label lblLatime;
        private System.Windows.Forms.Label lblLungime;
        private System.Windows.Forms.Label lblGreutate;
        private System.Windows.Forms.Label lblTipMotor;
        private System.Windows.Forms.Label lblCupluMotor;
        private System.Windows.Forms.Label lblCaiPutere;
        private System.Windows.Forms.Label lblTractiune;
        private System.Windows.Forms.Label lblCapCilindrica;
        private System.Windows.Forms.PictureBox pbSteag;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMasini;
        private System.Windows.Forms.PictureBox pbLogoBacklight;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbProfil;
        private System.Windows.Forms.Button btnDelogare;
        private System.Windows.Forms.Button btnCredite;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnTranzactii;
        private System.Windows.Forms.Timer timerTranzactie;
    }
}