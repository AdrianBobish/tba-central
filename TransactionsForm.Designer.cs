namespace TBA_Central
{
    partial class TransactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsForm));
            this.dgwTranzactii = new System.Windows.Forms.DataGridView();
            this.statusTranzactii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbAnimatie = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnRestituire = new TBA_Central.CustomControls.RoundButton();
            this.btnInapoi = new TBA_Central.CustomControls.RoundButton();
            this.lblMesaj = new TBA_Central.CustomControls.ScrollingText();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTranzactii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimatie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTranzactii
            // 
            this.dgwTranzactii.AllowUserToAddRows = false;
            this.dgwTranzactii.AllowUserToDeleteRows = false;
            this.dgwTranzactii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwTranzactii.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTranzactii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTranzactii.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusTranzactii});
            this.dgwTranzactii.Location = new System.Drawing.Point(12, 72);
            this.dgwTranzactii.MultiSelect = false;
            this.dgwTranzactii.Name = "dgwTranzactii";
            this.dgwTranzactii.ReadOnly = true;
            this.dgwTranzactii.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTranzactii.Size = new System.Drawing.Size(640, 251);
            this.dgwTranzactii.TabIndex = 0;
            this.dgwTranzactii.SelectionChanged += new System.EventHandler(this.dgwTranzactii_SelectionChanged);
            this.dgwTranzactii.MouseHover += new System.EventHandler(this.form_MouseHover);
            // 
            // statusTranzactii
            // 
            this.statusTranzactii.HeaderText = "Status";
            this.statusTranzactii.Name = "statusTranzactii";
            this.statusTranzactii.ReadOnly = true;
            // 
            // pbAnimatie
            // 
            this.pbAnimatie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAnimatie.Location = new System.Drawing.Point(0, -237);
            this.pbAnimatie.Name = "pbAnimatie";
            this.pbAnimatie.Size = new System.Drawing.Size(811, 811);
            this.pbAnimatie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimatie.TabIndex = 11;
            this.pbAnimatie.TabStop = false;
            this.pbAnimatie.MouseHover += new System.EventHandler(this.form_MouseHover);
            // 
            // timer
            // 
            this.timer.Interval = 900;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnRestituire
            // 
            this.btnRestituire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestituire.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestituire.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnRestituire.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRestituire.BorderRadius = 17;
            this.btnRestituire.BorderSize = 2;
            this.btnRestituire.FlatAppearance.BorderSize = 0;
            this.btnRestituire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestituire.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestituire.ForeColor = System.Drawing.Color.White;
            this.btnRestituire.Location = new System.Drawing.Point(674, 247);
            this.btnRestituire.Name = "btnRestituire";
            this.btnRestituire.Size = new System.Drawing.Size(125, 35);
            this.btnRestituire.TabIndex = 14;
            this.btnRestituire.Text = "Restituire";
            this.btnRestituire.TextColor = System.Drawing.Color.White;
            this.btnRestituire.UseVisualStyleBackColor = false;
            this.btnRestituire.Click += new System.EventHandler(this.btnRestituire_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnInapoi.Location = new System.Drawing.Point(674, 288);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(125, 35);
            this.btnInapoi.TabIndex = 15;
            this.btnInapoi.Text = "Înapoi";
            this.btnInapoi.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.BackColor = System.Drawing.Color.Transparent;
            this.lblMesaj.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMesaj.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblMesaj.Location = new System.Drawing.Point(0, 0);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Seteaza_Viteza = 3;
            this.lblMesaj.Size = new System.Drawing.Size(2717, 69);
            this.lblMesaj.TabIndex = 7;
            this.lblMesaj.Text = "GESTIONAȚI TRANZACȚIILE EFECTUATE PE CONTUL CU EMAIL-UL BOBISHADI@GMAIL.COM";
            this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMesaj.UseCompatibleTextRendering = true;
            this.lblMesaj.MouseHover += new System.EventHandler(this.form_MouseHover);
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(811, 335);
            this.Controls.Add(this.btnRestituire);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.dgwTranzactii);
            this.Controls.Add(this.pbAnimatie);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestionează tranzacții";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransactionsForm_FormClosing);
            this.Load += new System.EventHandler(this.TransactionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTranzactii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimatie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTranzactii;
        private CustomControls.ScrollingText lblMesaj;
        private System.Windows.Forms.PictureBox pbAnimatie;
        private CustomControls.RoundButton btnRestituire;
        private CustomControls.RoundButton btnInapoi;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusTranzactii;
    }
}