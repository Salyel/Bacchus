using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.DAO
{
    class ImporterAjout
    {
        private OpenFileDialog Picker;
        private ModaleImporter Modale;

        public ImporterAjout(OpenFileDialog Picker, ModaleImporter Modale)
        {
            this.Picker = Picker;
            this.Modale = Modale;
            ImporterBDD();
        }

        public void ImporterBDD()
        {
            MarquesDAO MarquesD = new MarquesDAO();
            FamillesDAO FamillesD = new FamillesDAO();
            SousFamillesDAO SousFamillesD = new SousFamillesDAO();
            ArticlesDAO ArticlesD = new ArticlesDAO();

            List<string> AllMarques = new List<string>();
            List<string> AllFamilles = new List<string>();
            List<string> AllSousFamilles = new List<string>();
            List<string> AllSousFamillesFamilles = new List<string>();          //Pour récupérer la famille des sous familles

            //Pour les articles, on est obligé de tout stocker dans une liste à part car on doit récupérer les Ref des autres objets (donc ils doivent être créés avant)
            List<string> AllArticlesRefArticle = new List<string>();
            List<string> AllArticlesDescription = new List<string>();
            List<string> AllArticlesSousFamilleNom = new List<string>();
            List<string> AllArticlesMarqueNom = new List<string>();
            List<float> AllArticlesPrixHT = new List<float>();

            Modale.SetProgressBarValue(25);
            using (var reader = new StreamReader(Picker.FileName))
            {
                reader.ReadLine();                      //On passe la première ligne (les headers du fichier)
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    if (!AllMarques.Exists(e => e.EndsWith(values[2])))
                        AllMarques.Add(values[2]);
                    if (!AllFamilles.Exists(e => e.EndsWith(values[3])))
                        AllFamilles.Add(values[3]);
                    if (!AllSousFamilles.Exists(e => e.EndsWith(values[4])))
                    {
                        AllSousFamilles.Add(values[4]);
                        AllSousFamillesFamilles.Add(values[3]);
                    }

                    AllArticlesRefArticle.Add(values[1]);
                    AllArticlesDescription.Add(values[0]);
                    AllArticlesMarqueNom.Add(values[2]);
                    AllArticlesSousFamilleNom.Add(values[4]);
                    AllArticlesPrixHT.Add(float.Parse(values[5]));
                }
            }
            Modale.SetProgressBarValue(50);
            for (int Index = 0; Index < AllMarques.Count; Index++)
            {
                if(!MarquesD.CheckIfExists(AllMarques[Index]))
                {
                    Marques Marque = new Marques(AllMarques[Index]);
                    MarquesD.AjouterMarque(Marque);
                }
            }
            Modale.SetProgressBarValue(60);
            for (int Index = 0; Index < AllFamilles.Count; Index++)
            {
                if(!FamillesD.CheckIfExists(AllFamilles[Index]))
                {
                    Familles Famille = new Familles(AllFamilles[Index]);
                    FamillesD.AjouterFamille(Famille);
                }
            }
            Modale.SetProgressBarValue(70);
            for (int Index = 0; Index < AllSousFamilles.Count; Index++)
            {
                //Là je devais m'occuper d'ajouter la sous famille si elle était pas là, ou la modifier si sa famille avait changé (jsp si c'est possible)
                if(!SousFamillesD.CheckIfExists(AllSousFamilles[Index]))
                {
                    SousFamilles SousFamille = new SousFamilles(FamillesD.GetRefByName(AllSousFamillesFamilles[Index]), AllSousFamilles[Index]);
                    SousFamillesD.AjouterSousFamille(SousFamille);
                }
                else
                {
                    SousFamillesD.Update(FamillesD.GetRefByName(AllSousFamillesFamilles[Index]), AllSousFamilles[Index]);
                }
            }
            Modale.SetProgressBarValue(80);
            for (int Index = 0; Index < AllArticlesRefArticle.Count; Index++)
            {
                if(!ArticlesD.CheckIfExists(AllArticlesRefArticle[Index]))
                {
                    int RefSousFamille = SousFamillesD.GetRefByName(AllArticlesSousFamilleNom[Index]);
                    int RefMarque = MarquesD.GetRefByName(AllArticlesMarqueNom[Index]);
                    Articles Article = new Articles(AllArticlesRefArticle[Index], AllArticlesDescription[Index], RefSousFamille, RefMarque, AllArticlesPrixHT[Index], 0);
                    ArticlesD.AjouterArticle(Article);
                }
                else
                {
                    int RefSousFamille = SousFamillesD.GetRefByName(AllArticlesSousFamilleNom[Index]);
                    int RefMarque = MarquesD.GetRefByName(AllArticlesMarqueNom[Index]);
                    ArticlesD.Update(AllArticlesRefArticle[Index], AllArticlesDescription[Index], RefSousFamille, RefMarque, AllArticlesPrixHT[Index], 0);
                }
            }
            Modale.SetProgressBarValue(100);
        }
    }
}
