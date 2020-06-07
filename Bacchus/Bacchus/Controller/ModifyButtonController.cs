using Bacchus.DAO;
using Bacchus.Model;
using Bacchus.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.Controller
{
    class ModifyButtonController
    {
        /// <summary>
        /// Constructeur du bouton modifier des fenêtres de modification. Le String TypeModifier permet d'effectuer un traitement différent en fonction du type d'objet à modifier
        /// </summary>
        /// <param name="PathBdd"> Le chemin vers la base de données </param>
        /// <param name="ModifierForm"> Le formulaire de modification </param>
        /// <param name="TypeModifier"> Le String qui permet de déterminer quelles opérations faire </param>
        public ModifyButtonController(String PathBdd, Form ModifierForm, String TypeModifier)
        {
            if (TypeModifier.Equals("Marques"))
            {
                ModifierMarque Form = (ModifierMarque)ModifierForm;

                MarquesDAO MarquesD = new MarquesDAO(PathBdd);
                Form.GetFormMain().GetListView().SelectedItems[0].Text = Form.GetTextBox().Text;
                String NouveauNom = Form.GetTextBox().Text;
                MarquesD.ModifierNomMarques(Form.GetAncienNom(), NouveauNom);

                InitializeTreeView TreeViewInit = new InitializeTreeView(Form.GetFormMain().GetTreeView());
                TreeViewInit.ConstructTree(PathBdd);
            }

            if (TypeModifier.Equals("Familles"))
            {
                ModifierFamille Form = (ModifierFamille)ModifierForm;

                FamillesDAO FamillesD = new FamillesDAO(PathBdd);
                Form.GetFormMain().GetListView().SelectedItems[0].Text = Form.GetTextBox().Text;
                String NouveauNom = Form.GetTextBox().Text;
                FamillesD.ModifierNomFamilles(Form.GetAncienNom(), NouveauNom);

                InitializeTreeView TreeViewInit = new InitializeTreeView(Form.GetFormMain().GetTreeView());
                TreeViewInit.ConstructTree(PathBdd);
            }

            if (TypeModifier.Equals("SousFamilles"))
            {
                ModifierSousFamille Form = (ModifierSousFamille)ModifierForm;

                SousFamillesDAO SousFamillesD = new SousFamillesDAO(PathBdd);

                Form.GetFormMain().GetListView().SelectedItems[0].Text = Form.GetTextBox().Text;

                String NouveauNom = Form.GetTextBox().Text;
                SousFamillesD.ModifierSousFamilles(Form.GetAncienNom(), NouveauNom, (Familles)Form.GetComboBox().SelectedItem);

                ListViewController Controller = new ListViewController(Form.GetFormMain().GetListView(), PathBdd);
                Controller.LoadListView(Form.GetFormMain().GetTreeView().SelectedNode);

                InitializeTreeView TreeViewInit = new InitializeTreeView(Form.GetFormMain().GetTreeView());
                TreeViewInit.ConstructTree(PathBdd);
            }

            if (TypeModifier.Equals("Articles"))
            {
                ModifierArticle Form = (ModifierArticle)ModifierForm;

                ArticlesDAO ArticlesD = new ArticlesDAO(PathBdd);
                SousFamillesDAO SousFamillesD = new SousFamillesDAO(PathBdd);
                String Famille = SousFamillesD.GetFamilleNameBySousFamilleRef(((SousFamilles)Form.GetComboBoxSousFamille().SelectedItem).GetRefSousFamille());

                Form.GetFormMain().GetListView().SelectedItems[0].SubItems[1].Text = Form.GetTextBox().Text;
                Form.GetFormMain().GetListView().SelectedItems[0].SubItems[2].Text = Famille;
                Form.GetFormMain().GetListView().SelectedItems[0].SubItems[3].Text = Form.GetComboBoxSousFamille().SelectedItem.ToString();
                Form.GetFormMain().GetListView().SelectedItems[0].SubItems[4].Text = Form.GetComboBoxMarque().SelectedItem.ToString();
                Form.GetFormMain().GetListView().SelectedItems[0].SubItems[5].Text = Form.GetNumericUpDown().Value.ToString();

                String NouveauNom = Form.GetTextBox().Text;
                ArticlesD.ModifierArticle(Form.GetAncienNom(), NouveauNom, (SousFamilles)Form.GetComboBoxSousFamille().SelectedItem, (Marques)Form.GetComboBoxMarque().SelectedItem, (int)Form.GetNumericUpDown().Value);

                ListViewController Controller = new ListViewController(Form.GetFormMain().GetListView(), PathBdd);
                Controller.LoadListView(Form.GetFormMain().GetTreeView().SelectedNode);

                InitializeTreeView TreeViewInit = new InitializeTreeView(Form.GetFormMain().GetTreeView());
                TreeViewInit.ConstructTree(PathBdd);

             
            }
        }
    }
}
