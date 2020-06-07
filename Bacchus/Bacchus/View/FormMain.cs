using Bacchus.Controller;
using Bacchus.Model;
using Bacchus.View;
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
            this.listView1.KeyDown += ListView_KeyDown;
            this.listView1.MouseClick += new MouseEventHandler(this.ListView_ItemClick);
            this.listView1.MouseDoubleClick += new MouseEventHandler(this.ListView_ItemDoubleClick);

            this.contextMenuStrip1 = new ContextMenuStrip();
            contextMenuStrip1.Items.Add("Ajouter");
            contextMenuStrip1.Items.Add("Modifier");
            contextMenuStrip1.Items.Add("Supprimer");
            contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(this.ContextMenuStrip_ItemClicked);
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
            if(PathToSave != null)
            {
                MenuFichierController Menu = new MenuFichierController(this, "actualiser");
            }
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
                            switch (this.listView1.SelectedItems[0].Tag)
                            {
                                case Articles a:
                                    ModifierArticle ModifierA = new ModifierArticle(this, PathToSave);
                                    ModifierA.StartPosition = FormStartPosition.CenterParent;
                                    ModifierA.ShowDialog(this);
                                    break;
                                case Familles f:
                                    ModifierFamille ModifierF = new ModifierFamille(this, PathToSave);
                                    ModifierF.StartPosition = FormStartPosition.CenterParent;
                                    ModifierF.ShowDialog(this);
                                    break;
                                case SousFamilles sf:
                                    ModifierSousFamille ModifierSf = new ModifierSousFamille(this, PathToSave);
                                    ModifierSf.StartPosition = FormStartPosition.CenterParent;
                                    ModifierSf.ShowDialog(this);
                                    break;
                                case Marques m:
                                    ModifierMarque ModifierM = new ModifierMarque(this, PathToSave);
                                    ModifierM.StartPosition = FormStartPosition.CenterParent;
                                    ModifierM.ShowDialog(this);
                                    break;
                                default:
                                    break;
                            }
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
                case "Ajouter":
                    if (this.listView1.SelectedItems.Count > 0)
                    {
                        switch (this.listView1.SelectedItems[0].Tag)
                        {
                            case Articles a:
                                AjouterArticle AjouterA = new AjouterArticle(this, PathToSave);
                                AjouterA.StartPosition = FormStartPosition.CenterParent;
                                AjouterA.ShowDialog(this);
                                break;
                            case Familles f:
                                AjouterFamille AjouterF = new AjouterFamille(this, PathToSave);
                                AjouterF.StartPosition = FormStartPosition.CenterParent;
                                AjouterF.ShowDialog(this);
                                break;
                            case SousFamilles sf:
                                AjouterSousFamille AjouterSf = new AjouterSousFamille(this, PathToSave);
                                AjouterSf.StartPosition = FormStartPosition.CenterParent;
                                AjouterSf.ShowDialog(this);
                                break;
                            case Marques m:
                                AjouterMarque AjouterM = new AjouterMarque(this, PathToSave);
                                AjouterM.StartPosition = FormStartPosition.CenterParent;
                                AjouterM.ShowDialog(this);
                                break;
                            default:
                                break;
                        }
                    }
                    break;

                case "Modifier":
                    if (this.listView1.SelectedItems.Count > 0)
                    {
                        switch (this.listView1.SelectedItems[0].Tag)
                        {
                            case Articles a:
                                ModifierArticle ModifierA = new ModifierArticle(this, PathToSave);
                                ModifierA.StartPosition = FormStartPosition.CenterParent;
                                ModifierA.ShowDialog(this);
                                break;
                            case Familles f:
                                ModifierFamille ModifierF = new ModifierFamille(this, PathToSave);
                                ModifierF.StartPosition = FormStartPosition.CenterParent;
                                ModifierF.ShowDialog(this);
                                break;
                            case SousFamilles sf:
                                ModifierSousFamille ModifierSf = new ModifierSousFamille(this, PathToSave);
                                ModifierSf.StartPosition = FormStartPosition.CenterParent;
                                ModifierSf.ShowDialog(this);
                                break;
                            case Marques m:
                                ModifierMarque ModifierM = new ModifierMarque(this, PathToSave);
                                ModifierM.StartPosition = FormStartPosition.CenterParent;
                                ModifierM.ShowDialog(this);
                                break;
                            default:
                                break;
                        }
                    }
                    break;

                case "Supprimer":
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
            if (this.listView1.SelectedItems.Count > 0)
            {
                switch (this.listView1.SelectedItems[0].Tag)
                {
                    case Articles a:
                        ModifierArticle ModifierA = new ModifierArticle(this, PathToSave);
                        ModifierA.StartPosition = FormStartPosition.CenterParent;
                        ModifierA.ShowDialog(this);
                        break;
                    case Familles f:
                        ModifierFamille ModifierF = new ModifierFamille(this, PathToSave);
                        ModifierF.StartPosition = FormStartPosition.CenterParent;
                        ModifierF.ShowDialog(this);
                        break;
                    case SousFamilles sf:
                        ModifierSousFamille ModifierSf = new ModifierSousFamille(this, PathToSave);
                        ModifierSf.StartPosition = FormStartPosition.CenterParent;
                        ModifierSf.ShowDialog(this);
                        break;
                    case Marques m:
                        ModifierMarque ModifierM = new ModifierMarque(this, PathToSave);
                        ModifierM.StartPosition = FormStartPosition.CenterParent;
                        ModifierM.ShowDialog(this);
                        break;
                    default:
                        break;
                }
            };
        }

        private void listView1_ColumnClickSorting(object sender, ColumnClickEventArgs e)
        {
            Controller.ListViewController listViewController = new ListViewController(this.listView1, this.GetPathToSave());
            listViewController.SortingListView(e.Column);
        }

        public ListView GetListView()
        {
            return this.listView1;
        }

        private void articleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PathToSave != null)
            {
                MenuAjouterController Menu = new MenuAjouterController(this, "article");
            }
        }

        private void marqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PathToSave != null)
            {
                MenuAjouterController Menu = new MenuAjouterController(this, "marque");
            }
        }

        private void familleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PathToSave != null)
            {
                MenuAjouterController Menu = new MenuAjouterController(this, "famille");
            }
        }

        private void sousFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PathToSave != null)
            {
                MenuAjouterController Menu = new MenuAjouterController(this, "sous famille");
            }
        }

        public Label GetLabelAjouter()
        {
            return LabelAjouter;
        }
    }
}
