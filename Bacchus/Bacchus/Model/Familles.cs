using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    class Familles
    {
        private int RefFamille;
        private String Nom;

        public Familles(int RefFamille, String Nom)
        {
            this.RefFamille = RefFamille;
            this.Nom = Nom;
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
