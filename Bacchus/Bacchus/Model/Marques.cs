using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    /// <summary>
    /// Classe qui permet de manipuler les marques
    /// </summary>
    class Marques
    {
        //Attributs
        private int RefMarque;
        private String Nom;

        //Constructeurs

        /// <summary>
        /// Constructeur permettant d'instancier une marque (avec référence)
        /// </summary>
        /// <param name="RefMarque"> référence de la marque </param>
        /// <param name="Nom"> nom de la marque </param>
        public Marques(int RefMarque, String Nom)
        {
            this.RefMarque = RefMarque;
            this.Nom = Nom;
        }

        /// <summary>
        /// Constructeurs permettant d'instancier une marque (sans référence)
        /// </summary>
        /// <param name="Nom"> nom de la marque </param>
        public Marques(String Nom)
        {
            this.Nom = Nom;
        }

        //Getters & setters

        public int GetRefMarque()
        {
            return RefMarque;
        }
        public void SetRefMarque(int RefMarque)
        {
            this.RefMarque = RefMarque;
        }

        public String GetNom()
        {
            return Nom;
        }
        public void SetNom(String Nom)
        {
            this.Nom = Nom;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}

