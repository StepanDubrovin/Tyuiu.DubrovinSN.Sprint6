using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DubrovinSN.Sprint6.Task2.V11.Lib;

namespace Tyuiu.DubrovinSN.Sprint6.Task2.V11
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

                this.chartGraph_DSN.Titles.Add("График функции F(x)");
                this.chartGraph_DSN.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartGraph_DSN.ChartAreas[0].AxisX.Title = "Ось Y";

                for (int i = 0; i < len - 1; i++)
                {
                    this.dataGridViewFunction_DSN.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartGraph_DSN.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPerform_DSN_MouseEnter(object sender, EventArgs e)
        {
            buttonPerform_DSN.BackColor = Color.Red;
        }

        private void buttonPerform_DSN_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPerform_DSN.BackColor = Color.Blue;
        }

        private void buttonPerform_DSN_MouseLeave(object sender, EventArgs e)
        {
            buttonPerform_DSN.BackColor = Color.Chartreuse;
        }

        private void buttonSpravka_DSN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПБ-23-3 Дубровин Степан Николаевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}


