namespace Bacchus.View
{
    partial class AjouterSousFamille
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
            this.LabelFamille = new System.Windows.Forms.Label();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.LabelSousFamille = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFamille
            // 
            this.LabelFamille.Location = new System.Drawing.Point(13, 13);
            this.LabelFamille.Name = "LabelFamille";
            this.LabelFamille.Size = new System.Drawing.Size(203, 23);
            this.LabelFamille.TabIndex = 0;
            this.LabelFamille.Text = "Famille de la sous famille\r\n";
            this.LabelFamille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(12, 39);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(203, 21);
            this.ComboBox.TabIndex = 1;
            // 
            // LabelSousFamille
            // 
            this.LabelSousFamille.Location = new System.Drawing.Point(9, 74);
            this.LabelSousFamille.Name = "LabelSousFamille";
            this.LabelSousFamille.Size = new System.Drawing.Size(206, 23);
            this.LabelSousFamille.TabIndex = 2;
            this.LabelSousFamille.Text = "Nom de la sous famille";
            this.LabelSousFamille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 101);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(203, 20);
            this.TextBox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 139);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(204, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Ajouter";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AjouterSousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 174);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.LabelSousFamille);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.LabelFamille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AjouterSousFamille";
            this.Text = "Ajouter une sous famille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFamille;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Label LabelSousFamille;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button AddButton;
    }
}