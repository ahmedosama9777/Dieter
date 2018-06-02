namespace Dieter
{
    partial class Diets
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
            this.subdbutton = new System.Windows.Forms.Button();
            this.dietGridView1 = new System.Windows.Forms.DataGridView();
            this.DietIDtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dietGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // subdbutton
            // 
            this.subdbutton.Location = new System.Drawing.Point(523, 369);
            this.subdbutton.Name = "subdbutton";
            this.subdbutton.Size = new System.Drawing.Size(103, 33);
            this.subdbutton.TabIndex = 1;
            this.subdbutton.Text = "Subscribe";
            this.subdbutton.UseVisualStyleBackColor = true;
            this.subdbutton.Click += new System.EventHandler(this.subdbutton_Click);
            // 
            // dietGridView1
            // 
            this.dietGridView1.AllowUserToAddRows = false;
            this.dietGridView1.AllowUserToDeleteRows = false;
            this.dietGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dietGridView1.Location = new System.Drawing.Point(0, 0);
            this.dietGridView1.MultiSelect = false;
            this.dietGridView1.Name = "dietGridView1";
            this.dietGridView1.ReadOnly = true;
            this.dietGridView1.RowTemplate.Height = 24;
            this.dietGridView1.Size = new System.Drawing.Size(685, 363);
            this.dietGridView1.TabIndex = 2;
            this.dietGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dietGridView1_CellContentClick_1);
            // 
            // DietIDtextBox
            // 
            this.DietIDtextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.DietIDtextBox.Location = new System.Drawing.Point(345, 369);
            this.DietIDtextBox.Multiline = true;
            this.DietIDtextBox.Name = "DietIDtextBox";
            this.DietIDtextBox.Size = new System.Drawing.Size(161, 33);
            this.DietIDtextBox.TabIndex = 3;
            this.DietIDtextBox.Text = "Enter Diet ID here...";
            // 
            // Diets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 414);
            this.Controls.Add(this.DietIDtextBox);
            this.Controls.Add(this.dietGridView1);
            this.Controls.Add(this.subdbutton);
            this.Name = "Diets";
            this.Text = "Diets";
            this.Load += new System.EventHandler(this.Diets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dietGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button subdbutton;
        private System.Windows.Forms.DataGridView dietGridView1;
        private System.Windows.Forms.TextBox DietIDtextBox;
    }
}