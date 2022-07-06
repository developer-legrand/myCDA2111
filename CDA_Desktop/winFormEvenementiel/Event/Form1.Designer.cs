namespace Event
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
            this.tvHardDisk = new System.Windows.Forms.TreeView();
            this.btnHardDisk = new System.Windows.Forms.Button();
            this.btnExpansion = new System.Windows.Forms.Button();
            this.btnReduction = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tvHardDisk
            // 
            this.tvHardDisk.Location = new System.Drawing.Point(151, 88);
            this.tvHardDisk.Name = "tvHardDisk";
            this.tvHardDisk.Size = new System.Drawing.Size(432, 272);
            this.tvHardDisk.TabIndex = 0;
            // 
            // btnHardDisk
            // 
            this.btnHardDisk.Location = new System.Drawing.Point(151, 12);
            this.btnHardDisk.Name = "btnHardDisk";
            this.btnHardDisk.Size = new System.Drawing.Size(78, 70);
            this.btnHardDisk.TabIndex = 1;
            this.btnHardDisk.Text = "Hard Disk Display";
            this.btnHardDisk.UseVisualStyleBackColor = true;
            this.btnHardDisk.Click += new System.EventHandler(this.BtnHardDisk_Click);
            // 
            // btnExpansion
            // 
            this.btnExpansion.Location = new System.Drawing.Point(151, 366);
            this.btnExpansion.Name = "btnExpansion";
            this.btnExpansion.Size = new System.Drawing.Size(78, 70);
            this.btnExpansion.TabIndex = 2;
            this.btnExpansion.Text = "Tree View Expansion";
            this.btnExpansion.UseVisualStyleBackColor = true;
            this.btnExpansion.Click += new System.EventHandler(this.BtnExpansion_Click);
            // 
            // btnReduction
            // 
            this.btnReduction.Location = new System.Drawing.Point(505, 366);
            this.btnReduction.Name = "btnReduction";
            this.btnReduction.Size = new System.Drawing.Size(78, 70);
            this.btnReduction.TabIndex = 3;
            this.btnReduction.Text = "Tree View Reduction";
            this.btnReduction.UseVisualStyleBackColor = true;
            this.btnReduction.Click += new System.EventHandler(this.BtnReduction_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(331, 59);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(252, 23);
            this.tbPath.TabIndex = 4;
            this.tbPath.Validating += new System.ComponentModel.CancelEventHandler(this.TbPath_Validating);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(331, 41);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(175, 15);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "path of the file to be examined :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnReduction);
            this.Controls.Add(this.btnExpansion);
            this.Controls.Add(this.btnHardDisk);
            this.Controls.Add(this.tvHardDisk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView tvHardDisk;
        private Button btnHardDisk;
        private Button btnExpansion;
        private Button btnReduction;
        private TextBox tbPath;
        private Label lblPath;
        private OpenFileDialog openFileDialog1;
    }
}