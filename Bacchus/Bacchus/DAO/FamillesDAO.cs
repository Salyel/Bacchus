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
    /// Classe DAO pour les objets de la classe Famille
    /// </summary>
    class FamillesDAO
    {
        //Attributs

        private string DatabasePath;

        //Constructeur

        /// <summary>
        /// Constructeur pour le DAO des familles
        /// </summary>
        /// <param name="Path"> Chemin vers le fichier SQLite </param>
        public FamillesDAO(string Path)
        {
            DatabasePath = Path;
        }

        /// <summary>
        /// DAO pour ajouter une famille dans la base de données
        /// </summary>
        /// <param name="Famille"> Objet Famille à ajouter </param>
        public void AjouterFamille(Familles Famille)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "insert into familles (Nom) values ('" + Famille.GetNom() + "')";

            //Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }

            M_dbConnection.Close();
        }

        /// <summary>
        /// DAO pour supprimer une famille de la base de donnees.
        /// </summary>
        /// <param name="RefFamille"></param>
        public void SupprimerFamille(int RefFamille)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "DELETE FROM Familles WHERE RefFamille = " + RefFamille;

            //Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }

            M_dbConnection.Close();
        }

        /// <summary>
        /// DAO pour récupérer la référence d'une famille en fonction de son nom
        /// </summary>
        /// <param name="Nom"> Nom de la famille dont on veut obtenir la référence </param>
        /// <returns> Référence de la famille </returns>
        public int GetRefByName(String Nom)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefFamille from familles where Nom= ('" + Nom + "')";
            //Console.WriteLine(Sql);

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

        /// <summary>
        /// DAO pour récupérer le nom d'une famille en fonction de sa référence
        /// </summary>
        /// <param name="Ref"> référence de la famille dont on veut obtenir le nom </param>
        /// <returns> Le nom de la famille </returns>
        public string GetNameByRef(int Ref)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            Console.WriteLine("database : " + DatabasePath);
            M_dbConnection.Open();

            String Sql = "select Nom from Familles where RefFamille=" + Ref;
            //Console.WriteLine(Sql);

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

        /// <summary>
        /// DAO pour vérifier si une famille existe
        /// </summary>
        /// <param name="Nom"> nom de la famille </param>
        /// <returns> true si la famille existe, false sinon </returns>
        public bool CheckIfExists(String Nom)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefFamille from familles where Nom= ('" + Nom + "')";
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
        /// Permet de récupérer toutes les familles dans la base de donnees
        /// </summary>
        /// <returns> la liste des noms des familles </returns>
        public List<Familles> GetAllFamilles()
        {
            List<Familles> AllFamilles = new List<Familles>();

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            //Console.WriteLine("database allfam : "+DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefFamille, Nom from Familles";
            //Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    while(Reader.Read())
                    {
                        Familles f = new Familles(Reader.GetInt32(0), Reader.GetString(1));
                        AllFamilles.Add(f);
                    }
                }
            }

            M_dbConnection.Close();

            return AllFamilles;
        }

        /// <summary>
        /// Renvoie le nombre de familles présentes dans la bdd
        /// </summary>
        /// <returns></returns>
        public int CountAllFamilles()
        {
            int Total = 0;

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select COUNT(*) from Familles";

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
