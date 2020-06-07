using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.DAO
{
    /// <summary>
    /// Classe DAO pour les objets de la classe Article
    /// </summary>
    class ArticlesDAO
    {
        //Attributs

        private string DatabasePath;

        //Constructeur


        /// <summary>
        /// Constructeur pour le DAO des articles
        /// </summary>
        /// <param name="Path"> Chemin vers le fichier SQLite </param>
        public ArticlesDAO(string Path)
        {
            DatabasePath = Path;
        }

        /// <summary>
        /// DAO pour ajouter un article dans la base de données
        /// </summary>
        /// <param name="Article"> Objet Article à ajouter </param>
        public void AjouterArticle(Articles Article)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source="+DatabasePath);

            M_dbConnection.Open();

            String Sql = "insert into Articles (RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite) values ('" + Article.GetRefArticle() + "', '" + Article.GetDescription() + "', " + Article.GetRefSousFamille() + ", " + Article.GetRefMarque() + ", '" + Article.GetPrixHT() + "', " + Article.GetQuantite() + ")";

            //Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }

            M_dbConnection.Close();
        }

        /// <summary>
        /// DAO pour supprimer un article de base de donnees.
        /// </summary>
        /// <param name="RefArticle"></param>
        public void SupprimerArticle(string RefArticle)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "DELETE FROM Articles WHERE RefArticle = '" + RefArticle + "'";

            //Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }

            M_dbConnection.Close();
        }

        /// <summary>
        /// DAO pour récupérer un article en fonction de sa référence
        /// </summary>
        /// <param name="RefArt"> référence de l'article que l'on veut récupérer </param>
        /// <returns> l'objet Article </returns>
        public Articles GetArticleByRef(string RefArt)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select * from Articles where RefArticle='"+RefArt+"'";

            //Console.WriteLine(Sql);

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

        /// <summary>
        /// DAO pour vérifier si un article existe
        /// </summary>
        /// <param name="Nom"> nom de l'article </param>
        /// <returns> true si l'article existe, false sinon </returns>
        public bool CheckIfExists(String RefArticle)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select Description from articles where RefArticle= ('" + RefArticle + "')";
            //Console.WriteLine(Sql);

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

        /// <summary>
        /// DAO pour update un article
        /// </summary>
        /// <param name="RefArticle"> référence </param>
        /// <param name="Description"> description </param>
        /// <param name="RefSousFamille"> référence de la sous famille </param>
        /// <param name="RefMarque"> référence de la marque </param>
        /// <param name="PrixHT"> prix hors taxes </param>
        /// <param name="Quantite"> quantité disponible </param>
        public void Update(String RefArticle, String Description, int RefSousFamille, int RefMarque, float PrixHT, int Quantite)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "update Articles set Description=" + "'" + Description + "'" + ", RefSousFamille=" + RefSousFamille + ", RefMarque=" + RefMarque + ", PrixHT=" + "'" + PrixHT + "'" + ", Quantite=" + Quantite + " where RefArticle=" + "'" + RefArticle + "'";

            //Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }

            M_dbConnection.Close();
        }

        /// <summary>
        /// Recupere tous les articles dans la base de donnees
        /// </summary>
        /// <returns></returns>
        public List<Articles> GetAllArticles()
        {
            List<Articles> AllArticles = new List<Articles>();

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite from Articles";
            // Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Articles a = new Articles(Reader.GetString(0), Reader.GetString(1), Reader.GetInt32(2), Reader.GetInt32(3), 0, Reader.GetInt32(5));
                        AllArticles.Add(a);
                    }
                }
            }

            M_dbConnection.Close();

            return AllArticles;
        }

        /// <summary>
        /// Recupere dans la base de donnees tous les articles d'une marque
        /// </summary>
        /// <param name="RefMarque"></param>
        /// <returns></returns>
        public List<Articles> GetArticlesOfMarque(int RefMarque)
        {
            List<Articles> AllArticles = new List<Articles>();

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite from Articles WHERE Refmarque = " + RefMarque;
            // Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Articles a = new Articles(Reader.GetString(0), Reader.GetString(1), Reader.GetInt32(2), Reader.GetInt32(3), 0, Reader.GetInt32(5));
                        AllArticles.Add(a);
                    }
                }
            }

            M_dbConnection.Close();

            return AllArticles;
        }

        /// <summary>
        /// Recupere dans la base de donnees tous les articles d'une sous-famille
        /// </summary>
        /// <param name="RefSousFamille"></param>
        /// <returns></returns>
        public List<Articles> GetArticlesOfSousFamille(int RefSousFamille)
        {
            List<Articles> AllArticles = new List<Articles>();

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite from Articles WHERE RefSousFamille = " + RefSousFamille;
            // Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Articles a = new Articles(Reader.GetString(0), Reader.GetString(1), Reader.GetInt32(2), Reader.GetInt32(3), 0, Reader.GetInt32(5));
                        AllArticles.Add(a);
                    }
                }
            }

            M_dbConnection.Close();

            return AllArticles;
        }

        /// <summary>
        /// DAO qui renvoie le nombre d'articles appartenant a une certaine marque dans la base de donnees.
        /// </summary>
        /// <param name="RefMarque"></param>
        /// <returns></returns>
        public int CountArticlesOfMarques(int RefMarque)
        {
            int nbArticles = 0;

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select COUNT(*) from Articles WHERE RefMarque = " + RefMarque;

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        nbArticles = Reader.GetInt32(0);
                    }
                }
            }

            M_dbConnection.Close();

            return nbArticles;
        }

        /// <summary>
        /// DAO qui renvoie le nombre d'articles appartenant a une certaine sous-famille dans la base de donnees.
        /// </summary>
        /// <param name="RefSousFamille"></param>
        /// <returns></returns>
        public int CountArticlesOfSousFamille(int RefSousFamille)
        {
            int nbArticles = 0;

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select COUNT(*) from Articles WHERE RefSousFamille = " + RefSousFamille;

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        nbArticles = Reader.GetInt32(0);
                    }
                }
            }

            M_dbConnection.Close();

            return nbArticles;
        }

        /// <summary>
        /// Renvoie le nombre d'articles présents dans la bdd
        /// </summary>
        /// <returns></returns>
        public int CountAllArticles()
        {
            int Total = 0;

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select COUNT(*) from Articles";

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    Reader.Read();
                    Total = Reader.GetInt32(0);
                }
            }

            M_dbConnection.Close();

            return Total;
        }
    }
}
