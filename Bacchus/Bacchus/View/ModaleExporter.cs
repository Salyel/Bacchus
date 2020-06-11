using Bacchus.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.View
{
    /// <summary>
    /// Classe gérant la fenetre d'importation
    /// </summary>
    public partial class ModaleExporter : Form
    {
        //Attributs

        private string PathToSave = "";
        private string PathToExport = "";

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ModaleExporter()
        {
            InitializeComponent();
        }

        //fonction chargées dans les handler

        private void Button_Click(object sender, EventArgs e)
        {
            ChooseSQLButtonControllerExport Controller = new ChooseSQLButtonControllerExport(this);
        }

        private void CsvButton_Click(object sender, EventArgs e)
        {
            ChooseCSVButtonControllerExport Controller = new ChooseCSVButtonControllerExport(this);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportButtonController Controller = new ExportButtonController(this);
        }

        //Getters & setters

        public void SetProgressBarValue(int Value)
        {
            ProgressBar.Value = Value;
        }

        public Label GetLabelFileName()
        {
            return LabelFileName;
        }

        public Label GetLabelFileNameSave()
        {
            return LabelCsv;
        }

        public Label GetLabelExport()
        {
            return LabelExport;
        }      

        public string GetPathToSave()
        {
            return PathToSave;
        }

        public void SetPathToSave(string Path)
        {
            PathToSave = Path;
        }

        public string GetPathToExport()
        {
            return PathToExport;
        }

        public void SetPathToExport(string Path)
        {
            PathToExport = Path;
        }

    }
}
