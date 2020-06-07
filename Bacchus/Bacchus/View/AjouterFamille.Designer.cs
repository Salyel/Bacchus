namespace Bacchus.View
{
    partial class AjouterFamille
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFamille
            // 
            this.LabelFamille.Location = new System.Drawing.Point(13, 13);
            this.LabelFamille.Name = "LabelFamille";
            this.LabelFamille.Size = new System.Drawing.Size(183, 23);
            this.LabelFamille.TabIndex = 0;
            this.LabelFamille.Text = "Nom de la famille";
            this.LabelFamille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(13, 40);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(183, 20);
            this.TextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(13, 76);
            this.AddButton.Name = "button1";
            this.AddButton.Size = new System.Drawing.Size(183, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Ajouter";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AjouterFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 111);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.LabelFamille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AjouterFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une famille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFamille;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button AddButton;
    }
}