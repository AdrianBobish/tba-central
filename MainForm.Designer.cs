namespace TBA_Central
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pbProfil = new System.Windows.Forms.PictureBox();
            this.btnTranzactii = new System.Windows.Forms.Button();
            this.btnCredite = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.pbSelectAS = new System.Windows.Forms.PictureBox();
            this.pbSelectEU = new System.Windows.Forms.PictureBox();
            this.pbSelectNA = new System.Windows.Forms.PictureBox();
            this.btnAsia = new TBA_Central.CustomControls.RoundButton();
            this.btnAmericaN = new TBA_Central.CustomControls.RoundButton();
            this.btnEuropa = new TBA_Central.CustomControls.RoundButton();
            this.btnInchide = new TBA_Central.CustomControls.RoundButton();
            this.btnDelogare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectEU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectNA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "T  B  A    C  E  N  T  R  A  L";
            // 
            // pbProfil
            // 
            this.pbProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProfil.BackColor = System.Drawing.Color.Transparent;
            this.pbProfil.Location = new System.Drawing.Point(714, 11);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(35, 35);
            this.pbProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfil.TabIndex = 52;
            this.pbProfil.TabStop = false;
            this.pbProfil.Click += new System.EventHandler(this.pbProfil_Click);
            this.pbProfil.Paint += new System.Windows.Forms.PaintEventHandler(this.pbProfile_Paint);
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
            this.btnTranzactii.Location = new System.Drawing.Point(622, 90);
            this.btnTranzactii.Name = "btnTranzactii";
            this.btnTranzactii.Size = new System.Drawing.Size(105, 32);
            this.btnTranzactii.TabIndex = 47;
            this.btnTranzactii.Text = "Tranzacții";
            this.btnTranzactii.UseVisualStyleBackColor = false;
            this.btnTranzactii.Visible = false;
            this.btnTranzactii.Click += new System.EventHandler(this.btnProfil_Click);
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
            this.btnCredite.Location = new System.Drawing.Point(622, 60);
            this.btnCredite.Name = "btnCredite";
            this.btnCredite.Size = new System.Drawing.Size(105, 32);
            this.btnCredite.TabIndex = 46;
            this.btnCredite.Text = "Credite";
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
            this.btnProfil.Location = new System.Drawing.Point(622, 30);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(105, 32);
            this.btnProfil.TabIndex = 44;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Visible = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.pbSelectAS);
            this.panel.Controls.Add(this.pbSelectEU);
            this.panel.Controls.Add(this.pbSelectNA);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(761, 461);
            this.panel.TabIndex = 53;
            // 
            // pbSelectAS
            // 
            this.pbSelectAS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbSelectAS.BackColor = System.Drawing.Color.Transparent;
            this.pbSelectAS.Location = new System.Drawing.Point(545, 114);
            this.pbSelectAS.Name = "pbSelectAS";
            this.pbSelectAS.Size = new System.Drawing.Size(182, 169);
            this.pbSelectAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectAS.TabIndex = 49;
            this.pbSelectAS.TabStop = false;
            this.pbSelectAS.Visible = false;
            // 
            // pbSelectEU
            // 
            this.pbSelectEU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbSelectEU.BackColor = System.Drawing.Color.Transparent;
            this.pbSelectEU.Location = new System.Drawing.Point(286, 69);
            this.pbSelectEU.Name = "pbSelectEU";
            this.pbSelectEU.Size = new System.Drawing.Size(182, 169);
            this.pbSelectEU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectEU.TabIndex = 48;
            this.pbSelectEU.TabStop = false;
            this.pbSelectEU.Visible = false;
            // 
            // pbSelectNA
            // 
            this.pbSelectNA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbSelectNA.BackColor = System.Drawing.Color.Transparent;
            this.pbSelectNA.Location = new System.Drawing.Point(71, 110);
            this.pbSelectNA.Name = "pbSelectNA";
            this.pbSelectNA.Size = new System.Drawing.Size(182, 169);
            this.pbSelectNA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectNA.TabIndex = 47;
            this.pbSelectNA.TabStop = false;
            // 
            // btnAsia
            // 
            this.btnAsia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAsia.BackColor = System.Drawing.Color.Transparent;
            this.btnAsia.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAsia.BorderColor = System.Drawing.Color.DimGray;
            this.btnAsia.BorderRadius = 19;
            this.btnAsia.BorderSize = 2;
            this.btnAsia.FlatAppearance.BorderSize = 0;
            this.btnAsia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAsia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAsia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsia.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsia.ForeColor = System.Drawing.Color.DimGray;
            this.btnAsia.Location = new System.Drawing.Point(467, 323);
            this.btnAsia.Name = "btnAsia";
            this.btnAsia.Size = new System.Drawing.Size(171, 40);
            this.btnAsia.TabIndex = 50;
            this.btnAsia.Text = "ASIA";
            this.btnAsia.TextColor = System.Drawing.Color.DimGray;
            this.btnAsia.UseVisualStyleBackColor = false;
            this.btnAsia.Click += new System.EventHandler(this.btnSelection_Click);
            this.btnAsia.MouseHover += new System.EventHandler(this.btnSelection_MouseHover);
            // 
            // btnAmericaN
            // 
            this.btnAmericaN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAmericaN.BackColor = System.Drawing.Color.Transparent;
            this.btnAmericaN.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAmericaN.BorderColor = System.Drawing.Color.DimGray;
            this.btnAmericaN.BorderRadius = 19;
            this.btnAmericaN.BorderSize = 2;
            this.btnAmericaN.FlatAppearance.BorderSize = 0;
            this.btnAmericaN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAmericaN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAmericaN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmericaN.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmericaN.ForeColor = System.Drawing.Color.DimGray;
            this.btnAmericaN.Location = new System.Drawing.Point(113, 323);
            this.btnAmericaN.Name = "btnAmericaN";
            this.btnAmericaN.Size = new System.Drawing.Size(171, 40);
            this.btnAmericaN.TabIndex = 48;
            this.btnAmericaN.Text = "AMERICA DE NORD";
            this.btnAmericaN.TextColor = System.Drawing.Color.DimGray;
            this.btnAmericaN.UseVisualStyleBackColor = false;
            this.btnAmericaN.Click += new System.EventHandler(this.btnSelection_Click);
            this.btnAmericaN.MouseHover += new System.EventHandler(this.btnSelection_MouseHover);
            // 
            // btnEuropa
            // 
            this.btnEuropa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEuropa.BackColor = System.Drawing.Color.Transparent;
            this.btnEuropa.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEuropa.BorderColor = System.Drawing.Color.DimGray;
            this.btnEuropa.BorderRadius = 19;
            this.btnEuropa.BorderSize = 2;
            this.btnEuropa.FlatAppearance.BorderSize = 0;
            this.btnEuropa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEuropa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnEuropa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEuropa.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEuropa.ForeColor = System.Drawing.Color.DimGray;
            this.btnEuropa.Location = new System.Drawing.Point(290, 323);
            this.btnEuropa.Name = "btnEuropa";
            this.btnEuropa.Size = new System.Drawing.Size(171, 40);
            this.btnEuropa.TabIndex = 49;
            this.btnEuropa.Text = "EUROPA";
            this.btnEuropa.TextColor = System.Drawing.Color.DimGray;
            this.btnEuropa.UseVisualStyleBackColor = false;
            this.btnEuropa.Click += new System.EventHandler(this.btnSelection_Click);
            this.btnEuropa.MouseHover += new System.EventHandler(this.btnSelection_MouseHover);
            // 
            // btnInchide
            // 
            this.btnInchide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInchide.BackColor = System.Drawing.Color.Transparent;
            this.btnInchide.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnInchide.BorderColor = System.Drawing.Color.Firebrick;
            this.btnInchide.BorderRadius = 15;
            this.btnInchide.BorderSize = 2;
            this.btnInchide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInchide.FlatAppearance.BorderSize = 0;
            this.btnInchide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnInchide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnInchide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInchide.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInchide.ForeColor = System.Drawing.Color.Firebrick;
            this.btnInchide.Location = new System.Drawing.Point(324, 423);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(102, 31);
            this.btnInchide.TabIndex = 51;
            this.btnInchide.Text = "ÎNCHIDEȚI";
            this.btnInchide.TextColor = System.Drawing.Color.Firebrick;
            this.btnInchide.UseVisualStyleBackColor = false;
            this.btnInchide.Click += new System.EventHandler(this.btnSelection_Click);
            this.btnInchide.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnInchide.MouseHover += new System.EventHandler(this.btnSelection_MouseHover);
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
            this.btnDelogare.Location = new System.Drawing.Point(622, 121);
            this.btnDelogare.Name = "btnDelogare";
            this.btnDelogare.Size = new System.Drawing.Size(105, 32);
            this.btnDelogare.TabIndex = 54;
            this.btnDelogare.Text = "Delogare";
            this.btnDelogare.UseVisualStyleBackColor = false;
            this.btnDelogare.Visible = false;
            this.btnDelogare.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 461);
            this.Controls.Add(this.btnDelogare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbProfil);
            this.Controls.Add(this.btnTranzactii);
            this.Controls.Add(this.btnCredite);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnAsia);
            this.Controls.Add(this.btnAmericaN);
            this.Controls.Add(this.btnEuropa);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(777, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectEU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectNA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbProfil;
        private System.Windows.Forms.Button btnTranzactii;
        private System.Windows.Forms.Button btnCredite;
        private System.Windows.Forms.Button btnProfil;
        private CustomControls.RoundButton btnAsia;
        private CustomControls.RoundButton btnAmericaN;
        private CustomControls.RoundButton btnEuropa;
        private CustomControls.RoundButton btnInchide;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pbSelectAS;
        private System.Windows.Forms.PictureBox pbSelectEU;
        private System.Windows.Forms.PictureBox pbSelectNA;
        private System.Windows.Forms.Button btnDelogare;
    }
}