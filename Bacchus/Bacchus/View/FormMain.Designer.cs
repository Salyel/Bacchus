using Bacchus.Controller;
using Bacchus.Model;
using System;
using System.Data.Entity.Core.Common.EntitySql;
using System.Windows.Forms;
using System.IO;

namespace Bacchus
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string PathToSave = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tous les articles");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Familles");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Marques");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusArticle = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusFamilles = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSousFamilles = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusMarques = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sousFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelAjouter = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.ajouterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(493, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualiserToolStripMenuItem,
            this.importerToolStripMenuItem,
            this.exporterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // actualiserToolStripMenuItem
            // 
            this.actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            this.actualiserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualiserToolStripMenuItem.Text = "Actualiser";
            this.actualiserToolStripMenuItem.Click += new System.EventHandler(this.actualiserToolStripMenuItem_Click);
            // 
            // importerToolStripMenuItem
            // 
            this.importerToolStripMenuItem.Name = "importerToolStripMenuItem";
            this.importerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importerToolStripMenuItem.Text = "Importer";
            this.importerToolStripMenuItem.Click += new System.EventHandler(this.importerToolStripMenuItem_Click);
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exporterToolStripMenuItem.Text = "Exporter";
            this.exporterToolStripMenuItem.Click += new System.EventHandler(this.exporterToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusArticle,
            this.toolStripStatusFamilles,
            this.toolStripStatusSousFamilles,
            this.toolStripStatusMarques});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(882, 26);
            this.statusStrip1.TabIndex = 1;
            // 
            // toolStripStatusArticle
            // 
            this.toolStripStatusArticle.Name = "toolStripStatusArticle";
            this.toolStripStatusArticle.Size = new System.Drawing.Size(146, 20);
            this.toolStripStatusArticle.Text = "Nombre d\'articles : 0";
            // 
            // toolStripStatusFamilles
            // 
            this.toolStripStatusFamilles.Name = "toolStripStatusFamilles";
            this.toolStripStatusFamilles.Size = new System.Drawing.Size(160, 20);
            this.toolStripStatusFamilles.Text = "Nombre de familles : 0";
            // 
            // toolStripStatusSousFamilles
            // 
            this.toolStripStatusSousFamilles.Name = "toolStripStatusSousFamilles";
            this.toolStripStatusSousFamilles.Size = new System.Drawing.Size(195, 20);
            this.toolStripStatusSousFamilles.Text = "Nombre de sous-familles : 0";
            // 
            // toolStripStatusMarques
            // 
            this.toolStripStatusMarques.Name = "toolStripStatusMarques";
            this.toolStripStatusMarques.Size = new System.Drawing.Size(165, 20);
            this.toolStripStatusMarques.Text = "Nombre de marques : 0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(493, 302);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.MinimumSize = new System.Drawing.Size(151, 4);
            this.treeView1.Name = "treeView1";
            treeNode4.Name = "";
            treeNode4.Tag = "articles";
            treeNode4.Text = "Tous les articles";
            treeNode5.Name = "";
            treeNode5.Tag = "familles";
            treeNode5.Text = "Familles";
            treeNode6.Name = "";
            treeNode6.Tag = "marques";
            treeNode6.Text = "Marques";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(234, 302);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Size = new System.Drawing.Size(255, 302);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClickSorting);
            //this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_ItemClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_ItemDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStrip1_ItemClicked);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articleToolStripMenuItem,
            this.marqueToolStripMenuItem,
            this.familleToolStripMenuItem,
            this.sousFamilleToolStripMenuItem});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // articleToolStripMenuItem
            // 
            this.articleToolStripMenuItem.Name = "articleToolStripMenuItem";
            this.articleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.articleToolStripMenuItem.Text = "Article";
            this.articleToolStripMenuItem.Click += new System.EventHandler(this.articleToolStripMenuItem_Click);
            // 
            // marqueToolStripMenuItem
            // 
            this.marqueToolStripMenuItem.Name = "marqueToolStripMenuItem";
            this.marqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marqueToolStripMenuItem.Text = "Marque";
            this.marqueToolStripMenuItem.Click += new System.EventHandler(this.marqueToolStripMenuItem_Click);
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.familleToolStripMenuItem.Text = "Famille";
            this.familleToolStripMenuItem.Click += new System.EventHandler(this.familleToolStripMenuItem_Click);
            // 
            // sousFamilleToolStripMenuItem
            // 
            this.sousFamilleToolStripMenuItem.Name = "sousFamilleToolStripMenuItem";
            this.sousFamilleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sousFamilleToolStripMenuItem.Text = "Sous famille";
            this.sousFamilleToolStripMenuItem.Click += new System.EventHandler(this.sousFamilleToolStripMenuItem_Click);
            // 
            // LabelAjouter
            // 
            this.LabelAjouter.Location = new System.Drawing.Point(122, 0);
            this.LabelAjouter.Name = "LabelAjouter";
            this.LabelAjouter.Size = new System.Drawing.Size(371, 21);
            this.LabelAjouter.TabIndex = 3;
            this.LabelAjouter.Text = "Veuillez ouvrir une base (en important un fichier csv) avant d\'ajouter";
            this.LabelAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(493, 348);
            this.Controls.Add(this.LabelAjouter);

            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Bacchus";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ToolStripStatusLabel toolStripStatusArticle;
        private ToolStripStatusLabel toolStripStatusFamilles;
        private ToolStripStatusLabel toolStripStatusSousFamilles;
        private ToolStripStatusLabel toolStripStatusMarques;


        public TreeView GetTreeView()
        {
            return this.treeView1;
        }

        public string GetPathToSave()
        {
            return this.PathToSave;
        }

        public void SetPathToSave(string PathToSave)
        {
            this.PathToSave = PathToSave;
        }

        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem articleToolStripMenuItem;
        private ToolStripMenuItem marqueToolStripMenuItem;
        private ToolStripMenuItem familleToolStripMenuItem;
        private ToolStripMenuItem sousFamilleToolStripMenuItem;
        private Label LabelAjouter;
        public StatusStrip GetStatusStrip()
        {
            return statusStrip1;
        }

        
    }
}

#endregion