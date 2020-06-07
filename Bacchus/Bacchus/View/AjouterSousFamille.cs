using Bacchus.Controller;
using Bacchus.DAO;
using Bacchus.Model;
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
    public partial class AjouterSousFamille : Form
    {
        private FormMain Form;
        private String PathBdd;

        /// <summary>
        /// Constructeur de la form AjouterSousFamille
        /// </summary>
        public AjouterSousFamille(FormMain Form, String PathToSave)
        {
            this.Form = Form;
            PathBdd = PathToSave;

            InitializeComponent();

            FamillesDAO FamillesD = new FamillesDAO(PathBdd);
            List<Familles> FamillesList = FamillesD.GetAllFamilles();

            foreach (Familles f in FamillesList)
            {
                ComboBox.Items.Add(f);
                ComboBox.SelectedItem = ComboBox.Items[ComboBox.Items.IndexOf(f)];
            }
        }

        /// <summary>
        /// Lorsqu'on clique sur le bouton, on récupère la valeur stockée dans la TextBox.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddButtonController Controller = new AddButtonController(PathBdd, this, "SousFamilles");
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

        /// <summary>
        /// Renvoie la ComboBox contenue dans la fenêtre
        /// </summary>
        public ComboBox GetComboBox()
        {
            return ComboBox;
        }
    }
}
