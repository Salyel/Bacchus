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
    /// Controller pour la selection du fichier SQLite
    /// </summary>
    class SelectSQLButtonImportController
    {
        //Attributs

        private ModaleImporter Modale;

        //Constructuers

        /// <summary>
        /// Constructeur pour lancer la fenetre de selection du fichier SQLite
        /// </summary>
        /// <param name="Modale"> fenetre d'importation </param>
        public SelectSQLButtonImportController(ModaleImporter Modale)
        {
            this.Modale = Modale;

            String FileName;

            OpenFileDialog Picker = new OpenFileDialog();
            Picker.Title = "Selectionne le fichier .sqlite dans lequel importer le fichier .csv";
            Picker.InitialDirectory = Directory.GetCurrentDirectory();
            Picker.Filter = "SQLite files (*.sqlite)|*.sqlite";
            Picker.ShowDialog();

            FileName = Picker.FileName;
            Modale.SetPathToSave(Picker.FileName);
            Modale.GetLabelSQL().Text = FileName;
        }
    }
}
