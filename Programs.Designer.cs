namespace Dieter
{
    partial class Programs
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.progGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // progGridView1
            // 
            this.progGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.progGridView1.Location = new System.Drawing.Point(12, 12);
            this.progGridView1.Name = "progGridView1";
            this.progGridView1.RowTemplate.Height = 24;
            this.progGridView1.Size = new System.Drawing.Size(539, 302);
            this.progGridView1.TabIndex = 0;
            this.progGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.progGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Subscribe";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Programs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progGridView1);
            this.Name = "Programs";
            this.Text = "Programs";
            this.Load += new System.EventHandler(this.Programs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView progGridView1;
        private System.Windows.Forms.Button button1;
    }
}