using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DubrovinSN.Sprint6.Task4.V9.Lib;
using System.IO;

namespace Tyuiu.DubrovinSN.Sprint6.Task4.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonPerform_DSN_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartVar_DSN.Text);
                int stopValue = Convert.ToInt32(textBoxStopVar_DSN.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                
                this.chartFunction_DSN.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_DSN.ChartAreas[0].AxisX.Title = "Ось Y";
                textBoxRes_DSN.Text = "";

                chartFunction_DSN.Series[0].Points.Clear();
                for (int i = 0; i < len - 1; i++)
                {
                    this.chartFunction_DSN.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxRes_DSN.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_DSN_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V9.txt";
                File.WriteAllText(path, textBoxRes_DSN.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }    
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_DSN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПБ-23-3 Дубровин Степан Николаевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
