
namespace Tyuiu.DubrovinSN.Sprint6.Task6.V13
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
            this.pictureBoxAvatar_DSN = new System.Windows.Forms.PictureBox();
            this.labelInfo_DSN = new System.Windows.Forms.Label();
            this.buttonOk_DSN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_DSN)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_DSN
            // 
            this.pictureBoxAvatar_DSN.Image = global::Tyuiu.DubrovinSN.Sprint6.Task6.V13.Properties.Resources.fyl26wep3gY;
            this.pictureBoxAvatar_DSN.Location = new System.Drawing.Point(12, 11);
            this.pictureBoxAvatar_DSN.Name = "pictureBoxAvatar_DSN";
            this.pictureBoxAvatar_DSN.Size = new System.Drawing.Size(276, 287);
            this.pictureBoxAvatar_DSN.TabIndex = 0;
            this.pictureBoxAvatar_DSN.TabStop = false;
            // 
            // labelInfo_DSN
            // 
            this.labelInfo_DSN.AutoSize = true;
            this.labelInfo_DSN.Location = new System.Drawing.Point(308, 11);
            this.labelInfo_DSN.Name = "labelInfo_DSN";
            this.labelInfo_DSN.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_DSN.TabIndex = 1;
            this.labelInfo_DSN.Text = resources.GetString("labelInfo_DSN.Text");
            // 
            // buttonOk_DSN
            // 
            this.buttonOk_DSN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOk_DSN.Location = new System.Drawing.Point(627, 275);
            this.buttonOk_DSN.Name = "buttonOk_DSN";
            this.buttonOk_DSN.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_DSN.TabIndex = 2;
            this.buttonOk_DSN.Text = "Ok";
            this.buttonOk_DSN.UseVisualStyleBackColor = true;
            this.buttonOk_DSN.Click += new System.EventHandler(this.buttonOk_DSN_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 310);
            this.Controls.Add(this.buttonOk_DSN);
            this.Controls.Add(this.labelInfo_DSN);
            this.Controls.Add(this.pictureBoxAvatar_DSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_DSN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_DSN;
        private System.Windows.Forms.Label labelInfo_DSN;
        private System.Windows.Forms.Button buttonOk_DSN;
    }
}