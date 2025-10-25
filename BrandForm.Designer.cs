namespace TBA_Central
{
    partial class BrandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandForm));
            this.lblRegiune = new System.Windows.Forms.Label();
            this.panelBranduri = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.panelBranduri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegiune
            // 
            this.lblRegiune.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegiune.AutoSize = true;
            this.lblRegiune.BackColor = System.Drawing.Color.Transparent;
            this.lblRegiune.Font = new System.Drawing.Font("Felix Titling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiune.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegiune.Location = new System.Drawing.Point(12, 25);
            this.lblRegiune.Name = "lblRegiune";
            this.lblRegiune.Size = new System.Drawing.Size(490, 32);
            this.lblRegiune.TabIndex = 2;
            this.lblRegiune.Text = "A  M  E  R  I  C  A    D  E    N  O  R  D";
            // 
            // panelBranduri
            // 
            this.panelBranduri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBranduri.BackColor = System.Drawing.Color.Transparent;
            this.panelBranduri.Controls.Add(this.pbBack);
            this.panelBranduri.Location = new System.Drawing.Point(23, 72);
            this.panelBranduri.Name = "panelBranduri";
            this.panelBranduri.Size = new System.Drawing.Size(474, 557);
            this.panelBranduri.TabIndex = 3;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.Location = new System.Drawing.Point(3, 502);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(65, 50);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 4;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 636);
            this.Controls.Add(this.panelBranduri);
            this.Controls.Add(this.lblRegiune);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(541, 675);
            this.Name = "BrandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Brands";
            this.Load += new System.EventHandler(this.BrandForm_Load);
            this.panelBranduri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegiune;
        private System.Windows.Forms.Panel panelBranduri;
        private System.Windows.Forms.PictureBox pbBack;
    }
}