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
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnWindowsFolder = new System.Windows.Forms.Button();
            this.edtSample = new System.Windows.Forms.TextBox();
            this.lblSampleDesc = new System.Windows.Forms.Label();
            this.lblSample = new System.Windows.Forms.Label();
            this.lblFontName = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblFontStyle = new System.Windows.Forms.Label();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.sbFolder = new System.Windows.Forms.StatusStrip();
            this.lblStatusFolder = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.speSize)).BeginInit();
            this.sbFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFonts
            // 
            this.lbFonts.FormattingEnabled = true;
            this.lbFonts.Location = new System.Drawing.Point(376, 80);
            this.lbFonts.Name = "lbFonts";
            this.lbFonts.Size = new System.Drawing.Size(120, 342);
            this.lbFonts.TabIndex = 0;
            this.lbFonts.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cbFonts
            // 
            this.cbFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFonts.FormattingEnabled = true;
            this.cbFonts.Location = new System.Drawing.Point(12, 25);
            this.cbFonts.Name = "cbFonts";
            this.cbFonts.Size = new System.Drawing.Size(161, 21);
            this.cbFonts.TabIndex = 1;
            this.cbFonts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // speSize
            // 
            this.speSize.Location = new System.Drawing.Point(183, 25);
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
            this.cbStyle.Location = new System.Drawing.Point(245, 25);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(121, 21);
            this.cbStyle.TabIndex = 3;
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(373, 11);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(123, 23);
            this.btnOpenFolder.TabIndex = 4;
            this.btnOpenFolder.Text = "&Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnWindowsFolder
            // 
            this.btnWindowsFolder.Location = new System.Drawing.Point(373, 40);
            this.btnWindowsFolder.Name = "btnWindowsFolder";
            this.btnWindowsFolder.Size = new System.Drawing.Size(123, 23);
            this.btnWindowsFolder.TabIndex = 5;
            this.btnWindowsFolder.Text = "&Windows Folder";
            this.btnWindowsFolder.UseVisualStyleBackColor = true;
            this.btnWindowsFolder.Click += new System.EventHandler(this.btnWindowsFolder_Click);
            // 
            // edtSample
            // 
            this.edtSample.Location = new System.Drawing.Point(12, 52);
            this.edtSample.Name = "edtSample";
            this.edtSample.Size = new System.Drawing.Size(354, 20);
            this.edtSample.TabIndex = 6;
            this.edtSample.Text = "Sample";
            this.edtSample.TextChanged += new System.EventHandler(this.edtSample_TextChanged);
            // 
            // lblSampleDesc
            // 
            this.lblSampleDesc.AutoSize = true;
            this.lblSampleDesc.Location = new System.Drawing.Point(12, 75);
            this.lblSampleDesc.Name = "lblSampleDesc";
            this.lblSampleDesc.Size = new System.Drawing.Size(42, 13);
            this.lblSampleDesc.TabIndex = 7;
            this.lblSampleDesc.Text = "Sample";
            // 
            // lblSample
            // 
            this.lblSample.Location = new System.Drawing.Point(12, 99);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(354, 323);
            this.lblSample.TabIndex = 8;
            this.lblSample.Text = "label2";
            // 
            // lblFontName
            // 
            this.lblFontName.AutoSize = true;
            this.lblFontName.Location = new System.Drawing.Point(12, 9);
            this.lblFontName.Name = "lblFontName";
            this.lblFontName.Size = new System.Drawing.Size(59, 13);
            this.lblFontName.TabIndex = 9;
            this.lblFontName.Text = "Font Name";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(180, 9);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(51, 13);
            this.lblSize.TabIndex = 10;
            this.lblSize.Text = "Font Size";
            // 
            // lblFontStyle
            // 
            this.lblFontStyle.AutoSize = true;
            this.lblFontStyle.Location = new System.Drawing.Point(242, 9);
            this.lblFontStyle.Name = "lblFontStyle";
            this.lblFontStyle.Size = new System.Drawing.Size(54, 13);
            this.lblFontStyle.TabIndex = 11;
            this.lblFontStyle.Text = "Font Style";
            // 
            // dlgFolder
            // 
            this.dlgFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.dlgFolder.ShowNewFolderButton = false;
            this.dlgFolder.HelpRequest += new System.EventHandler(this.dlgFolder_HelpRequest);
            // 
            // sbFolder
            // 
            this.sbFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusFolder});
            this.sbFolder.Location = new System.Drawing.Point(0, 425);
            this.sbFolder.Name = "sbFolder";
            this.sbFolder.Size = new System.Drawing.Size(508, 22);
            this.sbFolder.TabIndex = 12;
            this.sbFolder.Text = "sbFolder";
            // 
            // lblStatusFolder
            // 
            this.lblStatusFolder.Name = "lblStatusFolder";
            this.lblStatusFolder.Size = new System.Drawing.Size(85, 17);
            this.lblStatusFolder.Text = "lblStatusFolder";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 447);
            this.Controls.Add(this.sbFolder);
            this.Controls.Add(this.lblFontStyle);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFontName);
            this.Controls.Add(this.lblSample);
            this.Controls.Add(this.lblSampleDesc);
            this.Controls.Add(this.edtSample);
            this.Controls.Add(this.btnWindowsFolder);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.cbStyle);
            this.Controls.Add(this.speSize);
            this.Controls.Add(this.cbFonts);
            this.Controls.Add(this.lbFonts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Font Browser .NET";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speSize)).EndInit();
            this.sbFolder.ResumeLayout(false);
            this.sbFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFonts;
        private System.Windows.Forms.ComboBox cbFonts;
        private System.Windows.Forms.NumericUpDown speSize;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnWindowsFolder;
        private System.Windows.Forms.TextBox edtSample;
        private System.Windows.Forms.Label lblSampleDesc;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.Label lblFontName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblFontStyle;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.StatusStrip sbFolder;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusFolder;
    }
}

