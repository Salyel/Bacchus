using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.Controller
{
    class MenuFichierController
    {
        private FormMain Form;
        private string Type;

        public MenuFichierController(FormMain Form, string Type)
        {
            this.Form = Form;
            this.Type = Type;

            if(Type.Equals("importer"))
            {
                ModaleImporter FenetreImporter = new ModaleImporter();
                FenetreImporter.StartPosition = FormStartPosition.CenterParent;
                FenetreImporter.ShowDialog(Form);
            }
            else if(Type.Equals("exporter"))
            {

            }

        }
    }
}
