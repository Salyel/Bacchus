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
    /// <summary>
    /// Classe pour gérer la vue des ajout d'articles
    /// </summary>
    public partial class AjouterArticle : Form
    {
        //Attributs

        private FormMain Form;
        private String PathBdd;

        /// <summary>
        /// Constructeur de la form AjouterArticle
        /// </summary>
        public AjouterArticle(FormMain Form, String PathToSave)
        {
            this.Form = Form;
            PathBdd = PathToSave;

            InitializeComponent();

            SousFamillesDAO SousFamillesD = new SousFamillesDAO(PathBdd);
            List<SousFamilles> SousFamillesList = SousFamillesD.GetAllSousFamilles();

            //remplissage des combobox
            foreach (SousFamilles Sf in SousFamillesList)
            {
                ComboBoxSousFamille.Items.Add(Sf);
                ComboBoxSousFamille.SelectedItem = ComboBoxSousFamille.Items[ComboBoxSousFamille.Items.IndexOf(Sf)];
            }

            MarquesDAO MarquesD = new MarquesDAO(PathBdd);
            List<Marques> MarquesList = MarquesD.GetAllMarques();

            foreach (Marques Mar in MarquesList)
            {
                ComboBoxMarque.Items.Add(Mar);
                ComboBoxMarque.SelectedItem = ComboBoxMarque.Items[ComboBoxMarque.Items.IndexOf(Mar)];
            }
        }

        /// <summary>
        /// Lorsqu'on clique sur le bouton, on récupère la valeur stockée dans la TextBox.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddButtonController Controller = new AddButtonController(PathBdd, this, "Articles");
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
        /// Renvoie la ComboBox de marques contenue dans la fenêtre
        /// </summary>
        public ComboBox GetComboBoxMarque()
        {
            return ComboBoxMarque;
        }

        /// <summary>
        /// Renvoie la ComboBox de sous familles contenue dans la fenêtre
        /// </summary>
        public ComboBox GetComboBoxSousFamille()
        {
            return ComboBoxSousFamille;
        }

        /// <summary>
        /// Renvoie le NumericUpDown de la quantité contenu dans la fenêtre
        /// </summary>
        public NumericUpDown GetNumericUpDown()
        {
            return NumericUpDown;
        }

        /// <summary>
        /// Renvoie le NumericUpDown du prix contenu dans la fenêtre
        /// </summary>
        public NumericUpDown GetNumericUpDownPrix()
        {
            return NumericUpDownPrix;
        }
    }
}
