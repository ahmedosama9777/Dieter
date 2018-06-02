namespace Dieter
{
    partial class DietGuide
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
            this.dietguideGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dietguideGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dietguideGridView1
            // 
            this.dietguideGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dietguideGridView1.Location = new System.Drawing.Point(12, 68);
            this.dietguideGridView1.Name = "dietguideGridView1";
            this.dietguideGridView1.RowTemplate.Height = 24;
            this.dietguideGridView1.Size = new System.Drawing.Size(580, 268);
            this.dietguideGridView1.TabIndex = 5;
            this.dietguideGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dietguideGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Here you\'ll find restaurants where you can enjoy guilt free meals";
            // 
            // DietGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dietguideGridView1);
            this.Name = "DietGuide";
            this.Text = "Diet Guide";
            this.Load += new System.EventHandler(this.DietGuide_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dietguideGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dietguideGridView1;
        private System.Windows.Forms.Label label1;
    }
}