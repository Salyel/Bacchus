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
using System.Workflow.ComponentModel;

namespace Bacchus
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFichierController Menu = new MenuFichierController(this, "importer");
        }

        private void exporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFichierController Menu = new MenuFichierController(this, "exporter");
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        /// <summary>
        /// Handler pour le click sur les nodes de la treeview. Affiche la listview correspondante.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (PathToSave != null)
            {
                TreeNode EventNode = e.Node;
                ListViewController Controller = new ListViewController(this.listView1, PathToSave);
                Controller.LoadListView(EventNode);
            }
        }

        /// <summary>
        /// Handler pour l'appui d'une touche sur la listview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (PathToSave != null)
            {
                ListViewController Controller = new ListViewController(this.listView1, PathToSave);

                switch (e.KeyCode)
                {
                    case Keys.F5:
                        Controller.LoadListView(treeView1.SelectedNode);
                        break;

                    case Keys.Delete:
                        if(this.listView1.SelectedItems.Count > 0)
                            Controller.DeleteSelectedItem(this.treeView1.SelectedNode);
                        break;

                    case Keys.Return:
                        Console.WriteLine("Entree");
                        if(this.listView1.SelectedItems.Count > 0)
                        {
                            //ouvrir la fenêtre de modification
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Handler pour le click droit sur un item de la listview. Affiche un menu contextuel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_ItemClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    this.contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        /// <summary>
        /// Handler pour un click dans le menu contextuel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ListViewController Controller = new ListViewController(this.listView1, PathToSave);

            switch (e.ClickedItem.Text)
            {
                case "Ajouter article":
                    //ouvrir fenetre d'ajout
                    break;

                case "Modifier article":
                    //ouvrir fenetre de modification
                    break;

                case "Supprimer article":
                    Controller.DeleteSelectedItem(this.treeView1.SelectedNode);
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Handler pour le double click sur un item de la listview. Ouvre la fenêtre de modification.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_ItemDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.listView1.SelectedItems.Count > 0)
            {
                //ouvrir la fenêtre de modification
            }
        }
    }
}
