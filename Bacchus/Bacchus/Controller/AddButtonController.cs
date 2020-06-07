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
    class AddButtonController
    {
        /// <summary>
        /// Constructeur du bouton ajouter des fenêtres d'ajout. Le String TypeModifier permet d'effectuer un traitement différent en fonction du type d'objet à ajouter
        /// </summary>
        /// <param name="PathBdd"> Le chemin vers la base de données </param>
        /// <param name="AjouterForm"> Le formulaire d'ajout </param>
        /// <param name="TypeAjouter"> Le String qui permet de déterminer quelles opérations faire </param>
        public AddButtonController(String PathBdd, Form AjouterForm, String TypeAjouter)
        {
            if (TypeAjouter.Equals("Marques"))
            {
                AjouterMarque Form = (AjouterMarque)AjouterForm;

                MarquesDAO MarquesD = new MarquesDAO(PathBdd);
                String NouveauNom = Form.GetTextBox().Text;

                Marques Marque = new Marques(NouveauNom);
                MarquesD.AjouterMarque(Marque);

                InitializeTreeView TreeViewInit = new InitializeTreeView(Form.GetFormMain().GetTreeView());
                TreeViewInit.ConstructTree(PathBdd);

                ListViewController ListViewInit = new ListViewController(Form.GetFormMain().GetListView(), PathBdd);
                ListViewInit.LoadListView(Form.GetFormMain().GetTreeView().SelectedNode);
            }

            if (TypeAjouter.Equals("Familles"))
            {
                AjouterFamille Form = (AjouterFamille)AjouterForm;

                FamillesDAO FamillesD = new FamillesDAO(PathBdd);
                String NouveauNom = Form.GetTextBox().Text;

                Familles Famille = new Familles(NouveauNom);
                FamillesD.AjouterFamille(Famille);

                InitializeTreeView TreeViewInit = new InitializeTreeView(Form.GetFormMain().GetTreeView());
                TreeViewInit.ConstructTree(PathBdd);

                ListViewController ListViewInit = new ListViewController(Form.GetFormMain().GetListView(), PathBdd);
                ListViewInit.LoadListView(Form.GetFormMain().GetTreeView().SelectedNode);
            }

            if (TypeAjouter.Equals("SousFamilles"))
            {
                AjouterSousFamille Form = (AjouterSousFamille)AjouterForm;

                SousFamillesDAO SousFamillesD = new SousFamillesDAO(PathBdd);
                String NouveauNom = Form.GetTextBox().Text;

                SousFamilles SousFamille = new SousFamilles(((Familles)Form.GetComboBox().SelectedItem).GetRefFamille(), NouveauNom);
                SousFamillesD.AjouterSousFamille(SousFamille);

                InitializeTreeView TreeViewInit = new InitializeTreeView(Form.GetFormMain().GetTreeView());
                TreeViewInit.ConstructTree(PathBdd);

                ListViewController ListViewInit = new ListViewController(Form.GetFormMain().GetListView(), PathBdd);
                ListViewInit.LoadListView(Form.GetFormMain().GetTreeView().SelectedNode);
            }

            if (TypeAjouter.Equals("Articles"))
            {
                AjouterArticle Form = (AjouterArticle)AjouterForm;

                ArticlesDAO ArticlesD = new ArticlesDAO(PathBdd);
                SousFamillesDAO SousFamillesD = new SousFamillesDAO(PathBdd);

                Random aleatoire = new Random();
                int Nombre = aleatoire.Next(9999999);
                String RefArticle = "F" + Nombre;
                List<String> Refs = ArticlesD.GetAllArticlesRef();
                while (Refs.Contains(RefArticle))
                {
                    Nombre = aleatoire.Next(9999999);
                    RefArticle = "F" + Nombre;
                }

                String Description = Form.GetTextBox().Text;
                int RefSousFamille = ((SousFamilles)Form.GetComboBoxSousFamille().SelectedItem).GetRefSousFamille();
                int RefMarque = ((Marques)Form.GetComboBoxMarque().SelectedItem).GetRefMarque();
                float PrixHT = (float)Form.GetNumericUpDownPrix().Value;
                int Quantite = (int)Form.GetNumericUpDown().Value;

                Articles Article = new Articles(RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite);

                ArticlesD.AjouterArticle(Article);

                InitializeTreeView TreeViewInit = new InitializeTreeView(Form.GetFormMain().GetTreeView());
                TreeViewInit.ConstructTree(PathBdd);

                ListViewController ListViewInit = new ListViewController(Form.GetFormMain().GetListView(), PathBdd);
                ListViewInit.LoadListView(Form.GetFormMain().GetTreeView().SelectedNode);
            }
        }
    }
}
