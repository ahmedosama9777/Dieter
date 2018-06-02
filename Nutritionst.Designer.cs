namespace Dieter
{
    partial class Nutritionst
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
            this.editinfoButton1 = new System.Windows.Forms.Button();
            this.logoutButton1 = new System.Windows.Forms.Button();
            this.viewbox1 = new System.Windows.Forms.ComboBox();
            this.Addmenu1 = new System.Windows.Forms.ComboBox();
            this.workoutButton1 = new System.Windows.Forms.Button();
            this.dietButton1 = new System.Windows.Forms.Button();
            this.namelabel1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progbutton1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.programname1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editinfoButton1
            // 
            this.editinfoButton1.Location = new System.Drawing.Point(407, 461);
            this.editinfoButton1.Name = "editinfoButton1";
            this.editinfoButton1.Size = new System.Drawing.Size(86, 31);
            this.editinfoButton1.TabIndex = 25;
            this.editinfoButton1.Text = "Edit info";
            this.editinfoButton1.UseVisualStyleBackColor = true;
            this.editinfoButton1.Click += new System.EventHandler(this.editinfoButton1_Click);
            // 
            // logoutButton1
            // 
            this.logoutButton1.Location = new System.Drawing.Point(499, 461);
            this.logoutButton1.Name = "logoutButton1";
            this.logoutButton1.Size = new System.Drawing.Size(86, 31);
            this.logoutButton1.TabIndex = 24;
            this.logoutButton1.Text = "Log out";
            this.logoutButton1.UseVisualStyleBackColor = true;
            this.logoutButton1.Click += new System.EventHandler(this.logoutButton1_Click);
            // 
            // viewbox1
            // 
            this.viewbox1.FormattingEnabled = true;
            this.viewbox1.Items.AddRange(new object[] {
            "Recipes",
            "Supplements",
            "Guides"});
            this.viewbox1.Location = new System.Drawing.Point(285, 403);
            this.viewbox1.Name = "viewbox1";
            this.viewbox1.Size = new System.Drawing.Size(121, 24);
            this.viewbox1.TabIndex = 23;
            this.viewbox1.SelectedIndexChanged += new System.EventHandler(this.viewbox1_SelectedIndexChanged);
            // 
            // Addmenu1
            // 
            this.Addmenu1.FormattingEnabled = true;
            this.Addmenu1.Items.AddRange(new object[] {
            "Add Diet",
            "Add Program",
            "Add Recipe",
            "Add Supplement",
            "Add Diet Guide",
            "Add Cheat Guide"});
            this.Addmenu1.Location = new System.Drawing.Point(464, 43);
            this.Addmenu1.Name = "Addmenu1";
            this.Addmenu1.Size = new System.Drawing.Size(121, 24);
            this.Addmenu1.TabIndex = 22;
            this.Addmenu1.Text = "Add Menu";
            this.Addmenu1.SelectedIndexChanged += new System.EventHandler(this.Addmenu1_SelectedIndexChanged);
            // 
            // workoutButton1
            // 
            this.workoutButton1.Location = new System.Drawing.Point(218, 269);
            this.workoutButton1.Name = "workoutButton1";
            this.workoutButton1.Size = new System.Drawing.Size(120, 65);
            this.workoutButton1.TabIndex = 21;
            this.workoutButton1.Text = "View All Workouts";
            this.workoutButton1.UseVisualStyleBackColor = true;
            this.workoutButton1.Click += new System.EventHandler(this.workoutButton1_Click);
            // 
            // dietButton1
            // 
            this.dietButton1.Location = new System.Drawing.Point(62, 269);
            this.dietButton1.Name = "dietButton1";
            this.dietButton1.Size = new System.Drawing.Size(120, 65);
            this.dietButton1.TabIndex = 20;
            this.dietButton1.Text = "View All Diets";
            this.dietButton1.UseVisualStyleBackColor = true;
            this.dietButton1.Click += new System.EventHandler(this.dietButton1_Click);
            // 
            // namelabel1
            // 
            this.namelabel1.AutoSize = true;
            this.namelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel1.Location = new System.Drawing.Point(210, 77);
            this.namelabel1.Name = "namelabel1";
            this.namelabel1.Size = new System.Drawing.Size(148, 44);
            this.namelabel1.TabIndex = 17;
            this.namelabel1.Text = "(name)";
            this.namelabel1.Click += new System.EventHandler(this.namelabel1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "What are you looking for?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome, ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progbutton1
            // 
            this.progbutton1.Location = new System.Drawing.Point(328, 151);
            this.progbutton1.Name = "progbutton1";
            this.progbutton1.Size = new System.Drawing.Size(165, 66);
            this.progbutton1.TabIndex = 18;
            this.progbutton1.Text = "View my Diets and Programs";
            this.progbutton1.UseVisualStyleBackColor = true;
            this.progbutton1.Click += new System.EventHandler(this.progbutton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Keep track of your contribution";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // programname1
            // 
            this.programname1.AutoSize = true;
            this.programname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programname1.Location = new System.Drawing.Point(221, 151);
            this.programname1.Name = "programname1";
            this.programname1.Size = new System.Drawing.Size(70, 24);
            this.programname1.TabIndex = 26;
            this.programname1.Text = "(name)";
            this.programname1.Click += new System.EventHandler(this.programname1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 65);
            this.button1.TabIndex = 41;
            this.button1.Text = "View All Programs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nutritionst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.programname1);
            this.Controls.Add(this.editinfoButton1);
            this.Controls.Add(this.logoutButton1);
            this.Controls.Add(this.viewbox1);
            this.Controls.Add(this.Addmenu1);
            this.Controls.Add(this.workoutButton1);
            this.Controls.Add(this.dietButton1);
            this.Controls.Add(this.progbutton1);
            this.Controls.Add(this.namelabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Nutritionst";
            this.Text = "Nutritionst";
            this.Load += new System.EventHandler(this.Nutritionst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editinfoButton1;
        private System.Windows.Forms.Button logoutButton1;
        private System.Windows.Forms.ComboBox viewbox1;
        private System.Windows.Forms.ComboBox Addmenu1;
        private System.Windows.Forms.Button workoutButton1;
        private System.Windows.Forms.Button dietButton1;
        private System.Windows.Forms.Label namelabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button progbutton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label programname1;
        private System.Windows.Forms.Button button1;

    }
}