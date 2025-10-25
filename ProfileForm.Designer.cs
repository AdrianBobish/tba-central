namespace TBA_Central
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.pbProfil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblCredite = new System.Windows.Forms.Label();
            this.pbAnimatie1 = new System.Windows.Forms.PictureBox();
            this.pbAnimatie3 = new System.Windows.Forms.PictureBox();
            this.pbAnimatie2 = new System.Windows.Forms.PictureBox();
            this.pbAnimatie4 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.timerEroare = new System.Windows.Forms.Timer(this.components);
            this.lblAfisaj = new System.Windows.Forms.Label();
            this.pbAnimatie5 = new System.Windows.Forms.PictureBox();
            this.txtParola = new TBA_Central.CustomControls.ModernTextBox();
            this.txtEmail = new TBA_Central.CustomControls.ModernTextBox();
            this.txtPrenume = new TBA_Central.CustomControls.ModernTextBox();
            this.txtNume = new TBA_Central.CustomControls.ModernTextBox();
            this.btnEdit = new TBA_Central.CustomControls.RoundButton();
            this.btnInapoi = new TBA_Central.CustomControls.RoundButton();
            this.btnSchimbaPoza = new TBA_Central.CustomControls.RoundButton();
            this.panelUtil2 = new System.Windows.Forms.Panel();
            this.panelUtil1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimatie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimatie3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimatie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimatie4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimatie5)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProfil
            // 
            this.pbProfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbProfil.Image = ((System.Drawing.Image)(resources.GetObject("pbProfil.Image")));
            this.pbProfil.Location = new System.Drawing.Point(16, 21);
            this.pbProfil.Margin = new System.Windows.Forms.Padding(4);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(306, 293);
            this.pbProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfil.TabIndex = 0;
            this.pbProfil.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credite: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume:  ";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(446, 179);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 21);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "eMail: ";
            // 
            // lblParola
            // 
            this.lblParola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.Location = new System.Drawing.Point(444, 225);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(67, 21);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parolă: ";
            // 
            // lblCredite
            // 
            this.lblCredite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCredite.AutoSize = true;
            this.lblCredite.BackColor = System.Drawing.Color.Transparent;
            this.lblCredite.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredite.Location = new System.Drawing.Point(540, 26);
            this.lblCredite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCredite.Name = "lblCredite";
            this.lblCredite.Size = new System.Drawing.Size(175, 36);
            this.lblCredite.TabIndex = 1;
            this.lblCredite.Text = "1.000.000 €";
            // 
            // pbAnimatie1
            // 
            this.pbAnimatie1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAnimatie1.Location = new System.Drawing.Point(381, 244);
            this.pbAnimatie1.Name = "pbAnimatie1";
            this.pbAnimatie1.Size = new System.Drawing.Size(400, 400);
            this.pbAnimatie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimatie1.TabIndex = 5;
            this.pbAnimatie1.TabStop = false;
            // 
            // pbAnimatie3
            // 
            this.pbAnimatie3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAnimatie3.Location = new System.Drawing.Point(-97, 173);
            this.pbAnimatie3.Name = "pbAnimatie3";
            this.pbAnimatie3.Size = new System.Drawing.Size(261, 241);
            this.pbAnimatie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimatie3.TabIndex = 5;
            this.pbAnimatie3.TabStop = false;
            this.pbAnimatie3.Visible = false;
            // 
            // pbAnimatie2
            // 
            this.pbAnimatie2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAnimatie2.Location = new System.Drawing.Point(241, 133);
            this.pbAnimatie2.Name = "pbAnimatie2";
            this.pbAnimatie2.Size = new System.Drawing.Size(135, 135);
            this.pbAnimatie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimatie2.TabIndex = 5;
            this.pbAnimatie2.TabStop = false;
            this.pbAnimatie2.Visible = false;
            // 
            // pbAnimatie4
            // 
            this.pbAnimatie4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAnimatie4.Location = new System.Drawing.Point(-8, -28);
            this.pbAnimatie4.Name = "pbAnimatie4";
            this.pbAnimatie4.Size = new System.Drawing.Size(300, 300);
            this.pbAnimatie4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimatie4.TabIndex = 5;
            this.pbAnimatie4.TabStop = false;
            this.pbAnimatie4.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Prenume: ";
            // 
            // timerEroare
            // 
            this.timerEroare.Interval = 1000;
            this.timerEroare.Tick += new System.EventHandler(this.timerEroare_Tick);
            // 
            // lblAfisaj
            // 
            this.lblAfisaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAfisaj.BackColor = System.Drawing.Color.Transparent;
            this.lblAfisaj.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfisaj.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAfisaj.Location = new System.Drawing.Point(404, 255);
            this.lblAfisaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAfisaj.Name = "lblAfisaj";
            this.lblAfisaj.Size = new System.Drawing.Size(326, 23);
            this.lblAfisaj.TabIndex = 21;
            this.lblAfisaj.Text = "~afișaj~";
            this.lblAfisaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAfisaj.Visible = false;
            // 
            // pbAnimatie5
            // 
            this.pbAnimatie5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAnimatie5.Location = new System.Drawing.Point(531, -393);
            this.pbAnimatie5.Name = "pbAnimatie5";
            this.pbAnimatie5.Size = new System.Drawing.Size(492, 481);
            this.pbAnimatie5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimatie5.TabIndex = 5;
            this.pbAnimatie5.TabStop = false;
            // 
            // txtParola
            // 
            this.txtParola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtParola.BackColor = System.Drawing.SystemColors.Window;
            this.txtParola.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtParola.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.txtParola.BorderSize = 0;
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtParola.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtParola.Location = new System.Drawing.Point(532, 217);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtParola.MaxLength = 50;
            this.txtParola.Multiline = false;
            this.txtParola.Name = "txtParola";
            this.txtParola.Padding = new System.Windows.Forms.Padding(7);
            this.txtParola.PasswordChar = true;
            this.txtParola.ReadOnly = true;
            this.txtParola.Size = new System.Drawing.Size(207, 36);
            this.txtParola.TabIndex = 14;
            this.txtParola.Texts = "adrian2006";
            this.txtParola.UnderlinedStyle = true;
            this.txtParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNume_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmail.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.txtEmail.BorderSize = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEmail.Location = new System.Drawing.Point(532, 173);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(207, 36);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Texts = "bobishadi@gmail.com";
            this.txtEmail.UnderlinedStyle = true;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNume_KeyDown);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrenume.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrenume.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrenume.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.txtPrenume.BorderSize = 0;
            this.txtPrenume.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrenume.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPrenume.Location = new System.Drawing.Point(532, 129);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenume.MaxLength = 50;
            this.txtPrenume.Multiline = false;
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrenume.PasswordChar = false;
            this.txtPrenume.ReadOnly = true;
            this.txtPrenume.Size = new System.Drawing.Size(207, 36);
            this.txtPrenume.TabIndex = 14;
            this.txtPrenume.Texts = "Adrian-Teodor";
            this.txtPrenume.UnderlinedStyle = true;
            this.txtPrenume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNume_KeyDown);
            // 
            // txtNume
            // 
            this.txtNume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNume.BackColor = System.Drawing.SystemColors.Window;
            this.txtNume.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNume.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.txtNume.BorderSize = 0;
            this.txtNume.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNume.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNume.Location = new System.Drawing.Point(532, 85);
            this.txtNume.Margin = new System.Windows.Forms.Padding(4);
            this.txtNume.MaxLength = 30;
            this.txtNume.Multiline = false;
            this.txtNume.Name = "txtNume";
            this.txtNume.Padding = new System.Windows.Forms.Padding(7);
            this.txtNume.PasswordChar = false;
            this.txtNume.ReadOnly = true;
            this.txtNume.Size = new System.Drawing.Size(207, 36);
            this.txtNume.TabIndex = 14;
            this.txtNume.Texts = "Bobiș";
            this.txtNume.UnderlinedStyle = true;
            this.txtNume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNume_KeyDown);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.BorderRadius = 17;
            this.btnEdit.BorderSize = 2;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(576, 281);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 35);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Editați profilul";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInapoi.BackColor = System.Drawing.Color.Transparent;
            this.btnInapoi.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnInapoi.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnInapoi.BorderRadius = 17;
            this.btnInapoi.BorderSize = 2;
            this.btnInapoi.FlatAppearance.BorderSize = 0;
            this.btnInapoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnInapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInapoi.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInapoi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnInapoi.Location = new System.Drawing.Point(445, 281);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(125, 35);
            this.btnInapoi.TabIndex = 13;
            this.btnInapoi.Text = "Înapoi";
            this.btnInapoi.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // btnSchimbaPoza
            // 
            this.btnSchimbaPoza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSchimbaPoza.BackColor = System.Drawing.Color.Transparent;
            this.btnSchimbaPoza.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSchimbaPoza.BorderColor = System.Drawing.Color.Black;
            this.btnSchimbaPoza.BorderRadius = 20;
            this.btnSchimbaPoza.BorderSize = 1;
            this.btnSchimbaPoza.FlatAppearance.BorderSize = 0;
            this.btnSchimbaPoza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSchimbaPoza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchimbaPoza.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchimbaPoza.ForeColor = System.Drawing.Color.Black;
            this.btnSchimbaPoza.Location = new System.Drawing.Point(298, 6);
            this.btnSchimbaPoza.Name = "btnSchimbaPoza";
            this.btnSchimbaPoza.Size = new System.Drawing.Size(40, 40);
            this.btnSchimbaPoza.TabIndex = 6;
            this.btnSchimbaPoza.Text = "📂";
            this.btnSchimbaPoza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchimbaPoza.TextColor = System.Drawing.Color.Black;
            this.btnSchimbaPoza.UseVisualStyleBackColor = false;
            this.btnSchimbaPoza.Visible = false;
            this.btnSchimbaPoza.Click += new System.EventHandler(this.btnSchimbaPoza_Click);
            // 
            // panelUtil2
            // 
            this.panelUtil2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUtil2.Location = new System.Drawing.Point(381, 390);
            this.panelUtil2.Name = "panelUtil2";
            this.panelUtil2.Size = new System.Drawing.Size(400, 240);
            this.panelUtil2.TabIndex = 22;
            this.panelUtil2.Visible = false;
            // 
            // panelUtil1
            // 
            this.panelUtil1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUtil1.Location = new System.Drawing.Point(531, -393);
            this.panelUtil1.Name = "panelUtil1";
            this.panelUtil1.Size = new System.Drawing.Size(492, 360);
            this.panelUtil1.TabIndex = 22;
            this.panelUtil1.Visible = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 335);
            this.Controls.Add(this.panelUtil2);
            this.Controls.Add(this.panelUtil1);
            this.Controls.Add(this.lblAfisaj);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnSchimbaPoza);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCredite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbProfil);
            this.Controls.Add(this.pbAnimatie2);
            this.Controls.Add(this.pbAnimatie3);
            this.Controls.Add(this.pbAnimatie4);
            this.Controls.Add(this.pbAnimatie5);
            this.Controls.Add(this.pbAnimatie1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vizualizare profil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileForm_FormClosing);
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimatie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimatie3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimatie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimatie4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimatie5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblCredite;
        private System.Windows.Forms.PictureBox pbAnimatie1;
        private System.Windows.Forms.PictureBox pbAnimatie3;
        private System.Windows.Forms.PictureBox pbAnimatie2;
        private System.Windows.Forms.PictureBox pbAnimatie4;
        private System.Windows.Forms.Timer timer;
        private CustomControls.RoundButton btnSchimbaPoza;
        private CustomControls.RoundButton btnEdit;
        private CustomControls.RoundButton btnInapoi;
        private System.Windows.Forms.Label label5;
        private CustomControls.ModernTextBox txtNume;
        private CustomControls.ModernTextBox txtPrenume;
        private CustomControls.ModernTextBox txtEmail;
        private CustomControls.ModernTextBox txtParola;
        private System.Windows.Forms.Timer timerEroare;
        private System.Windows.Forms.Label lblAfisaj;
        private System.Windows.Forms.PictureBox pbAnimatie5;
        private System.Windows.Forms.Panel panelUtil2;
        private System.Windows.Forms.Panel panelUtil1;
    }
}