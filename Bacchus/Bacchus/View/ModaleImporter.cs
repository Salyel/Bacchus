using Bacchus.Controller;
using Bacchus.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus
{
    public partial class ModaleImporter : Form
    {
        /*Attributs*/
        private String ButtonsValue = "";
        private string PathToImport = "";
        private string PathToSave = "";

        /*Constructor*/
        public ModaleImporter()
        {
            InitializeComponent();
        }


        /*Other methods*/
        private void button1_Click(object sender, EventArgs e)
        {
            SelectCSVButtonImportController Controller = new SelectCSVButtonImportController(this);
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ImportButtonController Controller = new ImportButtonController(this);
        }

        private void SQLButton_Click(object sender, EventArgs e)
        {
            SelectSQLButtonImportController Controller = new SelectSQLButtonImportController(this);
        }

        private void CrushRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ButtonsValue = "Ecrasement";
        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ButtonsValue = "Ajout";
        }

        public void SetProgressBarValue(int Value)
        {
            ProgressBar.Value = Value;
        }

        public string GetButtonsValue()
        {
            return ButtonsValue;
        }

        public Label GetLabelFileName()
        {
            return LabelFileName;
        }

        public Label GetLabelImport()
        {
            return LabelImport;
        }

        public Label GetLabelSQL()
        {
            return LabelSQL;
        }

        public string GetPathToSave()
        {
            return PathToSave;
        }
        public void SetPathToSave(string Path)
        {
            PathToSave = Path;
        }

        public string GetPathToImport()
        {
            return PathToImport;
        }
        public void SetPathToImport(string Path)
        {
            PathToImport = Path;
        }

        private void ModaleImporter_Load(object sender, EventArgs e)
        {

        }
    }
}
