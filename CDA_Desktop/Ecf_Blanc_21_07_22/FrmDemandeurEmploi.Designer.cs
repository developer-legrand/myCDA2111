namespace Ecf_Blanc_21_07_22
{
    partial class FrmDemandeurEmploi
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
            this.cbLevelEducation = new System.Windows.Forms.ComboBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbInscription = new System.Windows.Forms.TextBox();
            this.tbLastDiploma = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbLevelEducation
            // 
            this.cbLevelEducation.FormattingEnabled = true;
            this.cbLevelEducation.Location = new System.Drawing.Point(202, 222);
            this.cbLevelEducation.Name = "cbLevelEducation";
            this.cbLevelEducation.Size = new System.Drawing.Size(121, 23);
            this.cbLevelEducation.TabIndex = 0;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(202, 66);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(121, 23);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(202, 118);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(121, 23);
            this.tbLastName.TabIndex = 2;
            // 
            // tbInscription
            // 
            this.tbInscription.Location = new System.Drawing.Point(202, 170);
            this.tbInscription.Name = "tbInscription";
            this.tbInscription.Size = new System.Drawing.Size(121, 23);
            this.tbInscription.TabIndex = 3;
            // 
            // tbLastDiploma
            // 
            this.tbLastDiploma.Location = new System.Drawing.Point(202, 274);
            this.tbLastDiploma.Name = "tbLastDiploma";
            this.tbLastDiploma.Size = new System.Drawing.Size(121, 23);
            this.tbLastDiploma.TabIndex = 4;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(202, 326);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(121, 23);
            this.btnValidate.TabIndex = 5;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unemployment Inscription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Level Education";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "last diploma obtained";
            // 
            // FrmDemandeurEmploi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.tbLastDiploma);
            this.Controls.Add(this.tbInscription);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.cbLevelEducation);
            this.Name = "FrmDemandeurEmploi";
            this.Text = "PaulEmploi";
            this.Load += new System.EventHandler(this.FrmTrouverEmploi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbLevelEducation;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbInscription;
        private TextBox tbLastDiploma;
        private Button btnValidate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}