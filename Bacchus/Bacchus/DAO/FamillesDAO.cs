using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.DAO
{
    class FamillesDAO
    {
        public FamillesDAO()
        {

        }

        public void AjouterFamille(Familles Famille)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=D:/Programmes Visual/Bacchus/Bacchus/Bacchus.sqlite");

            M_dbConnection.Open();

            String Sql = "insert into familles (Nom) values ('" + Famille.GetNom() + "')";

            Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }

            M_dbConnection.Close();
        }

        public int GetRefByName(String Nom)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=D:/Programmes Visual/Bacchus/Bacchus/Bacchus.sqlite");

            M_dbConnection.Open();

            String Sql = "select RefFamille from familles where Nom= ('" + Nom + "')";
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
    }
}
