namespace Dieter
{
    partial class Workouts
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
            this.subwbutton = new System.Windows.Forms.Button();
            this.WorkoutIDtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.workoutGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // workoutGridView1
            // 
            this.workoutGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workoutGridView1.Location = new System.Drawing.Point(9, 12);
            this.workoutGridView1.MultiSelect = false;
            this.workoutGridView1.Name = "workoutGridView1";
            this.workoutGridView1.ReadOnly = true;
            this.workoutGridView1.RowTemplate.Height = 24;
            this.workoutGridView1.Size = new System.Drawing.Size(657, 333);
            this.workoutGridView1.TabIndex = 1;
            // 
            // subwbutton
            // 
            this.subwbutton.Location = new System.Drawing.Point(539, 359);
            this.subwbutton.Name = "subwbutton";
            this.subwbutton.Size = new System.Drawing.Size(103, 33);
            this.subwbutton.TabIndex = 2;
            this.subwbutton.Text = "Subscribe";
            this.subwbutton.UseVisualStyleBackColor = true;
            this.subwbutton.Click += new System.EventHandler(this.subwbutton_Click);
            // 
            // WorkoutIDtextBox
            // 
            this.WorkoutIDtextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.WorkoutIDtextBox.Location = new System.Drawing.Point(360, 359);
            this.WorkoutIDtextBox.Multiline = true;
            this.WorkoutIDtextBox.Name = "WorkoutIDtextBox";
            this.WorkoutIDtextBox.Size = new System.Drawing.Size(161, 33);
            this.WorkoutIDtextBox.TabIndex = 4;
            this.WorkoutIDtextBox.Text = "Enter Workout ID here...";
            this.WorkoutIDtextBox.TextChanged += new System.EventHandler(this.WorkoutIDtextBox_TextChanged);
            // 
            // Workouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 404);
            this.Controls.Add(this.WorkoutIDtextBox);
            this.Controls.Add(this.subwbutton);
            this.Controls.Add(this.workoutGridView1);
            this.Name = "Workouts";
            this.Text = "Workouts";
            this.Load += new System.EventHandler(this.Workouts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workoutGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView workoutGridView1;
        private System.Windows.Forms.Button subwbutton;
        private System.Windows.Forms.TextBox WorkoutIDtextBox;
    }
}