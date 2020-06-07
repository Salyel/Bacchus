namespace Bacchus.View
{
    partial class ModifierSousFamille
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
            this.LabelFamilleSF = new System.Windows.Forms.Label();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.LabelNomSF = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFamilleSF
            // 
            this.LabelFamilleSF.Location = new System.Drawing.Point(12, 9);
            this.LabelFamilleSF.Name = "LabelFamilleSF";
            this.LabelFamilleSF.Size = new System.Drawing.Size(204, 23);
            this.LabelFamilleSF.TabIndex = 0;
            this.LabelFamilleSF.Text = "Nouvelle famille de la sous famille";
            this.LabelFamilleSF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(12, 35);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(204, 21);
            this.ComboBox.TabIndex = 1;
            // 
            // LabelNomSF
            // 
            this.LabelNomSF.Location = new System.Drawing.Point(9, 68);
            this.LabelNomSF.Name = "LabelNomSF";
            this.LabelNomSF.Size = new System.Drawing.Size(207, 23);
            this.LabelNomSF.TabIndex = 2;
            this.LabelNomSF.Text = "Nouveau nom de la sous famille";
            this.LabelNomSF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 94);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(204, 20);
            this.TextBox.TabIndex = 3;
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(12, 139);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(204, 23);
            this.ModifyButton.TabIndex = 4;
            this.ModifyButton.Text = "Modifier";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // ModifierSousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 174);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.LabelNomSF);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.LabelFamilleSF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierSousFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier une sous famille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFamilleSF;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Label LabelNomSF;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button ModifyButton;
    }
}