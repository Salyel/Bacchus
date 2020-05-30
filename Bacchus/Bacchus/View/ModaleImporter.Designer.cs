namespace Bacchus
{
    partial class ModaleImporter
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
            this.SelectButton = new System.Windows.Forms.Button();
            this.LabelIntegration = new System.Windows.Forms.Label();
            this.CrushRadioButton = new System.Windows.Forms.RadioButton();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(9, 11);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(348, 25);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "Sélectionner un fichier .csv à importer";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelIntegration
            // 
            this.LabelIntegration.AutoSize = true;
            this.LabelIntegration.Location = new System.Drawing.Point(7, 99);
            this.LabelIntegration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelIntegration.Name = "LabelIntegration";
            this.LabelIntegration.Size = new System.Drawing.Size(166, 13);
            this.LabelIntegration.TabIndex = 1;
            this.LabelIntegration.Text = "Choisissez un mode d\'intégration :";
            // 
            // CrushRadioButton
            // 
            this.CrushRadioButton.AutoSize = true;
            this.CrushRadioButton.Location = new System.Drawing.Point(9, 136);
            this.CrushRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.CrushRadioButton.Name = "CrushRadioButton";
            this.CrushRadioButton.Size = new System.Drawing.Size(80, 17);
            this.CrushRadioButton.TabIndex = 2;
            this.CrushRadioButton.TabStop = true;
            this.CrushRadioButton.Text = "écrasement";
            this.CrushRadioButton.UseVisualStyleBackColor = true;
            this.CrushRadioButton.CheckedChanged += new System.EventHandler(this.CrushRadioButton_CheckedChanged);
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Location = new System.Drawing.Point(9, 173);
            this.AddRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(48, 17);
            this.AddRadioButton.TabIndex = 3;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "ajout";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            this.AddRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButton_CheckedChanged);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(9, 240);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(348, 28);
            this.ProgressBar.TabIndex = 4;
            // 
            // LabelFileName
            // 
            this.LabelFileName.Location = new System.Drawing.Point(9, 44);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(348, 48);
            this.LabelFileName.TabIndex = 5;
            this.LabelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModaleImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 278);
            this.Controls.Add(this.LabelFileName);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.AddRadioButton);
            this.Controls.Add(this.CrushRadioButton);
            this.Controls.Add(this.LabelIntegration);
            this.Controls.Add(this.SelectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModaleImporter";
            this.Text = "Importer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label LabelIntegration;
        private System.Windows.Forms.RadioButton CrushRadioButton;
        private System.Windows.Forms.RadioButton AddRadioButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label LabelFileName;
    }
}