using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DubrovinSN.Sprint6.Task7.V18;
using System.IO;

namespace Tyuiu.DubrovinSN.Sprint6.Task7.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_DSN.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile; 
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpenFile_DSN_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void buttonDoneClick_DSN_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_DSN_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonSpravka_DSN_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }

        private void buttonOpenFile_DSN_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DSN.ShowDialog();
            openFile = openFileDialogTask_DSN.FileName;
            int[,] matrix = new int[rows, columns];
            matrix = LoadFromData(openFile);
            
            dataGridViewInMatrix_DSN.RowCount = rows;
            dataGridViewInMatrix_DSN.ColumnCount = columns;
            dataGridViewOutMatrix_DSN.RowCount = rows;
            dataGridViewOutMatrix_DSN.ColumnCount = columns;


            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_DSN.Columns[i].Width = 50;
                dataGridViewOutMatrix_DSN.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_DSN.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            matrix = ds.GetMatrix(openFile);
            buttonDoneClick_DSN.Enabled = true;
        }

        private void buttonDoneClick_DSN_Click(object sender, EventArgs e)
        {
            int[,] matrixNew = new int[rows, columns];
            matrixNew = ds.GetMatrix(openFile);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {   
                    dataGridViewOutMatrix_DSN.Rows[r].Cells[c].Value = matrixNew[r, c];
                }
            }
            buttonSaveFile_DSN.Enabled = true;
        }

        private void buttonSaveFile_DSN_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();
            string path = saveFileDialogMatrix.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutMatrix_DSN.RowCount;
            int columns = dataGridViewOutMatrix_DSN.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_DSN.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_DSN.Rows[i].Cells[j].Value;
                    }
                }
               File.AppendAllText(path, str + Environment.NewLine);
               str = "";
            }
        }

        private void buttonSpravka_DSN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
