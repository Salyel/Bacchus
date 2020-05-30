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
            ImportButtonController Listener = new ImportButtonController(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CrushRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ButtonsValue = "Ecrasement";
        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ButtonsValue = "Ajout";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        public void SetProgressBarValue(int Value)
        {
            ProgressBar.Value = Value;
        }

        public string GetButtonsValue()
        {
            return ButtonsValue;
        }

        public Label GetLabel2()
        {
            return label2;
        }
    }
}
