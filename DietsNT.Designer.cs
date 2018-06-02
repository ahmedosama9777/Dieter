namespace Dieter
{
    partial class DietsNT
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
            this.dietGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dietGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dietGridView1
            // 
            this.dietGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dietGridView1.Location = new System.Drawing.Point(12, 12);
            this.dietGridView1.Name = "dietGridView1";
            this.dietGridView1.RowTemplate.Height = 24;
            this.dietGridView1.Size = new System.Drawing.Size(685, 363);
            this.dietGridView1.TabIndex = 3;
            // 
            // DietsNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 390);
            this.Controls.Add(this.dietGridView1);
            this.Name = "DietsNT";
            this.Text = "DIetsNT";
            this.Load += new System.EventHandler(this.DietsNT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dietGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dietGridView1;
    }
}