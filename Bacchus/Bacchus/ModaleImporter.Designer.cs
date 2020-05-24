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
            this.label1 = new System.Windows.Forms.Label();
            this.CrushRadioButton = new System.Windows.Forms.RadioButton();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(12, 12);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(191, 31);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "Sélectionner un fichier .csv";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisissez un mode d\'intégration :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CrushRadioButton
            // 
            this.CrushRadioButton.AutoSize = true;
            this.CrushRadioButton.Location = new System.Drawing.Point(12, 167);
            this.CrushRadioButton.Name = "CrushRadioButton";
            this.CrushRadioButton.Size = new System.Drawing.Size(103, 21);
            this.CrushRadioButton.TabIndex = 2;
            this.CrushRadioButton.TabStop = true;
            this.CrushRadioButton.Text = "écrasement";
            this.CrushRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Location = new System.Drawing.Point(12, 213);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(60, 21);
            this.AddRadioButton.TabIndex = 3;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "ajout";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 296);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(464, 34);
            this.ProgressBar.TabIndex = 4;
            // 
            // ModaleImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 342);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.AddRadioButton);
            this.Controls.Add(this.CrushRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModaleImporter";
            this.Text = "ModaleImporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton CrushRadioButton;
        private System.Windows.Forms.RadioButton AddRadioButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}