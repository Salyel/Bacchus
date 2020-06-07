using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    /// <summary>
    /// Classe qui permet de manipuler les familles
    /// </summary>
    class Familles
    {
        //Attributs
        private int RefFamille;
        private String Nom;

        //Constructeurs

        /// <summary>
        /// Constructeur permettant d'instancier une famille (avec référence)
        /// </summary>
        /// <param name="RefFamille"> référence de la famille </param>
        /// <param name="Nom"> nom de la famille </param>
        public Familles(int RefFamille, String Nom)
        {
            this.RefFamille = RefFamille;
            this.Nom = Nom;
        }

        /// <summary>
        /// Constructeur permettant d'instancier une famille (sans référence)
        /// </summary>
        /// <param name="Nom"> nom de la famille </param>
        public Familles(String Nom)
        {
            this.Nom = Nom;
        }

        //Getters & setters 

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

        public override String ToString()
        {
            return Nom;
        }
    }
}
