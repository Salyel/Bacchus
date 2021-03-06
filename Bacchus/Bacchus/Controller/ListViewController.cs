﻿using Bacchus.DAO;
using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                default:
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

            int Compteur = 0;
            foreach(TreeNode Node in EventNode.Nodes)
            {
                ListViewItem Item = new ListViewItem(Node.Text);
                Item.Name = Node.Text;

                List.Items.Add(Item);
                //List.Items[Compteur].Tag = Node.Tag;
                List.Items.Find(Node.Text, false)[0].Tag = Node.Tag;
                Compteur++;
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

            //ajout de chaque article dans la listView, chaque article correpond à un objet Item
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

            // permet d'adapter la taille d'une colonne en fonction de son contenu
            List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// Supprime l'item selectionne dans la listview, dans la treeview et dans la base de donnees si cela ne provoque pas de supression en cascade
        /// </summary>
        /// <param name="SelectedNode"></param>
        public void DeleteSelectedItem(TreeNode SelectedNode, FormMain Form)
        {
            ListViewItem SelectedItem = this.List.SelectedItems[0]; 
            ArticlesDAO aDAO = new ArticlesDAO(PathBdd);
            SousFamillesDAO sfDAO = new SousFamillesDAO(PathBdd);

            ToolStatusStripController TSSController;
            int nbArticles = 0;

            //on effectue la suppression en fonction de la classe de l'objet présent dans le Tag
            switch (SelectedItem.Tag)
            {
                case Articles a:
                    this.List.Items.Remove(SelectedItem);
                    aDAO.SupprimerArticle(a.GetRefArticle());

                    //maj du status strip
                    TSSController = new ToolStatusStripController(Form.GetToolStatusStrip("Article"));
                    TSSController.ChangeNumber(aDAO.CountAllArticles());
                    break;

                case Familles f:
                    int nbSousFamilles = sfDAO.CountSousFamillesOfFamille(f.GetRefFamille());
                    if (nbSousFamilles > 0)
                    {
                        MessageBox.Show("Veuillez supprimer les sous-familles de cette famille au prealable.");
                    }
                    else
                    {
                        this.List.Items.Remove(SelectedItem);
                        FamillesDAO fDAO = new FamillesDAO(PathBdd);
                        fDAO.SupprimerFamille(f.GetRefFamille());
                        SelectedNode.Nodes.RemoveByKey(f.GetNom());

                        //maj du statusStrip
                        TSSController = new ToolStatusStripController(Form.GetToolStatusStrip("Familles"));
                        TSSController.ChangeNumber(fDAO.CountAllFamilles());
                    }
                    break;

                case SousFamilles sf:
                    nbArticles = aDAO.CountArticlesOfSousFamille(sf.GetRefSousFamille());
                    if (nbArticles > 0)
                    {
                        MessageBox.Show("Veuillez supprimer les articles de cette sous-famille au prealable.");
                    }
                    else
                    {
                        this.List.Items.Remove(SelectedItem);
                        sfDAO.SupprimerSousFamille(sf.GetRefSousFamille());
                        SelectedNode.Nodes.RemoveByKey(sf.GetNom());

                        //maj du status strip
                        TSSController = new ToolStatusStripController(Form.GetToolStatusStrip("SousFamilles"));
                        TSSController.ChangeNumber(sfDAO.CountAllSousFamilles());
                    }
                    break;

                case Marques m:
                    nbArticles = aDAO.CountArticlesOfMarques(m.GetRefMarque());
                    if (nbArticles > 0)
                    {
                        MessageBox.Show("Veuillez supprimer les articles de cette marque au prealable.");
                    }
                    else
                    {
                        MarquesDAO mDAO = new MarquesDAO(PathBdd);
                        this.List.Items.Remove(SelectedItem);
                        mDAO.SupprimerMarques(m.GetRefMarque());
                        SelectedNode.Nodes.RemoveByKey(m.GetNom());

                        //maj du status strip
                        TSSController = new ToolStatusStripController(Form.GetToolStatusStrip("Marques"));
                        TSSController.ChangeNumber(mDAO.CountAllMarques());
                    }
                    break;

                default:
                    break;
            }

        }

        /// Trie la liste en fonction de la colonne sur laquelle on a cliqué
        /// </summary>
        /// <param name="ColumnId"> numéro de la colonne </param>
        public void SortingListView(int ColumnId)
        {
            //on fait le tri uniquement si la liste n'est pas vide
            if(List.Items.Count > 0)
                List.ListViewItemSorter = new ListViewItemComparer(ColumnId);
        }
    }
}
