using Bacchus.DAO;
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
        public void CreateFamillesNodes(List<string> FamillesNames)
        {
            FamillesDAO famillesDAO = new FamillesDAO()

            Tree.BeginUpdate();

            Tree.Nodes[1].Nodes.Clear();
            foreach(string Names in FamillesNames)
            {
                Tree.Nodes[1].Nodes.Add(Names);
            }

            Tree.EndUpdate();
        }

    }
}
