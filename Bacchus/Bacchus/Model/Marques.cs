using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    class Marques
    {
        private int RefMarque;
        private String Nom;

        public Marques(int RefMarque, String Nom)
        {
            this.RefMarque = RefMarque;
            this.Nom = Nom;
        }

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
    }
}
}
