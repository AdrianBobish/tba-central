namespace TBA_Central
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.timerAfisaj = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.txtPrivilegii = new TBA_Central.CustomControls.ModernTextBox();
            this.txtConfirmare = new TBA_Central.CustomControls.ModernTextBox();
            this.txtParola = new TBA_Central.CustomControls.ModernTextBox();
            this.txtEmail = new TBA_Central.CustomControls.ModernTextBox();
            this.txtPrenume = new TBA_Central.CustomControls.ModernTextBox();
            this.txtNume = new TBA_Central.CustomControls.ModernTextBox();
            this.btnInapoi = new TBA_Central.CustomControls.RoundButton();
            this.btnInregistrare = new TBA_Central.CustomControls.RoundButton();
            this.lblAfisaj = new System.Windows.Forms.Label();
            this.chkNegativ = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkAfirmativ = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerAfisaj
            // 
            this.timerAfisaj.Tick += new System.EventHandler(this.timerAfisaj_Tick);
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.txtPrivilegii);
            this.panel.Controls.Add(this.txtConfirmare);
            this.panel.Controls.Add(this.txtParola);
            this.panel.Controls.Add(this.txtEmail);
            this.panel.Controls.Add(this.txtPrenume);
            this.panel.Controls.Add(this.txtNume);
            this.panel.Controls.Add(this.btnInapoi);
            this.panel.Controls.Add(this.btnInregistrare);
            this.panel.Controls.Add(this.lblAfisaj);
            this.panel.Controls.Add(this.chkNegativ);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.chkAfirmativ);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.lblCod);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(364, 537);
            this.panel.TabIndex = 0;
            // 
            // txtPrivilegii
            // 
            this.txtPrivilegii.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrivilegii.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrivilegii.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrivilegii.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.txtPrivilegii.BorderSize = 1;
            this.txtPrivilegii.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivilegii.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrivilegii.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPrivilegii.Location = new System.Drawing.Point(234, 390);
            this.txtPrivilegii.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivilegii.MaxLength = 13;
            this.txtPrivilegii.Multiline = false;
            this.txtPrivilegii.Name = "txtPrivilegii";
            this.txtPrivilegii.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrivilegii.PasswordChar = true;
            this.txtPrivilegii.ReadOnly = false;
            this.txtPrivilegii.Size = new System.Drawing.Size(108, 31);
            this.txtPrivilegii.TabIndex = 6;
            this.txtPrivilegii.Texts = "C!%.1(f_bN}M:";
            this.txtPrivilegii.UnderlinedStyle = false;
            this.txtPrivilegii.Visible = false;
            this.txtPrivilegii.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtConfirmare
            // 
            this.txtConfirmare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmare.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmare.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtConfirmare.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.txtConfirmare.BorderSize = 2;
            this.txtConfirmare.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConfirmare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtConfirmare.Location = new System.Drawing.Point(140, 337);
            this.txtConfirmare.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmare.MaxLength = 50;
            this.txtConfirmare.Multiline = false;
            this.txtConfirmare.Name = "txtConfirmare";
            this.txtConfirmare.Padding = new System.Windows.Forms.Padding(7);
            this.txtConfirmare.PasswordChar = true;
            this.txtConfirmare.ReadOnly = false;
            this.txtConfirmare.Size = new System.Drawing.Size(202, 34);
            this.txtConfirmare.TabIndex = 4;
            this.txtConfirmare.Texts = "";
            this.txtConfirmare.UnderlinedStyle = false;
            this.txtConfirmare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtParola
            // 
            this.txtParola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtParola.BackColor = System.Drawing.SystemColors.Window;
            this.txtParola.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtParola.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.txtParola.BorderSize = 2;
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtParola.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtParola.Location = new System.Drawing.Point(140, 291);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtParola.MaxLength = 50;
            this.txtParola.Multiline = false;
            this.txtParola.Name = "txtParola";
            this.txtParola.Padding = new System.Windows.Forms.Padding(7);
            this.txtParola.PasswordChar = true;
            this.txtParola.ReadOnly = false;
            this.txtParola.Size = new System.Drawing.Size(202, 34);
            this.txtParola.TabIndex = 3;
            this.txtParola.Texts = "";
            this.txtParola.UnderlinedStyle = false;
            this.txtParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmail.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEmail.Location = new System.Drawing.Point(140, 243);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(202, 34);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrenume.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrenume.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrenume.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.txtPrenume.BorderSize = 2;
            this.txtPrenume.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrenume.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPrenume.Location = new System.Drawing.Point(140, 195);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenume.MaxLength = 50;
            this.txtPrenume.Multiline = false;
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrenume.PasswordChar = false;
            this.txtPrenume.ReadOnly = false;
            this.txtPrenume.Size = new System.Drawing.Size(202, 34);
            this.txtPrenume.TabIndex = 1;
            this.txtPrenume.Texts = "";
            this.txtPrenume.UnderlinedStyle = false;
            this.txtPrenume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtNume
            // 
            this.txtNume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNume.BackColor = System.Drawing.SystemColors.Window;
            this.txtNume.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNume.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.txtNume.BorderSize = 2;
            this.txtNume.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNume.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNume.Location = new System.Drawing.Point(140, 146);
            this.txtNume.Margin = new System.Windows.Forms.Padding(4);
            this.txtNume.MaxLength = 30;
            this.txtNume.Multiline = false;
            this.txtNume.Name = "txtNume";
            this.txtNume.Padding = new System.Windows.Forms.Padding(7);
            this.txtNume.PasswordChar = false;
            this.txtNume.ReadOnly = false;
            this.txtNume.Size = new System.Drawing.Size(202, 34);
            this.txtNume.TabIndex = 0;
            this.txtNume.Texts = "";
            this.txtNume.UnderlinedStyle = false;
            this.txtNume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInapoi.BackColor = System.Drawing.Color.Transparent;
            this.btnInapoi.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnInapoi.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnInapoi.BorderRadius = 15;
            this.btnInapoi.BorderSize = 2;
            this.btnInapoi.FlatAppearance.BorderSize = 0;
            this.btnInapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInapoi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnInapoi.Location = new System.Drawing.Point(84, 495);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(91, 32);
            this.btnInapoi.TabIndex = 36;
            this.btnInapoi.Text = "Înapoi";
            this.btnInapoi.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInregistrare.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInregistrare.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnInregistrare.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInregistrare.BorderRadius = 15;
            this.btnInregistrare.BorderSize = 0;
            this.btnInregistrare.FlatAppearance.BorderSize = 0;
            this.btnInregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInregistrare.ForeColor = System.Drawing.Color.White;
            this.btnInregistrare.Location = new System.Drawing.Point(181, 495);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(91, 32);
            this.btnInregistrare.TabIndex = 29;
            this.btnInregistrare.Text = "Înregistrare";
            this.btnInregistrare.TextColor = System.Drawing.Color.White;
            this.btnInregistrare.UseVisualStyleBackColor = false;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // lblAfisaj
            // 
            this.lblAfisaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAfisaj.BackColor = System.Drawing.Color.Transparent;
            this.lblAfisaj.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfisaj.ForeColor = System.Drawing.Color.Red;
            this.lblAfisaj.Location = new System.Drawing.Point(20, 453);
            this.lblAfisaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAfisaj.Name = "lblAfisaj";
            this.lblAfisaj.Size = new System.Drawing.Size(322, 38);
            this.lblAfisaj.TabIndex = 38;
            this.lblAfisaj.Text = "~afișaj~";
            this.lblAfisaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAfisaj.Visible = false;
            // 
            // chkNegativ
            // 
            this.chkNegativ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkNegativ.AutoSize = true;
            this.chkNegativ.BackColor = System.Drawing.Color.Transparent;
            this.chkNegativ.Checked = true;
            this.chkNegativ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNegativ.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNegativ.Location = new System.Drawing.Point(141, 428);
            this.chkNegativ.Margin = new System.Windows.Forms.Padding(4);
            this.chkNegativ.Name = "chkNegativ";
            this.chkNegativ.Size = new System.Drawing.Size(49, 24);
            this.chkNegativ.TabIndex = 7;
            this.chkNegativ.Text = "Nu";
            this.chkNegativ.UseVisualStyleBackColor = false;
            this.chkNegativ.CheckedChanged += new System.EventHandler(this.chkNegativ_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 392);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Privilegii: ";
            // 
            // chkAfirmativ
            // 
            this.chkAfirmativ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkAfirmativ.AutoSize = true;
            this.chkAfirmativ.BackColor = System.Drawing.Color.Transparent;
            this.chkAfirmativ.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAfirmativ.Location = new System.Drawing.Point(141, 393);
            this.chkAfirmativ.Margin = new System.Windows.Forms.Padding(4);
            this.chkAfirmativ.Name = "chkAfirmativ";
            this.chkAfirmativ.Size = new System.Drawing.Size(47, 24);
            this.chkAfirmativ.TabIndex = 5;
            this.chkAfirmativ.Text = "Da";
            this.chkAfirmativ.UseVisualStyleBackColor = false;
            this.chkAfirmativ.CheckedChanged += new System.EventHandler(this.chkAfirmativ_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 345);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Confirmare parolă: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Parolă: ";
            // 
            // lblCod
            // 
            this.lblCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCod.AutoSize = true;
            this.lblCod.BackColor = System.Drawing.Color.Transparent;
            this.lblCod.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(198, 397);
            this.lblCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(34, 16);
            this.lblCod.TabIndex = 35;
            this.lblCod.Text = "Cod: ";
            this.lblCod.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "eMail: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Prenume: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 37);
            this.label2.TabIndex = 28;
            this.label2.Text = "Înregistrare";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "T  B  A    C  E  N  T  R  A  L";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 561);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(405, 600);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerAfisaj;
        private System.Windows.Forms.Panel panel;
        private CustomControls.RoundButton btnInapoi;
        private CustomControls.RoundButton btnInregistrare;
        private System.Windows.Forms.Label lblAfisaj;
        private System.Windows.Forms.CheckBox chkNegativ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkAfirmativ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.ModernTextBox txtNume;
        private CustomControls.ModernTextBox txtParola;
        private CustomControls.ModernTextBox txtEmail;
        private CustomControls.ModernTextBox txtPrenume;
        private CustomControls.ModernTextBox txtPrivilegii;
        private CustomControls.ModernTextBox txtConfirmare;
    }
}