namespace Menu.ImportApp
{
    partial class Element
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
            this.lstBoxElement = new System.Windows.Forms.ListBox();
            this.tbInputUser = new System.Windows.Forms.TextBox();
            this.tbIndexElement = new System.Windows.Forms.TextBox();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbItemCount = new System.Windows.Forms.TextBox();
            this.tbSelectedIndex = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxElement
            // 
            this.lstBoxElement.FormattingEnabled = true;
            this.lstBoxElement.ItemHeight = 15;
            this.lstBoxElement.Location = new System.Drawing.Point(38, 173);
            this.lstBoxElement.Name = "lstBoxElement";
            this.lstBoxElement.Size = new System.Drawing.Size(149, 184);
            this.lstBoxElement.TabIndex = 0;
            this.lstBoxElement.SelectedIndexChanged += new System.EventHandler(this.lstBoxElement_SelectedIndexChanged);
            // 
            // tbInputUser
            // 
            this.tbInputUser.Location = new System.Drawing.Point(38, 68);
            this.tbInputUser.Name = "tbInputUser";
            this.tbInputUser.Size = new System.Drawing.Size(149, 23);
            this.tbInputUser.TabIndex = 1;
            // 
            // tbIndexElement
            // 
            this.tbIndexElement.Location = new System.Drawing.Point(268, 68);
            this.tbIndexElement.Name = "tbIndexElement";
            this.tbIndexElement.Size = new System.Drawing.Size(66, 23);
            this.tbIndexElement.TabIndex = 2;
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(347, 68);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(143, 23);
            this.btnSelectionner.TabIndex = 3;
            this.btnSelectionner.Text = "Sélectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Vider la Liste";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nouvel Elément";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(268, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Index Elément";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Liste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(270, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Propriétés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(264, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Item.Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(244, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Selected Index";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(306, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Text";
            // 
            // tbItemCount
            // 
            this.tbItemCount.Enabled = false;
            this.tbItemCount.Location = new System.Drawing.Point(347, 173);
            this.tbItemCount.Name = "tbItemCount";
            this.tbItemCount.Size = new System.Drawing.Size(44, 23);
            this.tbItemCount.TabIndex = 12;
            // 
            // tbSelectedIndex
            // 
            this.tbSelectedIndex.Enabled = false;
            this.tbSelectedIndex.Location = new System.Drawing.Point(347, 201);
            this.tbSelectedIndex.Name = "tbSelectedIndex";
            this.tbSelectedIndex.Size = new System.Drawing.Size(44, 23);
            this.tbSelectedIndex.TabIndex = 13;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(347, 232);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 23);
            this.tbName.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Ajout Liste";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSelectedIndex);
            this.Controls.Add(this.tbItemCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.tbIndexElement);
            this.Controls.Add(this.tbInputUser);
            this.Controls.Add(this.lstBoxElement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button btnSelectionner;
        private TextBox tbIndexElement;
        private TextBox tbInputUser;
        private ListBox lstBoxElement;
        private TextBox tbName;
        private TextBox tbSelectedIndex;
        private TextBox tbItemCount;
        private Button button3;
    }
}