
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.groupBoxCondition_DSN.SuspendLayout();
            this.groupBoxInput_DSN.SuspendLayout();
            this.groupBoxСonclusion_DSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DSN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_DSN
            // 
            this.groupBoxCondition_DSN.Controls.Add(this.textBoxTask_DSN);
            this.groupBoxCondition_DSN.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_DSN.Name = "groupBoxCondition_DSN";
            this.groupBoxCondition_DSN.Size = new System.Drawing.Size(355, 70);
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
            this.textBoxTask_DSN.Size = new System.Drawing.Size(342, 45);
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
            this.groupBoxInput_DSN.Location = new System.Drawing.Point(374, 13);
            this.groupBoxInput_DSN.Name = "groupBoxInput_DSN";
            this.groupBoxInput_DSN.Size = new System.Drawing.Size(242, 70);
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
            this.groupBoxСonclusion_DSN.Location = new System.Drawing.Point(13, 89);
            this.groupBoxСonclusion_DSN.Name = "groupBoxСonclusion_DSN";
            this.groupBoxСonclusion_DSN.Size = new System.Drawing.Size(241, 448);
            this.groupBoxСonclusion_DSN.TabIndex = 2;
            this.groupBoxСonclusion_DSN.TabStop = false;
            this.groupBoxСonclusion_DSN.Text = "Вывод данных";
            // 
            // textBoxRes_DSN
            // 
            this.textBoxRes_DSN.Location = new System.Drawing.Point(7, 20);
            this.textBoxRes_DSN.Multiline = true;
            this.textBoxRes_DSN.Name = "textBoxRes_DSN";
            this.textBoxRes_DSN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRes_DSN.Size = new System.Drawing.Size(228, 422);
            this.textBoxRes_DSN.TabIndex = 0;
            // 
            // buttonPerform_DSN
            // 
            this.buttonPerform_DSN.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonPerform_DSN.Location = new System.Drawing.Point(622, 26);
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
            this.buttonSaveFile_DSN.Location = new System.Drawing.Point(710, 26);
            this.buttonSaveFile_DSN.Name = "buttonSaveFile_DSN";
            this.buttonSaveFile_DSN.Size = new System.Drawing.Size(75, 51);
            this.buttonSaveFile_DSN.TabIndex = 4;
            this.buttonSaveFile_DSN.Text = "Сохранить";
            this.buttonSaveFile_DSN.UseVisualStyleBackColor = false;
            this.buttonSaveFile_DSN.Click += new System.EventHandler(this.buttonSaveFile_DSN_Click);
            // 
            // buttonSpravka_DSN
            // 
            this.buttonSpravka_DSN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSpravka_DSN.Location = new System.Drawing.Point(791, 26);
            this.buttonSpravka_DSN.Name = "buttonSpravka_DSN";
            this.buttonSpravka_DSN.Size = new System.Drawing.Size(74, 51);
            this.buttonSpravka_DSN.TabIndex = 5;
            this.buttonSpravka_DSN.Text = "Справка";
            this.buttonSpravka_DSN.UseVisualStyleBackColor = false;
            this.buttonSpravka_DSN.Click += new System.EventHandler(this.buttonSpravka_DSN_Click);
            // 
            // chartFunction_DSN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_DSN.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_DSN.Legends.Add(legend1);
            this.chartFunction_DSN.Location = new System.Drawing.Point(261, 90);
            this.chartFunction_DSN.Name = "chartFunction_DSN";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_DSN.Series.Add(series1);
            this.chartFunction_DSN.Size = new System.Drawing.Size(604, 447);
            this.chartFunction_DSN.TabIndex = 6;
            this.chartFunction_DSN.Text = "chartFunction";
            title1.Name = "TitleFunction";
            title1.Text = "График функции F(x)";
            this.chartFunction_DSN.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 541);
            this.Controls.Add(this.chartFunction_DSN);
            this.Controls.Add(this.buttonSpravka_DSN);
            this.Controls.Add(this.buttonSaveFile_DSN);
            this.Controls.Add(this.buttonPerform_DSN);
            this.Controls.Add(this.groupBoxСonclusion_DSN);
            this.Controls.Add(this.groupBoxInput_DSN);
            this.Controls.Add(this.groupBoxCondition_DSN);
            this.MaximizeBox = false;
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
    }
}

