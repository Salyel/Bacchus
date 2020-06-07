namespace Bacchus.View
{
    partial class ModifierArticle
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
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.LabelSousFamille = new System.Windows.Forms.Label();
            this.ComboBoxSousFamille = new System.Windows.Forms.ComboBox();
            this.LabelMarque = new System.Windows.Forms.Label();
            this.ComboBoxMarque = new System.Windows.Forms.ComboBox();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LabelQuantite = new System.Windows.Forms.Label();
            this.ModifyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDescription
            // 
            this.LabelDescription.Location = new System.Drawing.Point(13, 9);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(203, 27);
            this.LabelDescription.TabIndex = 0;
            this.LabelDescription.Text = "Nouvelle description de l\'article";
            this.LabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(13, 40);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(203, 79);
            this.TextBoxDescription.TabIndex = 1;
            // 
            // LabelSousFamille
            // 
            this.LabelSousFamille.Location = new System.Drawing.Point(13, 135);
            this.LabelSousFamille.Name = "LabelSousFamille";
            this.LabelSousFamille.Size = new System.Drawing.Size(203, 23);
            this.LabelSousFamille.TabIndex = 2;
            this.LabelSousFamille.Text = "Nouvelle sous famille de l\'article";
            this.LabelSousFamille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxSousFamille
            // 
            this.ComboBoxSousFamille.FormattingEnabled = true;
            this.ComboBoxSousFamille.Location = new System.Drawing.Point(13, 162);
            this.ComboBoxSousFamille.Name = "ComboBoxSousFamille";
            this.ComboBoxSousFamille.Size = new System.Drawing.Size(203, 21);
            this.ComboBoxSousFamille.TabIndex = 3;
            // 
            // LabelMarque
            // 
            this.LabelMarque.Location = new System.Drawing.Point(13, 199);
            this.LabelMarque.Name = "LabelMarque";
            this.LabelMarque.Size = new System.Drawing.Size(203, 23);
            this.LabelMarque.TabIndex = 4;
            this.LabelMarque.Text = "Nouvelle marque de l\'article";
            this.LabelMarque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxMarque
            // 
            this.ComboBoxMarque.FormattingEnabled = true;
            this.ComboBoxMarque.Location = new System.Drawing.Point(13, 226);
            this.ComboBoxMarque.Name = "ComboBoxMarque";
            this.ComboBoxMarque.Size = new System.Drawing.Size(203, 21);
            this.ComboBoxMarque.TabIndex = 5;
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(12, 285);
            this.NumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(204, 20);
            this.NumericUpDown.TabIndex = 6;
            // 
            // LabelQuantite
            // 
            this.LabelQuantite.Location = new System.Drawing.Point(9, 259);
            this.LabelQuantite.Name = "LabelQuantite";
            this.LabelQuantite.Size = new System.Drawing.Size(207, 23);
            this.LabelQuantite.TabIndex = 7;
            this.LabelQuantite.Text = "Nouvelle quantité de l\'article";
            this.LabelQuantite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(12, 326);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(204, 23);
            this.ModifyButton.TabIndex = 8;
            this.ModifyButton.Text = "Modifier";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // ModifierArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 361);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.LabelQuantite);
            this.Controls.Add(this.NumericUpDown);
            this.Controls.Add(this.ComboBoxMarque);
            this.Controls.Add(this.LabelMarque);
            this.Controls.Add(this.ComboBoxSousFamille);
            this.Controls.Add(this.LabelSousFamille);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.LabelDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier un article";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Label LabelSousFamille;
        private System.Windows.Forms.ComboBox ComboBoxSousFamille;
        private System.Windows.Forms.Label LabelMarque;
        private System.Windows.Forms.ComboBox ComboBoxMarque;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
        private System.Windows.Forms.Label LabelQuantite;
        private System.Windows.Forms.Button ModifyButton;
    }
}