using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DubrovinSN.Sprint6.Task6.V13.Lib;
using System.IO;

namespace Tyuiu.DubrovinSN.Sprint6.Task6.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path;
        private void buttonSpravka_DSN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_DSN_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            path = openFileDialogTask.FileName;
            textBoxLoadFile_DSN.Text = File.ReadAllText(path);
            groupBoxСonclusion_DSN.Text = groupBoxСonclusion_DSN.Text + " " + openFileDialogTask.FileName;
            buttonDone_DSN.Enabled = true;       
        }

        private void buttonDone_DSN_Click(object sender, EventArgs e)
        {   
  
            textBoxPerform_DSN.Text = ds.CollectTextFromFile(path);
        }
    }
}
