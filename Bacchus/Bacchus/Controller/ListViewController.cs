using Bacchus.DAO;
using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Bacchus.Controller
{
    class ListViewController
    {
        //Attributs

        private  ListView List;
        private string PathBdd;

        //Constructeur

        /// <summary>
        /// Recupere la ListView et le chemin d'acces a la base de donnees
        /// </summary>
        /// <param name="List"></param>
        /// <param name="PathToSave"></param>
        public ListViewController(ListView List, string PathToSave)
        {
            this.List = List;
            this.PathBdd = PathToSave;
        }

        //Methodes

        /// <summary>
        /// Determine quelle methode on va appeler pour remplir la ListView en fonction de la node qui a ete clickee
        /// </summary>
        /// <param name="EventNode"></param>
        public void LoadListView(TreeNode EventNode)
        {
            switch (EventNode.Tag)
            {
                case String s:
                    if (s.Equals("articles"))
                        LoadAllArticles();
                    else
                        LoadNoeudsEnfant(EventNode);
                    break;
                case Familles f:
                    LoadNoeudsEnfant(EventNode);
                    break;
                case SousFamilles sf:
                    LoadArticleOfSousFamille(sf);
                    break;
                case Marques m:
                    LoadArticlesOfMarque(m);
                    break;
            }
        }

        /// <summary>
        /// Recupere tous les articles et les affiche dans la ListView
        /// </summary>
        public void LoadAllArticles()
        {
            List.BeginUpdate();

            InitializeColumnArticle();

            ArticlesDAO aDAO = new ArticlesDAO(PathBdd);
            List<Articles> AllArticles = aDAO.GetAllArticles();

            FillListView(AllArticles);

            List.EndUpdate();
        }

        /// <summary>
        /// Recupere tous les articles d'une marque et les affiche dans la ListView
        /// </summary>
        /// <param name="Marque"></param>
        public void LoadArticlesOfMarque(Marques Marque)
        {
            List.BeginUpdate();

            InitializeColumnArticle();

            ArticlesDAO aDAO = new ArticlesDAO(PathBdd);
            List<Articles> AllArticles = aDAO.GetArticlesOfMarque(Marque.GetRefMarque());

            FillListView(AllArticles);

            List.EndUpdate();
        }

        /// <summary>
        /// Recupere tous les articles d'une sous-famille et les affiche dans la ListView
        /// </summary>
        /// <param name="SousFamille"></param>
        public void LoadArticleOfSousFamille(SousFamilles SousFamille)
        {
            List.BeginUpdate();

            InitializeColumnArticle();

            ArticlesDAO aDAO = new ArticlesDAO(PathBdd);
            List<Articles> AllArticles = aDAO.GetArticlesOfSousFamille(SousFamille.GetRefSousFamille());

            FillListView(AllArticles);

            List.EndUpdate();
        }

        /// <summary>
        /// Recupere tous les noeuds enfants du noeud clicke et affiche leur nom dans la ListView
        /// </summary>
        /// <param name="EventNode"></param>
        public void LoadNoeudsEnfant(TreeNode EventNode)
        {
            List.BeginUpdate();

            InitializeColumnNom();

            foreach(TreeNode Node in EventNode.Nodes)
            {
                List.Items.Add(Node.Text);
            }

            List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            List.EndUpdate();
        }

        /// <summary>
        /// Cree les headers de colonnes dans les cas ou on affiche que le nom
        /// </summary>
        public void InitializeColumnNom()
        {
            List.Columns.Clear();
            List.Items.Clear();

            List.Columns.Add("Nom");

        }

        /// <summary>
        /// Cree les headers de colonnes dans le cas ou on affiche des articles
        /// </summary>
        public void InitializeColumnArticle()
        {
            List.Columns.Clear();
            List.Items.Clear();
           
            List.Columns.Add("Reference");
            List.Columns.Add("Description");
            List.Columns.Add("Famille");
            List.Columns.Add("Sous-famille");
            List.Columns.Add("Marque");
            List.Columns.Add("Quantité");

        }

        /// <summary>
        /// Prend une liste d'article passee en parametre et remplit la ListView avec
        /// </summary>
        /// <param name="AllArticles"></param>
        public void FillListView(List<Articles> AllArticles)
        {
            SousFamillesDAO sfDAO = new SousFamillesDAO(PathBdd);
            MarquesDAO mDAO = new MarquesDAO(PathBdd);

            foreach (Articles a in AllArticles)
            {
                ListViewItem Item = new ListViewItem();
                Item.Tag = a;
                Item.Text = a.GetRefArticle();
                Item.SubItems.Add(a.GetDescription());
                Item.SubItems.Add(sfDAO.GetFamilleNameBySousFamilleRef(a.GetRefSousFamille()));
                Item.SubItems.Add(sfDAO.GetNameByRef(a.GetRefSousFamille()));
                Item.SubItems.Add(mDAO.GetNameByRef(a.GetRefMarque()));
                Item.SubItems.Add(a.GetQuantite().ToString());

                List.Items.Add(Item);
            }

            List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
