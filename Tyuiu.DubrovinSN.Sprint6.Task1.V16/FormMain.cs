using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DubrovinSN.Sprint6.Task1.V16.Lib;

namespace Tyuiu.DubrovinSN.Sprint6.Task1.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonPerformDSN_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartVarDSN.Text);
                int stopValue = Convert.ToInt32(textBoxStopVarDSN.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResultDSN.Text = "";
                textBoxResultDSN.AppendText("+----------+-------------+" + Environment.NewLine);
                textBoxResultDSN.AppendText("+    X     +     F(x)    |" + Environment.NewLine);
                textBoxResultDSN.AppendText("+----------+-------------+" + Environment.NewLine);

                string str;
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0,5:d}     |  {1, 7:f2}    |", startValue, valueArray[i]);
                    textBoxResultDSN.AppendText(str + Environment.NewLine);
                    startValue++;
                }
                textBoxResultDSN.AppendText("+----------+-------------+" + Environment.NewLine);
                
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravkaDSN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент ИИПБ-23-3 Дубровин Степан Николаевич","Сообщение", MessageBoxButtons.OK);
        }
    }
}
