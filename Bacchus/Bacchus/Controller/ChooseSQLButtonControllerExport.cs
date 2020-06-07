using Bacchus.DAO;
using Bacchus.Model;
using Bacchus.View;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.Controller
{
    /// <summary>
    /// Constroller pour choisir vers quel fichier SQLite nous devons exporter la bdd locale
    /// </summary>
    class ChooseSQLButtonControllerExport
    {
        //Attributs

        private ModaleExporter Modale;

        //Constructeur

        /// <summary>
        /// Controller pour le choix du fichier SQLite à exporter
        /// </summary>
        /// <param name="Modale"> fenêtre d'exportation </param>
        public ChooseSQLButtonControllerExport(ModaleExporter Modale)
        {
            //link avec la view
            this.Modale = Modale;

            String FileName;

            //choix du fichier
            OpenFileDialog Picker = new OpenFileDialog();
            Picker.Title = "Selectionne ton fichier .sqlite";
            Picker.InitialDirectory = Directory.GetCurrentDirectory();
            Picker.Filter = "SQLite files (*.sqlite)|*.sqlite";
            Picker.ShowDialog();

            FileName = Picker.FileName;
            Modale.SetPathToExport(Picker.FileName);
            Modale.GetLabelFileName().Text = FileName;
        }
    }
}
