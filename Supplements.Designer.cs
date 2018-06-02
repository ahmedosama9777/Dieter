namespace Dieter
{
    partial class Supplements
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
            this.supGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.supGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // supGridView1
            // 
            this.supGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supGridView1.Location = new System.Drawing.Point(12, 12);
            this.supGridView1.Name = "supGridView1";
            this.supGridView1.RowTemplate.Height = 24;
            this.supGridView1.Size = new System.Drawing.Size(570, 378);
            this.supGridView1.TabIndex = 4;
            // 
            // Supplements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 402);
            this.Controls.Add(this.supGridView1);
            this.Name = "Supplements";
            this.Text = "Supplements";
            this.Load += new System.EventHandler(this.Supplements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView supGridView1;
    }
}