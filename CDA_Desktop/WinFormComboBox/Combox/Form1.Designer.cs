namespace Combox
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
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveOne = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectOne = new System.Windows.Forms.Button();
            this.cbxDataMain = new System.Windows.Forms.ComboBox();
            this.lstDataTarget = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDown.Location = new System.Drawing.Point(459, 255);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 40);
            this.btnDown.TabIndex = 15;
            this.btnDown.Text = "6";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUp.Location = new System.Drawing.Point(459, 212);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 40);
            this.btnUp.TabIndex = 14;
            this.btnUp.Text = "5";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveAll.Location = new System.Drawing.Point(348, 152);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(50, 50);
            this.btnRemoveAll.TabIndex = 13;
            this.btnRemoveAll.Text = "7";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemoveOne
            // 
            this.btnRemoveOne.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveOne.Location = new System.Drawing.Point(348, 96);
            this.btnRemoveOne.Name = "btnRemoveOne";
            this.btnRemoveOne.Size = new System.Drawing.Size(50, 50);
            this.btnRemoveOne.TabIndex = 12;
            this.btnRemoveOne.Text = "3";
            this.btnRemoveOne.UseVisualStyleBackColor = true;
            this.btnRemoveOne.Click += new System.EventHandler(this.btnRemoveOne_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectAll.Location = new System.Drawing.Point(404, 152);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(50, 50);
            this.btnSelectAll.TabIndex = 11;
            this.btnSelectAll.Text = "8";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectOne
            // 
            this.btnSelectOne.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectOne.Location = new System.Drawing.Point(404, 96);
            this.btnSelectOne.Name = "btnSelectOne";
            this.btnSelectOne.Size = new System.Drawing.Size(50, 50);
            this.btnSelectOne.TabIndex = 10;
            this.btnSelectOne.Text = "4";
            this.btnSelectOne.UseVisualStyleBackColor = true;
            this.btnSelectOne.Click += new System.EventHandler(this.btnSelectOne_Click);
            // 
            // cbxDataMain
            // 
            this.cbxDataMain.FormattingEnabled = true;
            this.cbxDataMain.Location = new System.Drawing.Point(80, 96);
            this.cbxDataMain.Name = "cbxDataMain";
            this.cbxDataMain.Size = new System.Drawing.Size(212, 23);
            this.cbxDataMain.TabIndex = 9;
            // 
            // lstDataTarget
            // 
            this.lstDataTarget.FormattingEnabled = true;
            this.lstDataTarget.ItemHeight = 15;
            this.lstDataTarget.Location = new System.Drawing.Point(505, 96);
            this.lstDataTarget.Name = "lstDataTarget";
            this.lstDataTarget.Size = new System.Drawing.Size(212, 199);
            this.lstDataTarget.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemoveOne);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnSelectOne);
            this.Controls.Add(this.cbxDataMain);
            this.Controls.Add(this.lstDataTarget);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDown;
        private Button btnUp;
        private Button btnRemoveAll;
        private Button btnRemoveOne;
        private Button btnSelectAll;
        private Button btnSelectOne;
        private ComboBox cbxDataMain;
        private ListBox lstDataTarget;
    }
}