using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.DAO
{
    class ImporterEcrasement
    {
        private OpenFileDialog Picker;

        public ImporterEcrasement(OpenFileDialog Picker)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=D:/Programmes Visual/Bacchus/Bacchus/Bacchus.sqlite");
            M_dbConnection.Open();

            String Sql = "DELETE FROM 'Marques'";
            Console.WriteLine(Sql);
            SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection);
            Command.ExecuteNonQuery();

            Sql = "DELETE FROM 'Familles'";
            Console.WriteLine(Sql);
            Command = new SQLiteCommand(Sql, M_dbConnection);
            Command.ExecuteNonQuery();

            Sql = "DELETE FROM 'SousFamilles'";
            Console.WriteLine(Sql);
            Command = new SQLiteCommand(Sql, M_dbConnection);
            Command.ExecuteNonQuery();

            Sql = "DELETE FROM 'Articles'";
            Console.WriteLine(Sql);
            Command = new SQLiteCommand(Sql, M_dbConnection);
            Command.ExecuteNonQuery();

            M_dbConnection.Close();

            this.Picker = Picker;
            ImporterBDD();
        }

        public void ImporterBDD()
        {
            MarquesDAO MarquesD = new MarquesDAO();
            FamillesDAO FamillesD = new FamillesDAO();
            SousFamillesDAO SousFamillesD = new SousFamillesDAO();

            List<string> AllMarques = new List<string>();
            List<string> AllFamilles = new List<string>();
            List<string> AllSousFamilles = new List<string>();
            List<string> AllSousFamillesFamilles = new List<string>();          //Pour récupérer la famille des sous familles

            //Pour les articles
            List<Articles> AllArticles = new List<Articles>();

            using (var reader = new StreamReader(Picker.FileName))
            {
                reader.ReadLine();                      //On passe la première ligne (les headers du fichier)

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    if (!AllMarques.Exists(e => e.EndsWith(values[2])))
                        AllMarques.Add(values[2]);
                    if (!AllFamilles.Exists(e => e.EndsWith(values[3])))
                        AllFamilles.Add(values[3]);
                    if (!AllSousFamilles.Exists(e => e.EndsWith(values[4])))
                    {
                        AllSousFamilles.Add(values[4]);
                        AllSousFamillesFamilles.Add(values[3]);
                    }

                    //Articles Article = new Articles(values[1], values[0], SousFamillesD.GetRefByName(values[4]), MarquesD.GetRefByName(values[2]), float.Parse(values[5]), 0);      //la faut modifier
                   // AllArticles.Add(Article);
                }
            }
            for (int Index = 0;  Index < AllMarques.Count; Index++)
            {
                Marques Marque = new Marques(AllMarques[Index]);
                MarquesD.AjouterMarque(Marque);
            }
            for (int Index = 0; Index < AllFamilles.Count; Index++)
            {
                Familles Famille = new Familles(AllFamilles[Index]);
                FamillesD.AjouterFamille(Famille);
            }
            for (int Index = 0; Index < AllSousFamilles.Count; Index++)
            {
                SousFamilles SousFamille = new SousFamilles(FamillesD.GetRefByName(AllSousFamillesFamilles[Index]), AllSousFamilles[Index]);
                SousFamillesD.AjouterSousFamille(SousFamille);
            }
        }
    }
}
