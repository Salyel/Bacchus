using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    class SousFamilles
    {
        private int RefSousFamille;
        private int RefFamille;
        private String Nom;

        public SousFamilles(int RefSousFamille, int RefFamille, String Nom)
        {
            this.RefSousFamille = RefSousFamille;
            this.RefFamille = RefFamille;
            this.Nom = Nom;
        }

        public SousFamilles(int RefFamille, String Nom)
        {
            this.RefFamille = RefFamille;
            this.Nom = Nom;
        }

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
