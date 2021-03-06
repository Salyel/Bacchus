﻿using Bacchus.DAO;
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
    /// Controller pour la selection du fichier .csv
    /// </summary>
    class SelectCSVButtonImportController
    {
        //Attributs

        private ModaleImporter Modale;

        //Constructeur

        /// <summary>
        /// Fenetre de selection du .csv
        /// </summary>
        /// <param name="Modale"> fenetre d'import </param>
        public SelectCSVButtonImportController(ModaleImporter Modale)
        {
            this.Modale = Modale;

            String FileName;

            OpenFileDialog Picker = new OpenFileDialog();
            Picker.Title = "Selectionne ton fichier .csv";
            Picker.InitialDirectory = Directory.GetCurrentDirectory();
            Picker.Filter = "CSV files (*.csv)|*.csv";
            Picker.ShowDialog();

            FileName = Picker.FileName;
            Modale.SetPathToImport(FileName);
            Modale.GetLabelFileName().Text = FileName;
        }
    }
}
