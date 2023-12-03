using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DubrovinSN.Sprint6.Task3.V1.Lib;

namespace Tyuiu.DubrovinSN.Sprint6.Task3.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { {25,20,28,2,6},
                                            {19,9,18,-7,24},
                                            {21,16,5,-7,-8},
                                            {30,-13,1,-15,2},
                                            {31,9,-3,-9,-18}};
        private void buttonClick_DSN_Click(object sender, EventArgs e)
        {
            int[,] array = ds.Calculate(matrix);
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            dataGridViewMatrixNew_DSN.ColumnCount = columns;
            dataGridViewMatrixNew_DSN.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
             dataGridViewMatrixNew_DSN.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixNew_DSN.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            dataGridViewMatixTask_DSN.ColumnCount = columns;
            dataGridViewMatixTask_DSN.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatixTask_DSN.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatixTask_DSN.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonSpravka_DSN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПБ-23-3 Дубровин Степан Николаевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
