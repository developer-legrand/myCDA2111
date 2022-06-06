namespace checkBoxRadioButton
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbFondRouge = new System.Windows.Forms.RadioButton();
            this.rbFondVert = new System.Windows.Forms.RadioButton();
            this.rbFondBleu = new System.Windows.Forms.RadioButton();
            this.tbInputUser = new System.Windows.Forms.TextBox();
            this.gbChoix = new System.Windows.Forms.GroupBox();
            this.cbCasse = new System.Windows.Forms.CheckBox();
            this.cbCouleurCaracteres = new System.Windows.Forms.CheckBox();
            this.cbCouleurFond = new System.Windows.Forms.CheckBox();
            this.gbFond = new System.Windows.Forms.GroupBox();
            this.gbCaractere = new System.Windows.Forms.GroupBox();
            this.rbCaractereRouge = new System.Windows.Forms.RadioButton();
            this.rbCaractereBlanc = new System.Windows.Forms.RadioButton();
            this.rbCaractereNoir = new System.Windows.Forms.RadioButton();
            this.gbCasse = new System.Windows.Forms.GroupBox();
            this.rbMinuscule = new System.Windows.Forms.RadioButton();
            this.rbMajuscule = new System.Windows.Forms.RadioButton();
            this.labelInputUserControl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbChoix.SuspendLayout();
            this.gbFond.SuspendLayout();
            this.gbCaractere.SuspendLayout();
            this.gbCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
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
            this.rbFondRouge.CheckedChanged += new System.EventHandler(this.rbFondRouge_CheckedChanged);
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
            this.rbFondVert.CheckedChanged += new System.EventHandler(this.rbFondVert_CheckedChanged);
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
            this.rbFondBleu.CheckedChanged += new System.EventHandler(this.rbFondBleu_CheckedChanged);
            // 
            // tbInputUser
            // 
            this.tbInputUser.Location = new System.Drawing.Point(88, 58);
            this.tbInputUser.Name = "tbInputUser";
            this.tbInputUser.Size = new System.Drawing.Size(226, 23);
            this.tbInputUser.TabIndex = 13;
            this.tbInputUser.TextChanged += new System.EventHandler(this.tbInputUser_TextChanged);
            // 
            // gbChoix
            // 
            this.gbChoix.Controls.Add(this.cbCasse);
            this.gbChoix.Controls.Add(this.cbCouleurCaracteres);
            this.gbChoix.Controls.Add(this.cbCouleurFond);
            this.gbChoix.Enabled = false;
            this.gbChoix.ForeColor = System.Drawing.Color.Blue;
            this.gbChoix.Location = new System.Drawing.Point(466, 12);
            this.gbChoix.Name = "gbChoix";
            this.gbChoix.Size = new System.Drawing.Size(160, 102);
            this.gbChoix.TabIndex = 14;
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
            this.cbCasse.CheckedChanged += new System.EventHandler(this.cbCasse_CheckedChanged);
            // 
            // cbCouleurCaracteres
            // 
            this.cbCouleurCaracteres.AutoSize = true;
            this.cbCouleurCaracteres.ForeColor = System.Drawing.Color.Black;
            this.cbCouleurCaracteres.Location = new System.Drawing.Point(10, 50);
            this.cbCouleurCaracteres.Name = "cbCouleurCaracteres";
            this.cbCouleurCaracteres.Size = new System.Drawing.Size(145, 19);
            this.cbCouleurCaracteres.TabIndex = 1;
            this.cbCouleurCaracteres.Text = "Couleur des caractères";
            this.cbCouleurCaracteres.UseVisualStyleBackColor = true;
            this.cbCouleurCaracteres.CheckedChanged += new System.EventHandler(this.cbCouleurCaracteres_CheckedChanged);
            // 
            // cbCouleurFond
            // 
            this.cbCouleurFond.AutoSize = true;
            this.cbCouleurFond.ForeColor = System.Drawing.Color.Black;
            this.cbCouleurFond.Location = new System.Drawing.Point(10, 24);
            this.cbCouleurFond.Name = "cbCouleurFond";
            this.cbCouleurFond.Size = new System.Drawing.Size(112, 19);
            this.cbCouleurFond.TabIndex = 0;
            this.cbCouleurFond.Text = "Couleur de fond";
            this.cbCouleurFond.UseVisualStyleBackColor = true;
            this.cbCouleurFond.CheckedChanged += new System.EventHandler(this.cbCouleurFond_CheckedChanged);
            // 
            // gbFond
            // 
            this.gbFond.Controls.Add(this.rbFondRouge);
            this.gbFond.Controls.Add(this.rbFondVert);
            this.gbFond.Controls.Add(this.rbFondBleu);
            this.gbFond.ForeColor = System.Drawing.Color.Blue;
            this.gbFond.Location = new System.Drawing.Point(85, 201);
            this.gbFond.Name = "gbFond";
            this.gbFond.Size = new System.Drawing.Size(123, 144);
            this.gbFond.TabIndex = 15;
            this.gbFond.TabStop = false;
            this.gbFond.Text = "Fond";
            this.gbFond.Visible = false;
            // 
            // gbCaractere
            // 
            this.gbCaractere.Controls.Add(this.rbCaractereRouge);
            this.gbCaractere.Controls.Add(this.rbCaractereBlanc);
            this.gbCaractere.Controls.Add(this.rbCaractereNoir);
            this.gbCaractere.ForeColor = System.Drawing.Color.Blue;
            this.gbCaractere.Location = new System.Drawing.Point(252, 201);
            this.gbCaractere.Name = "gbCaractere";
            this.gbCaractere.Size = new System.Drawing.Size(123, 144);
            this.gbCaractere.TabIndex = 16;
            this.gbCaractere.TabStop = false;
            this.gbCaractere.Text = "Caractères";
            this.gbCaractere.Visible = false;
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
            this.rbCaractereRouge.CheckedChanged += new System.EventHandler(this.rbCaractereRouge_CheckedChanged);
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
            this.rbCaractereBlanc.CheckedChanged += new System.EventHandler(this.rbCaractereBlanc_CheckedChanged);
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
            this.rbCaractereNoir.CheckedChanged += new System.EventHandler(this.rbCaractereNoir_CheckedChanged);
            // 
            // gbCasse
            // 
            this.gbCasse.Controls.Add(this.rbMinuscule);
            this.gbCasse.Controls.Add(this.rbMajuscule);
            this.gbCasse.ForeColor = System.Drawing.Color.Blue;
            this.gbCasse.Location = new System.Drawing.Point(419, 239);
            this.gbCasse.Name = "gbCasse";
            this.gbCasse.Size = new System.Drawing.Size(123, 105);
            this.gbCasse.TabIndex = 17;
            this.gbCasse.TabStop = false;
            this.gbCasse.Text = "Casse";
            this.gbCasse.Visible = false;
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
            this.rbMinuscule.CheckedChanged += new System.EventHandler(this.rbMinuscule_CheckedChanged);
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
            this.rbMajuscule.CheckedChanged += new System.EventHandler(this.rbMajuscule_CheckedChanged);
            // 
            // labelInputUserControl
            // 
            this.labelInputUserControl.AutoSize = true;
            this.labelInputUserControl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelInputUserControl.Location = new System.Drawing.Point(88, 136);
            this.labelInputUserControl.Name = "labelInputUserControl";
            this.labelInputUserControl.Size = new System.Drawing.Size(0, 15);
            this.labelInputUserControl.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInputUserControl);
            this.Controls.Add(this.gbCasse);
            this.Controls.Add(this.gbCaractere);
            this.Controls.Add(this.gbChoix);
            this.Controls.Add(this.tbInputUser);
            this.Controls.Add(this.gbFond);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbChoix.ResumeLayout(false);
            this.gbChoix.PerformLayout();
            this.gbFond.ResumeLayout(false);
            this.gbFond.PerformLayout();
            this.gbCaractere.ResumeLayout(false);
            this.gbCaractere.PerformLayout();
            this.gbCasse.ResumeLayout(false);
            this.gbCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ErrorProvider errorProvider;
        private GroupBox gbCasse;
        private RadioButton rbMinuscule;
        private RadioButton rbMajuscule;
        private GroupBox gbCaractere;
        private RadioButton rbCaractereRouge;
        private RadioButton rbCaractereBlanc;
        private RadioButton rbCaractereNoir;
        private GroupBox gbChoix;
        private TextBox tbInputUser;
        private GroupBox gbFond;
        private RadioButton rbFondRouge;
        private RadioButton rbFondVert;
        private RadioButton rbFondBleu;
        private CheckBox cbCasse;
        private CheckBox cbCouleurCaracteres;
        private CheckBox cbCouleurFond;
        private Label labelInputUserControl;
    }
}