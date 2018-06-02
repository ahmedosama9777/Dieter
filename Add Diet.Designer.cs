namespace Dieter
{
    partial class Add_Diet
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
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.estwtlosstextBox = new System.Windows.Forms.TextBox();
            this.durtextBox = new System.Windows.Forms.TextBox();
            this.diettitletextBox = new System.Windows.Forms.TextBox();
            this.Addsuppbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dietpathtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Estimated Weight Loss";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Title:";
            // 
            // estwtlosstextBox
            // 
            this.estwtlosstextBox.Location = new System.Drawing.Point(192, 128);
            this.estwtlosstextBox.Name = "estwtlosstextBox";
            this.estwtlosstextBox.Size = new System.Drawing.Size(59, 22);
            this.estwtlosstextBox.TabIndex = 48;
            // 
            // durtextBox
            // 
            this.durtextBox.Location = new System.Drawing.Point(369, 128);
            this.durtextBox.Name = "durtextBox";
            this.durtextBox.Size = new System.Drawing.Size(62, 22);
            this.durtextBox.TabIndex = 46;
            // 
            // diettitletextBox
            // 
            this.diettitletextBox.Location = new System.Drawing.Point(118, 51);
            this.diettitletextBox.Name = "diettitletextBox";
            this.diettitletextBox.Size = new System.Drawing.Size(257, 22);
            this.diettitletextBox.TabIndex = 45;
            // 
            // Addsuppbutton
            // 
            this.Addsuppbutton.Location = new System.Drawing.Point(369, 243);
            this.Addsuppbutton.Name = "Addsuppbutton";
            this.Addsuppbutton.Size = new System.Drawing.Size(79, 46);
            this.Addsuppbutton.TabIndex = 44;
            this.Addsuppbutton.Text = "Add";
            this.Addsuppbutton.UseVisualStyleBackColor = true;
            this.Addsuppbutton.Click += new System.EventHandler(this.Addsuppbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Diet Path:";
            // 
            // dietpathtextBox
            // 
            this.dietpathtextBox.Location = new System.Drawing.Point(118, 200);
            this.dietpathtextBox.Name = "dietpathtextBox";
            this.dietpathtextBox.Size = new System.Drawing.Size(330, 22);
            this.dietpathtextBox.TabIndex = 54;
            this.dietpathtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Add_Diet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 339);
            this.Controls.Add(this.dietpathtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.estwtlosstextBox);
            this.Controls.Add(this.durtextBox);
            this.Controls.Add(this.diettitletextBox);
            this.Controls.Add(this.Addsuppbutton);
            this.Name = "Add_Diet";
            this.Text = "Add_Diet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox estwtlosstextBox;
        private System.Windows.Forms.TextBox durtextBox;
        private System.Windows.Forms.TextBox diettitletextBox;
        private System.Windows.Forms.Button Addsuppbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dietpathtextBox;
    }
}