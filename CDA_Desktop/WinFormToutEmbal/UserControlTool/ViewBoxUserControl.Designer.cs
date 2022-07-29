namespace WinFormToutEmbal.UserControlTool
{
    partial class ViewBoxUserControl
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
            this.tbNumberBox = new System.Windows.Forms.TextBox();
            this.tbDefaultPerHour = new System.Windows.Forms.TextBox();
            this.tbDefaultFromStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumberBox
            // 
            this.tbNumberBox.Enabled = false;
            this.tbNumberBox.Location = new System.Drawing.Point(189, 50);
            this.tbNumberBox.Name = "tbNumberBox";
            this.tbNumberBox.Size = new System.Drawing.Size(117, 23);
            this.tbNumberBox.TabIndex = 0;
            // 
            // tbDefaultPerHour
            // 
            this.tbDefaultPerHour.Enabled = false;
            this.tbDefaultPerHour.Location = new System.Drawing.Point(189, 92);
            this.tbDefaultPerHour.Name = "tbDefaultPerHour";
            this.tbDefaultPerHour.Size = new System.Drawing.Size(117, 23);
            this.tbDefaultPerHour.TabIndex = 1;
            // 
            // tbDefaultFromStart
            // 
            this.tbDefaultFromStart.Enabled = false;
            this.tbDefaultFromStart.Location = new System.Drawing.Point(189, 134);
            this.tbDefaultFromStart.Name = "tbDefaultFromStart";
            this.tbDefaultFromStart.Size = new System.Drawing.Size(117, 23);
            this.tbDefaultFromStart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number Box ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Default Per Hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Default Start Production";
            // 
            // ViewBoxManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDefaultFromStart);
            this.Controls.Add(this.tbDefaultPerHour);
            this.Controls.Add(this.tbNumberBox);
            this.Name = "ViewBoxManager";
            this.Size = new System.Drawing.Size(356, 205);
            this.Load += new System.EventHandler(this.ViewBoxManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNumberBox;
        private TextBox tbDefaultPerHour;
        private TextBox tbDefaultFromStart;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
