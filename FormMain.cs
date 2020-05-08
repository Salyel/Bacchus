using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Permet d'ouvrir une fenetre pour lancer l'importation de la BdD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SousMenuImporter_Click(object sender, EventArgs e)
        {
            FormImporter formImport = new FormImporter();
        }
    }
}
