namespace checkBoxRadioButtonV2
{
    partial class Form1
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
            this.labelInputUserControl = new System.Windows.Forms.Label();
            this.bgCasse = new System.Windows.Forms.GroupBox();
            this.rbMinuscule = new System.Windows.Forms.RadioButton();
            this.rbMajuscule = new System.Windows.Forms.RadioButton();
            this.bgCaractere = new System.Windows.Forms.GroupBox();
            this.rbCaractereRouge = new System.Windows.Forms.RadioButton();
            this.rbCaractereBlanc = new System.Windows.Forms.RadioButton();
            this.rbCaractereNoir = new System.Windows.Forms.RadioButton();
            this.gbChoix = new System.Windows.Forms.GroupBox();
            this.cbCasse = new System.Windows.Forms.CheckBox();
            this.cbCouleurCaractere = new System.Windows.Forms.CheckBox();
            this.cbCouleurFond = new System.Windows.Forms.CheckBox();
            this.tbInputUser = new System.Windows.Forms.TextBox();
            this.bgFond = new System.Windows.Forms.GroupBox();
            this.rbFondRouge = new System.Windows.Forms.RadioButton();
            this.rbFondVert = new System.Windows.Forms.RadioButton();
            this.rbFondBleu = new System.Windows.Forms.RadioButton();
            this.bgCasse.SuspendLayout();
            this.bgCaractere.SuspendLayout();
            this.gbChoix.SuspendLayout();
            this.bgFond.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInputUserControl
            // 
            this.labelInputUserControl.AutoSize = true;
            this.labelInputUserControl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInputUserControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelInputUserControl.Location = new System.Drawing.Point(40, 173);
            this.labelInputUserControl.Name = "labelInputUserControl";
            this.labelInputUserControl.Size = new System.Drawing.Size(0, 28);
            this.labelInputUserControl.TabIndex = 24;
            // 
            // bgCasse
            // 
            this.bgCasse.Controls.Add(this.rbMinuscule);
            this.bgCasse.Controls.Add(this.rbMajuscule);
            this.bgCasse.ForeColor = System.Drawing.Color.Blue;
            this.bgCasse.Location = new System.Drawing.Point(374, 289);
            this.bgCasse.Name = "bgCasse";
            this.bgCasse.Size = new System.Drawing.Size(123, 105);
            this.bgCasse.TabIndex = 23;
            this.bgCasse.TabStop = false;
            this.bgCasse.Text = "Casse";
            this.bgCasse.Visible = false;
            // 
            // rbMinuscule
            // 
            this.rbMinuscule.AutoSize = true;
            this.rbMinuscule.ForeColor = System.Drawing.Color.Black;
            this.rbMinuscule.Location = new System.Drawing.Point(6, 35);
            this.rbMinuscule.Name = "rbMinuscule";
            this.rbMinuscule.Size = new System.Drawing.Size(85, 19);
            this.rbMinuscule.TabIndex = 5;
            this.rbMinuscule.TabStop = true;
            this.rbMinuscule.Text = "Minuscules";
            this.rbMinuscule.UseVisualStyleBackColor = true;
            this.rbMinuscule.CheckedChanged += new System.EventHandler(this.RbCasseSelect);
            // 
            // rbMajuscule
            // 
            this.rbMajuscule.AutoSize = true;
            this.rbMajuscule.ForeColor = System.Drawing.Color.Black;
            this.rbMajuscule.Location = new System.Drawing.Point(6, 70);
            this.rbMajuscule.Name = "rbMajuscule";
            this.rbMajuscule.Size = new System.Drawing.Size(84, 19);
            this.rbMajuscule.TabIndex = 6;
            this.rbMajuscule.TabStop = true;
            this.rbMajuscule.Text = "Majuscules";
            this.rbMajuscule.UseVisualStyleBackColor = true;
            // 
            // bgCaractere
            // 
            this.bgCaractere.Controls.Add(this.rbCaractereRouge);
            this.bgCaractere.Controls.Add(this.rbCaractereBlanc);
            this.bgCaractere.Controls.Add(this.rbCaractereNoir);
            this.bgCaractere.ForeColor = System.Drawing.Color.Blue;
            this.bgCaractere.Location = new System.Drawing.Point(207, 251);
            this.bgCaractere.Name = "bgCaractere";
            this.bgCaractere.Size = new System.Drawing.Size(123, 144);
            this.bgCaractere.TabIndex = 22;
            this.bgCaractere.TabStop = false;
            this.bgCaractere.Text = "Caractères";
            this.bgCaractere.Visible = false;
            // 
            // rbCaractereRouge
            // 
            this.rbCaractereRouge.AutoSize = true;
            this.rbCaractereRouge.ForeColor = System.Drawing.Color.Black;
            this.rbCaractereRouge.Location = new System.Drawing.Point(6, 38);
            this.rbCaractereRouge.Name = "rbCaractereRouge";
            this.rbCaractereRouge.Size = new System.Drawing.Size(59, 19);
            this.rbCaractereRouge.TabIndex = 5;
            this.rbCaractereRouge.TabStop = true;
            this.rbCaractereRouge.Text = "Rouge";
            this.rbCaractereRouge.UseVisualStyleBackColor = true;
            this.rbCaractereRouge.CheckedChanged += new System.EventHandler(this.RbCaractereSelect);
            // 
            // rbCaractereBlanc
            // 
            this.rbCaractereBlanc.AutoSize = true;
            this.rbCaractereBlanc.ForeColor = System.Drawing.Color.Black;
            this.rbCaractereBlanc.Location = new System.Drawing.Point(6, 73);
            this.rbCaractereBlanc.Name = "rbCaractereBlanc";
            this.rbCaractereBlanc.Size = new System.Drawing.Size(54, 19);
            this.rbCaractereBlanc.TabIndex = 6;
            this.rbCaractereBlanc.TabStop = true;
            this.rbCaractereBlanc.Text = "Blanc";
            this.rbCaractereBlanc.UseVisualStyleBackColor = true;
            this.rbCaractereBlanc.CheckedChanged += new System.EventHandler(this.RbCaractereSelect);
            // 
            // rbCaractereNoir
            // 
            this.rbCaractereNoir.AutoSize = true;
            this.rbCaractereNoir.ForeColor = System.Drawing.Color.Black;
            this.rbCaractereNoir.Location = new System.Drawing.Point(6, 108);
            this.rbCaractereNoir.Name = "rbCaractereNoir";
            this.rbCaractereNoir.Size = new System.Drawing.Size(48, 19);
            this.rbCaractereNoir.TabIndex = 7;
            this.rbCaractereNoir.TabStop = true;
            this.rbCaractereNoir.Text = "Noir";
            this.rbCaractereNoir.UseVisualStyleBackColor = true;
            this.rbCaractereNoir.CheckedChanged += new System.EventHandler(this.RbCaractereSelect);
            // 
            // gbChoix
            // 
            this.gbChoix.Controls.Add(this.cbCasse);
            this.gbChoix.Controls.Add(this.cbCouleurCaractere);
            this.gbChoix.Controls.Add(this.cbCouleurFond);
            this.gbChoix.Enabled = false;
            this.gbChoix.ForeColor = System.Drawing.Color.Blue;
            this.gbChoix.Location = new System.Drawing.Point(421, 62);
            this.gbChoix.Name = "gbChoix";
            this.gbChoix.Size = new System.Drawing.Size(160, 102);
            this.gbChoix.TabIndex = 20;
            this.gbChoix.TabStop = false;
            this.gbChoix.Text = "Choix";
            // 
            // cbCasse
            // 
            this.cbCasse.AutoSize = true;
            this.cbCasse.ForeColor = System.Drawing.Color.Black;
            this.cbCasse.Location = new System.Drawing.Point(10, 76);
            this.cbCasse.Name = "cbCasse";
            this.cbCasse.Size = new System.Drawing.Size(56, 19);
            this.cbCasse.TabIndex = 2;
            this.cbCasse.Text = "Casse";
            this.cbCasse.UseVisualStyleBackColor = true;
            this.cbCasse.CheckedChanged += new System.EventHandler(this.CheckBoxSelect);
            // 
            // cbCouleurCaractere
            // 
            this.cbCouleurCaractere.AutoSize = true;
            this.cbCouleurCaractere.ForeColor = System.Drawing.Color.Black;
            this.cbCouleurCaractere.Location = new System.Drawing.Point(10, 50);
            this.cbCouleurCaractere.Name = "cbCouleurCaractere";
            this.cbCouleurCaractere.Size = new System.Drawing.Size(145, 19);
            this.cbCouleurCaractere.TabIndex = 1;
            this.cbCouleurCaractere.Text = "Couleur des caractères";
            this.cbCouleurCaractere.UseVisualStyleBackColor = true;
            this.cbCouleurCaractere.CheckedChanged += new System.EventHandler(this.CheckBoxSelect);
            // 
            // cbCouleurFond
            // 
            this.cbCouleurFond.AutoSize = true;
            this.cbCouleurFond.ForeColor = System.Drawing.Color.Black;
            this.cbCouleurFond.Location = new System.Drawing.Point(10, 24);
            this.cbCouleurFond.Name = "cbCouleurFond";
            this.cbCouleurFond.Size = new System.Drawing.Size(112, 19);
            this.cbCouleurFond.TabIndex = 0;
            this.cbCouleurFond.Tag = "";
            this.cbCouleurFond.Text = "Couleur de fond";
            this.cbCouleurFond.UseVisualStyleBackColor = true;
            this.cbCouleurFond.CheckedChanged += new System.EventHandler(this.CheckBoxSelect);
            // 
            // tbInputUser
            // 
            this.tbInputUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInputUser.Location = new System.Drawing.Point(35, 82);
            this.tbInputUser.Name = "tbInputUser";
            this.tbInputUser.Size = new System.Drawing.Size(226, 30);
            this.tbInputUser.TabIndex = 19;
            this.tbInputUser.TextChanged += new System.EventHandler(this.TbInputUser_TextChanged);
            // 
            // bgFond
            // 
            this.bgFond.Controls.Add(this.rbFondRouge);
            this.bgFond.Controls.Add(this.rbFondVert);
            this.bgFond.Controls.Add(this.rbFondBleu);
            this.bgFond.ForeColor = System.Drawing.Color.Blue;
            this.bgFond.Location = new System.Drawing.Point(40, 251);
            this.bgFond.Name = "bgFond";
            this.bgFond.Size = new System.Drawing.Size(123, 144);
            this.bgFond.TabIndex = 21;
            this.bgFond.TabStop = false;
            this.bgFond.Text = "Fond";
            this.bgFond.Visible = false;
            // 
            // rbFondRouge
            // 
            this.rbFondRouge.AutoSize = true;
            this.rbFondRouge.ForeColor = System.Drawing.Color.Black;
            this.rbFondRouge.Location = new System.Drawing.Point(6, 38);
            this.rbFondRouge.Name = "rbFondRouge";
            this.rbFondRouge.Size = new System.Drawing.Size(59, 19);
            this.rbFondRouge.TabIndex = 5;
            this.rbFondRouge.TabStop = true;
            this.rbFondRouge.Text = "Rouge";
            this.rbFondRouge.UseVisualStyleBackColor = true;
            this.rbFondRouge.CheckedChanged += new System.EventHandler(this.RbFondSelect);
            // 
            // rbFondVert
            // 
            this.rbFondVert.AutoSize = true;
            this.rbFondVert.ForeColor = System.Drawing.Color.Black;
            this.rbFondVert.Location = new System.Drawing.Point(6, 73);
            this.rbFondVert.Name = "rbFondVert";
            this.rbFondVert.Size = new System.Drawing.Size(45, 19);
            this.rbFondVert.TabIndex = 6;
            this.rbFondVert.TabStop = true;
            this.rbFondVert.Text = "Vert";
            this.rbFondVert.UseVisualStyleBackColor = true;
            this.rbFondVert.CheckedChanged += new System.EventHandler(this.RbFondSelect);
            // 
            // rbFondBleu
            // 
            this.rbFondBleu.AutoSize = true;
            this.rbFondBleu.ForeColor = System.Drawing.Color.Black;
            this.rbFondBleu.Location = new System.Drawing.Point(6, 108);
            this.rbFondBleu.Name = "rbFondBleu";
            this.rbFondBleu.Size = new System.Drawing.Size(48, 19);
            this.rbFondBleu.TabIndex = 7;
            this.rbFondBleu.TabStop = true;
            this.rbFondBleu.Text = "Bleu";
            this.rbFondBleu.UseVisualStyleBackColor = true;
            this.rbFondBleu.CheckedChanged += new System.EventHandler(this.RbFondSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInputUserControl);
            this.Controls.Add(this.bgCasse);
            this.Controls.Add(this.bgCaractere);
            this.Controls.Add(this.gbChoix);
            this.Controls.Add(this.tbInputUser);
            this.Controls.Add(this.bgFond);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bgCasse.ResumeLayout(false);
            this.bgCasse.PerformLayout();
            this.bgCaractere.ResumeLayout(false);
            this.bgCaractere.PerformLayout();
            this.gbChoix.ResumeLayout(false);
            this.gbChoix.PerformLayout();
            this.bgFond.ResumeLayout(false);
            this.bgFond.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInputUserControl;
        private GroupBox bgCasse;
        private RadioButton rbMinuscule;
        private RadioButton rbMajuscule;
        private GroupBox bgCaractere;
        private RadioButton rbCaractereRouge;
        private RadioButton rbCaractereBlanc;
        private RadioButton rbCaractereNoir;
        private GroupBox gbChoix;
        private CheckBox cbCasse;
        private CheckBox cbCouleurCaractere;
        private CheckBox cbCouleurFond;
        private TextBox tbInputUser;
        private GroupBox bgFond;
        private RadioButton rbFondRouge;
        private RadioButton rbFondVert;
        private RadioButton rbFondBleu;
    }
}