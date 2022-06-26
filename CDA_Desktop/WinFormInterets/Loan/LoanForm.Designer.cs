namespace Loan
{
    partial class LoanForm
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
            this.lblResultAmount = new System.Windows.Forms.Label();
            this.lblNumberOfPayment = new System.Windows.Forms.Label();
            this.lblReimbursement = new System.Windows.Forms.Label();
            this.gbInterestRate = new System.Windows.Forms.GroupBox();
            this.rbNine = new System.Windows.Forms.RadioButton();
            this.rbEight = new System.Windows.Forms.RadioButton();
            this.rbSeven = new System.Windows.Forms.RadioButton();
            this.tbLoan = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblTitleLoan = new System.Windows.Forms.Label();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.periodUserControl1 = new Loan.UserControls.PeriodUserControl();
            this.gbInterestRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultAmount
            // 
            this.lblResultAmount.AutoSize = true;
            this.lblResultAmount.Location = new System.Drawing.Point(677, 331);
            this.lblResultAmount.Name = "lblResultAmount";
            this.lblResultAmount.Size = new System.Drawing.Size(38, 15);
            this.lblResultAmount.TabIndex = 26;
            this.lblResultAmount.Text = "label7";
            // 
            // lblNumberOfPayment
            // 
            this.lblNumberOfPayment.AutoSize = true;
            this.lblNumberOfPayment.Location = new System.Drawing.Point(424, 331);
            this.lblNumberOfPayment.Name = "lblNumberOfPayment";
            this.lblNumberOfPayment.Size = new System.Drawing.Size(38, 15);
            this.lblNumberOfPayment.TabIndex = 25;
            this.lblNumberOfPayment.Text = "label6";
            this.lblNumberOfPayment.Visible = false;
            // 
            // lblReimbursement
            // 
            this.lblReimbursement.AutoSize = true;
            this.lblReimbursement.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReimbursement.Location = new System.Drawing.Point(495, 327);
            this.lblReimbursement.Name = "lblReimbursement";
            this.lblReimbursement.Size = new System.Drawing.Size(126, 20);
            this.lblReimbursement.TabIndex = 24;
            this.lblReimbursement.Text = "Remboursement";
            // 
            // gbInterestRate
            // 
            this.gbInterestRate.Controls.Add(this.rbNine);
            this.gbInterestRate.Controls.Add(this.rbEight);
            this.gbInterestRate.Controls.Add(this.rbSeven);
            this.gbInterestRate.Location = new System.Drawing.Point(468, 104);
            this.gbInterestRate.Name = "gbInterestRate";
            this.gbInterestRate.Size = new System.Drawing.Size(176, 136);
            this.gbInterestRate.TabIndex = 23;
            this.gbInterestRate.TabStop = false;
            this.gbInterestRate.Text = "Taux d\'interêts";
            // 
            // rbNine
            // 
            this.rbNine.AutoSize = true;
            this.rbNine.Location = new System.Drawing.Point(27, 102);
            this.rbNine.Name = "rbNine";
            this.rbNine.Size = new System.Drawing.Size(41, 19);
            this.rbNine.TabIndex = 2;
            this.rbNine.TabStop = true;
            this.rbNine.Text = "9%";
            this.rbNine.UseVisualStyleBackColor = true;
            this.rbNine.CheckedChanged += new System.EventHandler(this.RbValueTag_Checked);
            // 
            // rbEight
            // 
            this.rbEight.AutoSize = true;
            this.rbEight.Location = new System.Drawing.Point(27, 67);
            this.rbEight.Name = "rbEight";
            this.rbEight.Size = new System.Drawing.Size(41, 19);
            this.rbEight.TabIndex = 1;
            this.rbEight.TabStop = true;
            this.rbEight.Text = "8%";
            this.rbEight.UseVisualStyleBackColor = true;
            this.rbEight.CheckedChanged += new System.EventHandler(this.RbValueTag_Checked);
            // 
            // rbSeven
            // 
            this.rbSeven.AutoSize = true;
            this.rbSeven.Location = new System.Drawing.Point(27, 32);
            this.rbSeven.Name = "rbSeven";
            this.rbSeven.Size = new System.Drawing.Size(41, 19);
            this.rbSeven.TabIndex = 0;
            this.rbSeven.TabStop = true;
            this.rbSeven.Text = "7%";
            this.rbSeven.UseVisualStyleBackColor = true;
            this.rbSeven.CheckedChanged += new System.EventHandler(this.RbValueTag_Checked);
            // 
            // tbLoan
            // 
            this.tbLoan.Location = new System.Drawing.Point(246, 155);
            this.tbLoan.Name = "tbLoan";
            this.tbLoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbLoan.Size = new System.Drawing.Size(163, 23);
            this.tbLoan.TabIndex = 22;
            this.tbLoan.TextChanged += new System.EventHandler(this.TbLoan_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(246, 104);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(163, 23);
            this.tbName.TabIndex = 21;
            this.tbName.TextChanged += new System.EventHandler(this.TbName_TextChanged);
            // 
            // lblTitleLoan
            // 
            this.lblTitleLoan.AutoSize = true;
            this.lblTitleLoan.Location = new System.Drawing.Point(61, 158);
            this.lblTitleLoan.Name = "lblTitleLoan";
            this.lblTitleLoan.Size = new System.Drawing.Size(99, 15);
            this.lblTitleLoan.TabIndex = 17;
            this.lblTitleLoan.Text = "Capital Emprunté";
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Location = new System.Drawing.Point(61, 107);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(34, 15);
            this.lblTitleName.TabIndex = 16;
            this.lblTitleName.Text = "Nom";
            // 
            // periodUserControl1
            // 
            this.periodUserControl1.Location = new System.Drawing.Point(37, 216);
            this.periodUserControl1.Name = "periodUserControl1";
            this.periodUserControl1.Size = new System.Drawing.Size(372, 176);
            this.periodUserControl1.TabIndex = 30;
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.periodUserControl1);
            this.Controls.Add(this.lblResultAmount);
            this.Controls.Add(this.lblNumberOfPayment);
            this.Controls.Add(this.lblReimbursement);
            this.Controls.Add(this.gbInterestRate);
            this.Controls.Add(this.tbLoan);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblTitleLoan);
            this.Controls.Add(this.lblTitleName);
            this.Name = "LoanForm";
            this.Text = "Emprunt";
            this.Load += new System.EventHandler(this.LoanForm_Load);
            this.gbInterestRate.ResumeLayout(false);
            this.gbInterestRate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblResultAmount;
        private Label lblNumberOfPayment;
        private Label lblReimbursement;
        private GroupBox gbInterestRate;
        private RadioButton rbNine;
        private RadioButton rbEight;
        private RadioButton rbSeven;
        private TextBox tbLoan;
        private TextBox tbName;
        private Label lblTitleLoan;
        private Label lblTitleName;
        private UserControls.PeriodUserControl periodUserControl1;
    }
}