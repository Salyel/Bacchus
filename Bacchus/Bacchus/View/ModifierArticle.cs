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
    /// Classe gérant la vue permettant de modifier un article
    /// </summary>
    public partial class ModifierArticle : Form
    {
        private FormMain Form;
        private String PathBdd;
        private String AncienNom;

        /// <summary>
        /// Constructeur de la form ModifierArticle
        /// </summary>
        public ModifierArticle(FormMain Form, String PathToSave)
        {
            this.Form = Form;
            PathBdd = PathToSave;

            InitializeComponent();

            Articles Ar = (Articles)Form.GetListView().SelectedItems[0].Tag;

            this.TextBoxDescription.Text = Ar.GetDescription();
            AncienNom = Ar.GetDescription();

            SousFamillesDAO SousFamillesD = new SousFamillesDAO(PathBdd);
            List<SousFamilles> SousFamillesList = SousFamillesD.GetAllSousFamilles();

            //implémentation des combobox
            String SF = Form.GetListView().SelectedItems[0].SubItems[3].Text;
            foreach (SousFamilles Sf in SousFamillesList)
            {
                ComboBoxSousFamille.Items.Add(Sf);
                if (SF.Equals(Sf.GetNom()))
                {
                    ComboBoxSousFamille.SelectedItem = ComboBoxSousFamille.Items[ComboBoxSousFamille.Items.IndexOf(Sf)];
                }
            }

            MarquesDAO MarquesD = new MarquesDAO(PathBdd);
            List<Marques> MarquesList = MarquesD.GetAllMarques();

            String M = Form.GetListView().SelectedItems[0].SubItems[4].Text;
            foreach (Marques Mar in MarquesList)
            {
                ComboBoxMarque.Items.Add(Mar);
                if (M.Equals(Mar.GetNom()))
                {
                    ComboBoxMarque.SelectedItem = ComboBoxMarque.Items[ComboBoxMarque.Items.IndexOf(Mar)];
                }
            }

            NumericUpDown.Value = Ar.GetQuantite();
        }

        /// <summary>
        /// Lorsqu'on clique sur le bouton, on récupère la valeur stockée dans la TextBox.
        /// </summary>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            ModifyButtonController Controller = new ModifyButtonController(PathBdd, this, "Articles");
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
        /// Renvoie l'ancienne description de l'article
        /// </summary>
        public String GetAncienNom()
        {
            return AncienNom;
        }

        /// <summary>
        /// Renvoie la TextBox de la description contenue dans la fenêtre
        /// </summary>
        public TextBox GetTextBox()
        {
            return TextBoxDescription;
        }

        /// <summary>
        /// Renvoie le NumericUpDown contenu dans la fenêtre
        /// </summary>
        public NumericUpDown GetNumericUpDown()
        {
            return NumericUpDown;
        }

        /// <summary>
        /// Renvoie la ComboBox des sous familles contenue dans la fenêtre
        /// </summary>
        public ComboBox GetComboBoxSousFamille()
        {
            return ComboBoxSousFamille;
        }

        /// <summary>
        /// Renvoie la ComboBox des marques contenue dans la fenêtre
        /// </summary>
        public ComboBox GetComboBoxMarque()
        {
            return ComboBoxMarque;
        }
    }
}
