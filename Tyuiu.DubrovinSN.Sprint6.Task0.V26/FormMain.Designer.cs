
namespace Tyuiu.DubrovinSN.Sprint6.Task0.V26
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
            this.groupBoxCondition_DSN = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_DSN = new System.Windows.Forms.PictureBox();
            this.textBoxText_DSN = new System.Windows.Forms.TextBox();
            this.groupBoxInput_DSN = new System.Windows.Forms.GroupBox();
            this.labelVarX_DSN = new System.Windows.Forms.Label();
            this.textBoxVar_DSN = new System.Windows.Forms.TextBox();
            this.groupBoxСonclusion_DSN = new System.Windows.Forms.GroupBox();
            this.buttonHelp_DSN = new System.Windows.Forms.Button();
            this.labelRes_DSN = new System.Windows.Forms.Label();
            this.textBoxResult_DSN = new System.Windows.Forms.TextBox();
            this.buttonDone_DSN = new System.Windows.Forms.Button();
            this.groupBoxCondition_DSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_DSN)).BeginInit();
            this.groupBoxInput_DSN.SuspendLayout();
            this.groupBoxСonclusion_DSN.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_DSN
            // 
            this.groupBoxCondition_DSN.Controls.Add(this.pictureBoxFormula_DSN);
            this.groupBoxCondition_DSN.Controls.Add(this.textBoxText_DSN);
            this.groupBoxCondition_DSN.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_DSN.Name = "groupBoxCondition_DSN";
            this.groupBoxCondition_DSN.Size = new System.Drawing.Size(513, 179);
            this.groupBoxCondition_DSN.TabIndex = 0;
            this.groupBoxCondition_DSN.TabStop = false;
            this.groupBoxCondition_DSN.Text = "Условие";
            // 
            // pictureBoxFormula_DSN
            // 
            this.pictureBoxFormula_DSN.Image = global::Tyuiu.DubrovinSN.Sprint6.Task0.V26.Properties.Resources.Снимок_экрана_2023_11_30_131058;
            this.pictureBoxFormula_DSN.Location = new System.Drawing.Point(314, 46);
            this.pictureBoxFormula_DSN.Name = "pictureBoxFormula_DSN";
            this.pictureBoxFormula_DSN.Size = new System.Drawing.Size(175, 78);
            this.pictureBoxFormula_DSN.TabIndex = 1;
            this.pictureBoxFormula_DSN.TabStop = false;
            // 
            // textBoxText_DSN
            // 
            this.textBoxText_DSN.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxText_DSN.Location = new System.Drawing.Point(6, 19);
            this.textBoxText_DSN.Multiline = true;
            this.textBoxText_DSN.Name = "textBoxText_DSN";
            this.textBoxText_DSN.ReadOnly = true;
            this.textBoxText_DSN.Size = new System.Drawing.Size(302, 135);
            this.textBoxText_DSN.TabIndex = 0;
            this.textBoxText_DSN.Text = "Вычислить выражение по фомуле\r\n";
            // 
            // groupBoxInput_DSN
            // 
            this.groupBoxInput_DSN.Controls.Add(this.labelVarX_DSN);
            this.groupBoxInput_DSN.Controls.Add(this.textBoxVar_DSN);
            this.groupBoxInput_DSN.Location = new System.Drawing.Point(13, 229);
            this.groupBoxInput_DSN.Name = "groupBoxInput_DSN";
            this.groupBoxInput_DSN.Size = new System.Drawing.Size(217, 161);
            this.groupBoxInput_DSN.TabIndex = 1;
            this.groupBoxInput_DSN.TabStop = false;
            this.groupBoxInput_DSN.Text = "Ввод данных";
            // 
            // labelVarX_DSN
            // 
            this.labelVarX_DSN.AutoSize = true;
            this.labelVarX_DSN.Location = new System.Drawing.Point(6, 56);
            this.labelVarX_DSN.Name = "labelVarX_DSN";
            this.labelVarX_DSN.Size = new System.Drawing.Size(17, 13);
            this.labelVarX_DSN.TabIndex = 1;
            this.labelVarX_DSN.Text = "X:";
            // 
            // textBoxVar_DSN
            // 
            this.textBoxVar_DSN.Location = new System.Drawing.Point(6, 72);
            this.textBoxVar_DSN.Name = "textBoxVar_DSN";
            this.textBoxVar_DSN.Size = new System.Drawing.Size(100, 20);
            this.textBoxVar_DSN.TabIndex = 0;
            // 
            // groupBoxСonclusion_DSN
            // 
            this.groupBoxСonclusion_DSN.Controls.Add(this.buttonHelp_DSN);
            this.groupBoxСonclusion_DSN.Controls.Add(this.labelRes_DSN);
            this.groupBoxСonclusion_DSN.Controls.Add(this.textBoxResult_DSN);
            this.groupBoxСonclusion_DSN.Controls.Add(this.buttonDone_DSN);
            this.groupBoxСonclusion_DSN.Location = new System.Drawing.Point(276, 229);
            this.groupBoxСonclusion_DSN.Name = "groupBoxСonclusion_DSN";
            this.groupBoxСonclusion_DSN.Size = new System.Drawing.Size(250, 161);
            this.groupBoxСonclusion_DSN.TabIndex = 2;
            this.groupBoxСonclusion_DSN.TabStop = false;
            this.groupBoxСonclusion_DSN.Text = "Вывод данных";
            // 
            // buttonHelp_DSN
            // 
            this.buttonHelp_DSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_DSN.Location = new System.Drawing.Point(9, 119);
            this.buttonHelp_DSN.Name = "buttonHelp_DSN";
            this.buttonHelp_DSN.Size = new System.Drawing.Size(25, 23);
            this.buttonHelp_DSN.TabIndex = 3;
            this.buttonHelp_DSN.Text = "?";
            this.buttonHelp_DSN.UseVisualStyleBackColor = true;
            this.buttonHelp_DSN.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // labelRes_DSN
            // 
            this.labelRes_DSN.AutoSize = true;
            this.labelRes_DSN.Location = new System.Drawing.Point(6, 56);
            this.labelRes_DSN.Name = "labelRes_DSN";
            this.labelRes_DSN.Size = new System.Drawing.Size(62, 13);
            this.labelRes_DSN.TabIndex = 2;
            this.labelRes_DSN.Text = "Результат:";
            // 
            // textBoxResult_DSN
            // 
            this.textBoxResult_DSN.Location = new System.Drawing.Point(6, 72);
            this.textBoxResult_DSN.Name = "textBoxResult_DSN";
            this.textBoxResult_DSN.ReadOnly = true;
            this.textBoxResult_DSN.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_DSN.TabIndex = 1;
            // 
            // buttonDone_DSN
            // 
            this.buttonDone_DSN.Location = new System.Drawing.Point(51, 119);
            this.buttonDone_DSN.Name = "buttonDone_DSN";
            this.buttonDone_DSN.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_DSN.TabIndex = 0;
            this.buttonDone_DSN.Text = "Выполинть";
            this.buttonDone_DSN.UseVisualStyleBackColor = true;
            this.buttonDone_DSN.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.groupBoxСonclusion_DSN);
            this.Controls.Add(this.groupBoxInput_DSN);
            this.Controls.Add(this.groupBoxCondition_DSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 26 | Дубровин С.Н";
            this.groupBoxCondition_DSN.ResumeLayout(false);
            this.groupBoxCondition_DSN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_DSN)).EndInit();
            this.groupBoxInput_DSN.ResumeLayout(false);
            this.groupBoxInput_DSN.PerformLayout();
            this.groupBoxСonclusion_DSN.ResumeLayout(false);
            this.groupBoxСonclusion_DSN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_DSN;
        private System.Windows.Forms.PictureBox pictureBoxFormula_DSN;
        private System.Windows.Forms.TextBox textBoxText_DSN;
        private System.Windows.Forms.GroupBox groupBoxInput_DSN;
        private System.Windows.Forms.Label labelVarX_DSN;
        private System.Windows.Forms.TextBox textBoxVar_DSN;
        private System.Windows.Forms.GroupBox groupBoxСonclusion_DSN;
        private System.Windows.Forms.Button buttonDone_DSN;
        private System.Windows.Forms.Label labelRes_DSN;
        private System.Windows.Forms.TextBox textBoxResult_DSN;
        private System.Windows.Forms.Button buttonHelp_DSN;
    }
}

