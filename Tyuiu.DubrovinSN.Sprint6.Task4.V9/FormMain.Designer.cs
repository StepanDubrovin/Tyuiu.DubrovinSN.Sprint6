
namespace Tyuiu.DubrovinSN.Sprint6.Task4.V9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxCondition_DSN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DSN = new System.Windows.Forms.TextBox();
            this.groupBoxInput_DSN = new System.Windows.Forms.GroupBox();
            this.labelStopValue_DSN = new System.Windows.Forms.Label();
            this.labelStartValue_DSN = new System.Windows.Forms.Label();
            this.textBoxStopVar_DSN = new System.Windows.Forms.TextBox();
            this.textBoxStartVar_DSN = new System.Windows.Forms.TextBox();
            this.groupBoxСonclusion_DSN = new System.Windows.Forms.GroupBox();
            this.textBoxRes_DSN = new System.Windows.Forms.TextBox();
            this.buttonPerform_DSN = new System.Windows.Forms.Button();
            this.buttonSaveFile_DSN = new System.Windows.Forms.Button();
            this.buttonSpravka_DSN = new System.Windows.Forms.Button();
            this.chartFunction_DSN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelUp_DSN = new System.Windows.Forms.Panel();
            this.panelLeft_DSN = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelMiddle_DSN = new System.Windows.Forms.Panel();
            this.groupBoxCondition_DSN.SuspendLayout();
            this.groupBoxInput_DSN.SuspendLayout();
            this.groupBoxСonclusion_DSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DSN)).BeginInit();
            this.panelUp_DSN.SuspendLayout();
            this.panelLeft_DSN.SuspendLayout();
            this.panelMiddle_DSN.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_DSN
            // 
            this.groupBoxCondition_DSN.Controls.Add(this.textBoxTask_DSN);
            this.groupBoxCondition_DSN.Location = new System.Drawing.Point(9, 12);
            this.groupBoxCondition_DSN.Name = "groupBoxCondition_DSN";
            this.groupBoxCondition_DSN.Size = new System.Drawing.Size(386, 82);
            this.groupBoxCondition_DSN.TabIndex = 0;
            this.groupBoxCondition_DSN.TabStop = false;
            this.groupBoxCondition_DSN.Text = "Условие";
            // 
            // textBoxTask_DSN
            // 
            this.textBoxTask_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_DSN.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_DSN.Multiline = true;
            this.textBoxTask_DSN.Name = "textBoxTask_DSN";
            this.textBoxTask_DSN.ReadOnly = true;
            this.textBoxTask_DSN.Size = new System.Drawing.Size(380, 63);
            this.textBoxTask_DSN.TabIndex = 0;
            this.textBoxTask_DSN.Text = "Протабулировать функцию F(x) на заданном диапазоне от -5 до 5.\r\nРезультаты вывест" +
    "и в textBox, построить график функции и сохранить в файл\r\nOutPutFileTask.txt по " +
    "нажатию кнопки.\r\n";
            // 
            // groupBoxInput_DSN
            // 
            this.groupBoxInput_DSN.Controls.Add(this.labelStopValue_DSN);
            this.groupBoxInput_DSN.Controls.Add(this.labelStartValue_DSN);
            this.groupBoxInput_DSN.Controls.Add(this.textBoxStopVar_DSN);
            this.groupBoxInput_DSN.Controls.Add(this.textBoxStartVar_DSN);
            this.groupBoxInput_DSN.Location = new System.Drawing.Point(401, 12);
            this.groupBoxInput_DSN.Name = "groupBoxInput_DSN";
            this.groupBoxInput_DSN.Size = new System.Drawing.Size(242, 82);
            this.groupBoxInput_DSN.TabIndex = 1;
            this.groupBoxInput_DSN.TabStop = false;
            this.groupBoxInput_DSN.Text = "Ввод данных";
            // 
            // labelStopValue_DSN
            // 
            this.labelStopValue_DSN.AutoSize = true;
            this.labelStopValue_DSN.Location = new System.Drawing.Point(133, 28);
            this.labelStopValue_DSN.Name = "labelStopValue_DSN";
            this.labelStopValue_DSN.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue_DSN.TabIndex = 3;
            this.labelStopValue_DSN.Text = "Конец шага:";
            // 
            // labelStartValue_DSN
            // 
            this.labelStartValue_DSN.AutoSize = true;
            this.labelStartValue_DSN.Location = new System.Drawing.Point(6, 28);
            this.labelStartValue_DSN.Name = "labelStartValue_DSN";
            this.labelStartValue_DSN.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue_DSN.TabIndex = 2;
            this.labelStartValue_DSN.Text = "Старт шага:";
            // 
            // textBoxStopVar_DSN
            // 
            this.textBoxStopVar_DSN.Location = new System.Drawing.Point(136, 44);
            this.textBoxStopVar_DSN.Name = "textBoxStopVar_DSN";
            this.textBoxStopVar_DSN.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopVar_DSN.TabIndex = 1;
            // 
            // textBoxStartVar_DSN
            // 
            this.textBoxStartVar_DSN.Location = new System.Drawing.Point(6, 44);
            this.textBoxStartVar_DSN.Name = "textBoxStartVar_DSN";
            this.textBoxStartVar_DSN.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartVar_DSN.TabIndex = 0;
            // 
            // groupBoxСonclusion_DSN
            // 
            this.groupBoxСonclusion_DSN.Controls.Add(this.textBoxRes_DSN);
            this.groupBoxСonclusion_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxСonclusion_DSN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxСonclusion_DSN.Name = "groupBoxСonclusion_DSN";
            this.groupBoxСonclusion_DSN.Size = new System.Drawing.Size(225, 441);
            this.groupBoxСonclusion_DSN.TabIndex = 2;
            this.groupBoxСonclusion_DSN.TabStop = false;
            this.groupBoxСonclusion_DSN.Text = "Вывод данных";
            // 
            // textBoxRes_DSN
            // 
            this.textBoxRes_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRes_DSN.Location = new System.Drawing.Point(3, 16);
            this.textBoxRes_DSN.Multiline = true;
            this.textBoxRes_DSN.Name = "textBoxRes_DSN";
            this.textBoxRes_DSN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRes_DSN.Size = new System.Drawing.Size(219, 422);
            this.textBoxRes_DSN.TabIndex = 0;
            // 
            // buttonPerform_DSN
            // 
            this.buttonPerform_DSN.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonPerform_DSN.Location = new System.Drawing.Point(737, 25);
            this.buttonPerform_DSN.Name = "buttonPerform_DSN";
            this.buttonPerform_DSN.Size = new System.Drawing.Size(82, 51);
            this.buttonPerform_DSN.TabIndex = 3;
            this.buttonPerform_DSN.Text = "Выполнить";
            this.buttonPerform_DSN.UseVisualStyleBackColor = false;
            this.buttonPerform_DSN.Click += new System.EventHandler(this.buttonPerform_DSN_Click);
            // 
            // buttonSaveFile_DSN
            // 
            this.buttonSaveFile_DSN.BackColor = System.Drawing.Color.LightCyan;
            this.buttonSaveFile_DSN.Location = new System.Drawing.Point(825, 25);
            this.buttonSaveFile_DSN.Name = "buttonSaveFile_DSN";
            this.buttonSaveFile_DSN.Size = new System.Drawing.Size(82, 51);
            this.buttonSaveFile_DSN.TabIndex = 4;
            this.buttonSaveFile_DSN.Text = "Сохранить";
            this.buttonSaveFile_DSN.UseVisualStyleBackColor = false;
            this.buttonSaveFile_DSN.Click += new System.EventHandler(this.buttonSaveFile_DSN_Click);
            // 
            // buttonSpravka_DSN
            // 
            this.buttonSpravka_DSN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSpravka_DSN.Location = new System.Drawing.Point(649, 25);
            this.buttonSpravka_DSN.Name = "buttonSpravka_DSN";
            this.buttonSpravka_DSN.Size = new System.Drawing.Size(82, 51);
            this.buttonSpravka_DSN.TabIndex = 5;
            this.buttonSpravka_DSN.Text = "Справка";
            this.buttonSpravka_DSN.UseVisualStyleBackColor = false;
            this.buttonSpravka_DSN.Click += new System.EventHandler(this.buttonSpravka_DSN_Click);
            // 
            // chartFunction_DSN
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_DSN.ChartAreas.Add(chartArea2);
            this.chartFunction_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartFunction_DSN.Legends.Add(legend2);
            this.chartFunction_DSN.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_DSN.Name = "chartFunction_DSN";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_DSN.Series.Add(series2);
            this.chartFunction_DSN.Size = new System.Drawing.Size(685, 441);
            this.chartFunction_DSN.TabIndex = 6;
            this.chartFunction_DSN.Text = "chartFunction";
            title2.Name = "TitleFunction";
            title2.Text = "График функции F(x)";
            this.chartFunction_DSN.Titles.Add(title2);
            // 
            // panelUp_DSN
            // 
            this.panelUp_DSN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUp_DSN.Controls.Add(this.groupBoxCondition_DSN);
            this.panelUp_DSN.Controls.Add(this.buttonSaveFile_DSN);
            this.panelUp_DSN.Controls.Add(this.buttonPerform_DSN);
            this.panelUp_DSN.Controls.Add(this.groupBoxInput_DSN);
            this.panelUp_DSN.Controls.Add(this.buttonSpravka_DSN);
            this.panelUp_DSN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_DSN.Location = new System.Drawing.Point(0, 0);
            this.panelUp_DSN.MinimumSize = new System.Drawing.Size(913, 100);
            this.panelUp_DSN.Name = "panelUp_DSN";
            this.panelUp_DSN.Size = new System.Drawing.Size(913, 100);
            this.panelUp_DSN.TabIndex = 7;
            // 
            // panelLeft_DSN
            // 
            this.panelLeft_DSN.Controls.Add(this.groupBoxСonclusion_DSN);
            this.panelLeft_DSN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_DSN.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_DSN.Name = "panelLeft_DSN";
            this.panelLeft_DSN.Size = new System.Drawing.Size(225, 441);
            this.panelLeft_DSN.TabIndex = 8;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(225, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 441);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // panelMiddle_DSN
            // 
            this.panelMiddle_DSN.Controls.Add(this.chartFunction_DSN);
            this.panelMiddle_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle_DSN.Location = new System.Drawing.Point(228, 100);
            this.panelMiddle_DSN.Name = "panelMiddle_DSN";
            this.panelMiddle_DSN.Size = new System.Drawing.Size(685, 441);
            this.panelMiddle_DSN.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 541);
            this.Controls.Add(this.panelMiddle_DSN);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft_DSN);
            this.Controls.Add(this.panelUp_DSN);
            this.MinimumSize = new System.Drawing.Size(929, 580);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 9 | Дубровин С.Н";
            this.groupBoxCondition_DSN.ResumeLayout(false);
            this.groupBoxCondition_DSN.PerformLayout();
            this.groupBoxInput_DSN.ResumeLayout(false);
            this.groupBoxInput_DSN.PerformLayout();
            this.groupBoxСonclusion_DSN.ResumeLayout(false);
            this.groupBoxСonclusion_DSN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DSN)).EndInit();
            this.panelUp_DSN.ResumeLayout(false);
            this.panelLeft_DSN.ResumeLayout(false);
            this.panelMiddle_DSN.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBoxСonclusion_DSN;
        private System.Windows.Forms.TextBox textBoxRes_DSN;
        private System.Windows.Forms.Button buttonPerform_DSN;
        private System.Windows.Forms.Button buttonSaveFile_DSN;
        private System.Windows.Forms.Button buttonSpravka_DSN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DSN;
        private System.Windows.Forms.Panel panelUp_DSN;
        private System.Windows.Forms.Panel panelLeft_DSN;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelMiddle_DSN;
    }
}

