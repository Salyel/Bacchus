using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.DAO
{
    class MarquesDAO
    {
        private string DatabasePath;

        public MarquesDAO(string Path)
        {
            DatabasePath = Path;
        }

        public void AjouterMarque(Marques Marque)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);
            
            M_dbConnection.Open();

            String Sql = "insert into marques (Nom) values ('" + Marque.GetNom() + "')";

            Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }
            
            M_dbConnection.Close();
        }

        public int GetRefByName(String Nom)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefMarque from marques where Nom= ('" + Nom + "')";
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

        public string GetNameByRef(int Ref)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select Nom from marques where RefMarque=" + Ref;
            Console.WriteLine(Sql);

            string Nom = "";

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    Reader.Read();
                    Nom = Reader.GetString(0);
                }
            }

            M_dbConnection.Close();

            return Nom;
        }

        public bool CheckIfExists(String Nom)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefMarque from marques where Nom= ('" + Nom + "')";
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
    }
}
