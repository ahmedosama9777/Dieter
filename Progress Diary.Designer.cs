namespace Dieter
{
    partial class Progress_Diary
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editprogbutton = new System.Windows.Forms.Button();
            this.stweighttextBox1 = new System.Windows.Forms.TextBox();
            this.currweighttextBox = new System.Windows.Forms.TextBox();
            this.currweightnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stwtnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.calburnnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.calcounttextBox1 = new System.Windows.Forms.TextBox();
            this.calcountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.progsfinishednumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.currweightnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stwtnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calburnnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progsfinishednumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your starting weight was: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Now your weight is: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calories burnt today:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calories count today:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Promgrams finished so far:";
            // 
            // editprogbutton
            // 
            this.editprogbutton.Location = new System.Drawing.Point(374, 153);
            this.editprogbutton.Name = "editprogbutton";
            this.editprogbutton.Size = new System.Drawing.Size(197, 35);
            this.editprogbutton.TabIndex = 5;
            this.editprogbutton.Text = "Update Progress Diary";
            this.editprogbutton.UseVisualStyleBackColor = true;
            this.editprogbutton.Click += new System.EventHandler(this.editprogbutton_Click);
            // 
            // stweighttextBox1
            // 
            this.stweighttextBox1.Location = new System.Drawing.Point(471, 35);
            this.stweighttextBox1.Name = "stweighttextBox1";
            this.stweighttextBox1.ReadOnly = true;
            this.stweighttextBox1.Size = new System.Drawing.Size(100, 22);
            this.stweighttextBox1.TabIndex = 7;
            // 
            // currweighttextBox
            // 
            this.currweighttextBox.Location = new System.Drawing.Point(471, 73);
            this.currweighttextBox.Name = "currweighttextBox";
            this.currweighttextBox.ReadOnly = true;
            this.currweighttextBox.Size = new System.Drawing.Size(100, 22);
            this.currweighttextBox.TabIndex = 10;
            // 
            // currweightnumericUpDown
            // 
            this.currweightnumericUpDown.Location = new System.Drawing.Point(471, 73);
            this.currweightnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.currweightnumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.currweightnumericUpDown.Name = "currweightnumericUpDown";
            this.currweightnumericUpDown.Size = new System.Drawing.Size(115, 22);
            this.currweightnumericUpDown.TabIndex = 42;
            // 
            // stwtnumericUpDown
            // 
            this.stwtnumericUpDown.Location = new System.Drawing.Point(471, 33);
            this.stwtnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.stwtnumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.stwtnumericUpDown.Name = "stwtnumericUpDown";
            this.stwtnumericUpDown.ReadOnly = true;
            this.stwtnumericUpDown.Size = new System.Drawing.Size(115, 22);
            this.stwtnumericUpDown.TabIndex = 43;
            // 
            // calburnnumericUpDown
            // 
            this.calburnnumericUpDown.Location = new System.Drawing.Point(171, 35);
            this.calburnnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.calburnnumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.calburnnumericUpDown.Name = "calburnnumericUpDown";
            this.calburnnumericUpDown.Size = new System.Drawing.Size(115, 22);
            this.calburnnumericUpDown.TabIndex = 41;
            // 
            // calcounttextBox1
            // 
            this.calcounttextBox1.Location = new System.Drawing.Point(171, 73);
            this.calcounttextBox1.Name = "calcounttextBox1";
            this.calcounttextBox1.ReadOnly = true;
            this.calcounttextBox1.Size = new System.Drawing.Size(100, 22);
            this.calcounttextBox1.TabIndex = 8;
            this.calcounttextBox1.TextChanged += new System.EventHandler(this.calcounttextBox1_TextChanged);
            // 
            // calcountNumericUpDown
            // 
            this.calcountNumericUpDown.Location = new System.Drawing.Point(171, 74);
            this.calcountNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.calcountNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.calcountNumericUpDown.Name = "calcountNumericUpDown";
            this.calcountNumericUpDown.Size = new System.Drawing.Size(115, 22);
            this.calcountNumericUpDown.TabIndex = 40;
            // 
            // progsfinishednumeric
            // 
            this.progsfinishednumeric.Location = new System.Drawing.Point(216, 148);
            this.progsfinishednumeric.Margin = new System.Windows.Forms.Padding(4);
            this.progsfinishednumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.progsfinishednumeric.Name = "progsfinishednumeric";
            this.progsfinishednumeric.ReadOnly = true;
            this.progsfinishednumeric.Size = new System.Drawing.Size(115, 22);
            this.progsfinishednumeric.TabIndex = 44;
            // 
            // Progress_Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 225);
            this.Controls.Add(this.progsfinishednumeric);
            this.Controls.Add(this.stwtnumericUpDown);
            this.Controls.Add(this.currweightnumericUpDown);
            this.Controls.Add(this.calburnnumericUpDown);
            this.Controls.Add(this.calcountNumericUpDown);
            this.Controls.Add(this.currweighttextBox);
            this.Controls.Add(this.calcounttextBox1);
            this.Controls.Add(this.stweighttextBox1);
            this.Controls.Add(this.editprogbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Progress_Diary";
            this.Text = "Progress_Diary";
            this.Load += new System.EventHandler(this.Progress_Diary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currweightnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stwtnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calburnnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progsfinishednumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editprogbutton;
        private System.Windows.Forms.TextBox stweighttextBox1;
        private System.Windows.Forms.TextBox currweighttextBox;
        private System.Windows.Forms.NumericUpDown currweightnumericUpDown;
        private System.Windows.Forms.NumericUpDown stwtnumericUpDown;
        private System.Windows.Forms.NumericUpDown calburnnumericUpDown;
        private System.Windows.Forms.TextBox calcounttextBox1;
        private System.Windows.Forms.NumericUpDown calcountNumericUpDown;
        private System.Windows.Forms.NumericUpDown progsfinishednumeric;

    }
}