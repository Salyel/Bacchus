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
        /// Construit la tree view à partir des éléments de la bdd SQLite
        /// </summary>
        public void ConstructTree(string Path)
        {
            CreateFamillesNodes(Path);
            CreateMarquesNodes(Path);
        }
    }
}
