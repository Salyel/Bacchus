using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.DAO
{
    class ArticlesDAO
    {
        private string DatabasePath;

        public ArticlesDAO(string Path)
        {
            DatabasePath = Path;
        }

        public void AjouterArticle(Articles Article)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source="+DatabasePath);

            M_dbConnection.Open();

            String Sql = "insert into Articles (RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite) values ('" + Article.GetRefArticle() + "', '" + Article.GetDescription() + "', " + Article.GetRefSousFamille() + ", " + Article.GetRefMarque() + ", '" + Article.GetPrixHT() + "', " + Article.GetQuantite() + ")";

            Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }

            M_dbConnection.Close();
        }

        public Articles GetArticleByRef(string RefArt)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select * from Articles where RefArticle='"+RefArt+"'";

            Console.WriteLine(Sql);

            Articles Article;
            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    Reader.Read();
                    Article = new Articles(Reader.GetString(0), Reader.GetString(1), Reader.GetInt32(2), Reader.GetInt32(3), Reader.GetFloat(4), Reader.GetInt32(5));
                }
            }

            M_dbConnection.Close();

            return Article;
        }

        public bool CheckIfExists(String RefArticle)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select Description from articles where RefArticle= ('" + RefArticle + "')";
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

        public void Update(String RefArticle, String Description, int RefSousFamille, int RefMarque, float PrixHT, int Quantite)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "update Articles set Description=" + "'" + Description + "'" + ", RefSousFamille=" + RefSousFamille + ", RefMarque=" + RefMarque + ", PrixHT=" + "'" + PrixHT + "'" + ", Quantite=" + Quantite + " where RefArticle=" + "'" + RefArticle + "'";

            Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }

            M_dbConnection.Close();
        }
    }
}
