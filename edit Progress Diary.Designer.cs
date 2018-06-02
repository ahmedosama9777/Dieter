namespace Dieter
{
    partial class edit_Progress_Diary
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
            this.label1 = new System.Windows.Forms.Label();
            this.upStWtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.upCalcounttextBox = new System.Windows.Forms.TextBox();
            this.upCalBtextBox = new System.Windows.Forms.TextBox();
            this.upCurrWtextBox = new System.Windows.Forms.TextBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Weight";
            // 
            // upStWtextBox
            // 
            this.upStWtextBox.Location = new System.Drawing.Point(195, 28);
            this.upStWtextBox.Name = "upStWtextBox";
            this.upStWtextBox.Size = new System.Drawing.Size(100, 22);
            this.upStWtextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Today\'s Calorie Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Today\'s Calorie Burnt";
            // 
            // upCalcounttextBox
            // 
            this.upCalcounttextBox.Location = new System.Drawing.Point(246, 153);
            this.upCalcounttextBox.Name = "upCalcounttextBox";
            this.upCalcounttextBox.Size = new System.Drawing.Size(100, 22);
            this.upCalcounttextBox.TabIndex = 5;
            // 
            // upCalBtextBox
            // 
            this.upCalBtextBox.Location = new System.Drawing.Point(246, 111);
            this.upCalBtextBox.Name = "upCalBtextBox";
            this.upCalBtextBox.Size = new System.Drawing.Size(100, 22);
            this.upCalBtextBox.TabIndex = 6;
            // 
            // upCurrWtextBox
            // 
            this.upCurrWtextBox.Location = new System.Drawing.Point(195, 69);
            this.upCurrWtextBox.Name = "upCurrWtextBox";
            this.upCurrWtextBox.Size = new System.Drawing.Size(100, 22);
            this.upCurrWtextBox.TabIndex = 7;
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(159, 210);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(80, 34);
            this.updatebutton.TabIndex = 8;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // edit_Progress_Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 264);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.upCurrWtextBox);
            this.Controls.Add(this.upCalBtextBox);
            this.Controls.Add(this.upCalcounttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upStWtextBox);
            this.Controls.Add(this.label1);
            this.Name = "edit_Progress_Diary";
            this.Text = "edit_Progress_Diary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox upStWtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox upCalcounttextBox;
        private System.Windows.Forms.TextBox upCalBtextBox;
        private System.Windows.Forms.TextBox upCurrWtextBox;
        private System.Windows.Forms.Button updatebutton;
    }
}