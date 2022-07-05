namespace GroupExercices
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdditionneur = new System.Windows.Forms.ToolStripMenuItem();
            this.phase2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormulaire = new System.Windows.Forms.ToolStripMenuItem();
            this.phase3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCaractere = new System.Windows.Forms.ToolStripMenuItem();
            this.menuElement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCouleur = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dateStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastActionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.phase1ToolStripMenuItem,
            this.phase2ToolStripMenuItem,
            this.phase3ToolStripMenuItem,
            this.fenêtresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Checked = true;
            this.connectionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.connectionToolStripMenuItem.Text = "Connexion";
            // 
            // sidentifierToolStripMenuItem
            // 
            this.sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            this.sidentifierToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sidentifierToolStripMenuItem.Text = "S\'identifier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // phase1ToolStripMenuItem
            // 
            this.phase1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdditionneur});
            this.phase1ToolStripMenuItem.Name = "phase1ToolStripMenuItem";
            this.phase1ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.phase1ToolStripMenuItem.Text = "Phase1";
            // 
            // menuAdditionneur
            // 
            this.menuAdditionneur.Name = "menuAdditionneur";
            this.menuAdditionneur.Size = new System.Drawing.Size(144, 22);
            this.menuAdditionneur.Text = "Additionneur";
            this.menuAdditionneur.Click += new System.EventHandler(this.AppClickOpener);
            // 
            // phase2ToolStripMenuItem
            // 
            this.phase2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormulaire});
            this.phase2ToolStripMenuItem.Name = "phase2ToolStripMenuItem";
            this.phase2ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.phase2ToolStripMenuItem.Text = "Phase2";
            // 
            // menuFormulaire
            // 
            this.menuFormulaire.Name = "menuFormulaire";
            this.menuFormulaire.Size = new System.Drawing.Size(131, 22);
            this.menuFormulaire.Text = "Formulaire";
            this.menuFormulaire.Click += new System.EventHandler(this.AppClickOpener);
            // 
            // phase3ToolStripMenuItem
            // 
            this.phase3ToolStripMenuItem.Checked = true;
            this.phase3ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.phase3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCaractere,
            this.menuElement,
            this.menuCouleur});
            this.phase3ToolStripMenuItem.Name = "phase3ToolStripMenuItem";
            this.phase3ToolStripMenuItem.ShowShortcutKeys = false;
            this.phase3ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.phase3ToolStripMenuItem.Text = "Phase3";
            // 
            // menuCaractere
            // 
            this.menuCaractere.Name = "menuCaractere";
            this.menuCaractere.Size = new System.Drawing.Size(180, 22);
            this.menuCaractere.Text = "Caractere";
            this.menuCaractere.Click += new System.EventHandler(this.AppClickOpener);
            // 
            // menuElement
            // 
            this.menuElement.Name = "menuElement";
            this.menuElement.Size = new System.Drawing.Size(180, 22);
            this.menuElement.Text = "Element ";
            this.menuElement.Click += new System.EventHandler(this.AppClickOpener);
            // 
            // menuCouleur
            // 
            this.menuCouleur.Name = "menuCouleur";
            this.menuCouleur.Size = new System.Drawing.Size(180, 22);
            this.menuCouleur.Text = "Couleur";
            this.menuCouleur.Click += new System.EventHandler(this.AppClickOpener);
            // 
            // fenêtresToolStripMenuItem
            // 
            this.fenêtresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.toolStripSeparator1});
            this.fenêtresToolStripMenuItem.Name = "fenêtresToolStripMenuItem";
            this.fenêtresToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fenêtresToolStripMenuItem.Text = "Fenêtres";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateStatus,
            this.lastActionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dateStatus
            // 
            this.dateStatus.Name = "dateStatus";
            this.dateStatus.Size = new System.Drawing.Size(118, 17);
            this.dateStatus.Text = "toolStripStatusLabel1";
            // 
            // lastActionStatus
            // 
            this.lastActionStatus.Name = "lastActionStatus";
            this.lastActionStatus.Size = new System.Drawing.Size(118, 17);
            this.lastActionStatus.Text = "toolStripStatusLabel2";
            this.lastActionStatus.Visible = false;
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripMenuItem phase1ToolStripMenuItem;
        private ToolStripMenuItem phase2ToolStripMenuItem;
        private ToolStripMenuItem phase3ToolStripMenuItem;
        private ToolStripMenuItem fenêtresToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel dateStatus;
        private ToolStripStatusLabel lastActionStatus;
        private ToolStripMenuItem menuAdditionneur;
        private ToolStripMenuItem menuFormulaire;
        private ToolStripMenuItem menuCaractere;
        private ToolStripMenuItem menuElement;
        private ToolStripMenuItem menuCouleur;
        private ToolStripMenuItem sidentifierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}