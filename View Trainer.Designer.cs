namespace Dieter
{
    partial class View_Trainer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progfinishtextBox1 = new System.Windows.Forms.TextBox();
            this.calcounttextBox1 = new System.Windows.Forms.TextBox();
            this.calburntextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progfinishtextBox1
            // 
            this.progfinishtextBox1.Location = new System.Drawing.Point(138, 105);
            this.progfinishtextBox1.Multiline = true;
            this.progfinishtextBox1.Name = "progfinishtextBox1";
            this.progfinishtextBox1.ReadOnly = true;
            this.progfinishtextBox1.Size = new System.Drawing.Size(223, 82);
            this.progfinishtextBox1.TabIndex = 26;
            // 
            // calcounttextBox1
            // 
            this.calcounttextBox1.Location = new System.Drawing.Point(138, 63);
            this.calcounttextBox1.Name = "calcounttextBox1";
            this.calcounttextBox1.ReadOnly = true;
            this.calcounttextBox1.Size = new System.Drawing.Size(124, 22);
            this.calcounttextBox1.TabIndex = 25;
            // 
            // calburntextBox1
            // 
            this.calburntextBox1.Location = new System.Drawing.Point(138, 26);
            this.calburntextBox1.Name = "calburntextBox1";
            this.calburntextBox1.ReadOnly = true;
            this.calburntextBox1.Size = new System.Drawing.Size(124, 22);
            this.calburntextBox1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Degree(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "First Name";
            // 
            // View_Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 230);
            this.Controls.Add(this.progfinishtextBox1);
            this.Controls.Add(this.calcounttextBox1);
            this.Controls.Add(this.calburntextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "View_Trainer";
            this.Text = "View_Trainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox progfinishtextBox1;
        private System.Windows.Forms.TextBox calcounttextBox1;
        private System.Windows.Forms.TextBox calburntextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

    }
}