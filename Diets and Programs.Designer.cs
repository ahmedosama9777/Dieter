namespace Dieter
{
    partial class Diets_and_Programs
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DietsGridView1 = new System.Windows.Forms.DataGridView();
            this.ProgramsGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DietsGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramsGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Diets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Programs";
            // 
            // DietsGridView1
            // 
            this.DietsGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DietsGridView1.Location = new System.Drawing.Point(77, 312);
            this.DietsGridView1.Name = "DietsGridView1";
            this.DietsGridView1.RowTemplate.Height = 24;
            this.DietsGridView1.Size = new System.Drawing.Size(657, 201);
            this.DietsGridView1.TabIndex = 6;
            // 
            // ProgramsGridView1
            // 
            this.ProgramsGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProgramsGridView1.Location = new System.Drawing.Point(77, 50);
            this.ProgramsGridView1.Name = "ProgramsGridView1";
            this.ProgramsGridView1.RowTemplate.Height = 24;
            this.ProgramsGridView1.Size = new System.Drawing.Size(657, 201);
            this.ProgramsGridView1.TabIndex = 5;
            // 
            // Diets_and_Programs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DietsGridView1);
            this.Controls.Add(this.ProgramsGridView1);
            this.Name = "Diets_and_Programs";
            this.Text = "Diets_and_Programs";
            this.Load += new System.EventHandler(this.Diets_and_Programs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DietsGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramsGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DietsGridView1;
        private System.Windows.Forms.DataGridView ProgramsGridView1;
    }
}