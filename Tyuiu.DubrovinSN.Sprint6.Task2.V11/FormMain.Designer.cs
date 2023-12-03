
namespace Tyuiu.DubrovinSN.Sprint6.Task2.V11
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
            this.groupBoxCondition_DSN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DSN = new System.Windows.Forms.TextBox();
            this.groupBoxInput_DSN = new System.Windows.Forms.GroupBox();
            this.labelStopValue_DSN = new System.Windows.Forms.Label();
            this.labelStartValue_DSN = new System.Windows.Forms.Label();
            this.textBoxStopVar_DSN = new System.Windows.Forms.TextBox();
            this.textBoxStartVar_DSN = new System.Windows.Forms.TextBox();
            this.groupBoxResult_DSN = new System.Windows.Forms.GroupBox();
            this.chartGraph_DSN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelRes_DSN = new System.Windows.Forms.Label();
            this.dataGridViewFunction_DSN = new System.Windows.Forms.DataGridView();
            this.ColumnsX_DSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF_DSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSpravka_DSN = new System.Windows.Forms.Button();
            this.buttonPerform_DSN = new System.Windows.Forms.Button();
            this.groupBoxCondition_DSN.SuspendLayout();
            this.groupBoxInput_DSN.SuspendLayout();
            this.groupBoxResult_DSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_DSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_DSN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_DSN
            // 
            this.groupBoxCondition_DSN.Controls.Add(this.textBoxTask_DSN);
            this.groupBoxCondition_DSN.Location = new System.Drawing.Point(13, 12);
            this.groupBoxCondition_DSN.Name = "groupBoxCondition_DSN";
            this.groupBoxCondition_DSN.Size = new System.Drawing.Size(483, 315);
            this.groupBoxCondition_DSN.TabIndex = 0;
            this.groupBoxCondition_DSN.TabStop = false;
            this.groupBoxCondition_DSN.Text = "Условие";
            // 
            // textBoxTask_DSN
            // 
            this.textBoxTask_DSN.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_DSN.Multiline = true;
            this.textBoxTask_DSN.Name = "textBoxTask_DSN";
            this.textBoxTask_DSN.ReadOnly = true;
            this.textBoxTask_DSN.Size = new System.Drawing.Size(327, 290);
            this.textBoxTask_DSN.TabIndex = 0;
            this.textBoxTask_DSN.Text = "Протабулировать функцию F(x) в заданном диапозоне.\r\nРезультат вывести в DataGridV" +
    "iew и построить график функции.\r\n";
            // 
            // groupBoxInput_DSN
            // 
            this.groupBoxInput_DSN.Controls.Add(this.labelStopValue_DSN);
            this.groupBoxInput_DSN.Controls.Add(this.labelStartValue_DSN);
            this.groupBoxInput_DSN.Controls.Add(this.textBoxStopVar_DSN);
            this.groupBoxInput_DSN.Controls.Add(this.textBoxStartVar_DSN);
            this.groupBoxInput_DSN.Location = new System.Drawing.Point(19, 337);
            this.groupBoxInput_DSN.Name = "groupBoxInput_DSN";
            this.groupBoxInput_DSN.Size = new System.Drawing.Size(262, 101);
            this.groupBoxInput_DSN.TabIndex = 1;
            this.groupBoxInput_DSN.TabStop = false;
            this.groupBoxInput_DSN.Text = "Ввод данных";
            // 
            // labelStopValue_DSN
            // 
            this.labelStopValue_DSN.AutoSize = true;
            this.labelStopValue_DSN.Location = new System.Drawing.Point(129, 31);
            this.labelStopValue_DSN.Name = "labelStopValue_DSN";
            this.labelStopValue_DSN.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue_DSN.TabIndex = 3;
            this.labelStopValue_DSN.Text = "Конец шага:";
            // 
            // labelStartValue_DSN
            // 
            this.labelStartValue_DSN.AutoSize = true;
            this.labelStartValue_DSN.Location = new System.Drawing.Point(6, 31);
            this.labelStartValue_DSN.Name = "labelStartValue_DSN";
            this.labelStartValue_DSN.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue_DSN.TabIndex = 2;
            this.labelStartValue_DSN.Text = "Старт шага:";
            // 
            // textBoxStopVar_DSN
            // 
            this.textBoxStopVar_DSN.Location = new System.Drawing.Point(132, 47);
            this.textBoxStopVar_DSN.Name = "textBoxStopVar_DSN";
            this.textBoxStopVar_DSN.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopVar_DSN.TabIndex = 1;
            // 
            // textBoxStartVar_DSN
            // 
            this.textBoxStartVar_DSN.Location = new System.Drawing.Point(7, 47);
            this.textBoxStartVar_DSN.Name = "textBoxStartVar_DSN";
            this.textBoxStartVar_DSN.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartVar_DSN.TabIndex = 0;
            // 
            // groupBoxResult_DSN
            // 
            this.groupBoxResult_DSN.Controls.Add(this.chartGraph_DSN);
            this.groupBoxResult_DSN.Controls.Add(this.labelRes_DSN);
            this.groupBoxResult_DSN.Controls.Add(this.dataGridViewFunction_DSN);
            this.groupBoxResult_DSN.Location = new System.Drawing.Point(502, 12);
            this.groupBoxResult_DSN.Name = "groupBoxResult_DSN";
            this.groupBoxResult_DSN.Size = new System.Drawing.Size(588, 426);
            this.groupBoxResult_DSN.TabIndex = 2;
            this.groupBoxResult_DSN.TabStop = false;
            this.groupBoxResult_DSN.Text = "Вывод данных";
            // 
            // chartGraph_DSN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraph_DSN.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraph_DSN.Legends.Add(legend1);
            this.chartGraph_DSN.Location = new System.Drawing.Point(228, 42);
            this.chartGraph_DSN.Name = "chartGraph_DSN";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraph_DSN.Series.Add(series1);
            this.chartGraph_DSN.Size = new System.Drawing.Size(353, 378);
            this.chartGraph_DSN.TabIndex = 2;
            this.chartGraph_DSN.Text = "chart1";
            // 
            // labelRes_DSN
            // 
            this.labelRes_DSN.AutoSize = true;
            this.labelRes_DSN.Location = new System.Drawing.Point(15, 22);
            this.labelRes_DSN.Name = "labelRes_DSN";
            this.labelRes_DSN.Size = new System.Drawing.Size(62, 13);
            this.labelRes_DSN.TabIndex = 1;
            this.labelRes_DSN.Text = "Результат:";
            // 
            // dataGridViewFunction_DSN
            // 
            this.dataGridViewFunction_DSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_DSN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnsX_DSN,
            this.ColumnF_DSN});
            this.dataGridViewFunction_DSN.Location = new System.Drawing.Point(18, 42);
            this.dataGridViewFunction_DSN.Name = "dataGridViewFunction_DSN";
            this.dataGridViewFunction_DSN.RowHeadersVisible = false;
            this.dataGridViewFunction_DSN.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewFunction_DSN.Size = new System.Drawing.Size(204, 378);
            this.dataGridViewFunction_DSN.TabIndex = 0;
            // 
            // ColumnsX_DSN
            // 
            this.ColumnsX_DSN.HeaderText = "X";
            this.ColumnsX_DSN.Name = "ColumnsX_DSN";
            this.ColumnsX_DSN.ReadOnly = true;
            // 
            // ColumnF_DSN
            // 
            this.ColumnF_DSN.HeaderText = "F(X)";
            this.ColumnF_DSN.Name = "ColumnF_DSN";
            this.ColumnF_DSN.ReadOnly = true;
            // 
            // buttonSpravka_DSN
            // 
            this.buttonSpravka_DSN.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSpravka_DSN.Location = new System.Drawing.Point(287, 359);
            this.buttonSpravka_DSN.Name = "buttonSpravka_DSN";
            this.buttonSpravka_DSN.Size = new System.Drawing.Size(84, 65);
            this.buttonSpravka_DSN.TabIndex = 3;
            this.buttonSpravka_DSN.Text = "Справка";
            this.buttonSpravka_DSN.UseVisualStyleBackColor = false;
            this.buttonSpravka_DSN.Click += new System.EventHandler(this.buttonSpravka_DSN_Click);
            // 
            // buttonPerform_DSN
            // 
            this.buttonPerform_DSN.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonPerform_DSN.Location = new System.Drawing.Point(412, 359);
            this.buttonPerform_DSN.Name = "buttonPerform_DSN";
            this.buttonPerform_DSN.Size = new System.Drawing.Size(84, 65);
            this.buttonPerform_DSN.TabIndex = 4;
            this.buttonPerform_DSN.Text = "Выполнить";
            this.buttonPerform_DSN.UseVisualStyleBackColor = false;
            this.buttonPerform_DSN.Click += new System.EventHandler(this.buttonPerform_DSN_Click);
            this.buttonPerform_DSN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPerform_DSN_MouseDown);
            this.buttonPerform_DSN.MouseEnter += new System.EventHandler(this.buttonPerform_DSN_MouseEnter);
            this.buttonPerform_DSN.MouseLeave += new System.EventHandler(this.buttonPerform_DSN_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Controls.Add(this.buttonPerform_DSN);
            this.Controls.Add(this.buttonSpravka_DSN);
            this.Controls.Add(this.groupBoxResult_DSN);
            this.Controls.Add(this.groupBoxInput_DSN);
            this.Controls.Add(this.groupBoxCondition_DSN);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 11  | Дубровин С.Н";
            this.groupBoxCondition_DSN.ResumeLayout(false);
            this.groupBoxCondition_DSN.PerformLayout();
            this.groupBoxInput_DSN.ResumeLayout(false);
            this.groupBoxInput_DSN.PerformLayout();
            this.groupBoxResult_DSN.ResumeLayout(false);
            this.groupBoxResult_DSN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_DSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_DSN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_DSN;
        private System.Windows.Forms.TextBox textBoxTask_DSN;
        private System.Windows.Forms.GroupBox groupBoxInput_DSN;
        private System.Windows.Forms.Label labelStopValue_DSN;
        private System.Windows.Forms.Label labelStartValue_DSN;
        private System.Windows.Forms.TextBox textBoxStopVar_DSN;
        private System.Windows.Forms.TextBox textBoxStartVar_DSN;
        private System.Windows.Forms.GroupBox groupBoxResult_DSN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph_DSN;
        private System.Windows.Forms.Label labelRes_DSN;
        private System.Windows.Forms.Button buttonSpravka_DSN;
        private System.Windows.Forms.Button buttonPerform_DSN;
        private System.Windows.Forms.DataGridView dataGridViewFunction_DSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnsX_DSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF_DSN;
    }
}

