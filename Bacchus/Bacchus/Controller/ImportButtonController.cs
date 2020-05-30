using Bacchus.DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.Controller
{
    class ImportButtonController
    {
        private ModaleImporter Modale;

        public ImportButtonController(ModaleImporter Modale)
        {
            this.Modale = Modale;

            String FileName;

            if (Modale.GetButtonsValue().Equals(""))
            {
                Modale.GetLabel2().Text = "Veuillez choisir un mode d'intégration pour la base de données";
            }
            else
            {
                OpenFileDialog Picker = new OpenFileDialog();
                Picker.Title = "Selectionne ton fichier .csv";
                Picker.InitialDirectory = Directory.GetCurrentDirectory();
                Picker.Filter = "CSV files (*.csv)|*.csv";
                Picker.ShowDialog();

                FileName = Picker.FileName;
                Modale.GetLabel2().Text = FileName;

                if (Modale.GetButtonsValue().Equals("Ecrasement"))
                {
                    ImporterEcrasement ImportEcrasement = new ImporterEcrasement(Picker, Modale);
                }
                else if (Modale.GetButtonsValue().Equals("Ajout"))
                {
                    ImporterAjout ImportAjout = new ImporterAjout(Picker, Modale);
                }
            }
        }
    }
}
