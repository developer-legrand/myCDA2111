namespace Loan.UserControls
{
    partial class PeriodUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDuration = new System.Windows.Forms.Label();
            this.lbPeriodicity = new System.Windows.Forms.ListBox();
            this.hsbDuration = new System.Windows.Forms.HScrollBar();
            this.lblTitlePeriodicity = new System.Windows.Forms.Label();
            this.lblTitleDuration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(133, 19);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(38, 15);
            this.lblDuration.TabIndex = 35;
            this.lblDuration.Text = "label8";
            // 
            // lbPeriodicity
            // 
            this.lbPeriodicity.FormattingEnabled = true;
            this.lbPeriodicity.ItemHeight = 15;
            this.lbPeriodicity.Location = new System.Drawing.Point(188, 74);
            this.lbPeriodicity.Name = "lbPeriodicity";
            this.lbPeriodicity.Size = new System.Drawing.Size(163, 79);
            this.lbPeriodicity.TabIndex = 34;
            this.lbPeriodicity.SelectedIndexChanged += new System.EventHandler(this.lbPeriodicity_SelectedIndexChanged);
            // 
            // hsbDuration
            // 
            this.hsbDuration.LargeChange = 1;
            this.hsbDuration.Location = new System.Drawing.Point(188, 15);
            this.hsbDuration.Maximum = 309;
            this.hsbDuration.Name = "hsbDuration";
            this.hsbDuration.Size = new System.Drawing.Size(163, 18);
            this.hsbDuration.TabIndex = 33;
            this.hsbDuration.Value = 1;
            this.hsbDuration.ValueChanged += new System.EventHandler(this.hsbDuration_ValueChanged);
            // 
            // lblTitlePeriodicity
            // 
            this.lblTitlePeriodicity.AutoSize = true;
            this.lblTitlePeriodicity.Location = new System.Drawing.Point(3, 74);
            this.lblTitlePeriodicity.Name = "lblTitlePeriodicity";
            this.lblTitlePeriodicity.Size = new System.Drawing.Size(168, 15);
            this.lblTitlePeriodicity.TabIndex = 32;
            this.lblTitlePeriodicity.Text = "Périodicité du remboursement";
            // 
            // lblTitleDuration
            // 
            this.lblTitleDuration.Location = new System.Drawing.Point(3, 15);
            this.lblTitleDuration.Name = "lblTitleDuration";
            this.lblTitleDuration.Size = new System.Drawing.Size(111, 34);
            this.lblTitleDuration.TabIndex = 31;
            this.lblTitleDuration.Text = "Durée en mois du remboursement";
            // 
            // PeriodUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lbPeriodicity);
            this.Controls.Add(this.hsbDuration);
            this.Controls.Add(this.lblTitlePeriodicity);
            this.Controls.Add(this.lblTitleDuration);
            this.Name = "PeriodUserControl";
            this.Size = new System.Drawing.Size(372, 176);
            this.Load += new System.EventHandler(this.PeriodUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDuration;
        private ListBox lbPeriodicity;
        private HScrollBar hsbDuration;
        private Label lblTitlePeriodicity;
        private Label lblTitleDuration;
    }
}
