namespace Dieter
{
    partial class Workouts_and_Programs
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
            this.ProgramsGridView1 = new System.Windows.Forms.DataGridView();
            this.WorkoutGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramsGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkoutGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgramsGridView1
            // 
            this.ProgramsGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProgramsGridView1.Location = new System.Drawing.Point(71, 56);
            this.ProgramsGridView1.Name = "ProgramsGridView1";
            this.ProgramsGridView1.RowTemplate.Height = 24;
            this.ProgramsGridView1.Size = new System.Drawing.Size(657, 201);
            this.ProgramsGridView1.TabIndex = 1;
            // 
            // WorkoutGridView1
            // 
            this.WorkoutGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkoutGridView1.Location = new System.Drawing.Point(71, 318);
            this.WorkoutGridView1.Name = "WorkoutGridView1";
            this.WorkoutGridView1.RowTemplate.Height = 24;
            this.WorkoutGridView1.Size = new System.Drawing.Size(657, 201);
            this.WorkoutGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Programs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Workouts";
            // 
            // Workouts_and_Programs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WorkoutGridView1);
            this.Controls.Add(this.ProgramsGridView1);
            this.Name = "Workouts_and_Programs";
            this.Text = "Workouts_and_Programs";
            this.Load += new System.EventHandler(this.View_All_Workouts_and_Programs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProgramsGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkoutGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProgramsGridView1;
        private System.Windows.Forms.DataGridView WorkoutGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}