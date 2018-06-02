namespace Dieter
{
    partial class Change_Admin_Password
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newpassTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.oldpassTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "new password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "old password";
            // 
            // newpassTextBox2
            // 
            this.newpassTextBox2.Location = new System.Drawing.Point(152, 95);
            this.newpassTextBox2.Name = "newpassTextBox2";
            this.newpassTextBox2.Size = new System.Drawing.Size(176, 22);
            this.newpassTextBox2.TabIndex = 7;
            // 
            // oldpassTextBox
            // 
            this.oldpassTextBox.Location = new System.Drawing.Point(152, 48);
            this.oldpassTextBox.Name = "oldpassTextBox";
            this.oldpassTextBox.Size = new System.Drawing.Size(176, 22);
            this.oldpassTextBox.TabIndex = 6;
            // 
            // Change_Admin_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newpassTextBox2);
            this.Controls.Add(this.oldpassTextBox);
            this.Name = "Change_Admin_Password";
            this.Text = "Change_Admin_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox newpassTextBox2;
        private System.Windows.Forms.MaskedTextBox oldpassTextBox;
    }
}