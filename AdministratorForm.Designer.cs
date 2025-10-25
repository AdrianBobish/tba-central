namespace TBA_Central
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dgwSus = new System.Windows.Forms.DataGridView();
            this.dgwJos = new System.Windows.Forms.DataGridView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainerSus = new System.Windows.Forms.SplitContainer();
            this.gbS = new System.Windows.Forms.GroupBox();
            this.btnActSus = new System.Windows.Forms.Button();
            this.cmbSus = new System.Windows.Forms.ComboBox();
            this.splitContainerJos = new System.Windows.Forms.SplitContainer();
            this.gbD = new System.Windows.Forms.GroupBox();
            this.btnActJos = new System.Windows.Forms.Button();
            this.cmbJos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwJos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSus)).BeginInit();
            this.splitContainerSus.Panel1.SuspendLayout();
            this.splitContainerSus.Panel2.SuspendLayout();
            this.splitContainerSus.SuspendLayout();
            this.gbS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerJos)).BeginInit();
            this.splitContainerJos.Panel1.SuspendLayout();
            this.splitContainerJos.Panel2.SuspendLayout();
            this.splitContainerJos.SuspendLayout();
            this.gbD.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 0;
            // 
            // dgwSus
            // 
            this.dgwSus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwSus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSus.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgwSus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwSus.Location = new System.Drawing.Point(0, 0);
            this.dgwSus.MultiSelect = false;
            this.dgwSus.Name = "dgwSus";
            this.dgwSus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSus.Size = new System.Drawing.Size(594, 155);
            this.dgwSus.TabIndex = 1;
            this.dgwSus.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSus_CellValueChanged);
            this.dgwSus.SelectionChanged += new System.EventHandler(this.dgwS_SelectionChanged);
            this.dgwSus.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgwSus_UserDeletingRow);
            // 
            // dgwJos
            // 
            this.dgwJos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwJos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwJos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgwJos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwJos.Location = new System.Drawing.Point(0, 0);
            this.dgwJos.MultiSelect = false;
            this.dgwJos.Name = "dgwJos";
            this.dgwJos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwJos.Size = new System.Drawing.Size(594, 155);
            this.dgwJos.TabIndex = 1;
            this.dgwJos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwJos_CellValueChanged);
            this.dgwJos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgwJos_UserDeletingRow);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(12, 12);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.splitContainerSus);
            this.splitContainer.Panel1MinSize = 130;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainerJos);
            this.splitContainer.Panel2MinSize = 130;
            this.splitContainer.Size = new System.Drawing.Size(787, 311);
            this.splitContainer.SplitterDistance = 152;
            this.splitContainer.TabIndex = 3;
            // 
            // splitContainerSus
            // 
            this.splitContainerSus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSus.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSus.MinimumSize = new System.Drawing.Size(787, 155);
            this.splitContainerSus.Name = "splitContainerSus";
            // 
            // splitContainerSus.Panel1
            // 
            this.splitContainerSus.Panel1.Controls.Add(this.dgwSus);
            this.splitContainerSus.Panel1MinSize = 530;
            // 
            // splitContainerSus.Panel2
            // 
            this.splitContainerSus.Panel2.Controls.Add(this.gbS);
            this.splitContainerSus.Panel2MinSize = 158;
            this.splitContainerSus.Size = new System.Drawing.Size(787, 155);
            this.splitContainerSus.SplitterDistance = 594;
            this.splitContainerSus.TabIndex = 0;
            // 
            // gbS
            // 
            this.gbS.Controls.Add(this.btnActSus);
            this.gbS.Controls.Add(this.cmbSus);
            this.gbS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbS.Location = new System.Drawing.Point(0, 0);
            this.gbS.Name = "gbS";
            this.gbS.Size = new System.Drawing.Size(189, 155);
            this.gbS.TabIndex = 3;
            this.gbS.TabStop = false;
            this.gbS.Text = "Tabelă principală";
            // 
            // btnActSus
            // 
            this.btnActSus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActSus.Enabled = false;
            this.btnActSus.Location = new System.Drawing.Point(53, 95);
            this.btnActSus.Name = "btnActSus";
            this.btnActSus.Size = new System.Drawing.Size(92, 29);
            this.btnActSus.TabIndex = 1;
            this.btnActSus.Text = "Actualizează";
            this.btnActSus.UseVisualStyleBackColor = true;
            this.btnActSus.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // cmbSus
            // 
            this.cmbSus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSus.FormattingEnabled = true;
            this.cmbSus.Items.AddRange(new object[] {
            "",
            "Utilizatori",
            "Masini"});
            this.cmbSus.Location = new System.Drawing.Point(33, 45);
            this.cmbSus.Name = "cmbSus";
            this.cmbSus.Size = new System.Drawing.Size(137, 27);
            this.cmbSus.TabIndex = 0;
            this.cmbSus.SelectedIndexChanged += new System.EventHandler(this.cmbS_SelectedIndexChanged);
            // 
            // splitContainerJos
            // 
            this.splitContainerJos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerJos.Location = new System.Drawing.Point(0, 0);
            this.splitContainerJos.MinimumSize = new System.Drawing.Size(787, 152);
            this.splitContainerJos.Name = "splitContainerJos";
            // 
            // splitContainerJos.Panel1
            // 
            this.splitContainerJos.Panel1.Controls.Add(this.dgwJos);
            // 
            // splitContainerJos.Panel2
            // 
            this.splitContainerJos.Panel2.Controls.Add(this.gbD);
            this.splitContainerJos.Size = new System.Drawing.Size(787, 155);
            this.splitContainerJos.SplitterDistance = 594;
            this.splitContainerJos.TabIndex = 0;
            // 
            // gbD
            // 
            this.gbD.Controls.Add(this.btnActJos);
            this.gbD.Controls.Add(this.cmbJos);
            this.gbD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbD.Location = new System.Drawing.Point(0, 0);
            this.gbD.Name = "gbD";
            this.gbD.Size = new System.Drawing.Size(189, 155);
            this.gbD.TabIndex = 3;
            this.gbD.TabStop = false;
            this.gbD.Text = "Tabelă secundară";
            // 
            // btnActJos
            // 
            this.btnActJos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActJos.Enabled = false;
            this.btnActJos.Location = new System.Drawing.Point(53, 103);
            this.btnActJos.Name = "btnActJos";
            this.btnActJos.Size = new System.Drawing.Size(92, 29);
            this.btnActJos.TabIndex = 1;
            this.btnActJos.Text = "Actualizează";
            this.btnActJos.UseVisualStyleBackColor = true;
            this.btnActJos.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // cmbJos
            // 
            this.cmbJos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbJos.FormattingEnabled = true;
            this.cmbJos.Items.AddRange(new object[] {
            ""});
            this.cmbJos.Location = new System.Drawing.Point(33, 48);
            this.cmbJos.Name = "cmbJos";
            this.cmbJos.Size = new System.Drawing.Size(137, 27);
            this.cmbJos.TabIndex = 0;
            this.cmbJos.SelectedIndexChanged += new System.EventHandler(this.cmbD_SelectedIndexChanged);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 335);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Panou de control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwJos)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerSus.Panel1.ResumeLayout(false);
            this.splitContainerSus.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSus)).EndInit();
            this.splitContainerSus.ResumeLayout(false);
            this.gbS.ResumeLayout(false);
            this.splitContainerJos.Panel1.ResumeLayout(false);
            this.splitContainerJos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerJos)).EndInit();
            this.splitContainerJos.ResumeLayout(false);
            this.gbD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwSus;
        private System.Windows.Forms.DataGridView dgwJos;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.SplitContainer splitContainerSus;
        private System.Windows.Forms.GroupBox gbS;
        private System.Windows.Forms.Button btnActSus;
        private System.Windows.Forms.ComboBox cmbSus;
        private System.Windows.Forms.SplitContainer splitContainerJos;
        private System.Windows.Forms.GroupBox gbD;
        private System.Windows.Forms.Button btnActJos;
        private System.Windows.Forms.ComboBox cmbJos;
    }
}