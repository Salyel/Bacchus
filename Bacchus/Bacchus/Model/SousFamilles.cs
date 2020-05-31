using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    /// <summary>
    /// Classe qui permet de manipuler les sous familles
    /// </summary>
    class SousFamilles
    {
        //Attributs

        private int RefSousFamille;
        private int RefFamille;
        private String Nom;

        //Constructeurs

        /// <summary>
        /// Constructeur permettant d'instancier une sous famille (avec référence)
        /// </summary>
        /// <param name="RefSousFamille"> référence de la sous famille </param>
        /// <param name="RefFamille"> référence de la famille </param>
        /// <param name="Nom"> nom de la sous famille </param>
        public SousFamilles(int RefSousFamille, int RefFamille, String Nom)
        {
            this.RefSousFamille = RefSousFamille;
            this.RefFamille = RefFamille;
            this.Nom = Nom;
        }

        /// <summary>
        /// Constructeur permettant d'instancier une sous famille (sans référence)
        /// </summary>
        /// <param name="RefFamille"> référence de la famille </param>
        /// <param name="Nom"> nom de la sous famille </param>
        public SousFamilles(int RefFamille, String Nom)
        {
            this.RefFamille = RefFamille;
            this.Nom = Nom;
        }

        //Getters & setters

        public int GetRefSousFamille()
        {
            return RefSousFamille;
        }
        public void SetRefSousFamille(int RefSousFamille)
        {
            this.RefSousFamille = RefSousFamille;
        }

        public int GetRefFamille()
        {
            return RefFamille;
        }
        public void SetRefFamille(int RefFamille)
        {
            this.RefFamille = RefFamille;
        }

        public String GetNom()
        {
            return Nom;
        }
        public void SetNom(String Nom)
        {
            this.Nom = Nom;
        }
    }
}
