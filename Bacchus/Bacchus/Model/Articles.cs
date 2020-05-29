using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    class Articles
    {
        private String RefArticle;
        private String Description;
        private int RefSousFamille;
        private int RefMarque;
        private float PrixHT;
        private int Quantite;

        public Articles(String RefArticle, String Description, int RefSousFamille, int RefMarque, float PrixHT, int Quantite)
        {
            this.RefArticle = RefArticle;
            this.Description = Description;
            this.RefSousFamille = RefSousFamille;
            this.RefMarque = RefMarque;
            this.PrixHT = PrixHT;
            this.Quantite = Quantite;
        }
        
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
