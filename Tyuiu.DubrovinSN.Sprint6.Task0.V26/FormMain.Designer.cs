
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
            this.groupBoxConditionDSN = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormulaDSN = new System.Windows.Forms.PictureBox();
            this.textBoxTextDSN = new System.Windows.Forms.TextBox();
            this.groupBoxInputDSN = new System.Windows.Forms.GroupBox();
            this.labelVarX = new System.Windows.Forms.Label();
            this.textBoxVarDSN = new System.Windows.Forms.TextBox();
            this.groupBoxСonclusionDSN = new System.Windows.Forms.GroupBox();
            this.labelResDSN = new System.Windows.Forms.Label();
            this.textBoxResultDSN = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxConditionDSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormulaDSN)).BeginInit();
            this.groupBoxInputDSN.SuspendLayout();
            this.groupBoxСonclusionDSN.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConditionDSN
            // 
            this.groupBoxConditionDSN.Controls.Add(this.pictureBoxFormulaDSN);
            this.groupBoxConditionDSN.Controls.Add(this.textBoxTextDSN);
            this.groupBoxConditionDSN.Location = new System.Drawing.Point(13, 13);
            this.groupBoxConditionDSN.Name = "groupBoxConditionDSN";
            this.groupBoxConditionDSN.Size = new System.Drawing.Size(513, 179);
            this.groupBoxConditionDSN.TabIndex = 0;
            this.groupBoxConditionDSN.TabStop = false;
            this.groupBoxConditionDSN.Text = "Условие";
            // 
            // pictureBoxFormulaDSN
            // 
            this.pictureBoxFormulaDSN.Image = global::Tyuiu.DubrovinSN.Sprint6.Task0.V26.Properties.Resources.Снимок_экрана_2023_11_30_131058;
            this.pictureBoxFormulaDSN.Location = new System.Drawing.Point(314, 46);
            this.pictureBoxFormulaDSN.Name = "pictureBoxFormulaDSN";
            this.pictureBoxFormulaDSN.Size = new System.Drawing.Size(175, 78);
            this.pictureBoxFormulaDSN.TabIndex = 1;
            this.pictureBoxFormulaDSN.TabStop = false;
            // 
            // textBoxTextDSN
            // 
            this.textBoxTextDSN.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxTextDSN.Location = new System.Drawing.Point(6, 19);
            this.textBoxTextDSN.Multiline = true;
            this.textBoxTextDSN.Name = "textBoxTextDSN";
            this.textBoxTextDSN.ReadOnly = true;
            this.textBoxTextDSN.Size = new System.Drawing.Size(302, 135);
            this.textBoxTextDSN.TabIndex = 0;
            this.textBoxTextDSN.Text = "Вычислить выражение по фомуле\r\n";
            // 
            // groupBoxInputDSN
            // 
            this.groupBoxInputDSN.Controls.Add(this.labelVarX);
            this.groupBoxInputDSN.Controls.Add(this.textBoxVarDSN);
            this.groupBoxInputDSN.Location = new System.Drawing.Point(13, 229);
            this.groupBoxInputDSN.Name = "groupBoxInputDSN";
            this.groupBoxInputDSN.Size = new System.Drawing.Size(217, 161);
            this.groupBoxInputDSN.TabIndex = 1;
            this.groupBoxInputDSN.TabStop = false;
            this.groupBoxInputDSN.Text = "Ввод данных";
            // 
            // labelVarX
            // 
            this.labelVarX.AutoSize = true;
            this.labelVarX.Location = new System.Drawing.Point(6, 56);
            this.labelVarX.Name = "labelVarX";
            this.labelVarX.Size = new System.Drawing.Size(17, 13);
            this.labelVarX.TabIndex = 1;
            this.labelVarX.Text = "X:";
            // 
            // textBoxVarDSN
            // 
            this.textBoxVarDSN.Location = new System.Drawing.Point(6, 72);
            this.textBoxVarDSN.Name = "textBoxVarDSN";
            this.textBoxVarDSN.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarDSN.TabIndex = 0;
            // 
            // groupBoxСonclusionDSN
            // 
            this.groupBoxСonclusionDSN.Controls.Add(this.buttonHelp);
            this.groupBoxСonclusionDSN.Controls.Add(this.labelResDSN);
            this.groupBoxСonclusionDSN.Controls.Add(this.textBoxResultDSN);
            this.groupBoxСonclusionDSN.Controls.Add(this.buttonDone);
            this.groupBoxСonclusionDSN.Location = new System.Drawing.Point(276, 229);
            this.groupBoxСonclusionDSN.Name = "groupBoxСonclusionDSN";
            this.groupBoxСonclusionDSN.Size = new System.Drawing.Size(250, 161);
            this.groupBoxСonclusionDSN.TabIndex = 2;
            this.groupBoxСonclusionDSN.TabStop = false;
            this.groupBoxСonclusionDSN.Text = "Вывод данных";
            // 
            // labelResDSN
            // 
            this.labelResDSN.AutoSize = true;
            this.labelResDSN.Location = new System.Drawing.Point(6, 56);
            this.labelResDSN.Name = "labelResDSN";
            this.labelResDSN.Size = new System.Drawing.Size(62, 13);
            this.labelResDSN.TabIndex = 2;
            this.labelResDSN.Text = "Результат:";
            // 
            // textBoxResultDSN
            // 
            this.textBoxResultDSN.Location = new System.Drawing.Point(6, 72);
            this.textBoxResultDSN.Name = "textBoxResultDSN";
            this.textBoxResultDSN.ReadOnly = true;
            this.textBoxResultDSN.Size = new System.Drawing.Size(100, 20);
            this.textBoxResultDSN.TabIndex = 1;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(51, 119);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Выполинть";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(9, 119);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(25, 23);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.groupBoxСonclusionDSN);
            this.Controls.Add(this.groupBoxInputDSN);
            this.Controls.Add(this.groupBoxConditionDSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 26 | Дубровин С.Н";
            this.groupBoxConditionDSN.ResumeLayout(false);
            this.groupBoxConditionDSN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormulaDSN)).EndInit();
            this.groupBoxInputDSN.ResumeLayout(false);
            this.groupBoxInputDSN.PerformLayout();
            this.groupBoxСonclusionDSN.ResumeLayout(false);
            this.groupBoxСonclusionDSN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConditionDSN;
        private System.Windows.Forms.PictureBox pictureBoxFormulaDSN;
        private System.Windows.Forms.TextBox textBoxTextDSN;
        private System.Windows.Forms.GroupBox groupBoxInputDSN;
        private System.Windows.Forms.Label labelVarX;
        private System.Windows.Forms.TextBox textBoxVarDSN;
        private System.Windows.Forms.GroupBox groupBoxСonclusionDSN;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Label labelResDSN;
        private System.Windows.Forms.TextBox textBoxResultDSN;
        private System.Windows.Forms.Button buttonHelp;
    }
}

