
namespace Tyuiu.DubrovinSN.Sprint6.Task5.V3
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelUp_DSN = new System.Windows.Forms.Panel();
            this.buttonSpravka_DSN = new System.Windows.Forms.Button();
            this.buttonOpenFile_DSN = new System.Windows.Forms.Button();
            this.buttonDoneClick_DSN = new System.Windows.Forms.Button();
            this.groupBoxСondition_DSN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DSN = new System.Windows.Forms.TextBox();
            this.panelLeftward_DSN = new System.Windows.Forms.Panel();
            this.groupBoxPerform_DSN = new System.Windows.Forms.GroupBox();
            this.panelMiddle_DSN = new System.Windows.Forms.Panel();
            this.chartFunction_DSN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridViewNumsV_DSN = new System.Windows.Forms.DataGridView();
            this.panelUp_DSN.SuspendLayout();
            this.groupBoxСondition_DSN.SuspendLayout();
            this.panelLeftward_DSN.SuspendLayout();
            this.groupBoxPerform_DSN.SuspendLayout();
            this.panelMiddle_DSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumsV_DSN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_DSN
            // 
            this.panelUp_DSN.BackColor = System.Drawing.SystemColors.Control;
            this.panelUp_DSN.Controls.Add(this.buttonSpravka_DSN);
            this.panelUp_DSN.Controls.Add(this.buttonOpenFile_DSN);
            this.panelUp_DSN.Controls.Add(this.buttonDoneClick_DSN);
            this.panelUp_DSN.Controls.Add(this.groupBoxСondition_DSN);
            this.panelUp_DSN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_DSN.Location = new System.Drawing.Point(0, 0);
            this.panelUp_DSN.Name = "panelUp_DSN";
            this.panelUp_DSN.Size = new System.Drawing.Size(784, 85);
            this.panelUp_DSN.TabIndex = 0;
            // 
            // buttonSpravka_DSN
            // 
            this.buttonSpravka_DSN.BackColor = System.Drawing.Color.LightYellow;
            this.buttonSpravka_DSN.Location = new System.Drawing.Point(602, 12);
            this.buttonSpravka_DSN.Name = "buttonSpravka_DSN";
            this.buttonSpravka_DSN.Size = new System.Drawing.Size(73, 54);
            this.buttonSpravka_DSN.TabIndex = 3;
            this.buttonSpravka_DSN.Text = "Справка";
            this.buttonSpravka_DSN.UseVisualStyleBackColor = false;
            this.buttonSpravka_DSN.Click += new System.EventHandler(this.buttonSpravka_DSN_Click);
            // 
            // buttonOpenFile_DSN
            // 
            this.buttonOpenFile_DSN.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonOpenFile_DSN.Location = new System.Drawing.Point(523, 12);
            this.buttonOpenFile_DSN.Name = "buttonOpenFile_DSN";
            this.buttonOpenFile_DSN.Size = new System.Drawing.Size(73, 54);
            this.buttonOpenFile_DSN.TabIndex = 2;
            this.buttonOpenFile_DSN.Text = "Открыть файл";
            this.buttonOpenFile_DSN.UseVisualStyleBackColor = false;
            this.buttonOpenFile_DSN.Click += new System.EventHandler(this.buttonOpenFile_DSN_Click);
            // 
            // buttonDoneClick_DSN
            // 
            this.buttonDoneClick_DSN.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonDoneClick_DSN.Location = new System.Drawing.Point(444, 12);
            this.buttonDoneClick_DSN.Name = "buttonDoneClick_DSN";
            this.buttonDoneClick_DSN.Size = new System.Drawing.Size(73, 54);
            this.buttonDoneClick_DSN.TabIndex = 1;
            this.buttonDoneClick_DSN.Text = "Выполнить";
            this.buttonDoneClick_DSN.UseVisualStyleBackColor = false;
            this.buttonDoneClick_DSN.Click += new System.EventHandler(this.buttonDoneClick_DSN_Click);
            // 
            // groupBoxСondition_DSN
            // 
            this.groupBoxСondition_DSN.Controls.Add(this.textBoxTask_DSN);
            this.groupBoxСondition_DSN.Location = new System.Drawing.Point(3, 3);
            this.groupBoxСondition_DSN.Name = "groupBoxСondition_DSN";
            this.groupBoxСondition_DSN.Size = new System.Drawing.Size(435, 76);
            this.groupBoxСondition_DSN.TabIndex = 0;
            this.groupBoxСondition_DSN.TabStop = false;
            this.groupBoxСondition_DSN.Text = "Условие";
            // 
            // textBoxTask_DSN
            // 
            this.textBoxTask_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_DSN.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_DSN.Multiline = true;
            this.textBoxTask_DSN.Name = "textBoxTask_DSN";
            this.textBoxTask_DSN.ReadOnly = true;
            this.textBoxTask_DSN.Size = new System.Drawing.Size(429, 57);
            this.textBoxTask_DSN.TabIndex = 0;
            this.textBoxTask_DSN.Text = "Прочитать данные из файла InPutFileTask5V3.txt. Вывести в dataGridView. \r\nВывести" +
    " все вещественные числа.  Построить диаграмму по этим значениям.";
            // 
            // panelLeftward_DSN
            // 
            this.panelLeftward_DSN.Controls.Add(this.groupBoxPerform_DSN);
            this.panelLeftward_DSN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftward_DSN.Location = new System.Drawing.Point(0, 85);
            this.panelLeftward_DSN.Name = "panelLeftward_DSN";
            this.panelLeftward_DSN.Size = new System.Drawing.Size(200, 326);
            this.panelLeftward_DSN.TabIndex = 1;
            // 
            // groupBoxPerform_DSN
            // 
            this.groupBoxPerform_DSN.Controls.Add(this.dataGridViewNumsV_DSN);
            this.groupBoxPerform_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPerform_DSN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPerform_DSN.Name = "groupBoxPerform_DSN";
            this.groupBoxPerform_DSN.Size = new System.Drawing.Size(200, 326);
            this.groupBoxPerform_DSN.TabIndex = 0;
            this.groupBoxPerform_DSN.TabStop = false;
            this.groupBoxPerform_DSN.Text = "Вывод данных";
            // 
            // panelMiddle_DSN
            // 
            this.panelMiddle_DSN.Controls.Add(this.chartFunction_DSN);
            this.panelMiddle_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle_DSN.Location = new System.Drawing.Point(200, 85);
            this.panelMiddle_DSN.Name = "panelMiddle_DSN";
            this.panelMiddle_DSN.Size = new System.Drawing.Size(584, 326);
            this.panelMiddle_DSN.TabIndex = 2;
            // 
            // chartFunction_DSN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_DSN.ChartAreas.Add(chartArea1);
            this.chartFunction_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_DSN.Legends.Add(legend1);
            this.chartFunction_DSN.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_DSN.Name = "chartFunction_DSN";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DarkBlue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_DSN.Series.Add(series1);
            this.chartFunction_DSN.Size = new System.Drawing.Size(584, 326);
            this.chartFunction_DSN.TabIndex = 0;
            this.chartFunction_DSN.Text = "chart1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 85);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 326);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // dataGridViewNumsV_DSN
            // 
            this.dataGridViewNumsV_DSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumsV_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNumsV_DSN.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNumsV_DSN.Name = "dataGridViewNumsV_DSN";
            this.dataGridViewNumsV_DSN.ReadOnly = true;
            this.dataGridViewNumsV_DSN.RowHeadersVisible = false;
            this.dataGridViewNumsV_DSN.Size = new System.Drawing.Size(194, 307);
            this.dataGridViewNumsV_DSN.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelMiddle_DSN);
            this.Controls.Add(this.panelLeftward_DSN);
            this.Controls.Add(this.panelUp_DSN);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 3 | Дубровин С.Н";
            this.panelUp_DSN.ResumeLayout(false);
            this.groupBoxСondition_DSN.ResumeLayout(false);
            this.groupBoxСondition_DSN.PerformLayout();
            this.panelLeftward_DSN.ResumeLayout(false);
            this.groupBoxPerform_DSN.ResumeLayout(false);
            this.panelMiddle_DSN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumsV_DSN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_DSN;
        private System.Windows.Forms.GroupBox groupBoxСondition_DSN;
        private System.Windows.Forms.Panel panelLeftward_DSN;
        private System.Windows.Forms.GroupBox groupBoxPerform_DSN;
        private System.Windows.Forms.Panel panelMiddle_DSN;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonSpravka_DSN;
        private System.Windows.Forms.Button buttonOpenFile_DSN;
        private System.Windows.Forms.Button buttonDoneClick_DSN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DSN;
        private System.Windows.Forms.TextBox textBoxTask_DSN;
        private System.Windows.Forms.DataGridView dataGridViewNumsV_DSN;
    }
}

