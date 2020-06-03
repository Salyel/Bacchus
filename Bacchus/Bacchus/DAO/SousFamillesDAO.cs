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
    /// Classe DAO pour les objets de la classe SousFamille
    /// </summary>
    class SousFamillesDAO
    {
        /*TODO : Rajouter une gestion des exceptions*/

        //Attribut

        private string DatabasePath;

        //Constructeur

        /// <summary>
        /// Constructeur pour le DAO des sous familles
        /// </summary>
        /// <param name="Path"> Chemin vers le fichier SQLite </param>
        public SousFamillesDAO(string Path)
        {
            DatabasePath = Path;
        }

        //Méthodes

        /// <summary>
        /// DAO pour ajouter une sous famille dans la base de données
        /// </summary>
        /// <param name="SousFamille"> Objet SousFamille à ajouter </param>
        public void AjouterSousFamille(SousFamilles SousFamille)
        {
            //ouverture de la connexion avec la bdd & creation de la requete

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "insert into Sousfamilles (Nom, RefFamille) values ('" + SousFamille.GetNom() + "'" + ", " + SousFamille.GetRefFamille() + ")";
            //Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }

            M_dbConnection.Close();
        }

        /// <summary>
        /// DAO pour récupérer la référence d'une sous famille en fonction de son nom
        /// </summary>
        /// <param name="Nom"> Nom de la sous famille dont on veut obtenir la référence </param>
        /// <returns> Référence de la sous famille </returns>
        public int GetRefByName(String Nom)
        {
            //ouverture de la connexion avec la bdd & creation de la requete

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefSousFamille from sousfamilles where Nom= ('" + Nom + "')";
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

            //fermeture de la connexion
            M_dbConnection.Close();

            return Ref;
        }

        /// <summary>
        /// DAO pour récupérer le nom d'une sous famille en fonction de sa référence
        /// </summary>
        /// <param name="Ref"> référence de la sous famille dont on veut obtenir le nom </param>
        /// <returns> Le nom de la sous famille </returns>
        public string GetNameByRef(int Ref)
        {
            // ouverture de la connexion avec la bdd &creation de la requete

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select Nom from sousfamilles where RefSousFamille=" + Ref;
            //Console.WriteLine(Sql);

            string Nom = "";

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    //récupération du nom
                    Reader.Read();
                    Nom = Reader.GetString(0);
                }
            }

            //fermeture de la connexion
            M_dbConnection.Close();

            return Nom;
        }

        /// <summary>
        /// DAO pour récupérer le nom de la famille à laquelle appartient la sous famille
        /// </summary>
        /// <param name="Ref"> référence de la sous famille </param>
        /// <returns> le nom de la famille </returns>
        public string GetFamilleNameBySousFamilleRef(int Ref)
        {
            // ouverture de la connexion avec la bdd & creation de la requete

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefFamille from sousfamilles where RefSousFamille=" + Ref;
            //Console.WriteLine(Sql);

            int RefFamille = -1;

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    //récupération de la référence de la famille
                    Reader.Read();
                    RefFamille = Reader.GetInt32(0);
                }
            }

            //fermeture de la connexion
            M_dbConnection.Close();

            //récupération du nom de la famille à partir de la référence
            FamillesDAO FamilleD = new FamillesDAO(DatabasePath);
            string Nom = FamilleD.GetNameByRef(RefFamille);

            return Nom;
        }

        /// <summary>
        /// DAO pour vérifier si une sous famille existe
        /// </summary>
        /// <param name="Nom"> nom de la sous famille </param>
        /// <returns> true si la sous famille existe, false sinon </returns>
        public bool CheckIfExists(String Nom)
        {
            // ouverture de la connexion avec la bdd & creation de la requete

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "select RefSousFamille from SousFamilles where Nom= ('" + Nom + "')";
            //Console.WriteLine(Sql);

            bool Exists = true;

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                using (SQLiteDataReader Reader = Command.ExecuteReader())
                {
                    //on vérifie si la sous famille existe
                    Reader.Read();
                    if (Reader == null || !Reader.HasRows)
                    {
                        Exists = false;
                    }
                }
            }

            //fermeture de la connexion
            M_dbConnection.Close();

            return Exists;
        }

        /// <summary>
        /// DAO pour update la référence d'une sous famille
        /// </summary>
        /// <param name="RefFamille"></param>
        /// <param name="Nom"></param>
        public void Update(int RefFamille, string Nom)
        {
            // ouverture de la connexion avec la bdd & creation de la requete

            SQLiteConnection M_dbConnection = new SQLiteConnection("Data Source=" + DatabasePath);

            M_dbConnection.Open();

            String Sql = "update Sousfamilles set RefFamille=" + RefFamille + " where Nom=" + "'" + Nom + "'";
            //Console.WriteLine(Sql);

            using (SQLiteCommand Command = new SQLiteCommand(Sql, M_dbConnection))
            {
                Command.ExecuteNonQuery();
            }

            //fermeture de la connexion
            M_dbConnection.Close();
        }
    }
}
