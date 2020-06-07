namespace Bacchus.View
{
    partial class AjouterMarque
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
            this.LabelMarque = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelMarque
            // 
            this.LabelMarque.Location = new System.Drawing.Point(12, 9);
            this.LabelMarque.Name = "LabelMarque";
            this.LabelMarque.Size = new System.Drawing.Size(204, 23);
            this.LabelMarque.TabIndex = 0;
            this.LabelMarque.Text = "Nom de la marque";
            this.LabelMarque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(13, 36);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(203, 20);
            this.TextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(13, 76);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(203, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Ajouter";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AjouterMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 111);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.LabelMarque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AjouterMarque";
            this.Text = "Ajouter une marque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMarque;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button AddButton;
    }
}