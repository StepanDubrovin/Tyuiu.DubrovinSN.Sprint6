
namespace Tyuiu.DubrovinSN.Sprint6.Task7.V18
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelUp_DSN = new System.Windows.Forms.Panel();
            this.buttonSaveFile_DSN = new System.Windows.Forms.Button();
            this.buttonSpravka_DSN = new System.Windows.Forms.Button();
            this.buttonDoneClick_DSN = new System.Windows.Forms.Button();
            this.buttonOpenFile_DSN = new System.Windows.Forms.Button();
            this.panelUpTwo_DSN = new System.Windows.Forms.Panel();
            this.groupBoxCondition_DSN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DSN = new System.Windows.Forms.TextBox();
            this.panelLeft_DSN = new System.Windows.Forms.Panel();
            this.groupBoxInput_DSN = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix_DSN = new System.Windows.Forms.DataGridView();
            this.panelMiddle_DSN = new System.Windows.Forms.Panel();
            this.groupBoxOutput_DSN = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutMatrix_DSN = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_DSN = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.splitter_DSN = new System.Windows.Forms.Splitter();
            this.panelUp_DSN.SuspendLayout();
            this.panelUpTwo_DSN.SuspendLayout();
            this.groupBoxCondition_DSN.SuspendLayout();
            this.panelLeft_DSN.SuspendLayout();
            this.groupBoxInput_DSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_DSN)).BeginInit();
            this.panelMiddle_DSN.SuspendLayout();
            this.groupBoxOutput_DSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_DSN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_DSN
            // 
            this.panelUp_DSN.BackColor = System.Drawing.SystemColors.Control;
            this.panelUp_DSN.Controls.Add(this.buttonSaveFile_DSN);
            this.panelUp_DSN.Controls.Add(this.buttonSpravka_DSN);
            this.panelUp_DSN.Controls.Add(this.buttonDoneClick_DSN);
            this.panelUp_DSN.Controls.Add(this.buttonOpenFile_DSN);
            this.panelUp_DSN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_DSN.Location = new System.Drawing.Point(0, 0);
            this.panelUp_DSN.Name = "panelUp_DSN";
            this.panelUp_DSN.Size = new System.Drawing.Size(1172, 70);
            this.panelUp_DSN.TabIndex = 0;
            // 
            // buttonSaveFile_DSN
            // 
            this.buttonSaveFile_DSN.Image = global::Tyuiu.DubrovinSN.Sprint6.Task7.V18.Properties.Resources.page_save;
            this.buttonSaveFile_DSN.Location = new System.Drawing.Point(157, 6);
            this.buttonSaveFile_DSN.Name = "buttonSaveFile_DSN";
            this.buttonSaveFile_DSN.Size = new System.Drawing.Size(71, 58);
            this.buttonSaveFile_DSN.TabIndex = 3;
            this.toolTipButton.SetToolTip(this.buttonSaveFile_DSN, "Сохраняет полученную матрицу");
            this.buttonSaveFile_DSN.UseVisualStyleBackColor = true;
            this.buttonSaveFile_DSN.Click += new System.EventHandler(this.buttonSaveFile_DSN_Click);
            this.buttonSaveFile_DSN.MouseEnter += new System.EventHandler(this.buttonSaveFile_DSN_MouseEnter);
            // 
            // buttonSpravka_DSN
            // 
            this.buttonSpravka_DSN.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSpravka_DSN.Image = global::Tyuiu.DubrovinSN.Sprint6.Task7.V18.Properties.Resources.vopros;
            this.buttonSpravka_DSN.Location = new System.Drawing.Point(1101, 0);
            this.buttonSpravka_DSN.Name = "buttonSpravka_DSN";
            this.buttonSpravka_DSN.Size = new System.Drawing.Size(71, 70);
            this.buttonSpravka_DSN.TabIndex = 2;
            this.toolTipButton.SetToolTip(this.buttonSpravka_DSN, "Информация о программе");
            this.buttonSpravka_DSN.UseVisualStyleBackColor = true;
            this.buttonSpravka_DSN.Click += new System.EventHandler(this.buttonSpravka_DSN_Click);
            this.buttonSpravka_DSN.MouseEnter += new System.EventHandler(this.buttonSpravka_DSN_MouseEnter);
            // 
            // buttonDoneClick_DSN
            // 
            this.buttonDoneClick_DSN.Image = global::Tyuiu.DubrovinSN.Sprint6.Task7.V18.Properties.Resources.page_white_go;
            this.buttonDoneClick_DSN.Location = new System.Drawing.Point(80, 6);
            this.buttonDoneClick_DSN.Name = "buttonDoneClick_DSN";
            this.buttonDoneClick_DSN.Size = new System.Drawing.Size(71, 58);
            this.buttonDoneClick_DSN.TabIndex = 1;
            this.toolTipButton.SetToolTip(this.buttonDoneClick_DSN, "Изменяет в девятом столбце значения не равные 11 на 11");
            this.buttonDoneClick_DSN.UseVisualStyleBackColor = true;
            this.buttonDoneClick_DSN.Click += new System.EventHandler(this.buttonDoneClick_DSN_Click);
            this.buttonDoneClick_DSN.MouseEnter += new System.EventHandler(this.buttonDoneClick_DSN_MouseEnter);
            // 
            // buttonOpenFile_DSN
            // 
            this.buttonOpenFile_DSN.Image = global::Tyuiu.DubrovinSN.Sprint6.Task7.V18.Properties.Resources.folder_page;
            this.buttonOpenFile_DSN.Location = new System.Drawing.Point(3, 6);
            this.buttonOpenFile_DSN.Name = "buttonOpenFile_DSN";
            this.buttonOpenFile_DSN.Size = new System.Drawing.Size(71, 58);
            this.buttonOpenFile_DSN.TabIndex = 0;
            this.toolTipButton.SetToolTip(this.buttonOpenFile_DSN, "Открыть файл\r\nВыберите нужный файл для обработки\r\n\r\n");
            this.buttonOpenFile_DSN.UseVisualStyleBackColor = true;
            this.buttonOpenFile_DSN.Click += new System.EventHandler(this.buttonOpenFile_DSN_Click);
            this.buttonOpenFile_DSN.MouseEnter += new System.EventHandler(this.buttonOpenFile_DSN_MouseEnter);
            // 
            // panelUpTwo_DSN
            // 
            this.panelUpTwo_DSN.Controls.Add(this.groupBoxCondition_DSN);
            this.panelUpTwo_DSN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpTwo_DSN.Location = new System.Drawing.Point(0, 70);
            this.panelUpTwo_DSN.Name = "panelUpTwo_DSN";
            this.panelUpTwo_DSN.Size = new System.Drawing.Size(1172, 100);
            this.panelUpTwo_DSN.TabIndex = 1;
            // 
            // groupBoxCondition_DSN
            // 
            this.groupBoxCondition_DSN.Controls.Add(this.textBoxTask_DSN);
            this.groupBoxCondition_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCondition_DSN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCondition_DSN.Name = "groupBoxCondition_DSN";
            this.groupBoxCondition_DSN.Size = new System.Drawing.Size(1172, 100);
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
            this.textBoxTask_DSN.Size = new System.Drawing.Size(1166, 81);
            this.textBoxTask_DSN.TabIndex = 0;
            this.textBoxTask_DSN.Text = resources.GetString("textBoxTask_DSN.Text");
            // 
            // panelLeft_DSN
            // 
            this.panelLeft_DSN.Controls.Add(this.groupBoxInput_DSN);
            this.panelLeft_DSN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_DSN.Location = new System.Drawing.Point(0, 170);
            this.panelLeft_DSN.Name = "panelLeft_DSN";
            this.panelLeft_DSN.Size = new System.Drawing.Size(559, 445);
            this.panelLeft_DSN.TabIndex = 2;
            // 
            // groupBoxInput_DSN
            // 
            this.groupBoxInput_DSN.Controls.Add(this.dataGridViewInMatrix_DSN);
            this.groupBoxInput_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_DSN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_DSN.Name = "groupBoxInput_DSN";
            this.groupBoxInput_DSN.Size = new System.Drawing.Size(559, 445);
            this.groupBoxInput_DSN.TabIndex = 0;
            this.groupBoxInput_DSN.TabStop = false;
            this.groupBoxInput_DSN.Text = "Ввод данных";
            // 
            // dataGridViewInMatrix_DSN
            // 
            this.dataGridViewInMatrix_DSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_DSN.ColumnHeadersVisible = false;
            this.dataGridViewInMatrix_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatrix_DSN.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInMatrix_DSN.Name = "dataGridViewInMatrix_DSN";
            this.dataGridViewInMatrix_DSN.ReadOnly = true;
            this.dataGridViewInMatrix_DSN.RowHeadersVisible = false;
            this.dataGridViewInMatrix_DSN.Size = new System.Drawing.Size(553, 426);
            this.dataGridViewInMatrix_DSN.TabIndex = 0;
            // 
            // panelMiddle_DSN
            // 
            this.panelMiddle_DSN.Controls.Add(this.groupBoxOutput_DSN);
            this.panelMiddle_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle_DSN.Location = new System.Drawing.Point(562, 170);
            this.panelMiddle_DSN.Name = "panelMiddle_DSN";
            this.panelMiddle_DSN.Size = new System.Drawing.Size(610, 445);
            this.panelMiddle_DSN.TabIndex = 4;
            // 
            // groupBoxOutput_DSN
            // 
            this.groupBoxOutput_DSN.Controls.Add(this.dataGridViewOutMatrix_DSN);
            this.groupBoxOutput_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_DSN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_DSN.Name = "groupBoxOutput_DSN";
            this.groupBoxOutput_DSN.Size = new System.Drawing.Size(610, 445);
            this.groupBoxOutput_DSN.TabIndex = 0;
            this.groupBoxOutput_DSN.TabStop = false;
            this.groupBoxOutput_DSN.Text = "Вывод данных";
            // 
            // dataGridViewOutMatrix_DSN
            // 
            this.dataGridViewOutMatrix_DSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix_DSN.ColumnHeadersVisible = false;
            this.dataGridViewOutMatrix_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutMatrix_DSN.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutMatrix_DSN.Name = "dataGridViewOutMatrix_DSN";
            this.dataGridViewOutMatrix_DSN.ReadOnly = true;
            this.dataGridViewOutMatrix_DSN.RowHeadersVisible = false;
            this.dataGridViewOutMatrix_DSN.Size = new System.Drawing.Size(604, 426);
            this.dataGridViewOutMatrix_DSN.TabIndex = 0;
            // 
            // openFileDialogTask_DSN
            // 
            this.openFileDialogTask_DSN.FileName = "openFileDialogTask_DSN";
            // 
            // toolTipButton
            // 
            this.toolTipButton.IsBalloon = true;
            this.toolTipButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // splitter_DSN
            // 
            this.splitter_DSN.Location = new System.Drawing.Point(559, 170);
            this.splitter_DSN.Name = "splitter_DSN";
            this.splitter_DSN.Size = new System.Drawing.Size(3, 445);
            this.splitter_DSN.TabIndex = 3;
            this.splitter_DSN.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 615);
            this.Controls.Add(this.panelMiddle_DSN);
            this.Controls.Add(this.splitter_DSN);
            this.Controls.Add(this.panelLeft_DSN);
            this.Controls.Add(this.panelUpTwo_DSN);
            this.Controls.Add(this.panelUp_DSN);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 18 | Дубровин С.Н";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelUp_DSN.ResumeLayout(false);
            this.panelUpTwo_DSN.ResumeLayout(false);
            this.groupBoxCondition_DSN.ResumeLayout(false);
            this.groupBoxCondition_DSN.PerformLayout();
            this.panelLeft_DSN.ResumeLayout(false);
            this.groupBoxInput_DSN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_DSN)).EndInit();
            this.panelMiddle_DSN.ResumeLayout(false);
            this.groupBoxOutput_DSN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_DSN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_DSN;
        private System.Windows.Forms.Button buttonSpravka_DSN;
        private System.Windows.Forms.Button buttonDoneClick_DSN;
        private System.Windows.Forms.Button buttonOpenFile_DSN;
        private System.Windows.Forms.Panel panelUpTwo_DSN;
        private System.Windows.Forms.GroupBox groupBoxCondition_DSN;
        private System.Windows.Forms.TextBox textBoxTask_DSN;
        private System.Windows.Forms.Panel panelLeft_DSN;
        private System.Windows.Forms.GroupBox groupBoxInput_DSN;
        private System.Windows.Forms.Panel panelMiddle_DSN;
        private System.Windows.Forms.GroupBox groupBoxOutput_DSN;
        private System.Windows.Forms.Button buttonSaveFile_DSN;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_DSN;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_DSN;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_DSN;
        private System.Windows.Forms.Splitter splitter_DSN;
    }
}

