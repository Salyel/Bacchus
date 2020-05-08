namespace Bacchus
{
    partial class FormImporter
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
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonInteEcraser = new System.Windows.Forms.Button();
            this.buttonInteAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(12, 12);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(194, 30);
            this.buttonSelectFile.TabIndex = 0;
            this.buttonSelectFile.Text = "Sélectionner un fichier .csv";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // buttonInteEcraser
            // 
            this.buttonInteEcraser.Location = new System.Drawing.Point(12, 127);
            this.buttonInteEcraser.Name = "buttonInteEcraser";
            this.buttonInteEcraser.Size = new System.Drawing.Size(284, 30);
            this.buttonInteEcraser.TabIndex = 1;
            this.buttonInteEcraser.Text = "Lancer l\'intégration (mode écrasement)";
            this.buttonInteEcraser.UseVisualStyleBackColor = true;
            this.buttonInteEcraser.Click += new System.EventHandler(this.buttonInteEcraser_Click);
            // 
            // buttonInteAdd
            // 
            this.buttonInteAdd.Location = new System.Drawing.Point(12, 177);
            this.buttonInteAdd.Name = "buttonInteAdd";
            this.buttonInteAdd.Size = new System.Drawing.Size(284, 30);
            this.buttonInteAdd.TabIndex = 2;
            this.buttonInteAdd.Text = "Lancer l\'intégration (mode ajout)";
            this.buttonInteAdd.UseVisualStyleBackColor = true;
            // 
            // FormImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.buttonInteAdd);
            this.Controls.Add(this.buttonInteEcraser);
            this.Controls.Add(this.buttonSelectFile);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FormImporter";
            this.Text = "Importer une base de données";
            this.Load += new System.EventHandler(this.FormImporter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Button buttonInteEcraser;
        private System.Windows.Forms.Button buttonInteAdd;
    }
}