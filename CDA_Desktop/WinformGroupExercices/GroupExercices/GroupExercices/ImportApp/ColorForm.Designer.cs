namespace Menu.ImportApp
{
    partial class ColorForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColorSelect = new System.Windows.Forms.Label();
            this.numBlueText = new System.Windows.Forms.NumericUpDown();
            this.numGreenText = new System.Windows.Forms.NumericUpDown();
            this.numRedText = new System.Windows.Forms.NumericUpDown();
            this.lblBleu = new System.Windows.Forms.Label();
            this.lblVert = new System.Windows.Forms.Label();
            this.lblRouge = new System.Windows.Forms.Label();
            this.hsbGreen = new System.Windows.Forms.HScrollBar();
            this.hsbBlue = new System.Windows.Forms.HScrollBar();
            this.hsbRed = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedText)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(626, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(626, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(626, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 23;
            // 
            // lblColorSelect
            // 
            this.lblColorSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblColorSelect.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblColorSelect.Location = new System.Drawing.Point(75, 267);
            this.lblColorSelect.Name = "lblColorSelect";
            this.lblColorSelect.Size = new System.Drawing.Size(511, 47);
            this.lblColorSelect.TabIndex = 22;
            // 
            // numBlueText
            // 
            this.numBlueText.Location = new System.Drawing.Point(490, 211);
            this.numBlueText.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlueText.Name = "numBlueText";
            this.numBlueText.Size = new System.Drawing.Size(96, 23);
            this.numBlueText.TabIndex = 21;
            this.numBlueText.ValueChanged += new System.EventHandler(this.NumValueChanged);
            // 
            // numGreenText
            // 
            this.numGreenText.Location = new System.Drawing.Point(490, 176);
            this.numGreenText.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreenText.Name = "numGreenText";
            this.numGreenText.Size = new System.Drawing.Size(96, 23);
            this.numGreenText.TabIndex = 20;
            this.numGreenText.ValueChanged += new System.EventHandler(this.NumValueChanged);
            // 
            // numRedText
            // 
            this.numRedText.Location = new System.Drawing.Point(490, 138);
            this.numRedText.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRedText.Name = "numRedText";
            this.numRedText.Size = new System.Drawing.Size(96, 23);
            this.numRedText.TabIndex = 19;
            this.numRedText.ValueChanged += new System.EventHandler(this.NumValueChanged);
            // 
            // lblBleu
            // 
            this.lblBleu.AutoSize = true;
            this.lblBleu.Location = new System.Drawing.Point(75, 219);
            this.lblBleu.Name = "lblBleu";
            this.lblBleu.Size = new System.Drawing.Size(30, 15);
            this.lblBleu.TabIndex = 18;
            this.lblBleu.Text = "Bleu";
            // 
            // lblVert
            // 
            this.lblVert.AutoSize = true;
            this.lblVert.Location = new System.Drawing.Point(75, 184);
            this.lblVert.Name = "lblVert";
            this.lblVert.Size = new System.Drawing.Size(27, 15);
            this.lblVert.TabIndex = 17;
            this.lblVert.Text = "Vert";
            // 
            // lblRouge
            // 
            this.lblRouge.AutoSize = true;
            this.lblRouge.Location = new System.Drawing.Point(75, 146);
            this.lblRouge.Name = "lblRouge";
            this.lblRouge.Size = new System.Drawing.Size(41, 15);
            this.lblRouge.TabIndex = 16;
            this.lblRouge.Text = "Rouge";
            // 
            // hsbGreen
            // 
            this.hsbGreen.Location = new System.Drawing.Point(159, 182);
            this.hsbGreen.Maximum = 264;
            this.hsbGreen.Name = "hsbGreen";
            this.hsbGreen.Size = new System.Drawing.Size(289, 17);
            this.hsbGreen.TabIndex = 15;
            this.hsbGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollValueChanged);
            // 
            // hsbBlue
            // 
            this.hsbBlue.Location = new System.Drawing.Point(159, 217);
            this.hsbBlue.Maximum = 264;
            this.hsbBlue.Name = "hsbBlue";
            this.hsbBlue.Size = new System.Drawing.Size(289, 17);
            this.hsbBlue.TabIndex = 14;
            this.hsbBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollValueChanged);
            // 
            // hsbRed
            // 
            this.hsbRed.Location = new System.Drawing.Point(159, 144);
            this.hsbRed.Maximum = 264;
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(289, 17);
            this.hsbRed.TabIndex = 13;
            this.hsbRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollValueChanged);
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblColorSelect);
            this.Controls.Add(this.numBlueText);
            this.Controls.Add(this.numGreenText);
            this.Controls.Add(this.numRedText);
            this.Controls.Add(this.lblBleu);
            this.Controls.Add(this.lblVert);
            this.Controls.Add(this.lblRouge);
            this.Controls.Add(this.hsbGreen);
            this.Controls.Add(this.hsbBlue);
            this.Controls.Add(this.hsbRed);
            this.Name = "ColorForm";
            this.Text = "Couleur";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBlueText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblColorSelect;
        private NumericUpDown numBlueText;
        private NumericUpDown numGreenText;
        private NumericUpDown numRedText;
        private Label lblBleu;
        private Label lblVert;
        private Label lblRouge;
        private HScrollBar hsbGreen;
        private HScrollBar hsbBlue;
        private HScrollBar hsbRed;
    }
}