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
    /// Controller pour le menu ajouter de la fenetre principal
    /// </summary>
    class MenuAjouterController
    {
        //Attributs

        private FormMain Form;
        private string Type;

        //Constructeur

        /// <summary>
        /// Controller pour le menu ajouter de la fenetre principale
        /// </summary>
        /// <param name="Form"> fenetre principale </param>
        /// <param name="Type"> nom du bouton </param>
        public MenuAjouterController(FormMain Form, string Type)
        {
            this.Form = Form;
            this.Type = Type;

            if (Type.Equals("article"))
            {
                AjouterArticle AjouterA = new AjouterArticle(Form, Form.GetPathToSave());
                AjouterA.StartPosition = FormStartPosition.CenterParent;
                AjouterA.ShowDialog(Form);
            }
            else if (Type.Equals("marque"))
            {
                AjouterMarque AjouterM = new AjouterMarque(Form, Form.GetPathToSave());
                AjouterM.StartPosition = FormStartPosition.CenterParent;
                AjouterM.ShowDialog(Form);
            }
            else if (Type.Equals("famille"))
            {
                AjouterFamille AjouterF = new AjouterFamille(Form, Form.GetPathToSave());
                AjouterF.StartPosition = FormStartPosition.CenterParent;
                AjouterF.ShowDialog(Form);
            }
            else if (Type.Equals("sous famille"))
            {
                AjouterSousFamille AjouterSf = new AjouterSousFamille(Form, Form.GetPathToSave());
                AjouterSf.StartPosition = FormStartPosition.CenterParent;
                AjouterSf.ShowDialog(Form);
            }

        }
    }
}
