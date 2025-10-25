namespace TBA_Central
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.timerAfisaj = new System.Windows.Forms.Timer(this.components);
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblAfisaj = new System.Windows.Forms.Label();
            this.timerAnimatie = new System.Windows.Forms.Timer(this.components);
            this.lblRecuperare = new System.Windows.Forms.Label();
            this.txtParola = new TBA_Central.CustomControls.ModernTextBox();
            this.txtEmail = new TBA_Central.CustomControls.ModernTextBox();
            this.btnInregistrare = new TBA_Central.CustomControls.RoundButton();
            this.btnLogare = new TBA_Central.CustomControls.RoundButton();
            this.SuspendLayout();
            // 
            // timerAfisaj
            // 
            this.timerAfisaj.Tick += new System.EventHandler(this.timerEroare_Tick);
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Felix Titling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(131, 25);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(354, 32);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "T  B  A    C  E  N  T  R  A  L";
            // 
            // lblMesaj
            // 
            this.lblMesaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMesaj.BackColor = System.Drawing.Color.Transparent;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft YaHei UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.Location = new System.Drawing.Point(212, 91);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(185, 37);
            this.lblMesaj.TabIndex = 1;
            this.lblMesaj.Text = "Logare";
            this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(130, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 47);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "eMail: ";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblParola
            // 
            this.lblParola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblParola.AutoSize = true;
            this.lblParola.BackColor = System.Drawing.Color.Transparent;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.Location = new System.Drawing.Point(164, 207);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(58, 20);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parolă:";
            // 
            // lblAfisaj
            // 
            this.lblAfisaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAfisaj.BackColor = System.Drawing.Color.Transparent;
            this.lblAfisaj.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfisaj.ForeColor = System.Drawing.Color.Red;
            this.lblAfisaj.Location = new System.Drawing.Point(206, 252);
            this.lblAfisaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAfisaj.Name = "lblAfisaj";
            this.lblAfisaj.Size = new System.Drawing.Size(188, 23);
            this.lblAfisaj.TabIndex = 19;
            this.lblAfisaj.Text = "~afișaj~";
            this.lblAfisaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAfisaj.Visible = false;
            // 
            // timerAnimatie
            // 
            this.timerAnimatie.Interval = 10;
            this.timerAnimatie.Tick += new System.EventHandler(this.timerAnimatie_Tick);
            // 
            // lblRecuperare
            // 
            this.lblRecuperare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecuperare.BackColor = System.Drawing.Color.Transparent;
            this.lblRecuperare.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperare.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRecuperare.Location = new System.Drawing.Point(365, 236);
            this.lblRecuperare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecuperare.Name = "lblRecuperare";
            this.lblRecuperare.Size = new System.Drawing.Size(101, 23);
            this.lblRecuperare.TabIndex = 19;
            this.lblRecuperare.Text = "Ați uitat parola?";
            this.lblRecuperare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecuperare.Click += new System.EventHandler(this.lblRecuperare_Click);
            this.lblRecuperare.MouseLeave += new System.EventHandler(this.lblRecuperare_MouseLeave);
            this.lblRecuperare.MouseHover += new System.EventHandler(this.lblRecuperare_MouseHover);
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
            this.txtParola.Location = new System.Drawing.Point(233, 200);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtParola.MaxLength = 50;
            this.txtParola.Multiline = false;
            this.txtParola.Name = "txtParola";
            this.txtParola.Padding = new System.Windows.Forms.Padding(7);
            this.txtParola.PasswordChar = true;
            this.txtParola.ReadOnly = false;
            this.txtParola.Size = new System.Drawing.Size(202, 34);
            this.txtParola.TabIndex = 1;
            this.txtParola.Texts = "adr06";
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
            this.txtEmail.Location = new System.Drawing.Point(233, 158);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(202, 34);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Texts = "bobishadi@gmail.com";
            this.txtEmail.UnderlinedStyle = false;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInregistrare.BackColor = System.Drawing.Color.Transparent;
            this.btnInregistrare.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnInregistrare.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnInregistrare.BorderRadius = 15;
            this.btnInregistrare.BorderSize = 2;
            this.btnInregistrare.FlatAppearance.BorderSize = 0;
            this.btnInregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInregistrare.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnInregistrare.Location = new System.Drawing.Point(206, 278);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(91, 32);
            this.btnInregistrare.TabIndex = 7;
            this.btnInregistrare.Text = "Înregistrare";
            this.btnInregistrare.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnInregistrare.UseVisualStyleBackColor = false;
            this.btnInregistrare.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogare
            // 
            this.btnLogare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogare.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogare.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnLogare.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogare.BorderRadius = 15;
            this.btnLogare.BorderSize = 0;
            this.btnLogare.FlatAppearance.BorderSize = 0;
            this.btnLogare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogare.ForeColor = System.Drawing.Color.White;
            this.btnLogare.Location = new System.Drawing.Point(303, 278);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(91, 32);
            this.btnLogare.TabIndex = 6;
            this.btnLogare.Text = "Logare";
            this.btnLogare.TextColor = System.Drawing.Color.White;
            this.btnLogare.UseVisualStyleBackColor = false;
            this.btnLogare.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 361);
            this.Controls.Add(this.lblAfisaj);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRecuperare);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblLogo);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(450, 390);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerAfisaj;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblParola;
        private CustomControls.RoundButton btnLogare;
        private CustomControls.RoundButton btnInregistrare;
        private System.Windows.Forms.Label lblAfisaj;
        private CustomControls.ModernTextBox txtEmail;
        private CustomControls.ModernTextBox txtParola;
        private System.Windows.Forms.Timer timerAnimatie;
        private System.Windows.Forms.Label lblRecuperare;
    }
}

