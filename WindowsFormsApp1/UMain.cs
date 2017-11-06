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
            foreach (FileInfo file in Files)
            {
                str = file.Name;
                cbFonts.Items.Add(str);
                PrivateFontCollection fontCol = new PrivateFontCollection();
                fontCol.AddFontFile(@CurrentFolder + "\\" + str);
                lbFonts.Items.Add(fontCol.Families[0].Name);
            }
            //OTF Font Files
            FileInfo[] FilesO = d.GetFiles("*.otf"); //Getting Text files
            string strO = "";
            foreach (FileInfo fileO in FilesO)
            {
                strO = fileO.Name;
                cbFonts.Items.Add(strO);
                PrivateFontCollection fontCol = new PrivateFontCollection();
                fontCol.AddFontFile(@CurrentFolder + "\\" + strO);
                lbFonts.Items.Add(fontCol.Families[0].Name);
            }
        }

        public FontStyle SetFontStyle(int cbSelectedIndex)
        {
            switch (cbSelectedIndex) {
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
            cbFonts.SelectedIndex = 0;
            cbStyle.SelectedIndex = 0;
            lblStatusFolder.Text = CurrentFolder;
            sbFolder.Refresh();
            lblSample.Text = edtSample.Text;
            PrivateFontCollection fontCol = new PrivateFontCollection();
            fontCol.AddFontFile(@CurrentFolder + "\\" + cbFonts.Text);
            lblSample.Font = new Font(fontCol.Families[0], (float)speSize.Value, SetFontStyle(cbStyle.SelectedIndex));
            lblSample.Text = fontCol.Families[0].Name;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFonts.SelectedIndex = cbFonts.SelectedIndex;
            PrivateFontCollection fontCol = new PrivateFontCollection();
            fontCol.AddFontFile(@CurrentFolder + "\\" + cbFonts.Text);
            lblSample.Font = new Font(fontCol.Families[0], (float)speSize.Value, SetFontStyle(cbStyle.SelectedIndex));
            lblSample.Text = fontCol.Families[0].Name;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFonts.SelectedIndex = lbFonts.SelectedIndex;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            dlgFolder.SelectedPath = CurrentFolder;
            if (dlgFolder.ShowDialog() == DialogResult.OK)
            {
                CurrentFolder = dlgFolder.SelectedPath;
                lblStatusFolder.Text = CurrentFolder;
                sbFolder.Refresh();
                LoadFonts();
            }
        }

        private void btnWindowsFolder_Click(object sender, EventArgs e)
        {
            CurrentFolder = CurrentFolder = "C:\\Windows\\Fonts";
            lblStatusFolder.Text = CurrentFolder;
            sbFolder.Refresh();
            LoadFonts();

        }

        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSample.Font = new Font(lbFonts.Text, (float)speSize.Value, SetFontStyle(cbStyle.SelectedIndex));
        }

        private void dlgFolder_HelpRequest(object sender, EventArgs e)
        {

        }

        private void edtSample_TextChanged(object sender, EventArgs e)
        {
            lblSample.Text = edtSample.Text;
        }

        private void speSize_ValueChanged(object sender, EventArgs e)
        {
            lblSample.Font = new Font(lbFonts.Text, (float)speSize.Value, SetFontStyle(cbStyle.SelectedIndex));
        }
    }
}
