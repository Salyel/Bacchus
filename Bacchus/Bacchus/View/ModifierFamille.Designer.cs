namespace Bacchus.View
{
    partial class ModifierFamille
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
            this.ModifyButton = new System.Windows.Forms.Button();
            this.LabelFamille = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(13, 75);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(203, 23);
            this.ModifyButton.TabIndex = 0;
            this.ModifyButton.Text = "Modifier";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // LabelFamille
            // 
            this.LabelFamille.Location = new System.Drawing.Point(10, 9);
            this.LabelFamille.Name = "LabelFamille";
            this.LabelFamille.Size = new System.Drawing.Size(203, 23);
            this.LabelFamille.TabIndex = 1;
            this.LabelFamille.Text = "Nouveau nom de la famille";
            this.LabelFamille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(10, 35);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(203, 20);
            this.TextBox.TabIndex = 2;
            // 
            // ModifierFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 110);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.LabelFamille);
            this.Controls.Add(this.ModifyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier une famille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Label LabelFamille;
        private System.Windows.Forms.TextBox TextBox;
    }
}