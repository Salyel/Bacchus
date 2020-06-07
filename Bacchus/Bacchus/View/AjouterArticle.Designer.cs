namespace Bacchus.View
{
    partial class AjouterArticle
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
            this.LabelDescription = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.LabelSousFamille = new System.Windows.Forms.Label();
            this.ComboBoxSousFamille = new System.Windows.Forms.ComboBox();
            this.LabelMarque = new System.Windows.Forms.Label();
            this.ComboBoxMarque = new System.Windows.Forms.ComboBox();
            this.LabelQuantite = new System.Windows.Forms.Label();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.LabelPrix = new System.Windows.Forms.Label();
            this.NumericUpDownPrix = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDescription
            // 
            this.LabelDescription.Location = new System.Drawing.Point(13, 13);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(203, 23);
            this.LabelDescription.TabIndex = 0;
            this.LabelDescription.Text = "Description de l\'article";
            this.LabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(13, 40);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(203, 68);
            this.TextBox.TabIndex = 1;
            // 
            // LabelSousFamille
            // 
            this.LabelSousFamille.Location = new System.Drawing.Point(13, 125);
            this.LabelSousFamille.Name = "LabelSousFamille";
            this.LabelSousFamille.Size = new System.Drawing.Size(203, 23);
            this.LabelSousFamille.TabIndex = 2;
            this.LabelSousFamille.Text = "Sous famille de l\'article";
            this.LabelSousFamille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxSousFamille
            // 
            this.ComboBoxSousFamille.FormattingEnabled = true;
            this.ComboBoxSousFamille.Location = new System.Drawing.Point(13, 152);
            this.ComboBoxSousFamille.Name = "ComboBoxSousFamille";
            this.ComboBoxSousFamille.Size = new System.Drawing.Size(203, 21);
            this.ComboBoxSousFamille.TabIndex = 3;
            // 
            // LabelMarque
            // 
            this.LabelMarque.Location = new System.Drawing.Point(13, 190);
            this.LabelMarque.Name = "LabelMarque";
            this.LabelMarque.Size = new System.Drawing.Size(203, 23);
            this.LabelMarque.TabIndex = 4;
            this.LabelMarque.Text = "Marque de l\'article";
            this.LabelMarque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxMarque
            // 
            this.ComboBoxMarque.FormattingEnabled = true;
            this.ComboBoxMarque.Location = new System.Drawing.Point(13, 217);
            this.ComboBoxMarque.Name = "ComboBoxMarque";
            this.ComboBoxMarque.Size = new System.Drawing.Size(203, 21);
            this.ComboBoxMarque.TabIndex = 5;
            // 
            // LabelQuantite
            // 
            this.LabelQuantite.Location = new System.Drawing.Point(13, 316);
            this.LabelQuantite.Name = "LabelQuantite";
            this.LabelQuantite.Size = new System.Drawing.Size(203, 23);
            this.LabelQuantite.TabIndex = 6;
            this.LabelQuantite.Text = "Quantité de l\'article";
            this.LabelQuantite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(13, 343);
            this.NumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(203, 20);
            this.NumericUpDown.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(13, 386);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(203, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Ajouter";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LabelPrix
            // 
            this.LabelPrix.Location = new System.Drawing.Point(13, 255);
            this.LabelPrix.Name = "LabelPrix";
            this.LabelPrix.Size = new System.Drawing.Size(203, 23);
            this.LabelPrix.TabIndex = 9;
            this.LabelPrix.Text = "Prix de l\'article";
            this.LabelPrix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericUpDownPrix
            // 
            this.NumericUpDownPrix.Location = new System.Drawing.Point(16, 278);
            this.NumericUpDownPrix.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDownPrix.Name = "NumericUpDownPrix";
            this.NumericUpDownPrix.Size = new System.Drawing.Size(200, 20);
            this.NumericUpDownPrix.TabIndex = 10;
            // 
            // AjouterArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 423);
            this.Controls.Add(this.NumericUpDownPrix);
            this.Controls.Add(this.LabelPrix);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NumericUpDown);
            this.Controls.Add(this.LabelQuantite);
            this.Controls.Add(this.ComboBoxMarque);
            this.Controls.Add(this.LabelMarque);
            this.Controls.Add(this.ComboBoxSousFamille);
            this.Controls.Add(this.LabelSousFamille);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.LabelDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AjouterArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un article";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label LabelSousFamille;
        private System.Windows.Forms.ComboBox ComboBoxSousFamille;
        private System.Windows.Forms.Label LabelMarque;
        private System.Windows.Forms.ComboBox ComboBoxMarque;
        private System.Windows.Forms.Label LabelQuantite;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label LabelPrix;
        private System.Windows.Forms.NumericUpDown NumericUpDownPrix;
    }
}