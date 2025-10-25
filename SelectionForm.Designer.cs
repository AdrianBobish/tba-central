using System.Drawing;
using System.Windows.Forms;

namespace TBA_Central
{
    partial class SelectionForm
    {
        /// <summary>
        /// TEST
        /// </summary>
        /// <param name="e"></param>
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        //}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionForm));
            this.panelForm = new System.Windows.Forms.Panel();
            this.pbCredite = new System.Windows.Forms.PictureBox();
            this.lblCredite = new System.Windows.Forms.Label();
            this.panelCredite = new System.Windows.Forms.Panel();
            this.pbTranzactii = new System.Windows.Forms.PictureBox();
            this.lblTranzactii = new System.Windows.Forms.Label();
            this.panelTranzactii = new System.Windows.Forms.Panel();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.pbProfil = new System.Windows.Forms.PictureBox();
            this.lblProfil = new System.Windows.Forms.Label();
            this.panelProfil = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCredite)).BeginInit();
            this.panelCredite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTranzactii)).BeginInit();
            this.panelTranzactii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            this.panelProfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelForm.Location = new System.Drawing.Point(-3, 49);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(817, 335);
            this.panelForm.TabIndex = 6;
            // 
            // pbCredite
            // 
            this.pbCredite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCredite.Image = ((System.Drawing.Image)(resources.GetObject("pbCredite.Image")));
            this.pbCredite.Location = new System.Drawing.Point(18, 2);
            this.pbCredite.Name = "pbCredite";
            this.pbCredite.Size = new System.Drawing.Size(45, 45);
            this.pbCredite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCredite.TabIndex = 0;
            this.pbCredite.TabStop = false;
            this.pbCredite.Click += new System.EventHandler(this.control_Click);
            // 
            // lblCredite
            // 
            this.lblCredite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCredite.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCredite.Location = new System.Drawing.Point(62, 0);
            this.lblCredite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCredite.Name = "lblCredite";
            this.lblCredite.Size = new System.Drawing.Size(130, 51);
            this.lblCredite.TabIndex = 2;
            this.lblCredite.Text = "Adăugați credite";
            this.lblCredite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCredite.Click += new System.EventHandler(this.control_Click);
            // 
            // panelCredite
            // 
            this.panelCredite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCredite.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelCredite.Controls.Add(this.lblCredite);
            this.panelCredite.Controls.Add(this.pbCredite);
            this.panelCredite.Location = new System.Drawing.Point(200, 0);
            this.panelCredite.Name = "panelCredite";
            this.panelCredite.Size = new System.Drawing.Size(205, 50);
            this.panelCredite.TabIndex = 8;
            // 
            // pbTranzactii
            // 
            this.pbTranzactii.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbTranzactii.Image = ((System.Drawing.Image)(resources.GetObject("pbTranzactii.Image")));
            this.pbTranzactii.Location = new System.Drawing.Point(17, 3);
            this.pbTranzactii.Name = "pbTranzactii";
            this.pbTranzactii.Size = new System.Drawing.Size(45, 45);
            this.pbTranzactii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTranzactii.TabIndex = 0;
            this.pbTranzactii.TabStop = false;
            this.pbTranzactii.Click += new System.EventHandler(this.control_Click);
            // 
            // lblTranzactii
            // 
            this.lblTranzactii.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTranzactii.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranzactii.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTranzactii.Location = new System.Drawing.Point(61, 1);
            this.lblTranzactii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTranzactii.Name = "lblTranzactii";
            this.lblTranzactii.Size = new System.Drawing.Size(130, 51);
            this.lblTranzactii.TabIndex = 2;
            this.lblTranzactii.Text = "Gestionați tranzacțiile";
            this.lblTranzactii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTranzactii.Click += new System.EventHandler(this.control_Click);
            // 
            // panelTranzactii
            // 
            this.panelTranzactii.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTranzactii.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelTranzactii.Controls.Add(this.lblTranzactii);
            this.panelTranzactii.Controls.Add(this.pbTranzactii);
            this.panelTranzactii.Location = new System.Drawing.Point(404, 0);
            this.panelTranzactii.Name = "panelTranzactii";
            this.panelTranzactii.Size = new System.Drawing.Size(205, 50);
            this.panelTranzactii.TabIndex = 9;
            // 
            // pbAdmin
            // 
            this.pbAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbAdmin.Image")));
            this.pbAdmin.Location = new System.Drawing.Point(15, 3);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(45, 45);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdmin.TabIndex = 0;
            this.pbAdmin.TabStop = false;
            this.pbAdmin.Click += new System.EventHandler(this.control_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdmin.Location = new System.Drawing.Point(59, 1);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(130, 51);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "Panou de control";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdmin.Click += new System.EventHandler(this.control_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAdmin.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAdmin.Controls.Add(this.lblAdmin);
            this.panelAdmin.Controls.Add(this.pbAdmin);
            this.panelAdmin.Enabled = false;
            this.panelAdmin.Location = new System.Drawing.Point(609, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(205, 50);
            this.panelAdmin.TabIndex = 10;
            // 
            // pbProfil
            // 
            this.pbProfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbProfil.Image = ((System.Drawing.Image)(resources.GetObject("pbProfil.Image")));
            this.pbProfil.Location = new System.Drawing.Point(24, 3);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(42, 42);
            this.pbProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfil.TabIndex = 0;
            this.pbProfil.TabStop = false;
            this.pbProfil.Click += new System.EventHandler(this.control_Click);
            // 
            // lblProfil
            // 
            this.lblProfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfil.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProfil.Location = new System.Drawing.Point(67, 0);
            this.lblProfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(130, 51);
            this.lblProfil.TabIndex = 2;
            this.lblProfil.Text = "Vizualizare profil";
            this.lblProfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProfil.Click += new System.EventHandler(this.control_Click);
            // 
            // panelProfil
            // 
            this.panelProfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelProfil.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelProfil.Controls.Add(this.lblProfil);
            this.panelProfil.Controls.Add(this.pbProfil);
            this.panelProfil.Location = new System.Drawing.Point(-4, 0);
            this.panelProfil.Name = "panelProfil";
            this.panelProfil.Size = new System.Drawing.Size(205, 50);
            this.panelProfil.TabIndex = 7;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(811, 384);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelTranzactii);
            this.Controls.Add(this.panelCredite);
            this.Controls.Add(this.panelProfil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(827, 423);
            this.Name = "SelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCredite)).EndInit();
            this.panelCredite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTranzactii)).EndInit();
            this.panelTranzactii.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            this.panelProfil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelForm;
        private PictureBox pbCredite;
        private Label lblCredite;
        private Panel panelCredite;
        private PictureBox pbTranzactii;
        private Label lblTranzactii;
        private Panel panelTranzactii;
        private PictureBox pbAdmin;
        private Label lblAdmin;
        private Panel panelAdmin;
        private PictureBox pbProfil;
        private Label lblProfil;
        private Panel panelProfil;
    }
}