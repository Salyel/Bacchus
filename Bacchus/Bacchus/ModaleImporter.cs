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
        private String FileName;

        /*Constructor*/
        public ModaleImporter()
        {
            InitializeComponent();
        }


        /*Other methods*/
        private void button1_Click(object sender, EventArgs e)
        {
            String FileName;

            //opening a file selector*
            OpenFileDialog Picker = new OpenFileDialog();
            Picker.Title = "Selectionne ton fichier .csv";
            Picker.InitialDirectory = Directory.GetCurrentDirectory();
            Picker.Filter = "CSV files (*.csv)|*.csv";
            Picker.ShowDialog();

            FileName = Picker.FileName;
            label2.Text = FileName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CrushRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
