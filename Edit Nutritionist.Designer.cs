namespace Dieter
{
    partial class Edit_Nutritionist
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
            this.updinfobutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.degtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnametextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.fnametextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updinfobutton
            // 
            this.updinfobutton.Location = new System.Drawing.Point(187, 171);
            this.updinfobutton.Name = "updinfobutton";
            this.updinfobutton.Size = new System.Drawing.Size(102, 38);
            this.updinfobutton.TabIndex = 68;
            this.updinfobutton.Text = "Update info";
            this.updinfobutton.UseVisualStyleBackColor = true;
            this.updinfobutton.Click += new System.EventHandler(this.updinfobutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Degree:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // degtextBox
            // 
            this.degtextBox.Location = new System.Drawing.Point(130, 133);
            this.degtextBox.Name = "degtextBox";
            this.degtextBox.Size = new System.Drawing.Size(159, 22);
            this.degtextBox.TabIndex = 66;
            this.degtextBox.TextChanged += new System.EventHandler(this.stwtextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Last Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lnametextBox
            // 
            this.lnametextBox.Location = new System.Drawing.Point(130, 85);
            this.lnametextBox.Name = "lnametextBox";
            this.lnametextBox.Size = new System.Drawing.Size(159, 22);
            this.lnametextBox.TabIndex = 64;
            this.lnametextBox.TextChanged += new System.EventHandler(this.lnametextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "First Name:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // fnametextBox
            // 
            this.fnametextBox.Location = new System.Drawing.Point(130, 38);
            this.fnametextBox.Name = "fnametextBox";
            this.fnametextBox.Size = new System.Drawing.Size(159, 22);
            this.fnametextBox.TabIndex = 62;
            this.fnametextBox.TextChanged += new System.EventHandler(this.fnametextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 69;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit_Nutritionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updinfobutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.degtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnametextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fnametextBox);
            this.Name = "Edit_Nutritionist";
            this.Text = "Edit_Nutritionist";
            this.Load += new System.EventHandler(this.Edit_Nutritionist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updinfobutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox degtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lnametextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox fnametextBox;
        private System.Windows.Forms.Button button1;
    }
}