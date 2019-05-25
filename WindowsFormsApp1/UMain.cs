using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using Ookii.Dialogs;



namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        string CurrentFolder = "C:\\Windows\\Fonts";

        public frmMain()
        {
            InitializeComponent();

        }



        public void LoadFonts()
        {
            lbFonts.Items.Clear();
            cbFonts.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(@CurrentFolder);//Assuming Test is your Folder
            //TTF Font Files
            FileInfo[] Files = d.GetFiles("*.ttf"); //Getting Text files
            string str = "";
            var ttfcount = 0;
            foreach (FileInfo file in Files)
            {
                str = file.Name;
                lbFonts.Items.Add(str);
                PrivateFontCollection fontCol = new PrivateFontCollection();
                fontCol.AddFontFile(@CurrentFolder + "\\" + str);
                if (!cbFonts.Items.Contains(fontCol.Families[0].Name))
                {
                    cbFonts.Items.Add(fontCol.Families[0].Name);
                    ttfcount++;
                }
                else
                {
                    lbFonts.Items.RemoveAt(ttfcount);
                }
            }
            //OTF Font Files
            FileInfo[] FilesO = d.GetFiles("*.otf"); //Getting Text files
            string strO = "";
            var otfcount = 0;
            foreach (FileInfo fileO in FilesO)
            {
                strO = fileO.Name;
                lbFonts.Items.Add(strO);
                PrivateFontCollection fontCol = new PrivateFontCollection();
                fontCol.AddFontFile(@CurrentFolder + "\\" + strO);
                if (!cbFonts.Items.Contains(fontCol.Families[0].Name))
                {
                    cbFonts.Items.Add(fontCol.Families[0].Name);
                    otfcount++;
                }
                else
                {
                    lbFonts.Items.RemoveAt(ttfcount+otfcount);
                }
            }
        }

        public FontStyle SetFontStyle(int cbSelectedIndex)
        {
            switch (cbSelectedIndex)
            {
                case 0:
                    {
                        return FontStyle.Regular;
                    }
                case 1:
                    {
                        return FontStyle.Bold;
                    }
                case 2:
                    {
                        return FontStyle.Italic;
                    }
                case 3:
                    {
                        return FontStyle.Bold | FontStyle.Italic;
                    }
                default: return FontStyle.Regular;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFonts();
            lbFonts.SelectedIndex = 0;
            cbFonts.SelectedIndex = 0;
            cbStyle.SelectedIndex = 0;
            lblStatusFolder.Text = CurrentFolder;
            sbFolder.Refresh();
            lblSample.Text = edtSample.Text;
            PrivateFontCollection fontCol = new PrivateFontCollection();
            fontCol.AddFontFile(@CurrentFolder + "\\" + lbFonts.Text);
            lblSample.Font = new Font(fontCol.Families[0], (float)speSize.Value, SetFontStyle(cbStyle.SelectedIndex));
            lblSample.Text = fontCol.Families[0].Name;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFonts.SelectedIndex = cbFonts.SelectedIndex;
            PrivateFontCollection fontCol = new PrivateFontCollection();
            fontCol.AddFontFile(@CurrentFolder + "\\" + lbFonts.Text);
            lblSample.Font = new Font(fontCol.Families[0], (float)speSize.Value, SetFontStyle(cbStyle.SelectedIndex));
            if (String.IsNullOrEmpty(edtSample.Text))
            {
                lblSample.Text = fontCol.Families[0].Name;
            }
            else
            {
                lblSample.Text = edtSample.Text;
            }
        }


        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrivateFontCollection fontCol = new PrivateFontCollection();
            fontCol.AddFontFile(@CurrentFolder + "\\" + lbFonts.Text);
            lblSample.Font = new Font(fontCol.Families[0], (float)speSize.Value, SetFontStyle(cbStyle.SelectedIndex));
        }

        private void edtSample_TextChanged(object sender, EventArgs e)
        {
            lblSample.Text = edtSample.Text;
        }

        private void speSize_ValueChanged(object sender, EventArgs e)
        {
            PrivateFontCollection fontCol = new PrivateFontCollection();
            fontCol.AddFontFile(@CurrentFolder + "\\" + lbFonts.Text);
            lblSample.Font = new Font(fontCol.Families[0], (float)speSize.Value, SetFontStyle(cbStyle.SelectedIndex));
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog dlgVistaFolder = new VistaFolderBrowserDialog(); // Ookii.Dialogs
            dlgVistaFolder.SelectedPath = CurrentFolder;
            if (dlgVistaFolder.ShowDialog() == DialogResult.OK)
            {
                CurrentFolder = dlgVistaFolder.SelectedPath;
                lblStatusFolder.Text = CurrentFolder;
                sbFolder.Refresh();
                LoadFonts();
                cbFonts.SelectedIndex = 0;
            }
        }

        private void windowsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CurrentFolder = CurrentFolder = "C:\\Windows\\Fonts";
            lblStatusFolder.Text = CurrentFolder;
            sbFolder.Refresh();
            LoadFonts();
            cbFonts.SelectedIndex = 0;
        }

        private void mmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            lblSample.Width = ClientRectangle.Width - 31;
            lblSample.Height = ClientRectangle.Height - 168;
            edtSample.Width = ClientRectangle.Width - 31;
        }
    }
}
