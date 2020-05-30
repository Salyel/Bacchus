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
        public ModaleExporter()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ExportButtonController Controller = new ExportButtonController(this);
        }

        public void SetProgressBarValue(int Value)
        {
            ProgressBar.Value = Value;
        }

        public Label GetLabelFileName()
        {
            return LabelFileName;
        }
    }
}
