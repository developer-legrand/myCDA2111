namespace WinFormToutEmbal
{
    partial class frmToutEmbal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.démarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarProdA = new System.Windows.Forms.ProgressBar();
            this.progressBarProdB = new System.Windows.Forms.ProgressBar();
            this.progressBarProdC = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBoxA = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBoxB = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBoxC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProdA = new System.Windows.Forms.Label();
            this.lblProdB = new System.Windows.Forms.Label();
            this.lblProdC = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabBox = new System.Windows.Forms.TabControl();
            this.tabBoxA = new System.Windows.Forms.TabPage();
            this.tabBoxB = new System.Windows.Forms.TabPage();
            this.tabBoxC = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.démarrerToolStripMenuItem,
            this.arrêterToolStripMenuItem,
            this.continuerToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // démarrerToolStripMenuItem
            // 
            this.démarrerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem});
            this.démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
            this.démarrerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.démarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aToolStripMenuItem.Text = "A";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bToolStripMenuItem.Text = "B";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem.Text = "C";
            // 
            // arrêterToolStripMenuItem
            // 
            this.arrêterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem1,
            this.bToolStripMenuItem1,
            this.cToolStripMenuItem1});
            this.arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            this.arrêterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arrêterToolStripMenuItem.Text = "Arrêter";
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aToolStripMenuItem1.Text = "A";
            // 
            // bToolStripMenuItem1
            // 
            this.bToolStripMenuItem1.Name = "bToolStripMenuItem1";
            this.bToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bToolStripMenuItem1.Text = "B";
            // 
            // cToolStripMenuItem1
            // 
            this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            this.cToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem1.Text = "C";
            // 
            // continuerToolStripMenuItem
            // 
            this.continuerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem2,
            this.bToolStripMenuItem2,
            this.cToolStripMenuItem2});
            this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            this.continuerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.continuerToolStripMenuItem.Text = "continuer";
            // 
            // aToolStripMenuItem2
            // 
            this.aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            this.aToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.aToolStripMenuItem2.Text = "A";
            // 
            // bToolStripMenuItem2
            // 
            this.bToolStripMenuItem2.Name = "bToolStripMenuItem2";
            this.bToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.bToolStripMenuItem2.Text = "B";
            // 
            // cToolStripMenuItem2
            // 
            this.cToolStripMenuItem2.Name = "cToolStripMenuItem2";
            this.cToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem2.Text = "C";
            // 
            // progressBarProdA
            // 
            this.progressBarProdA.Location = new System.Drawing.Point(175, 286);
            this.progressBarProdA.Name = "progressBarProdA";
            this.progressBarProdA.Size = new System.Drawing.Size(545, 10);
            this.progressBarProdA.TabIndex = 1;
            // 
            // progressBarProdB
            // 
            this.progressBarProdB.Location = new System.Drawing.Point(175, 310);
            this.progressBarProdB.Name = "progressBarProdB";
            this.progressBarProdB.Size = new System.Drawing.Size(545, 10);
            this.progressBarProdB.TabIndex = 2;
            // 
            // progressBarProdC
            // 
            this.progressBarProdC.Location = new System.Drawing.Point(175, 334);
            this.progressBarProdC.Name = "progressBarProdC";
            this.progressBarProdC.Size = new System.Drawing.Size(545, 10);
            this.progressBarProdC.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBoxA,
            this.statusBoxB,
            this.statusBoxC,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBoxA
            // 
            this.statusBoxA.Name = "statusBoxA";
            this.statusBoxA.Size = new System.Drawing.Size(57, 17);
            this.statusBoxA.Text = "Caisse A :";
            // 
            // statusBoxB
            // 
            this.statusBoxB.Name = "statusBoxB";
            this.statusBoxB.Size = new System.Drawing.Size(56, 17);
            this.statusBoxB.Text = "Caisse B :";
            // 
            // statusBoxC
            // 
            this.statusBoxC.Name = "statusBoxC";
            this.statusBoxC.Size = new System.Drawing.Size(57, 17);
            this.statusBoxC.Text = "Caisse C :";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel4.Text = "Date Time Here";
            // 
            // lblProdA
            // 
            this.lblProdA.AutoSize = true;
            this.lblProdA.Location = new System.Drawing.Point(34, 281);
            this.lblProdA.Name = "lblProdA";
            this.lblProdA.Size = new System.Drawing.Size(77, 15);
            this.lblProdA.TabIndex = 6;
            this.lblProdA.Text = "Production A";
            // 
            // lblProdB
            // 
            this.lblProdB.AutoSize = true;
            this.lblProdB.Location = new System.Drawing.Point(36, 305);
            this.lblProdB.Name = "lblProdB";
            this.lblProdB.Size = new System.Drawing.Size(76, 15);
            this.lblProdB.TabIndex = 7;
            this.lblProdB.Text = "Production B";
            // 
            // lblProdC
            // 
            this.lblProdC.AutoSize = true;
            this.lblProdC.Location = new System.Drawing.Point(36, 329);
            this.lblProdC.Name = "lblProdC";
            this.lblProdC.Size = new System.Drawing.Size(77, 15);
            this.lblProdC.TabIndex = 8;
            this.lblProdC.Text = "Production C";
            // 
            // tabBox
            // 
            this.tabBox.Controls.Add(this.tabBoxA);
            this.tabBox.Controls.Add(this.tabBoxB);
            this.tabBox.Controls.Add(this.tabBoxC);
            this.tabBox.Location = new System.Drawing.Point(175, 52);
            this.tabBox.Name = "tabBox";
            this.tabBox.SelectedIndex = 0;
            this.tabBox.Size = new System.Drawing.Size(545, 186);
            this.tabBox.TabIndex = 9;
            // 
            // tabBoxA
            // 
            this.tabBoxA.Location = new System.Drawing.Point(4, 24);
            this.tabBoxA.Name = "tabBoxA";
            this.tabBoxA.Padding = new System.Windows.Forms.Padding(3);
            this.tabBoxA.Size = new System.Drawing.Size(537, 158);
            this.tabBoxA.TabIndex = 0;
            this.tabBoxA.Text = "Caisse A";
            this.tabBoxA.UseVisualStyleBackColor = true;
            // 
            // tabBoxB
            // 
            this.tabBoxB.Location = new System.Drawing.Point(4, 24);
            this.tabBoxB.Name = "tabBoxB";
            this.tabBoxB.Padding = new System.Windows.Forms.Padding(3);
            this.tabBoxB.Size = new System.Drawing.Size(537, 158);
            this.tabBoxB.TabIndex = 1;
            this.tabBoxB.Text = "Caisse B";
            this.tabBoxB.UseVisualStyleBackColor = true;
            // 
            // tabBoxC
            // 
            this.tabBoxC.Location = new System.Drawing.Point(4, 24);
            this.tabBoxC.Name = "tabBoxC";
            this.tabBoxC.Padding = new System.Windows.Forms.Padding(3);
            this.tabBoxC.Size = new System.Drawing.Size(537, 158);
            this.tabBoxC.TabIndex = 2;
            this.tabBoxC.Text = "Caisse C";
            this.tabBoxC.UseVisualStyleBackColor = true;
            // 
            // frmToutEmbal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabBox);
            this.Controls.Add(this.lblProdC);
            this.Controls.Add(this.lblProdB);
            this.Controls.Add(this.lblProdA);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBarProdC);
            this.Controls.Add(this.progressBarProdB);
            this.Controls.Add(this.progressBarProdA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmToutEmbal";
            this.Text = "ToutEmbal";
            this.Load += new System.EventHandler(this.frmToutEmbal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem démarrerToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem bToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem arrêterToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem1;
        private ToolStripMenuItem bToolStripMenuItem1;
        private ToolStripMenuItem cToolStripMenuItem1;
        private ToolStripMenuItem continuerToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem2;
        private ToolStripMenuItem bToolStripMenuItem2;
        private ToolStripMenuItem cToolStripMenuItem2;
        private ProgressBar progressBarProdA;
        private ProgressBar progressBarProdB;
        private ProgressBar progressBarProdC;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusBoxA;
        private ToolStripStatusLabel statusBoxB;
        private ToolStripStatusLabel statusBoxC;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private Label lblProdA;
        private Label lblProdB;
        private Label lblProdC;
        private System.Windows.Forms.Timer timer1;
        private TabControl tabBox;
        private TabPage tabBoxA;
        private TabPage tabBoxB;
        private TabPage tabBoxC;
    }
}