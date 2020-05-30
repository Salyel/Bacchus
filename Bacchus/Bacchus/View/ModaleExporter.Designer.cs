namespace Bacchus.View
{
    partial class ModaleExporter
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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Button = new System.Windows.Forms.Button();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.ProgressBar.Location = new System.Drawing.Point(9, 140);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(348, 28);
            this.ProgressBar.TabIndex = 0;
            // 
            // button1
            // 
            this.Button.Location = new System.Drawing.Point(9, 12);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(348, 23);
            this.Button.TabIndex = 1;
            this.Button.Text = "Sélectionner un fichier .sqlite à exporter";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // label1
            // 
            this.LabelFileName.Location = new System.Drawing.Point(9, 51);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(348, 73);
            this.LabelFileName.TabIndex = 2;
            this.LabelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModaleExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 181);
            this.Controls.Add(this.LabelFileName);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.ProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModaleExporter";
            this.RightToLeftLayout = true;
            this.Text = "Exporter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label LabelFileName;
    }
}