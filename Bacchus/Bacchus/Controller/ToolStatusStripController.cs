using Bacchus.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.Controller
{
    /// <summary>
    /// Contrôleur pour la gestion du statusStrip
    /// </summary>
    class ToolStatusStripController
    {
        //Attributs
        private ToolStripStatusLabel StatusLabel;

        //Constructeur

        /// <summary>
        /// Constructeur pour manipuler l'objet mis en attribut
        /// </summary>
        /// <param name="StatusLabel"></param>
        public ToolStatusStripController(ToolStripStatusLabel StatusLabel)
        {
            this.StatusLabel = StatusLabel;
        }

        /// <summary>
        /// Methode pour changer une quantité
        /// </summary>
        /// <param name="NewNumber"></param>
        public void ChangeNumber(int NewNumber)
        {
            if (StatusLabel.Text.Contains("Nombre d'articles"))
                StatusLabel.Text = "Nombre d'articles : " + NewNumber;

            if (StatusLabel.Text.Contains("Nombre de familles"))
                StatusLabel.Text = "Nombre de familles : " + NewNumber;

            if (StatusLabel.Text.Contains("Nombre de sous-familles"))
                StatusLabel.Text = "Nombre de sous-familles : " + NewNumber;

            if (StatusLabel.Text.Contains("Nombre de marques"))
                StatusLabel.Text = "Nombre de marques : " + NewNumber;
        }
            

    }
}
