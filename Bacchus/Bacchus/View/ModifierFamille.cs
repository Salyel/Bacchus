using Bacchus.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.View
{
    /// <summary>
    /// Classe gérant la vue permettant de modifier une famille
    /// </summary>
    public partial class ModifierFamille : Form
    {
        private FormMain Form;
        private String PathBdd;
        private String AncienNom;

        /// <summary>
        /// Constructeur de la form ModifierFamille
        /// </summary>
        public ModifierFamille(FormMain Form, String PathToSave)
        {
            this.Form = Form;
            PathBdd = PathToSave;

            InitializeComponent();
            this.TextBox.Text = Form.GetListView().SelectedItems[0].Text;
            AncienNom = Form.GetListView().SelectedItems[0].Text;

        }

        /// <summary>
        /// Lorsqu'on clique sur le bouton, on récupère la valeur stockée dans la TextBox.
        /// </summary>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            ModifyButtonController Controller = new ModifyButtonController(PathBdd, this, "Familles");
            this.Close();
        }

        /// <summary>
        /// Renvoie la FormMain
        /// </summary>
        public FormMain GetFormMain()
        {
            return Form;
        }

        /// <summary>
        /// Renvoie l'ancien nom de la famille
        /// </summary>
        public String GetAncienNom()
        {
            return AncienNom;
        }

        /// <summary>
        /// Renvoie la TextBox contenue dans la fenêtre
        /// </summary>
        public TextBox GetTextBox()
        {
            return TextBox;
        }
    }
}
