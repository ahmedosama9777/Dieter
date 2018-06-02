namespace Dieter
{
    partial class Board
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
            this.progGridView = new System.Windows.Forms.DataGridView();
            this.dietsGridView = new System.Windows.Forms.DataGridView();
            this.workoutsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.unsubbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.progGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // progGridView
            // 
            this.progGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.progGridView.Location = new System.Drawing.Point(1, 44);
            this.progGridView.Name = "progGridView";
            this.progGridView.RowTemplate.Height = 24;
            this.progGridView.Size = new System.Drawing.Size(839, 134);
            this.progGridView.TabIndex = 0;
            // 
            // dietsGridView
            // 
            this.dietsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dietsGridView.Location = new System.Drawing.Point(1, 226);
            this.dietsGridView.Name = "dietsGridView";
            this.dietsGridView.RowTemplate.Height = 24;
            this.dietsGridView.Size = new System.Drawing.Size(839, 150);
            this.dietsGridView.TabIndex = 1;
            // 
            // workoutsGridView
            // 
            this.workoutsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workoutsGridView.Location = new System.Drawing.Point(1, 420);
            this.workoutsGridView.Name = "workoutsGridView";
            this.workoutsGridView.RowTemplate.Height = 24;
            this.workoutsGridView.Size = new System.Drawing.Size(839, 157);
            this.workoutsGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Programs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Diets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Workouts";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(448, 601);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(191, 22);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // unsubbutton
            // 
            this.unsubbutton.Location = new System.Drawing.Point(659, 593);
            this.unsubbutton.Name = "unsubbutton";
            this.unsubbutton.Size = new System.Drawing.Size(115, 31);
            this.unsubbutton.TabIndex = 7;
            this.unsubbutton.Text = "Unsubscribe";
            this.unsubbutton.UseVisualStyleBackColor = true;
            this.unsubbutton.Click += new System.EventHandler(this.unsubbutton_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 635);
            this.Controls.Add(this.unsubbutton);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workoutsGridView);
            this.Controls.Add(this.dietsGridView);
            this.Controls.Add(this.progGridView);
            this.Name = "Board";
            this.Text = "Board";
            this.Load += new System.EventHandler(this.Board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView progGridView;
        private System.Windows.Forms.DataGridView dietsGridView;
        private System.Windows.Forms.DataGridView workoutsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button unsubbutton;
    }
}