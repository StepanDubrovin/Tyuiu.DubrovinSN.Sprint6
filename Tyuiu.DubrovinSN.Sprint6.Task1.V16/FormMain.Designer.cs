
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
            this.groupBoxСonditionDSN = new System.Windows.Forms.GroupBox();
            this.textBoxTaskDSN = new System.Windows.Forms.TextBox();
            this.groupBoxInputDSN = new System.Windows.Forms.GroupBox();
            this.labelStopValueDSN = new System.Windows.Forms.Label();
            this.textBoxStopVarDSN = new System.Windows.Forms.TextBox();
            this.labelStartValueDSN = new System.Windows.Forms.Label();
            this.textBoxStartVarDSN = new System.Windows.Forms.TextBox();
            this.buttonSpravkaDSN = new System.Windows.Forms.Button();
            this.buttonPerformDSN = new System.Windows.Forms.Button();
            this.groupBoxConclusionDSN = new System.Windows.Forms.GroupBox();
            this.textBoxResultDSN = new System.Windows.Forms.TextBox();
            this.groupBoxСonditionDSN.SuspendLayout();
            this.groupBoxInputDSN.SuspendLayout();
            this.groupBoxConclusionDSN.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxСonditionDSN
            // 
            this.groupBoxСonditionDSN.Controls.Add(this.textBoxTaskDSN);
            this.groupBoxСonditionDSN.Location = new System.Drawing.Point(12, 12);
            this.groupBoxСonditionDSN.Name = "groupBoxСonditionDSN";
            this.groupBoxСonditionDSN.Size = new System.Drawing.Size(467, 337);
            this.groupBoxСonditionDSN.TabIndex = 0;
            this.groupBoxСonditionDSN.TabStop = false;
            this.groupBoxСonditionDSN.Text = "Условие";
            // 
            // textBoxTaskDSN
            // 
            this.textBoxTaskDSN.Location = new System.Drawing.Point(3, 31);
            this.textBoxTaskDSN.Multiline = true;
            this.textBoxTaskDSN.Name = "textBoxTaskDSN";
            this.textBoxTaskDSN.ReadOnly = true;
            this.textBoxTaskDSN.Size = new System.Drawing.Size(307, 42);
            this.textBoxTaskDSN.TabIndex = 0;
            this.textBoxTaskDSN.Text = "Протабулировать функцию F(x) на заданном диапозоне.\r\nРезультат вывести в виде таб" +
    "лицы.\r\n";
            // 
            // groupBoxInputDSN
            // 
            this.groupBoxInputDSN.Controls.Add(this.labelStopValueDSN);
            this.groupBoxInputDSN.Controls.Add(this.textBoxStopVarDSN);
            this.groupBoxInputDSN.Controls.Add(this.labelStartValueDSN);
            this.groupBoxInputDSN.Controls.Add(this.textBoxStartVarDSN);
            this.groupBoxInputDSN.Location = new System.Drawing.Point(12, 355);
            this.groupBoxInputDSN.Name = "groupBoxInputDSN";
            this.groupBoxInputDSN.Size = new System.Drawing.Size(262, 83);
            this.groupBoxInputDSN.TabIndex = 1;
            this.groupBoxInputDSN.TabStop = false;
            this.groupBoxInputDSN.Text = "Ввод данных:";
            // 
            // labelStopValueDSN
            // 
            this.labelStopValueDSN.AutoSize = true;
            this.labelStopValueDSN.Location = new System.Drawing.Point(132, 31);
            this.labelStopValueDSN.Name = "labelStopValueDSN";
            this.labelStopValueDSN.Size = new System.Drawing.Size(69, 13);
            this.labelStopValueDSN.TabIndex = 3;
            this.labelStopValueDSN.Text = "Конец шага:";
            // 
            // textBoxStopVarDSN
            // 
            this.textBoxStopVarDSN.Location = new System.Drawing.Point(125, 47);
            this.textBoxStopVarDSN.Name = "textBoxStopVarDSN";
            this.textBoxStopVarDSN.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopVarDSN.TabIndex = 2;
            // 
            // labelStartValueDSN
            // 
            this.labelStartValueDSN.AutoSize = true;
            this.labelStartValueDSN.Location = new System.Drawing.Point(6, 31);
            this.labelStartValueDSN.Name = "labelStartValueDSN";
            this.labelStartValueDSN.Size = new System.Drawing.Size(67, 13);
            this.labelStartValueDSN.TabIndex = 1;
            this.labelStartValueDSN.Text = "Старт шага:";
            // 
            // textBoxStartVarDSN
            // 
            this.textBoxStartVarDSN.Location = new System.Drawing.Point(3, 47);
            this.textBoxStartVarDSN.Name = "textBoxStartVarDSN";
            this.textBoxStartVarDSN.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartVarDSN.TabIndex = 0;
            // 
            // buttonSpravkaDSN
            // 
            this.buttonSpravkaDSN.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSpravkaDSN.Location = new System.Drawing.Point(280, 370);
            this.buttonSpravkaDSN.Name = "buttonSpravkaDSN";
            this.buttonSpravkaDSN.Size = new System.Drawing.Size(89, 52);
            this.buttonSpravkaDSN.TabIndex = 2;
            this.buttonSpravkaDSN.Text = "Справка";
            this.buttonSpravkaDSN.UseVisualStyleBackColor = false;
            this.buttonSpravkaDSN.Click += new System.EventHandler(this.buttonSpravkaDSN_Click);
            // 
            // buttonPerformDSN
            // 
            this.buttonPerformDSN.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonPerformDSN.Location = new System.Drawing.Point(392, 370);
            this.buttonPerformDSN.Name = "buttonPerformDSN";
            this.buttonPerformDSN.Size = new System.Drawing.Size(87, 52);
            this.buttonPerformDSN.TabIndex = 3;
            this.buttonPerformDSN.Text = "Выполнить";
            this.buttonPerformDSN.UseVisualStyleBackColor = false;
            this.buttonPerformDSN.Click += new System.EventHandler(this.buttonPerformDSN_Click);
            // 
            // groupBoxConclusionDSN
            // 
            this.groupBoxConclusionDSN.Controls.Add(this.textBoxResultDSN);
            this.groupBoxConclusionDSN.Location = new System.Drawing.Point(485, 12);
            this.groupBoxConclusionDSN.Name = "groupBoxConclusionDSN";
            this.groupBoxConclusionDSN.Size = new System.Drawing.Size(269, 426);
            this.groupBoxConclusionDSN.TabIndex = 4;
            this.groupBoxConclusionDSN.TabStop = false;
            this.groupBoxConclusionDSN.Text = "Вывод данных:";
            // 
            // textBoxResultDSN
            // 
            this.textBoxResultDSN.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultDSN.Location = new System.Drawing.Point(6, 19);
            this.textBoxResultDSN.Multiline = true;
            this.textBoxResultDSN.Name = "textBoxResultDSN";
            this.textBoxResultDSN.ReadOnly = true;
            this.textBoxResultDSN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultDSN.Size = new System.Drawing.Size(257, 402);
            this.textBoxResultDSN.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.groupBoxConclusionDSN);
            this.Controls.Add(this.buttonPerformDSN);
            this.Controls.Add(this.buttonSpravkaDSN);
            this.Controls.Add(this.groupBoxInputDSN);
            this.Controls.Add(this.groupBoxСonditionDSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 16  | Дубровин С.Н";
            this.groupBoxСonditionDSN.ResumeLayout(false);
            this.groupBoxСonditionDSN.PerformLayout();
            this.groupBoxInputDSN.ResumeLayout(false);
            this.groupBoxInputDSN.PerformLayout();
            this.groupBoxConclusionDSN.ResumeLayout(false);
            this.groupBoxConclusionDSN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxСonditionDSN;
        private System.Windows.Forms.TextBox textBoxTaskDSN;
        private System.Windows.Forms.GroupBox groupBoxInputDSN;
        private System.Windows.Forms.Label labelStopValueDSN;
        private System.Windows.Forms.TextBox textBoxStopVarDSN;
        private System.Windows.Forms.Label labelStartValueDSN;
        private System.Windows.Forms.TextBox textBoxStartVarDSN;
        private System.Windows.Forms.Button buttonSpravkaDSN;
        private System.Windows.Forms.Button buttonPerformDSN;
        private System.Windows.Forms.GroupBox groupBoxConclusionDSN;
        private System.Windows.Forms.TextBox textBoxResultDSN;
    }
}

