using Bacchus.DAO;
using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.Controller
{
    class InitializeTreeView
    {
        //Attributs

        private TreeView Tree;

        //Constructeur

        /// <summary>
        /// Permet de linker une treeView afin de la manipuler
        /// </summary>
        /// <param name="Tree"></param>
        public InitializeTreeView(TreeView Tree)
        {
            this.Tree = Tree;
       
        }

        /// <summary>
        /// Créer les noeuds de base sur la treeView
        /// </summary>
        public void CreateRootNodes()
        {
            Tree.BeginUpdate();

            Tree.Nodes.Add("Tous les articles");
            Tree.Nodes.Add("Familles");
            Tree.Nodes.Add("Marques");

            Tree.EndUpdate();
        }

        /// <summary>
        /// Permet de créer les noeuds des familles 
        /// </summary>
        /// <param name="Path"> chemin vers la bdd SQLite </param>
        public void CreateFamillesNodes(string Path)
        {
            FamillesDAO famillesDAO = new FamillesDAO(Path);

            List<string> FamillesNames = famillesDAO.GetAllNomsFamilles();

            Tree.BeginUpdate();
            Tree.Nodes[1].Nodes.Clear();
            foreach(string Names in FamillesNames)
            {
                Tree.Nodes[1].Nodes.Add(Names);
            }
            Tree.EndUpdate();
        }

        /// <summary>
        /// Permet de créer les noeuds des marques 
        /// </summary>
        /// <param name="Path"> chemin vers la bdd SQLite </param>
        public void CreateMarquesNodes(string Path)
        {
            MarquesDAO marquesDAO = new MarquesDAO(Path);

            List<string> MarquesNames = marquesDAO.GetAllNames();

            Tree.BeginUpdate();
            Tree.Nodes[2].Nodes.Clear();
            foreach (string Names in MarquesNames)
            {
                Tree.Nodes[2].Nodes.Add(Names);
            }
            Tree.EndUpdate();
        }

        /// <summary>
        /// Permet de créer les noeuds des sous familles dans la branch Familles
        /// </summary>
        /// <param name="Path"> chemin vers la bdd SQLite </param>
        public void CreateSousFamillesNodes(string Path)
        {

            List<string> sousFamillesNames = new List<string>();
            SousFamillesDAO sfDAO = new SousFamillesDAO(Path);
            TreeNode famillesNodes = Tree.Nodes[1];

            Tree.BeginUpdate();          
            foreach(TreeNode n in famillesNodes.Nodes)
            {
                sousFamillesNames = sfDAO.GetSousFamillesByFamilleName(n.Text);

                foreach(string sfName in sousFamillesNames)
                {
                    n.Nodes.Add(sfName);
                }
                sousFamillesNames.Clear();
            }
            Tree.EndUpdate();
        }

        /// <summary>
        /// Affichage de l'arbre dans la console
        /// </summary>
        public void PrintTreeView()
        {
            TreeNodeCollection nodes = Tree.Nodes;
            foreach(TreeNode n in nodes)
            {
                PrintRecu(n);
            }
        }

        /// <summary>
        /// Affichage récusif d'un noeud et de ses enfants
        /// </summary>
        /// <param name="treenode"></param>
        public void PrintRecu(TreeNode treenode)
        {
            Console.WriteLine(treenode.Text);

            foreach(TreeNode n in treenode.Nodes)
            {
                PrintRecu(n);
            }
        }

        /// <summary>
        /// Construit la tree view à partir des éléments de la bdd SQLite
        /// </summary>
        public void ConstructTree(string Path)
        {
            CreateFamillesNodes(Path);
            CreateMarquesNodes(Path);
            CreateSousFamillesNodes(Path);

            //PrintTreeView();
        }
    }
}
