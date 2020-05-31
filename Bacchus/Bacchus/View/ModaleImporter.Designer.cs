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
            this.LabelImport = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            this.SQLButton = new System.Windows.Forms.Button();
            this.LabelSQL = new System.Windows.Forms.Label();
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
            this.LabelIntegration.Location = new System.Drawing.Point(7, 192);
            this.LabelIntegration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelIntegration.Name = "LabelIntegration";
            this.LabelIntegration.Size = new System.Drawing.Size(166, 13);
            this.LabelIntegration.TabIndex = 1;
            this.LabelIntegration.Text = "Choisissez un mode d\'intégration :";
            // 
            // CrushRadioButton
            // 
            this.CrushRadioButton.AutoSize = true;
            this.CrushRadioButton.Location = new System.Drawing.Point(9, 229);
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
            this.AddRadioButton.Location = new System.Drawing.Point(9, 266);
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
            this.ProgressBar.Location = new System.Drawing.Point(9, 380);
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
            this.LabelFileName.Text = "Pas de fichier selectionné";
            this.LabelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelImport
            // 
            this.LabelImport.Location = new System.Drawing.Point(91, 344);
            this.LabelImport.Name = "LabelImport";
            this.LabelImport.Size = new System.Drawing.Size(181, 34);
            this.LabelImport.TabIndex = 6;
            this.LabelImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(94, 318);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(178, 23);
            this.ImportButton.TabIndex = 7;
            this.ImportButton.Text = "IMPORTER";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // SQLButton
            // 
            this.SQLButton.Location = new System.Drawing.Point(9, 105);
            this.SQLButton.Name = "SQLButton";
            this.SQLButton.Size = new System.Drawing.Size(348, 23);
            this.SQLButton.TabIndex = 8;
            this.SQLButton.Text = "Selectionner le fichier .sqlite dans lequel importer le .csv";
            this.SQLButton.UseVisualStyleBackColor = true;
            this.SQLButton.Click += new System.EventHandler(this.SQLButton_Click);
            // 
            // LabelSQL
            // 
            this.LabelSQL.Location = new System.Drawing.Point(9, 135);
            this.LabelSQL.Name = "LabelSQL";
            this.LabelSQL.Size = new System.Drawing.Size(348, 57);
            this.LabelSQL.TabIndex = 9;
            this.LabelSQL.Text = "Pas de fichier selectionné";
            this.LabelSQL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModaleImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 419);
            this.Controls.Add(this.LabelSQL);
            this.Controls.Add(this.SQLButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.LabelImport);
            this.Controls.Add(this.LabelFileName);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.AddRadioButton);
            this.Controls.Add(this.CrushRadioButton);
            this.Controls.Add(this.LabelIntegration);
            this.Controls.Add(this.SelectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModaleImporter";
            this.Text = "Importer";
            this.Load += new System.EventHandler(this.ModaleImporter_Load);
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
        private System.Windows.Forms.Label LabelImport;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button SQLButton;
        private System.Windows.Forms.Label LabelSQL;
    }
}