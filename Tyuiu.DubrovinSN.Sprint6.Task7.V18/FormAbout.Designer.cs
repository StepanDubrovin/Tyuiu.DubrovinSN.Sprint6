
namespace Tyuiu.DubrovinSN.Sprint6.Task7.V18
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_DSN = new System.Windows.Forms.Label();
            this.buttonOk_DSN = new System.Windows.Forms.Button();
            this.pictureBox_DSN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DSN)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_DSN
            // 
            this.labelInfo_DSN.AutoSize = true;
            this.labelInfo_DSN.Location = new System.Drawing.Point(342, 29);
            this.labelInfo_DSN.Name = "labelInfo_DSN";
            this.labelInfo_DSN.Size = new System.Drawing.Size(284, 130);
            this.labelInfo_DSN.TabIndex = 0;
            this.labelInfo_DSN.Text = resources.GetString("labelInfo_DSN.Text");
            // 
            // buttonOk_DSN
            // 
            this.buttonOk_DSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk_DSN.Location = new System.Drawing.Point(604, 311);
            this.buttonOk_DSN.Name = "buttonOk_DSN";
            this.buttonOk_DSN.Size = new System.Drawing.Size(57, 35);
            this.buttonOk_DSN.TabIndex = 1;
            this.buttonOk_DSN.Text = "Ок";
            this.buttonOk_DSN.UseVisualStyleBackColor = true;
            this.buttonOk_DSN.Click += new System.EventHandler(this.buttonOk_DSN_Click);
            // 
            // pictureBox_DSN
            // 
            this.pictureBox_DSN.Image = global::Tyuiu.DubrovinSN.Sprint6.Task7.V18.Properties.Resources.fyl26wep3gY;
            this.pictureBox_DSN.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_DSN.Name = "pictureBox_DSN";
            this.pictureBox_DSN.Size = new System.Drawing.Size(295, 288);
            this.pictureBox_DSN.TabIndex = 2;
            this.pictureBox_DSN.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 358);
            this.Controls.Add(this.pictureBox_DSN);
            this.Controls.Add(this.buttonOk_DSN);
            this.Controls.Add(this.labelInfo_DSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DSN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_DSN;
        private System.Windows.Forms.Button buttonOk_DSN;
        private System.Windows.Forms.PictureBox pictureBox_DSN;
    }
}