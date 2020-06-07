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
    /// <summary>
    /// Classe DAO pour les objets de la classe Marque
    /// </summary>
    class MarquesDAO
    {
        //Attributs

        private string DatabasePath;

        //Constructeur

        // <summary>
        /// Constructeur pour le DAO des marques
        /// </summary>
        /// <param name="Path"> Chemin vers le fichier SQLite </param>
        public MarquesDAO(string Path)
        {
            DatabasePath = Path;
        }

        /// <summary>
        /// DAO pour ajouter une marque dans la base de données
        /// </summary>
        /// <param name="Marque"> Objet Marque à ajouter </param>
        public void AjouterMarque(Marques Marque)
        {
            //ouverture de la connexion avec la bdd & creation de la requete

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);
            
            M_dbConnection.Open();
            String Sql = "insert into marques (Nom) values ('" + Marque.GetNom() + "')";

            //Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                //ajout de la marque
                Command.ExecuteNonQuery();
            }
            
            //fermeture de la connexion
            M_dbConnection.Close();
        }

        /// <summary>
        /// DAO pour supprimer une marque de la base de donnees.
        /// </summary>
        /// <param name="RefMarque"></param>
        public void SupprimerMarques(int RefMarque)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "DELETE FROM Marques WHERE RefMarque = " + RefMarque;

            //Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }

            M_dbConnection.Close();
        }

        /// <summary>
        /// DAO pour récupérer la référence d'une marque en fonction de son nom
        /// </summary>
        /// <param name="Nom"> Nom de la marque dont on veut obtenir la référence </param>
        /// <returns> Référence de la marque </returns>
        public int GetRefByName(String Nom)
        {
            //ouverture de la connexion avec la bdd & creation de la requete

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefMarque from marques where Nom= ('" + Nom + "')";
            //Console.WriteLine(Sql);

            int Ref = -1;

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    //récupération de la référence
                    Reader.Read();
                    Ref = Reader.GetInt32(0);
                }
            }

            //fermeture de la connextion
            M_dbConnection.Close();

            return Ref;
        }

        /// <summary>
        /// DAO pour récupérer le nom d'une marque en fonction de sa référence
        /// </summary>
        /// <param name="Ref"> référence de la marque dont on veut obtenir le nom </param>
        /// <returns> Le nom de la marque </returns>
        public string GetNameByRef(int Ref)
        {

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select Nom from marques where RefMarque=" + Ref;
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
        /// DAO pour vérifier si une marquee existe
        /// </summary>
        /// <param name="Nom"> nom de la marque </param>
        /// <returns> true si la marque existe, false sinon </returns>
        public bool CheckIfExists(String Nom)
        {
            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefMarque from marques where Nom= ('" + Nom + "')";
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
        /// DAO pour récupérer toutes les marques dans la base de donnees 
        /// </summary>
        /// <returns> la liste de tous les noms </returns>
        public List<Marques> GetAllMarques()
        {
            List<Marques> AllMarques = new List<Marques>();

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefMarque, Nom from Marques";
           // Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Marques m = new Marques(Reader.GetInt32(0), Reader.GetString(1));
                        AllMarques.Add(m);
                    }
                }
            }

            M_dbConnection.Close();

            return AllMarques;
        }

        /// <summary>
        /// Renvoie le nombre de marques présentes dans la bdd
        /// </summary>
        /// <returns></returns>
        public int CountAllMarques()
        {
            int Total = 0;

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select COUNT(*) from Marques";

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
