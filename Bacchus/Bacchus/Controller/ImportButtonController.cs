using Bacchus.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Controller
{
    /// <summary>
    /// Constroller pour l'importation d'un fichier SQLite
    /// </summary>
    class ImportButtonController
    {
        //Attributs

        private ModaleImporter Modale;

        //Constructeur

        /// <summary>
        /// Lancement de l'importation
        /// </summary>
        /// <param name="Modale"> fenetre d'importation </param>
        public ImportButtonController(ModaleImporter Modale)
        {
            this.Modale = Modale;

            //si on a pas choisi un mode d'importation
            if (Modale.GetButtonsValue().Equals("") || Modale.GetPathToImport().Equals("") || Modale.GetPathToSave().Equals(""))
            {
                Modale.GetLabelImport().Text = "Veuillez choisir un mode d'intégration pour la base de données, un fichier .csv à importer et un fichier .sqlite dans lequel le fichier .csv sera importé.";
            }

            else
            {
                //import en mode ecrasement
                if (Modale.GetButtonsValue().Equals("Ecrasement"))
                {
                    Modale.GetLabelImport().Text = "Import en mode Ecrasement en cours ...";
                    ImporterEcrasement ImportEcrasement = new ImporterEcrasement(Modale);
                }
                //import en mode ajout
                else if (Modale.GetButtonsValue().Equals("Ajout"))
                {
                    Modale.GetLabelImport().Text = "Import en mode Ajout en cours ...";
                    ImporterAjout ImportAjout = new ImporterAjout(Modale);
                }
            }
        }
    }
}
