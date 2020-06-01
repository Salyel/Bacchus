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
    /// Constroller pour lancer l'exportation du fichier
    /// </summary>
    class ExportButtonController
    {
        //Attribut

        private ModaleExporter Modale;
        
        //Constructeur

        /// <summary>
        /// Constructeur pour lancer l'exportation
        /// </summary>
        /// <param name="Modale"> fenetre d'exportation </param>
        public ExportButtonController(ModaleExporter Modale)
        {
            this.Modale = Modale;
            if (!Modale.GetPathToSave().Equals("") && !Modale.GetPathToExport().Equals(""))
            {
                Export();
            }
            else
            {
                Modale.GetLabelExport().Text = "Veuillez choisir un fichier .sqlite et une localisation pour exporter";
            }
        }

        /// <summary>
        /// Exportation
        /// </summary>
        public void Export()
        {
            Modale.GetLabelExport().Text = "Export en cours...";
            Modale.SetProgressBarValue(10);
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data source ="+Modale.GetPathToExport());

            M_dbConnection.Open();

            String Sql = "select * from Articles";

            Console.WriteLine(Sql);

            Articles Article;
            List<Articles> AllArticles = new List<Articles>();
            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            float Prix = float.Parse(Reader.GetString(4));
                            Article = new Articles(Reader.GetString(0), Reader.GetString(1), Reader.GetInt32(2), Reader.GetInt32(3), Prix, Reader.GetInt32(5));
                            AllArticles.Add(Article);
                        }
                    }
                    else
                    {
                        Console.WriteLine("La table articles est vide.");
                    }
                }
            }
            Modale.SetProgressBarValue(40);

            M_dbConnection.Close();

            string Path = Modale.GetPathToSave();
            string Delimiter = ";";
            SousFamillesDAO SousFamilleD = new SousFamillesDAO(Modale.GetPathToExport());
            MarquesDAO MarqueD = new MarquesDAO(Modale.GetPathToExport());

            Modale.SetProgressBarValue(70);
            for (int Index = 0; Index < AllArticles.Count; Index++)
            {
                if (!File.Exists(Path))
                {
                    // On écrit les headers
                    string Headers = "Description" + Delimiter + "Ref" + Delimiter + "Marque" + Delimiter + "Famille" + Delimiter + "Sous-Famille" + Delimiter + "Prix H.T." + Environment.NewLine;
                    File.WriteAllText(Path, Headers);
                }
                //On rentre les articles ligne par ligne mais on doit d'abord récupérer les noms des familles, sous familles et marques.
                string SousFamille = SousFamilleD.GetNameByRef(AllArticles[Index].GetRefSousFamille());
                string Famille = SousFamilleD.GetFamilleNameBySousFamilleRef(AllArticles[Index].GetRefSousFamille());
                string Marque = MarqueD.GetNameByRef(AllArticles[Index].GetRefMarque());
                string appendText = AllArticles[Index].GetDescription() + Delimiter + AllArticles[Index].GetRefArticle() + Delimiter + Marque + Delimiter + Famille + Delimiter + SousFamille + Delimiter + AllArticles[Index].GetPrixHT() + Environment.NewLine;
                File.AppendAllText(Path, appendText);
            }
            Modale.SetProgressBarValue(100);
            Modale.GetLabelExport().Text = "Export terminé";
        }
    }
}
