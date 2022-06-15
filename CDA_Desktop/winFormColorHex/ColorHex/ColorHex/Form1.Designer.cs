namespace ColorHex
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
            this.hsbRed = new System.Windows.Forms.HScrollBar();
            this.hsbBlue = new System.Windows.Forms.HScrollBar();
            this.hsbGreen = new System.Windows.Forms.HScrollBar();
            this.lblRouge = new System.Windows.Forms.Label();
            this.lblVert = new System.Windows.Forms.Label();
            this.lblBleu = new System.Windows.Forms.Label();
            this.numRedText = new System.Windows.Forms.NumericUpDown();
            this.numGreenText = new System.Windows.Forms.NumericUpDown();
            this.numBlueText = new System.Windows.Forms.NumericUpDown();
            this.lblColorSelect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRedText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueText)).BeginInit();
            this.SuspendLayout();
            // 
            // hsbRed
            // 
            this.hsbRed.Location = new System.Drawing.Point(166, 91);
            this.hsbRed.Maximum = 264;
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(289, 17);
            this.hsbRed.TabIndex = 0;
            this.hsbRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Changed);
            // 
            // hsbBlue
            // 
            this.hsbBlue.Location = new System.Drawing.Point(166, 164);
            this.hsbBlue.Maximum = 264;
            this.hsbBlue.Name = "hsbBlue";
            this.hsbBlue.Size = new System.Drawing.Size(289, 17);
            this.hsbBlue.TabIndex = 1;
            this.hsbBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Changed);
            // 
            // hsbGreen
            // 
            this.hsbGreen.Location = new System.Drawing.Point(166, 129);
            this.hsbGreen.Maximum = 264;
            this.hsbGreen.Name = "hsbGreen";
            this.hsbGreen.Size = new System.Drawing.Size(289, 17);
            this.hsbGreen.TabIndex = 2;
            this.hsbGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Changed);
            // 
            // lblRouge
            // 
            this.lblRouge.AutoSize = true;
            this.lblRouge.Location = new System.Drawing.Point(82, 93);
            this.lblRouge.Name = "lblRouge";
            this.lblRouge.Size = new System.Drawing.Size(41, 15);
            this.lblRouge.TabIndex = 3;
            this.lblRouge.Text = "Rouge";
            // 
            // lblVert
            // 
            this.lblVert.AutoSize = true;
            this.lblVert.Location = new System.Drawing.Point(82, 131);
            this.lblVert.Name = "lblVert";
            this.lblVert.Size = new System.Drawing.Size(27, 15);
            this.lblVert.TabIndex = 4;
            this.lblVert.Text = "Vert";
            // 
            // lblBleu
            // 
            this.lblBleu.AutoSize = true;
            this.lblBleu.Location = new System.Drawing.Point(82, 166);
            this.lblBleu.Name = "lblBleu";
            this.lblBleu.Size = new System.Drawing.Size(30, 15);
            this.lblBleu.TabIndex = 5;
            this.lblBleu.Text = "Bleu";
            // 
            // numRedText
            // 
            this.numRedText.Location = new System.Drawing.Point(497, 85);
            this.numRedText.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRedText.Name = "numRedText";
            this.numRedText.Size = new System.Drawing.Size(96, 23);
            this.numRedText.TabIndex = 6;
            this.numRedText.ValueChanged += new System.EventHandler(this.numColorText_Changed);
            // 
            // numGreenText
            // 
            this.numGreenText.Location = new System.Drawing.Point(497, 123);
            this.numGreenText.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreenText.Name = "numGreenText";
            this.numGreenText.Size = new System.Drawing.Size(96, 23);
            this.numGreenText.TabIndex = 7;
            this.numGreenText.ValueChanged += new System.EventHandler(this.numColorText_Changed);
            // 
            // numBlueText
            // 
            this.numBlueText.Location = new System.Drawing.Point(497, 158);
            this.numBlueText.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlueText.Name = "numBlueText";
            this.numBlueText.Size = new System.Drawing.Size(96, 23);
            this.numBlueText.TabIndex = 8;
            this.numBlueText.ValueChanged += new System.EventHandler(this.numColorText_Changed);
            // 
            // lblColorSelect
            // 
            this.lblColorSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblColorSelect.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblColorSelect.Location = new System.Drawing.Point(82, 214);
            this.lblColorSelect.Name = "lblColorSelect";
            this.lblColorSelect.Size = new System.Drawing.Size(511, 47);
            this.lblColorSelect.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(633, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(633, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(633, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 281);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRedText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HScrollBar hsbRed;
        private HScrollBar hsbBlue;
        private HScrollBar hsbGreen;
        private Label lblRouge;
        private Label lblVert;
        private Label lblBleu;
        private NumericUpDown numRedText;
        private NumericUpDown numGreenText;
        private NumericUpDown numBlueText;
        private Label lblColorSelect;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}