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
    /// <summary>
    /// Classe pour importer la base de données en mode ajout
    /// Les éléments communs seront conservées, ceux de la base SQLite qui ne sont pas présents dans la base locale seront ajoutés
    /// </summary>
    class ImporterAjout
    {
        //Atributs

        private ModaleImporter Modale;

        //Constructeur

        /// <summary>
        /// Constructeur permettant de faire l'importation
        /// </summary>
        /// <param name="Modale"> fenêtre d'import </param>
        public ImporterAjout(ModaleImporter Modale)
        {
             this.Modale = Modale;
             ImporterBDD();
        }

        /// <summary>
        /// Importer la base de données SQLite en mode ajout
        /// </summary>
        public void ImporterBDD()
        {
            int NombreArticleAjout = 0;
            int NombreArticleUpdated = 0;

            MarquesDAO MarquesD = new MarquesDAO(Modale.GetPathToSave());
            FamillesDAO FamillesD = new FamillesDAO(Modale.GetPathToSave());
            SousFamillesDAO SousFamillesD = new SousFamillesDAO(Modale.GetPathToSave());
            ArticlesDAO ArticlesD = new ArticlesDAO(Modale.GetPathToSave());

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
            using (var reader = new StreamReader(Modale.GetPathToImport(), Encoding.Default))
            {
                reader.ReadLine();                      //On passe la première ligne (les headers du fichier)
                //On stocke tous dans des listes en parcourant notre fichier, on créera après (on ne stocke qu'une occurence de chaque item)
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
            //Maintenant on crée tout en base 
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
                    NombreArticleAjout++;
                }
                else
                {
                    int RefSousFamille = SousFamillesD.GetRefByName(AllArticlesSousFamilleNom[Index]);
                    int RefMarque = MarquesD.GetRefByName(AllArticlesMarqueNom[Index]);
                    Articles monArticle = ArticlesD.GetArticleByRef(AllArticlesRefArticle[Index]);
                    if (monArticle.GetDescription() != AllArticlesDescription[Index] || monArticle.GetRefSousFamille() != RefSousFamille || monArticle.GetRefMarque() != RefMarque || monArticle.GetPrixHT() != AllArticlesPrixHT[Index])
                    {
                        ArticlesD.Update(AllArticlesRefArticle[Index], AllArticlesDescription[Index], RefSousFamille, RefMarque, AllArticlesPrixHT[Index], 0);
                        NombreArticleUpdated++;
                    }
                }
            }
            Modale.SetProgressBarValue(100);
            Modale.GetLabelImport().Text = "Importation en mode Ajout terminé !";

            string message = NombreArticleAjout + " articles ont été ajoutés à la base de données et " + NombreArticleUpdated + " articles ont été mis à jour.";
            const string caption = "Intégration en mode Ajout terminé !";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }
    }
}
