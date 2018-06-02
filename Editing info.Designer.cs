namespace Dieter
{
    partial class Editing_info
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
            this.label12 = new System.Windows.Forms.Label();
            this.fnametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updinfobutton = new System.Windows.Forms.Button();
            this.stwtnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stwtnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(63, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 56;
            this.label12.Text = "first name:";
            // 
            // fnametextBox
            // 
            this.fnametextBox.Location = new System.Drawing.Point(175, 46);
            this.fnametextBox.Name = "fnametextBox";
            this.fnametextBox.Size = new System.Drawing.Size(120, 22);
            this.fnametextBox.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "last name:";
            // 
            // lnametextBox
            // 
            this.lnametextBox.Location = new System.Drawing.Point(175, 93);
            this.lnametextBox.Name = "lnametextBox";
            this.lnametextBox.Size = new System.Drawing.Size(120, 22);
            this.lnametextBox.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "starting weight";
            // 
            // updinfobutton
            // 
            this.updinfobutton.Location = new System.Drawing.Point(127, 206);
            this.updinfobutton.Name = "updinfobutton";
            this.updinfobutton.Size = new System.Drawing.Size(102, 38);
            this.updinfobutton.TabIndex = 61;
            this.updinfobutton.Text = "Update info";
            this.updinfobutton.UseVisualStyleBackColor = true;
            this.updinfobutton.Click += new System.EventHandler(this.updinfobutton_Click);
            // 
            // stwtnumericUpDown
            // 
            this.stwtnumericUpDown.Location = new System.Drawing.Point(204, 153);
            this.stwtnumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.stwtnumericUpDown.Name = "stwtnumericUpDown";
            this.stwtnumericUpDown.Size = new System.Drawing.Size(81, 22);
            this.stwtnumericUpDown.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 63;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Editing_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stwtnumericUpDown);
            this.Controls.Add(this.updinfobutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnametextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fnametextBox);
            this.Name = "Editing_info";
            this.Text = "Editing_info";
            this.Load += new System.EventHandler(this.Editing_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stwtnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox fnametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lnametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updinfobutton;
        private System.Windows.Forms.NumericUpDown stwtnumericUpDown;
        private System.Windows.Forms.Button button1;
    }
}