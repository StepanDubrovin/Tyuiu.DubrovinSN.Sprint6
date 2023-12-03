
namespace Tyuiu.DubrovinSN.Sprint6.Task3.V1
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
            this.groupBoxTask_DSN = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatixTask_DSN = new System.Windows.Forms.DataGridView();
            this.textBoxСondition_DSN = new System.Windows.Forms.TextBox();
            this.groupBoxResult_DSN = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrixNew_DSN = new System.Windows.Forms.DataGridView();
            this.buttonSpravka_DSN = new System.Windows.Forms.Button();
            this.buttonClick_DSN = new System.Windows.Forms.Button();
            this.groupBoxTask_DSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatixTask_DSN)).BeginInit();
            this.groupBoxResult_DSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixNew_DSN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_DSN
            // 
            this.groupBoxTask_DSN.Controls.Add(this.dataGridViewMatixTask_DSN);
            this.groupBoxTask_DSN.Controls.Add(this.textBoxСondition_DSN);
            this.groupBoxTask_DSN.Location = new System.Drawing.Point(14, 13);
            this.groupBoxTask_DSN.Name = "groupBoxTask_DSN";
            this.groupBoxTask_DSN.Size = new System.Drawing.Size(522, 319);
            this.groupBoxTask_DSN.TabIndex = 0;
            this.groupBoxTask_DSN.TabStop = false;
            this.groupBoxTask_DSN.Text = "Условие";
            // 
            // dataGridViewMatixTask_DSN
            // 
            this.dataGridViewMatixTask_DSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatixTask_DSN.ColumnHeadersVisible = false;
            this.dataGridViewMatixTask_DSN.Location = new System.Drawing.Point(276, 23);
            this.dataGridViewMatixTask_DSN.Name = "dataGridViewMatixTask_DSN";
            this.dataGridViewMatixTask_DSN.ReadOnly = true;
            this.dataGridViewMatixTask_DSN.RowHeadersVisible = false;
            this.dataGridViewMatixTask_DSN.Size = new System.Drawing.Size(240, 161);
            this.dataGridViewMatixTask_DSN.TabIndex = 1;
            // 
            // textBoxСondition_DSN
            // 
            this.textBoxСondition_DSN.Location = new System.Drawing.Point(6, 19);
            this.textBoxСondition_DSN.Multiline = true;
            this.textBoxСondition_DSN.Name = "textBoxСondition_DSN";
            this.textBoxСondition_DSN.ReadOnly = true;
            this.textBoxСondition_DSN.Size = new System.Drawing.Size(263, 294);
            this.textBoxСondition_DSN.TabIndex = 0;
            this.textBoxСondition_DSN.Text = "Дана матрица 5 на 5\r\n25  20  28  2    6\r\n19   9  18  -7  24\r\n21  16   5  -7  -8\r\n" +
    "30 -13  1  -15  2\r\n31   9  -3  -9 -18\r\nВыполнить сортировку по возрастанию в пер" +
    "вом столбце.\r\n";
            // 
            // groupBoxResult_DSN
            // 
            this.groupBoxResult_DSN.Controls.Add(this.dataGridViewMatrixNew_DSN);
            this.groupBoxResult_DSN.Location = new System.Drawing.Point(536, 13);
            this.groupBoxResult_DSN.Name = "groupBoxResult_DSN";
            this.groupBoxResult_DSN.Size = new System.Drawing.Size(262, 190);
            this.groupBoxResult_DSN.TabIndex = 1;
            this.groupBoxResult_DSN.TabStop = false;
            this.groupBoxResult_DSN.Text = "Вывод данных";
            // 
            // dataGridViewMatrixNew_DSN
            // 
            this.dataGridViewMatrixNew_DSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixNew_DSN.ColumnHeadersVisible = false;
            this.dataGridViewMatrixNew_DSN.Location = new System.Drawing.Point(6, 24);
            this.dataGridViewMatrixNew_DSN.Name = "dataGridViewMatrixNew_DSN";
            this.dataGridViewMatrixNew_DSN.ReadOnly = true;
            this.dataGridViewMatrixNew_DSN.RowHeadersVisible = false;
            this.dataGridViewMatrixNew_DSN.Size = new System.Drawing.Size(240, 160);
            this.dataGridViewMatrixNew_DSN.TabIndex = 0;
            // 
            // buttonSpravka_DSN
            // 
            this.buttonSpravka_DSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpravka_DSN.Location = new System.Drawing.Point(542, 295);
            this.buttonSpravka_DSN.Name = "buttonSpravka_DSN";
            this.buttonSpravka_DSN.Size = new System.Drawing.Size(41, 37);
            this.buttonSpravka_DSN.TabIndex = 2;
            this.buttonSpravka_DSN.Text = "?";
            this.buttonSpravka_DSN.UseVisualStyleBackColor = true;
            this.buttonSpravka_DSN.Click += new System.EventHandler(this.buttonSpravka_DSN_Click);
            // 
            // buttonClick_DSN
            // 
            this.buttonClick_DSN.Location = new System.Drawing.Point(711, 295);
            this.buttonClick_DSN.Name = "buttonClick_DSN";
            this.buttonClick_DSN.Size = new System.Drawing.Size(87, 37);
            this.buttonClick_DSN.TabIndex = 3;
            this.buttonClick_DSN.Text = "Выполнить";
            this.buttonClick_DSN.UseVisualStyleBackColor = true;
            this.buttonClick_DSN.Click += new System.EventHandler(this.buttonClick_DSN_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 338);
            this.Controls.Add(this.buttonClick_DSN);
            this.Controls.Add(this.buttonSpravka_DSN);
            this.Controls.Add(this.groupBoxResult_DSN);
            this.Controls.Add(this.groupBoxTask_DSN);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 1 | Дубровин С.Н";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_DSN.ResumeLayout(false);
            this.groupBoxTask_DSN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatixTask_DSN)).EndInit();
            this.groupBoxResult_DSN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixNew_DSN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DSN;
        private System.Windows.Forms.TextBox textBoxСondition_DSN;
        private System.Windows.Forms.DataGridView dataGridViewMatixTask_DSN;
        private System.Windows.Forms.GroupBox groupBoxResult_DSN;
        private System.Windows.Forms.DataGridView dataGridViewMatrixNew_DSN;
        private System.Windows.Forms.Button buttonSpravka_DSN;
        private System.Windows.Forms.Button buttonClick_DSN;
    }
}

