namespace Dieter
{
    partial class ProgramsNT
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
            this.progGridView1 = new System.Windows.Forms.DataGridView();
            this.Addtoprogbutton = new System.Windows.Forms.Button();
            this.progIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.progGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // progGridView1
            // 
            this.progGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.progGridView1.Location = new System.Drawing.Point(13, 12);
            this.progGridView1.Name = "progGridView1";
            this.progGridView1.RowTemplate.Height = 24;
            this.progGridView1.Size = new System.Drawing.Size(539, 302);
            this.progGridView1.TabIndex = 1;
            this.progGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.progGridView1_CellContentClick);
            // 
            // Addtoprogbutton
            // 
            this.Addtoprogbutton.Location = new System.Drawing.Point(315, 320);
            this.Addtoprogbutton.Name = "Addtoprogbutton";
            this.Addtoprogbutton.Size = new System.Drawing.Size(236, 39);
            this.Addtoprogbutton.TabIndex = 2;
            this.Addtoprogbutton.Text = "Add Diet to Program";
            this.Addtoprogbutton.UseVisualStyleBackColor = true;
            this.Addtoprogbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // progIDTextBox
            // 
            this.progIDTextBox.Location = new System.Drawing.Point(13, 320);
            this.progIDTextBox.Name = "progIDTextBox";
            this.progIDTextBox.Size = new System.Drawing.Size(159, 22);
            this.progIDTextBox.TabIndex = 3;
            this.progIDTextBox.Text = "Enter Program ID...";
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(12, 348);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(297, 22);
            this.addTextBox.TabIndex = 4;
            this.addTextBox.Text = "Enter Diet...";
            // 
            // ProgramsNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 384);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.progIDTextBox);
            this.Controls.Add(this.Addtoprogbutton);
            this.Controls.Add(this.progGridView1);
            this.Name = "ProgramsNT";
            this.Text = "ProgramsNT";
            this.Load += new System.EventHandler(this.ProgramsNT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView progGridView1;
        private System.Windows.Forms.Button Addtoprogbutton;
        private System.Windows.Forms.MaskedTextBox progIDTextBox;
        private System.Windows.Forms.MaskedTextBox addTextBox;
    }
}