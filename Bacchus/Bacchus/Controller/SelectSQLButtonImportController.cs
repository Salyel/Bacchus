using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.Controller
{
    class SelectSQLButtonImportController
    {
        private ModaleImporter Modale;

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
