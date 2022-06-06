namespace ajoutFormulaireValidating
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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(383, 180);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 43;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnVlalider_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(383, 209);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 23);
            this.btnEffacer.TabIndex = 42;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(162, 177);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(166, 23);
            this.txtCode.TabIndex = 41;
            this.txtCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtCode_Validating);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(162, 137);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(166, 23);
            this.txtMontant.TabIndex = 40;
            this.txtMontant.Validating += new System.ComponentModel.CancelEventHandler(this.txtMontant_Validating);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(162, 97);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(166, 23);
            this.txtDate.TabIndex = 39;
            this.txtDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtDate_Validating);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(162, 57);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(166, 23);
            this.txtNom.TabIndex = 38;
            this.txtNom.Validating += new System.ComponentModel.CancelEventHandler(this.txtNom_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "(JJ/MM/AAA)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Code Postal : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Montant : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nom : ";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnValider;
        private Button btnEffacer;
        private TextBox txtCode;
        private TextBox txtMontant;
        private TextBox txtDate;
        private TextBox txtNom;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider;
    }
}