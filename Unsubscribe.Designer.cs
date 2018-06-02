namespace Dieter
{
    partial class Unsubscribe
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
            this.label1 = new System.Windows.Forms.Label();
            this.DietOnlyradiobutton = new System.Windows.Forms.RadioButton();
            this.WorkoutOnlyradiobutton = new System.Windows.Forms.RadioButton();
            this.BothradioButton = new System.Windows.Forms.RadioButton();
            this.unsubbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "What would you like to finish?";
            // 
            // DietOnlyradiobutton
            // 
            this.DietOnlyradiobutton.AutoSize = true;
            this.DietOnlyradiobutton.Location = new System.Drawing.Point(38, 92);
            this.DietOnlyradiobutton.Name = "DietOnlyradiobutton";
            this.DietOnlyradiobutton.Size = new System.Drawing.Size(87, 21);
            this.DietOnlyradiobutton.TabIndex = 1;
            this.DietOnlyradiobutton.TabStop = true;
            this.DietOnlyradiobutton.Text = "Diet Only";
            this.DietOnlyradiobutton.UseVisualStyleBackColor = true;
            // 
            // WorkoutOnlyradiobutton
            // 
            this.WorkoutOnlyradiobutton.AutoSize = true;
            this.WorkoutOnlyradiobutton.Location = new System.Drawing.Point(165, 92);
            this.WorkoutOnlyradiobutton.Name = "WorkoutOnlyradiobutton";
            this.WorkoutOnlyradiobutton.Size = new System.Drawing.Size(115, 21);
            this.WorkoutOnlyradiobutton.TabIndex = 2;
            this.WorkoutOnlyradiobutton.TabStop = true;
            this.WorkoutOnlyradiobutton.Text = "Workout Only";
            this.WorkoutOnlyradiobutton.UseVisualStyleBackColor = true;
            // 
            // BothradioButton
            // 
            this.BothradioButton.AutoSize = true;
            this.BothradioButton.Location = new System.Drawing.Point(314, 92);
            this.BothradioButton.Name = "BothradioButton";
            this.BothradioButton.Size = new System.Drawing.Size(58, 21);
            this.BothradioButton.TabIndex = 3;
            this.BothradioButton.TabStop = true;
            this.BothradioButton.Text = "Both";
            this.BothradioButton.UseVisualStyleBackColor = true;
            // 
            // unsubbutton
            // 
            this.unsubbutton.Location = new System.Drawing.Point(314, 128);
            this.unsubbutton.Name = "unsubbutton";
            this.unsubbutton.Size = new System.Drawing.Size(87, 39);
            this.unsubbutton.TabIndex = 4;
            this.unsubbutton.Text = "Ok";
            this.unsubbutton.UseVisualStyleBackColor = true;
            this.unsubbutton.Click += new System.EventHandler(this.unsubbutton_Click);
            // 
            // Unsubscribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 179);
            this.Controls.Add(this.unsubbutton);
            this.Controls.Add(this.BothradioButton);
            this.Controls.Add(this.WorkoutOnlyradiobutton);
            this.Controls.Add(this.DietOnlyradiobutton);
            this.Controls.Add(this.label1);
            this.Name = "Unsubscribe";
            this.Text = "Unsubscribe";
            this.Load += new System.EventHandler(this.Unsubscribe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton DietOnlyradiobutton;
        private System.Windows.Forms.RadioButton WorkoutOnlyradiobutton;
        private System.Windows.Forms.RadioButton BothradioButton;
        private System.Windows.Forms.Button unsubbutton;
    }
}