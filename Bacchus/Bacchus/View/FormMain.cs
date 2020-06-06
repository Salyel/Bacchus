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

        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (PathToSave != null)
            {
                TreeNode EventNode = e.Node;
                ListViewController Controller = new ListViewController(this.listView1, PathToSave);
                Controller.LoadListView(EventNode);
            }
        }

        void ListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (PathToSave != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.F5:
                        ListViewController Controller = new ListViewController(this.listView1, PathToSave);
                        Controller.LoadListView(treeView1.SelectedNode);
                        break;
                    case Keys.Delete:
                        Console.WriteLine("Suppr");
                        //supprimer la ligne
                        break;
                    case Keys.Return:
                        Console.WriteLine("Entree");
                        //ouvrir la fenêtre de modification
                        break;
                    default:
                        break;
                }
            }
        }

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

        private void ContextMenuStrip_Ajouter(object sender, EventArgs e)
        {
            //ouvrir la fenetre d'ajout
        }

        private void ContextMenuStrip_Modifier(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                //ouvrir la fenetre de modification
            }
        }

        private void ContextMenuStrip_Supprimer(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if(me.Button == MouseButtons.Left)
            {
                //supprimer la ligne
            }
        }

        private void ListView_ItemDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.listView1.SelectedItems.Count > 0)
            {
                //ouvrir la fenêtre de modification
            }
        }
    }
}
