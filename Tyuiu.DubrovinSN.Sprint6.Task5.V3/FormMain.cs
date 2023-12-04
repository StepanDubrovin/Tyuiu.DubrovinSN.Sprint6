using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DubrovinSN.Sprint6.Task5.V3.Lib;

namespace Tyuiu.DubrovinSN.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Task5\InPutFileTask5V3.txt";
        private void buttonDoneClick_DSN_Click(object sender, EventArgs e)
        {
            double[] numArray = new double[ds.len];

            dataGridViewNumsV_DSN.ColumnCount = 2;
            dataGridViewNumsV_DSN.Columns[0].Width = 20;
            dataGridViewNumsV_DSN.Columns[1].Width = 50;

            this.chartFunction_DSN.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_DSN.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_DSN.Series[0].Points.Clear();

            numArray = ds.LoadFromDataFile(path);
            for (int i = 0; i < numArray.Length; i++)
            {
                dataGridViewNumsV_DSN.Rows.Add(Convert.ToString(i), Convert.ToString(numArray[i]));
                chartFunction_DSN.Series[0].Points.AddXY(i, numArray[i]);
            }
        }

        private void buttonOpenFile_DSN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonSpravka_DSN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-23-3 Дубровин Степан Николаевич", "Сообщение",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
