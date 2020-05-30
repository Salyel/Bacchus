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

        /*Constructor*/
        public ModaleImporter()
        {
            InitializeComponent();
        }


        /*Other methods*/
        private void button1_Click(object sender, EventArgs e)
        {
            ImportButtonController Controller = new ImportButtonController(this);
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
    }
}
