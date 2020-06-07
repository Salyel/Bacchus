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
            this.SQLButton = new System.Windows.Forms.Button();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.CsvButton = new System.Windows.Forms.Button();
            this.LabelCsv = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.LabelExport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(9, 300);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(348, 28);
            this.ProgressBar.TabIndex = 0;
            // 
            // SQLButton
            // 
            this.SQLButton.Location = new System.Drawing.Point(9, 12);
            this.SQLButton.Name = "SQLButton";
            this.SQLButton.Size = new System.Drawing.Size(348, 23);
            this.SQLButton.TabIndex = 1;
            this.SQLButton.Text = "Sélectionner un fichier .sqlite à exporter";
            this.SQLButton.UseVisualStyleBackColor = true;
            this.SQLButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // LabelFileName
            // 
            this.LabelFileName.Location = new System.Drawing.Point(6, 38);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(351, 58);
            this.LabelFileName.TabIndex = 2;
            this.LabelFileName.Text = "Aucun fichier selectionné";
            this.LabelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CsvButton
            // 
            this.CsvButton.Location = new System.Drawing.Point(9, 115);
            this.CsvButton.Name = "CsvButton";
            this.CsvButton.Size = new System.Drawing.Size(348, 23);
            this.CsvButton.TabIndex = 3;
            this.CsvButton.Text = "Sélectionner l\'endroit où le fichier .csv sera sauvegardé";
            this.CsvButton.UseVisualStyleBackColor = true;
            this.CsvButton.Click += new System.EventHandler(this.CsvButton_Click);
            // 
            // LabelCsv
            // 
            this.LabelCsv.Location = new System.Drawing.Point(9, 141);
            this.LabelCsv.Name = "LabelCsv";
            this.LabelCsv.Size = new System.Drawing.Size(348, 71);
            this.LabelCsv.TabIndex = 4;
            this.LabelCsv.Text = "Aucun fichier selectionné";
            this.LabelCsv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(82, 215);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExportButton.Size = new System.Drawing.Size(203, 32);
            this.ExportButton.TabIndex = 5;
            this.ExportButton.Text = "EXPORTER";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // LabelExport
            // 
            this.LabelExport.Location = new System.Drawing.Point(82, 250);
            this.LabelExport.Name = "LabelExport";
            this.LabelExport.Size = new System.Drawing.Size(203, 47);
            this.LabelExport.TabIndex = 6;
            this.LabelExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModaleExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 340);
            this.Controls.Add(this.LabelExport);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.LabelCsv);
            this.Controls.Add(this.CsvButton);
            this.Controls.Add(this.LabelFileName);
            this.Controls.Add(this.SQLButton);
            this.Controls.Add(this.ProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModaleExporter";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exporter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button SQLButton;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.Button CsvButton;
        private System.Windows.Forms.Label LabelCsv;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label LabelExport;
    }
}