using Bacchus.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.Controller
{
    /// <summary>
    /// Constroller pour l'importation d'un fichier SQLite
    /// </summary>
    class ImportButtonController
    {
        //Attributs

        private ModaleImporter Modale;


        //Constructeur

        /// <summary>
        /// Lancement de l'importation
        /// </summary>
        /// <param name="Modale"> fenetre d'importation </param>
        public ImportButtonController(ModaleImporter Modale)
        {
            this.Modale = Modale;
            //si on a pas choisi un mode d'importation
            if (Modale.GetButtonsValue().Equals("") || Modale.GetPathToImport().Equals("") || Modale.GetPathToSave().Equals(""))
            {
                Modale.GetLabelImport().Text = "Veuillez choisir un mode d'intégration pour la base de données, un fichier .csv à importer et un fichier .sqlite dans lequel le fichier .csv sera importé.";
            }

            else
            {
                //import en mode ecrasement
                if (Modale.GetButtonsValue().Equals("Ecrasement"))
                {
                    Modale.GetLabelImport().Text = "Import en mode Ecrasement en cours ...";
                    ImporterEcrasement ImportEcrasement = new ImporterEcrasement(Modale);
                }
                //import en mode ajout
                else if (Modale.GetButtonsValue().Equals("Ajout"))
                {
                    Modale.GetLabelImport().Text = "Import en mode Ajout en cours ...";
                    ImporterAjout ImportAjout = new ImporterAjout(Modale);
                }

                //mise à jour de la treeView
                InitializeTreeView initializeTree = new InitializeTreeView(Modale.GetFormMain().GetTreeView());
                initializeTree.ConstructTree(Modale.GetPathToSave());

                //stockage du chemin de la bdd
                Modale.GetFormMain().SetPathToSave(Modale.GetPathToSave());

                //mise à jour du statusStrip
                ToolStatusStripController FamilleStripControl = new ToolStatusStripController(Modale.GetFormMain().GetToolStatusStrip("Familles"));
                ToolStatusStripController ArticleStripControl = new ToolStatusStripController(Modale.GetFormMain().GetToolStatusStrip("Article"));
                ToolStatusStripController SousFamilleStripControl = new ToolStatusStripController(Modale.GetFormMain().GetToolStatusStrip("SousFamilles"));
                ToolStatusStripController MarqueStripControl = new ToolStatusStripController(Modale.GetFormMain().GetToolStatusStrip("Marques"));

                ArticlesDAO ArticlesDAO = new ArticlesDAO(Modale.GetPathToSave());
                MarquesDAO MarquesDAO = new MarquesDAO(Modale.GetPathToSave());
                FamillesDAO FamillesDAO = new FamillesDAO(Modale.GetPathToSave());
                SousFamillesDAO SousFamillesDAO = new SousFamillesDAO(Modale.GetPathToSave());

                ArticleStripControl.ChangeNumber(ArticlesDAO.CountAllArticles());
                FamilleStripControl.ChangeNumber(FamillesDAO.CountAllFamilles());
                SousFamilleStripControl.ChangeNumber(SousFamillesDAO.CountAllSousFamilles());
                MarqueStripControl.ChangeNumber(MarquesDAO.CountAllMarques());

                
            }
        }
    }
}
