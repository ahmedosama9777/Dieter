namespace Dieter
{
    partial class WorkoutsNT
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
            this.workoutGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.workoutGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // workoutGridView1
            // 
            this.workoutGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workoutGridView1.Location = new System.Drawing.Point(11, 12);
            this.workoutGridView1.Name = "workoutGridView1";
            this.workoutGridView1.RowTemplate.Height = 24;
            this.workoutGridView1.Size = new System.Drawing.Size(685, 363);
            this.workoutGridView1.TabIndex = 3;
            this.workoutGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dietGridView1_CellContentClick);
            // 
            // WorkoutsNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 387);
            this.Controls.Add(this.workoutGridView1);
            this.Name = "WorkoutsNT";
            this.Text = "WorkoutsNT";
            this.Load += new System.EventHandler(this.WorkoutsNT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workoutGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView workoutGridView1;
    }
}