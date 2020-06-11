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
    /// Classe gérant la vue qui permet d'ajouter une marque
    /// </summary>
    public partial class AjouterMarque : Form
    {
        //Attributs

        private FormMain Form;
        private String PathBdd;

        /// <summary>
        /// Constructeur de la form AjouterMarque
        /// </summary>
        public AjouterMarque(FormMain Form, String PathToSave)
        {
            this.Form = Form;
            PathBdd = PathToSave;

            InitializeComponent();
        }

        /// <summary>
        /// Lorsqu'on clique sur le bouton, on récupère la valeur stockée dans la TextBox.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddButtonController Controller = new AddButtonController(PathBdd, this, "Marques");
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
        /// Renvoie la TextBox contenue dans la fenêtre
        /// </summary>
        public TextBox GetTextBox()
        {
            return TextBox;
        }
    }
}
