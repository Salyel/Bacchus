using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.DAO
{
    class SousFamillesDAO
    {
        public SousFamillesDAO()
        {

        }

        public void AjouterSousFamille(SousFamilles SousFamille)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection(DatabaseDirectory.Database);

            M_dbConnection.Open();

            String Sql = "insert into Sousfamilles (Nom, RefFamille) values ('" + SousFamille.GetNom() + "'" + ", " + SousFamille.GetRefFamille() + ")";

            Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }

            M_dbConnection.Close();
        }

        public int GetRefByName(String Nom)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection(DatabaseDirectory.Database);

            M_dbConnection.Open();

            String Sql = "select RefSousFamille from sousfamilles where Nom= ('" + Nom + "')";
            Console.WriteLine(Sql);

            int Ref = -1;

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    Reader.Read();
                    Ref = Reader.GetInt32(0);
                }
            }

            M_dbConnection.Close();

            return Ref;
        }

        public bool CheckIfExists(String Nom)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection(DatabaseDirectory.Database);

            M_dbConnection.Open();

            String Sql = "select RefSousFamille from SousFamilles where Nom= ('" + Nom + "')";
            Console.WriteLine(Sql);

            bool Exists = true;

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    Reader.Read();
                    if (Reader == null || !Reader.HasRows)
                    {
                        Exists = false;
                    }
                }
            }

            M_dbConnection.Close();

            return Exists;
        }

        public void Update(int RefFamille, string Nom)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection(DatabaseDirectory.Database);

            M_dbConnection.Open();

            String Sql = "update Sousfamilles set RefFamille=" + RefFamille + " where Nom=" + "'" + Nom + "'";

            Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }

            M_dbConnection.Close();
        }
    }
}
