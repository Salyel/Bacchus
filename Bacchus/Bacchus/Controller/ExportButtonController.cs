using Bacchus.DAO;
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
    class ExportButtonController
    {
        private ModaleExporter Modale;

        public ExportButtonController(ModaleExporter Modale)
        {
            this.Modale = Modale;

            String FileName;

            OpenFileDialog Picker = new OpenFileDialog();
            Picker.Title = "Selectionne ton fichier .sqlite";
            Picker.InitialDirectory = Directory.GetCurrentDirectory();
            Picker.Filter = "SQLite files (*.sqlite)|*.sqlite";
            Picker.ShowDialog();

            FileName = Picker.FileName;
            Modale.GetLabelFileName().Text = FileName;

            Export(Picker);
        }

        public void Export(OpenFileDialog Picker)
        {
            if(!Picker.FileName.Equals(""))
            {

            }
        }
    }
}
