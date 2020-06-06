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
        public ListViewController(ListView List, string PathToSave)
        {
            this.List = List;
            this.PathBdd = PathToSave;
        }

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

        public void LoadAllArticles()
        {
            List.BeginUpdate();

            InitializeColumnArticle();

            ArticlesDAO aDAO = new ArticlesDAO(PathBdd);
            List<Articles> AllArticles = aDAO.GetAllArticles();

            FillListView(AllArticles);

            List.EndUpdate();
        }

        public void LoadArticlesOfMarque(Marques Marque)
        {
            List.BeginUpdate();

            InitializeColumnArticle();

            ArticlesDAO aDAO = new ArticlesDAO(PathBdd);
            List<Articles> AllArticles = aDAO.GetArticlesOfMarque(Marque.GetRefMarque());

            FillListView(AllArticles);

            List.EndUpdate();
        }

        public void LoadArticleOfSousFamille(SousFamilles SousFamille)
        {
            List.BeginUpdate();

            InitializeColumnArticle();

            ArticlesDAO aDAO = new ArticlesDAO(PathBdd);
            List<Articles> AllArticles = aDAO.GetArticlesOfSousFamille(SousFamille.GetRefSousFamille());

            FillListView(AllArticles);

            List.EndUpdate();
        }

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

        public void InitializeColumnNom()
        {
            List.Columns.Clear();
            List.Items.Clear();

            List.Columns.Add("Nom");

        }

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
