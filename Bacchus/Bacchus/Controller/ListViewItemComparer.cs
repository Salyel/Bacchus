using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.Controller
{
    /// <summary>
    /// Comparateur d'objets pour le tri
    /// Implémente l'interface IComparer
    /// </summary>
    class ListViewItemComparer : IComparer
    {
        //Attributs

        private int colomn = -1; //le numéro de la colonne

        //Constructeur

        /// <summary>
        /// Constructeur principal
        /// </summary>
        /// <param name="column"> numéro de la colonne sur laquelle effectuer le tri </param>
        public ListViewItemComparer(int column)
        {
            this.colomn = column;
        }

        /// <summary>
        /// Methode de l'interface ICompare
        /// </summary>
        /// <param name="x"> objet 1 à comparer </param>
        /// <param name="y"> objet 2 à comparer </param>
        /// <returns></returns>
        public int Compare(object x, object y)
        {
            try
            {
                return String.Compare(((ListViewItem)x).SubItems[colomn].Text, ((ListViewItem)y).SubItems[colomn].Text);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return 0;
        }
    }
}
