namespace WindowsFormsApp1
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbFonts = new System.Windows.Forms.ListBox();
            this.cbFonts = new System.Windows.Forms.ComboBox();
            this.speSize = new System.Windows.Forms.NumericUpDown();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.edtSample = new System.Windows.Forms.TextBox();
            this.lblSample = new System.Windows.Forms.Label();
            this.lblFontName = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblFontStyle = new System.Windows.Forms.Label();
            this.sbFolder = new System.Windows.Forms.StatusStrip();
            this.lblStatusFolder = new System.Windows.Forms.ToolStripStatusLabel();
            this.mmiMain = new System.Windows.Forms.MenuStrip();
            this.mmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mmiOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mmiWindowsFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mmiExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.speSize)).BeginInit();
            this.sbFolder.SuspendLayout();
            this.mmiMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFonts
            // 
            this.lbFonts.FormattingEnabled = true;
            this.lbFonts.Location = new System.Drawing.Point(369, 141);
            this.lbFonts.Name = "lbFonts";
            this.lbFonts.Size = new System.Drawing.Size(120, 134);
            this.lbFonts.TabIndex = 0;
            this.lbFonts.Visible = false;
            // 
            // cbFonts
            // 
            this.cbFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFonts.FormattingEnabled = true;
            this.cbFonts.Location = new System.Drawing.Point(12, 48);
            this.cbFonts.Name = "cbFonts";
            this.cbFonts.Size = new System.Drawing.Size(293, 21);
            this.cbFonts.TabIndex = 1;
            this.cbFonts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // speSize
            // 
            this.speSize.Location = new System.Drawing.Point(311, 49);
            this.speSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speSize.Name = "speSize";
            this.speSize.Size = new System.Drawing.Size(52, 20);
            this.speSize.TabIndex = 2;
            this.speSize.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.speSize.ValueChanged += new System.EventHandler(this.speSize_ValueChanged);
            // 
            // cbStyle
            // 
            this.cbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Items.AddRange(new object[] {
            "Regular",
            "Bold",
            "Italic",
            "Bold Italic"});
            this.cbStyle.Location = new System.Drawing.Point(369, 48);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(121, 21);
            this.cbStyle.TabIndex = 3;
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // edtSample
            // 
            this.edtSample.Location = new System.Drawing.Point(12, 75);
            this.edtSample.Multiline = true;
            this.edtSample.Name = "edtSample";
            this.edtSample.Size = new System.Drawing.Size(477, 60);
            this.edtSample.TabIndex = 6;
            this.edtSample.TextChanged += new System.EventHandler(this.edtSample_TextChanged);
            // 
            // lblSample
            // 
            this.lblSample.Location = new System.Drawing.Point(12, 151);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(477, 294);
            this.lblSample.TabIndex = 8;
            this.lblSample.Text = "Sample Label";
            // 
            // lblFontName
            // 
            this.lblFontName.AutoSize = true;
            this.lblFontName.Location = new System.Drawing.Point(12, 32);
            this.lblFontName.Name = "lblFontName";
            this.lblFontName.Size = new System.Drawing.Size(59, 13);
            this.lblFontName.TabIndex = 9;
            this.lblFontName.Text = "Font Name";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(308, 33);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(51, 13);
            this.lblSize.TabIndex = 10;
            this.lblSize.Text = "Font Size";
            // 
            // lblFontStyle
            // 
            this.lblFontStyle.AutoSize = true;
            this.lblFontStyle.Location = new System.Drawing.Point(366, 32);
            this.lblFontStyle.Name = "lblFontStyle";
            this.lblFontStyle.Size = new System.Drawing.Size(54, 13);
            this.lblFontStyle.TabIndex = 11;
            this.lblFontStyle.Text = "Font Style";
            // 
            // sbFolder
            // 
            this.sbFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusFolder});
            this.sbFolder.Location = new System.Drawing.Point(0, 451);
            this.sbFolder.Name = "sbFolder";
            this.sbFolder.Size = new System.Drawing.Size(502, 22);
            this.sbFolder.TabIndex = 12;
            this.sbFolder.Text = "sbFolder";
            // 
            // lblStatusFolder
            // 
            this.lblStatusFolder.Name = "lblStatusFolder";
            this.lblStatusFolder.Size = new System.Drawing.Size(85, 17);
            this.lblStatusFolder.Text = "lblStatusFolder";
            // 
            // mmiMain
            // 
            this.mmiMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmiFile});
            this.mmiMain.Location = new System.Drawing.Point(0, 0);
            this.mmiMain.Name = "mmiMain";
            this.mmiMain.Size = new System.Drawing.Size(502, 24);
            this.mmiMain.TabIndex = 13;
            // 
            // mmiFile
            // 
            this.mmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmiOpenFolder,
            this.mmiWindowsFolder,
            this.toolStripSeparator1,
            this.mmiExit});
            this.mmiFile.Name = "mmiFile";
            this.mmiFile.Size = new System.Drawing.Size(37, 20);
            this.mmiFile.Text = "&File";
            // 
            // mmiOpenFolder
            // 
            this.mmiOpenFolder.Name = "mmiOpenFolder";
            this.mmiOpenFolder.Size = new System.Drawing.Size(159, 22);
            this.mmiOpenFolder.Text = "&Open Folder";
            this.mmiOpenFolder.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // mmiWindowsFolder
            // 
            this.mmiWindowsFolder.Name = "mmiWindowsFolder";
            this.mmiWindowsFolder.Size = new System.Drawing.Size(159, 22);
            this.mmiWindowsFolder.Text = "&Windows Folder";
            this.mmiWindowsFolder.Click += new System.EventHandler(this.windowsFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // mmiExit
            // 
            this.mmiExit.Name = "mmiExit";
            this.mmiExit.Size = new System.Drawing.Size(159, 22);
            this.mmiExit.Text = "&Exit";
            this.mmiExit.Click += new System.EventHandler(this.mmiExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 473);
            this.Controls.Add(this.sbFolder);
            this.Controls.Add(this.mmiMain);
            this.Controls.Add(this.lblFontStyle);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFontName);
            this.Controls.Add(this.lblSample);
            this.Controls.Add(this.edtSample);
            this.Controls.Add(this.cbStyle);
            this.Controls.Add(this.speSize);
            this.Controls.Add(this.cbFonts);
            this.Controls.Add(this.lbFonts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mmiMain;
            this.Name = "frmMain";
            this.Text = "Font Browser .NET";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.speSize)).EndInit();
            this.sbFolder.ResumeLayout(false);
            this.sbFolder.PerformLayout();
            this.mmiMain.ResumeLayout(false);
            this.mmiMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFonts;
        private System.Windows.Forms.ComboBox cbFonts;
        private System.Windows.Forms.NumericUpDown speSize;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.TextBox edtSample;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.Label lblFontName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblFontStyle;
        private System.Windows.Forms.StatusStrip sbFolder;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusFolder;
        private System.Windows.Forms.MenuStrip mmiMain;
        private System.Windows.Forms.ToolStripMenuItem mmiFile;
        private System.Windows.Forms.ToolStripMenuItem mmiOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem mmiWindowsFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mmiExit;
    }
}

