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
    /// Classe gérant la vue permettant de modifier une sous-famille
    /// </summary>
    public partial class ModifierSousFamille : Form
    {
        //Attributs

        private FormMain Form;
        private String PathBdd;
        private String AncienNom;

        /// <summary>
        /// Constructeur de la form ModifierSousFamille
        /// </summary>
        public ModifierSousFamille(FormMain Form, String PathToSave)
        {
            this.Form = Form;
            PathBdd = PathToSave;

            InitializeComponent();
            this.TextBox.Text = Form.GetListView().SelectedItems[0].Text;
            AncienNom = Form.GetListView().SelectedItems[0].Text;

            FamillesDAO FamillesD = new FamillesDAO(PathBdd);
            List<Familles> FamillesList = FamillesD.GetAllFamilles();

            SousFamilles SF = (SousFamilles)Form.GetListView().SelectedItems[0].Tag;
            //implémentation des combobox
            foreach (Familles f in FamillesList)
            {
                ComboBox.Items.Add(f);
                if (SF.GetRefFamille() == f.GetRefFamille())
                {
                    ComboBox.SelectedItem = ComboBox.Items[ComboBox.Items.IndexOf(f)];
                }
            }
        }

        /// <summary>
        /// Lorsqu'on clique sur le bouton, on récupère les valeur stockées.
        /// </summary>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            ModifyButtonController Controller = new ModifyButtonController(PathBdd, this, "SousFamilles");
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
        /// Renvoie l'ancien nom de la sous famille
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

        /// <summary>
        /// Renvoie la ComboBox contenue dans la fenêtre
        /// </summary>
        public ComboBox GetComboBox()
        {
            return ComboBox;
        }
    }
}
