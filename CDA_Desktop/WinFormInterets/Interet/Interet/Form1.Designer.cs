namespace Interet
{
    partial class Emprunt
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
            this.lblDurationMonth = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lstPeriodicity = new System.Windows.Forms.ListBox();
            this.lblResultAmount = new System.Windows.Forms.Label();
            this.lblNumberOfPayment = new System.Windows.Forms.Label();
            this.lblReimbbursement = new System.Windows.Forms.Label();
            this.rbtnNine = new System.Windows.Forms.RadioButton();
            this.txtBoxLoan = new System.Windows.Forms.TextBox();
            this.rbtnEight = new System.Windows.Forms.RadioButton();
            this.rbtnSeven = new System.Windows.Forms.RadioButton();
            this.grpBoxInterestRate = new System.Windows.Forms.GroupBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.hsbDurationMonth = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxInterestRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDurationMonth
            // 
            this.lblDurationMonth.AutoSize = true;
            this.lblDurationMonth.Location = new System.Drawing.Point(166, 168);
            this.lblDurationMonth.Name = "lblDurationMonth";
            this.lblDurationMonth.Size = new System.Drawing.Size(38, 15);
            this.lblDurationMonth.TabIndex = 30;
            this.lblDurationMonth.Text = "label8";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(639, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(639, 65);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 28;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lstPeriodicity
            // 
            this.lstPeriodicity.FormattingEnabled = true;
            this.lstPeriodicity.ItemHeight = 15;
            this.lstPeriodicity.Location = new System.Drawing.Point(221, 223);
            this.lstPeriodicity.Name = "lstPeriodicity";
            this.lstPeriodicity.Size = new System.Drawing.Size(163, 79);
            this.lstPeriodicity.TabIndex = 27;
            // 
            // lblResultAmount
            // 
            this.lblResultAmount.AutoSize = true;
            this.lblResultAmount.Location = new System.Drawing.Point(652, 289);
            this.lblResultAmount.Name = "lblResultAmount";
            this.lblResultAmount.Size = new System.Drawing.Size(38, 15);
            this.lblResultAmount.TabIndex = 26;
            this.lblResultAmount.Text = "label7";
            this.lblResultAmount.Visible = false;
            // 
            // lblNumberOfPayment
            // 
            this.lblNumberOfPayment.AutoSize = true;
            this.lblNumberOfPayment.Location = new System.Drawing.Point(399, 289);
            this.lblNumberOfPayment.Name = "lblNumberOfPayment";
            this.lblNumberOfPayment.Size = new System.Drawing.Size(38, 15);
            this.lblNumberOfPayment.TabIndex = 25;
            this.lblNumberOfPayment.Text = "label6";
            this.lblNumberOfPayment.Visible = false;
            // 
            // lblReimbbursement
            // 
            this.lblReimbbursement.AutoSize = true;
            this.lblReimbbursement.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReimbbursement.Location = new System.Drawing.Point(470, 285);
            this.lblReimbbursement.Name = "lblReimbbursement";
            this.lblReimbbursement.Size = new System.Drawing.Size(126, 20);
            this.lblReimbbursement.TabIndex = 24;
            this.lblReimbbursement.Text = "Remboursement";
            // 
            // rbtnNine
            // 
            this.rbtnNine.AutoSize = true;
            this.rbtnNine.Location = new System.Drawing.Point(27, 102);
            this.rbtnNine.Name = "rbtnNine";
            this.rbtnNine.Size = new System.Drawing.Size(41, 19);
            this.rbtnNine.TabIndex = 2;
            this.rbtnNine.TabStop = true;
            this.rbtnNine.Text = "9%";
            this.rbtnNine.UseVisualStyleBackColor = true;
            // 
            // txtBoxLoan
            // 
            this.txtBoxLoan.Location = new System.Drawing.Point(221, 113);
            this.txtBoxLoan.Name = "txtBoxLoan";
            this.txtBoxLoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBoxLoan.Size = new System.Drawing.Size(163, 23);
            this.txtBoxLoan.TabIndex = 22;
            // 
            // rbtnEight
            // 
            this.rbtnEight.AutoSize = true;
            this.rbtnEight.Location = new System.Drawing.Point(27, 67);
            this.rbtnEight.Name = "rbtnEight";
            this.rbtnEight.Size = new System.Drawing.Size(41, 19);
            this.rbtnEight.TabIndex = 1;
            this.rbtnEight.TabStop = true;
            this.rbtnEight.Text = "8%";
            this.rbtnEight.UseVisualStyleBackColor = true;
            // 
            // rbtnSeven
            // 
            this.rbtnSeven.AutoSize = true;
            this.rbtnSeven.Location = new System.Drawing.Point(27, 32);
            this.rbtnSeven.Name = "rbtnSeven";
            this.rbtnSeven.Size = new System.Drawing.Size(41, 19);
            this.rbtnSeven.TabIndex = 0;
            this.rbtnSeven.TabStop = true;
            this.rbtnSeven.Text = "7%";
            this.rbtnSeven.UseVisualStyleBackColor = true;
            // 
            // grpBoxInterestRate
            // 
            this.grpBoxInterestRate.Controls.Add(this.rbtnNine);
            this.grpBoxInterestRate.Controls.Add(this.rbtnEight);
            this.grpBoxInterestRate.Controls.Add(this.rbtnSeven);
            this.grpBoxInterestRate.Location = new System.Drawing.Point(443, 62);
            this.grpBoxInterestRate.Name = "grpBoxInterestRate";
            this.grpBoxInterestRate.Size = new System.Drawing.Size(176, 136);
            this.grpBoxInterestRate.TabIndex = 23;
            this.grpBoxInterestRate.TabStop = false;
            this.grpBoxInterestRate.Text = "Taux d\'interêts";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(221, 62);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(163, 23);
            this.txtBoxName.TabIndex = 21;
            // 
            // hsbDurationMonth
            // 
            this.hsbDurationMonth.LargeChange = 1;
            this.hsbDurationMonth.Location = new System.Drawing.Point(221, 164);
            this.hsbDurationMonth.Maximum = 309;
            this.hsbDurationMonth.Name = "hsbDurationMonth";
            this.hsbDurationMonth.Size = new System.Drawing.Size(163, 18);
            this.hsbDurationMonth.TabIndex = 20;
            this.hsbDurationMonth.Value = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Périodicité du remboursement";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 34);
            this.label3.TabIndex = 18;
            this.label3.Text = "Durée en mois du remboursement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Capital Emprunté";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nom";
            // 
            // Emprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDurationMonth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lstPeriodicity);
            this.Controls.Add(this.lblResultAmount);
            this.Controls.Add(this.lblNumberOfPayment);
            this.Controls.Add(this.lblReimbbursement);
            this.Controls.Add(this.txtBoxLoan);
            this.Controls.Add(this.grpBoxInterestRate);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.hsbDurationMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Emprunts";
            this.Text = "Form1";
            this.grpBoxInterestRate.ResumeLayout(false);
            this.grpBoxInterestRate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}