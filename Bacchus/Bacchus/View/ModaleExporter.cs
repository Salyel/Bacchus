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
    public partial class ModaleExporter : Form
    {
        private string PathToSave = "";
        private string PathToExport = "";

        public ModaleExporter()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ChooseSQLButtonControllerExport Controller = new ChooseSQLButtonControllerExport(this);
        }

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

        private void CsvButton_Click(object sender, EventArgs e)
        {
            ChooseCSVButtonControllerExport Controller = new ChooseCSVButtonControllerExport(this);
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

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportButtonController Controller = new ExportButtonController(this);
        }
    }
}
