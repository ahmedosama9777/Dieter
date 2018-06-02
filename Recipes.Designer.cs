namespace Dieter
{
    partial class Recipes
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
            this.recbutton = new System.Windows.Forms.Button();
            this.recipiesGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.recipiesGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // recbutton
            // 
            this.recbutton.Location = new System.Drawing.Point(659, 426);
            this.recbutton.Name = "recbutton";
            this.recbutton.Size = new System.Drawing.Size(112, 36);
            this.recbutton.TabIndex = 3;
            this.recbutton.Text = "Open";
            this.recbutton.UseVisualStyleBackColor = true;
            // 
            // recipiesGridView1
            // 
            this.recipiesGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipiesGridView1.Location = new System.Drawing.Point(-2, 12);
            this.recipiesGridView1.Name = "recipiesGridView1";
            this.recipiesGridView1.RowTemplate.Height = 24;
            this.recipiesGridView1.Size = new System.Drawing.Size(796, 407);
            this.recipiesGridView1.TabIndex = 5;
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 474);
            this.Controls.Add(this.recipiesGridView1);
            this.Controls.Add(this.recbutton);
            this.Name = "Recipes";
            this.Text = "Recipes";
            this.Load += new System.EventHandler(this.Recipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipiesGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recbutton;
        private System.Windows.Forms.DataGridView recipiesGridView1;
    }
}