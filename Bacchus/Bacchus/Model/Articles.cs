using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    /// <summary>
    /// Classe qui permet de manipuler les articles
    /// </summary>
    class Articles
    {
        //Attributs
        private String RefArticle;
        private String Description;
        private int RefSousFamille;
        private int RefMarque;
        private float PrixHT;
        private int Quantite;

        //Constructeurs

        /// <summary>
        /// Constructeur permettant d'instancier un article (avec une référence)
        /// </summary>
        /// <param name="RefArticle"> référence de l'article </param>
        /// <param name="Description"> description de l'article </param>
        /// <param name="RefSousFamille"> référence de la sous famille </param>
        /// <param name="RefMarque"> référence de la marque </param>
        /// <param name="PrixHT"> prix hors taxes </param>
        /// <param name="Quantite"> quantité disponible </param>
        public Articles(String RefArticle, String Description, int RefSousFamille, int RefMarque, float PrixHT, int Quantite)
        {
            this.RefArticle = RefArticle;
            this.Description = Description;
            this.RefSousFamille = RefSousFamille;
            this.RefMarque = RefMarque;
            this.PrixHT = PrixHT;
            this.Quantite = Quantite;
        }

        /// <summary>
        /// Constructeur permettant d'instancier un article (sans référence)
        /// </summary>
        /// <param name="Description"> description de l'article </param>
        /// <param name="RefSousFamille"> référence de la sous famille </param>
        /// <param name="RefMarque"> référence de la marque </param>
        /// <param name="PrixHT"> prix hors taxes </param>
        /// <param name="Quantite"> quantité disponible </param>
        public Articles(String Description, int RefSousFamille, int RefMarque, float PrixHT, int Quantite)
        {
            this.Description = Description;
            this.RefSousFamille = RefSousFamille;
            this.RefMarque = RefMarque;
            this.PrixHT = PrixHT;
            this.Quantite = Quantite;
        }

        //Getters & setters

        public String GetRefArticle()
        {
            return RefArticle;
        }
        public void SetRefArticle(String RefArticle)
        {
            this.RefArticle = RefArticle;
        }

        public String GetDescription()
        {
            return Description;
        }
        public void SetDescription(String Description)
        {
            this.Description = Description;
        }

        public int GetRefSousFamille()
        {
            return RefSousFamille;
        }
        public void SetRefSousFamille(int RefSousFamille)
        {
            this.RefSousFamille = RefSousFamille;
        }

        public int GetRefMarque()
        {
            return RefMarque;
        }
        public void SetRefMarque(int RefMarque)
        {
            this.RefMarque = RefMarque;
        }

        public float GetPrixHT()
        {
            return PrixHT;
        }
        public void SetPrixHT(float PrixHT)
        {
            this.PrixHT = PrixHT;
        }

        public int GetQuantite()
        {
            return Quantite;
        }
        public void SetQuantite(int Quantite)
        {
            this.Quantite = Quantite;
        }
    }
}
