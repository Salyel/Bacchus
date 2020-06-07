using Bacchus.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.Controller
{
    /// <summary>
    /// Controller pour le menu fichier de la fenetre principal
    /// </summary>
    class MenuFichierController
    {
        //Attributs

        private FormMain Form;
        private string Type;

        //Constructeur

        /// <summary>
        /// Controller pour le menu Fichier de la fenetre principale
        /// </summary>
        /// <param name="Form"> fenetre principale </param>
        /// <param name="Type"> nom du bouton </param>
        public MenuFichierController(FormMain Form, string Type)
        {
            this.Form = Form;
            this.Type = Type;

            if(Type.Equals("importer"))
            {
                ModaleImporter FenetreImporter = new ModaleImporter(Form);
                FenetreImporter.StartPosition = FormStartPosition.CenterParent;
                FenetreImporter.ShowDialog(Form);
            }
            else if(Type.Equals("exporter"))
            {
                ModaleExporter FenetreExporter = new ModaleExporter();
                FenetreExporter.StartPosition = FormStartPosition.CenterParent;
                FenetreExporter.ShowDialog(Form);
            }
            else if(Type.Equals("actualiser"))
            {
                InitializeTreeView TreeViewInit = new InitializeTreeView(Form.GetTreeView());
                TreeViewInit.ConstructTree(Form.GetPathToSave());

                ListViewController ListViewInit = new ListViewController(Form.GetListView(), Form.GetPathToSave());
                ListViewInit.LoadListView(Form.GetTreeView().SelectedNode);
            }

        }
    }
}
