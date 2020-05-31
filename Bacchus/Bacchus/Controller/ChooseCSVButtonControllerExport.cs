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
    class ChooseCSVButtonControllerExport
    {
        private ModaleExporter Modale;

        public ChooseCSVButtonControllerExport(ModaleExporter Modale)
        {
            this.Modale = Modale;

            String FileName;

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
