
namespace Tyuiu.DubrovinSN.Sprint6.Task1.V16
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
            this.groupBoxСondition_DSN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DSN = new System.Windows.Forms.TextBox();
            this.groupBoxInput_DSN = new System.Windows.Forms.GroupBox();
            this.labelStopValue_DSN = new System.Windows.Forms.Label();
            this.textBoxStopVar_DSN = new System.Windows.Forms.TextBox();
            this.labelStartValue_DSN = new System.Windows.Forms.Label();
            this.textBoxStartVar_DSN = new System.Windows.Forms.TextBox();
            this.buttonSpravka_DSN = new System.Windows.Forms.Button();
            this.buttonPerform_DSN = new System.Windows.Forms.Button();
            this.groupBoxConclusion_DSN = new System.Windows.Forms.GroupBox();
            this.textBoxResult_DSN = new System.Windows.Forms.TextBox();
            this.groupBoxСondition_DSN.SuspendLayout();
            this.groupBoxInput_DSN.SuspendLayout();
            this.groupBoxConclusion_DSN.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxСondition_DSN
            // 
            this.groupBoxСondition_DSN.Controls.Add(this.textBoxTask_DSN);
            this.groupBoxСondition_DSN.Location = new System.Drawing.Point(12, 12);
            this.groupBoxСondition_DSN.Name = "groupBoxСondition_DSN";
            this.groupBoxСondition_DSN.Size = new System.Drawing.Size(467, 337);
            this.groupBoxСondition_DSN.TabIndex = 0;
            this.groupBoxСondition_DSN.TabStop = false;
            this.groupBoxСondition_DSN.Text = "Условие";
            // 
            // textBoxTask_DSN
            // 
            this.textBoxTask_DSN.Location = new System.Drawing.Point(3, 31);
            this.textBoxTask_DSN.Multiline = true;
            this.textBoxTask_DSN.Name = "textBoxTask_DSN";
            this.textBoxTask_DSN.ReadOnly = true;
            this.textBoxTask_DSN.Size = new System.Drawing.Size(307, 42);
            this.textBoxTask_DSN.TabIndex = 0;
            this.textBoxTask_DSN.Text = "Протабулировать функцию F(x) на заданном диапозоне.\r\nРезультат вывести в виде таб" +
    "лицы.\r\n";
            // 
            // groupBoxInput_DSN
            // 
            this.groupBoxInput_DSN.Controls.Add(this.labelStopValue_DSN);
            this.groupBoxInput_DSN.Controls.Add(this.textBoxStopVar_DSN);
            this.groupBoxInput_DSN.Controls.Add(this.labelStartValue_DSN);
            this.groupBoxInput_DSN.Controls.Add(this.textBoxStartVar_DSN);
            this.groupBoxInput_DSN.Location = new System.Drawing.Point(12, 355);
            this.groupBoxInput_DSN.Name = "groupBoxInput_DSN";
            this.groupBoxInput_DSN.Size = new System.Drawing.Size(262, 83);
            this.groupBoxInput_DSN.TabIndex = 1;
            this.groupBoxInput_DSN.TabStop = false;
            this.groupBoxInput_DSN.Text = "Ввод данных:";
            // 
            // labelStopValue_DSN
            // 
            this.labelStopValue_DSN.AutoSize = true;
            this.labelStopValue_DSN.Location = new System.Drawing.Point(132, 31);
            this.labelStopValue_DSN.Name = "labelStopValue_DSN";
            this.labelStopValue_DSN.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue_DSN.TabIndex = 3;
            this.labelStopValue_DSN.Text = "Конец шага:";
            // 
            // textBoxStopVar_DSN
            // 
            this.textBoxStopVar_DSN.Location = new System.Drawing.Point(125, 47);
            this.textBoxStopVar_DSN.Name = "textBoxStopVar_DSN";
            this.textBoxStopVar_DSN.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopVar_DSN.TabIndex = 2;
            // 
            // labelStartValue_DSN
            // 
            this.labelStartValue_DSN.AutoSize = true;
            this.labelStartValue_DSN.Location = new System.Drawing.Point(6, 31);
            this.labelStartValue_DSN.Name = "labelStartValue_DSN";
            this.labelStartValue_DSN.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue_DSN.TabIndex = 1;
            this.labelStartValue_DSN.Text = "Старт шага:";
            // 
            // textBoxStartVar_DSN
            // 
            this.textBoxStartVar_DSN.Location = new System.Drawing.Point(3, 47);
            this.textBoxStartVar_DSN.Name = "textBoxStartVar_DSN";
            this.textBoxStartVar_DSN.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartVar_DSN.TabIndex = 0;
            // 
            // buttonSpravka_DSN
            // 
            this.buttonSpravka_DSN.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSpravka_DSN.Location = new System.Drawing.Point(280, 370);
            this.buttonSpravka_DSN.Name = "buttonSpravka_DSN";
            this.buttonSpravka_DSN.Size = new System.Drawing.Size(89, 52);
            this.buttonSpravka_DSN.TabIndex = 2;
            this.buttonSpravka_DSN.Text = "Справка";
            this.buttonSpravka_DSN.UseVisualStyleBackColor = false;
            this.buttonSpravka_DSN.Click += new System.EventHandler(this.buttonSpravkaDSN_Click);
            // 
            // buttonPerform_DSN
            // 
            this.buttonPerform_DSN.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonPerform_DSN.Location = new System.Drawing.Point(392, 370);
            this.buttonPerform_DSN.Name = "buttonPerform_DSN";
            this.buttonPerform_DSN.Size = new System.Drawing.Size(87, 52);
            this.buttonPerform_DSN.TabIndex = 3;
            this.buttonPerform_DSN.Text = "Выполнить";
            this.buttonPerform_DSN.UseVisualStyleBackColor = false;
            this.buttonPerform_DSN.Click += new System.EventHandler(this.buttonPerformDSN_Click);
            // 
            // groupBoxConclusion_DSN
            // 
            this.groupBoxConclusion_DSN.Controls.Add(this.textBoxResult_DSN);
            this.groupBoxConclusion_DSN.Location = new System.Drawing.Point(485, 12);
            this.groupBoxConclusion_DSN.Name = "groupBoxConclusion_DSN";
            this.groupBoxConclusion_DSN.Size = new System.Drawing.Size(269, 426);
            this.groupBoxConclusion_DSN.TabIndex = 4;
            this.groupBoxConclusion_DSN.TabStop = false;
            this.groupBoxConclusion_DSN.Text = "Вывод данных:";
            // 
            // textBoxResult_DSN
            // 
            this.textBoxResult_DSN.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_DSN.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_DSN.Multiline = true;
            this.textBoxResult_DSN.Name = "textBoxResult_DSN";
            this.textBoxResult_DSN.ReadOnly = true;
            this.textBoxResult_DSN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_DSN.Size = new System.Drawing.Size(257, 402);
            this.textBoxResult_DSN.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.groupBoxConclusion_DSN);
            this.Controls.Add(this.buttonPerform_DSN);
            this.Controls.Add(this.buttonSpravka_DSN);
            this.Controls.Add(this.groupBoxInput_DSN);
            this.Controls.Add(this.groupBoxСondition_DSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 16  | Дубровин С.Н";
            this.groupBoxСondition_DSN.ResumeLayout(false);
            this.groupBoxСondition_DSN.PerformLayout();
            this.groupBoxInput_DSN.ResumeLayout(false);
            this.groupBoxInput_DSN.PerformLayout();
            this.groupBoxConclusion_DSN.ResumeLayout(false);
            this.groupBoxConclusion_DSN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxСondition_DSN;
        private System.Windows.Forms.TextBox textBoxTask_DSN;
        private System.Windows.Forms.GroupBox groupBoxInput_DSN;
        private System.Windows.Forms.Label labelStopValue_DSN;
        private System.Windows.Forms.TextBox textBoxStopVar_DSN;
        private System.Windows.Forms.Label labelStartValue_DSN;
        private System.Windows.Forms.TextBox textBoxStartVar_DSN;
        private System.Windows.Forms.Button buttonSpravka_DSN;
        private System.Windows.Forms.Button buttonPerform_DSN;
        private System.Windows.Forms.GroupBox groupBoxConclusion_DSN;
        private System.Windows.Forms.TextBox textBoxResult_DSN;
    }
}

