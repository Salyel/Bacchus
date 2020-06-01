using Bacchus.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.Controller
{
    /// <summary>
    /// Controller pour le bouton d'exportation des données (.csv)
    /// </summary>
    class ChooseCSVButtonControllerExport
    {
        //Attributs

        private ModaleExporter Modale;

        //Constructeur

        /// <summary>
        /// Constructeur permettant de sélectionner où le fichier .csv sera sauvegardé
        /// </summary>
        /// <param name="Modale"> fenêtre d'exportation </param>
        public ChooseCSVButtonControllerExport(ModaleExporter Modale)
        {
            //link avec la fenetre d'export
            this.Modale = Modale;

            String FileName;

            //ouverture d'une boite de dialogue pour sélectionner le chemin de sauvegarde
            SaveFileDialog Picker = new SaveFileDialog();
            Picker.Title = "Selectionne la location pour le futur fichier .csv";
            Picker.InitialDirectory = Directory.GetCurrentDirectory();
            Picker.Filter = "CSV files (*.csv)|*.csv";
            Picker.ShowDialog();

            FileName = Picker.FileName;
            Modale.SetPathToSave(Picker.FileName);
            Modale.GetLabelFileNameSave().Text = FileName;
        }
    }
}
