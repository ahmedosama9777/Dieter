namespace Dieter
{
    partial class Premium_Dieter
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
            this.Addmenu2 = new System.Windows.Forms.ComboBox();
            this.workoutButton1 = new System.Windows.Forms.Button();
            this.dietButton1 = new System.Windows.Forms.Button();
            this.progbutton2 = new System.Windows.Forms.Button();
            this.namelabel1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.programname1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editinfoButton1
            // 
            this.editinfoButton1.Location = new System.Drawing.Point(407, 431);
            this.editinfoButton1.Name = "editinfoButton1";
            this.editinfoButton1.Size = new System.Drawing.Size(86, 31);
            this.editinfoButton1.TabIndex = 25;
            this.editinfoButton1.Text = "Edit info";
            this.editinfoButton1.UseVisualStyleBackColor = true;
            this.editinfoButton1.Click += new System.EventHandler(this.editinfoButton1_Click);
            // 
            // logoutButton1
            // 
            this.logoutButton1.Location = new System.Drawing.Point(499, 431);
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
            this.viewbox1.Location = new System.Drawing.Point(285, 373);
            this.viewbox1.Name = "viewbox1";
            this.viewbox1.Size = new System.Drawing.Size(121, 24);
            this.viewbox1.TabIndex = 23;
            this.viewbox1.SelectedIndexChanged += new System.EventHandler(this.viewbox1_SelectedIndexChanged);
            // 
            // Addmenu2
            // 
            this.Addmenu2.FormattingEnabled = true;
            this.Addmenu2.Items.AddRange(new object[] {
            "Add Recipe",
            "Add Supplement",
            "Add Diet Guide",
            "Add Cheat Guide"});
            this.Addmenu2.Location = new System.Drawing.Point(443, 18);
            this.Addmenu2.Name = "Addmenu2";
            this.Addmenu2.Size = new System.Drawing.Size(121, 24);
            this.Addmenu2.TabIndex = 22;
            this.Addmenu2.Text = "Add Menu";
            this.Addmenu2.SelectedIndexChanged += new System.EventHandler(this.Addmenu2_SelectedIndexChanged);
            // 
            // workoutButton1
            // 
            this.workoutButton1.Location = new System.Drawing.Point(218, 239);
            this.workoutButton1.Name = "workoutButton1";
            this.workoutButton1.Size = new System.Drawing.Size(120, 65);
            this.workoutButton1.TabIndex = 21;
            this.workoutButton1.Text = "View Workouts";
            this.workoutButton1.UseVisualStyleBackColor = true;
            this.workoutButton1.Click += new System.EventHandler(this.workoutButton1_Click);
            // 
            // dietButton1
            // 
            this.dietButton1.Location = new System.Drawing.Point(62, 239);
            this.dietButton1.Name = "dietButton1";
            this.dietButton1.Size = new System.Drawing.Size(120, 65);
            this.dietButton1.TabIndex = 20;
            this.dietButton1.Text = "View Diets";
            this.dietButton1.UseVisualStyleBackColor = true;
            this.dietButton1.Click += new System.EventHandler(this.dietButton1_Click);
            // 
            // progbutton2
            // 
            this.progbutton2.Location = new System.Drawing.Point(328, 133);
            this.progbutton2.Name = "progbutton2";
            this.progbutton2.Size = new System.Drawing.Size(104, 30);
            this.progbutton2.TabIndex = 18;
            this.progbutton2.Text = "See Progress";
            this.progbutton2.UseVisualStyleBackColor = true;
            this.progbutton2.Click += new System.EventHandler(this.progbutton2_Click);
            // 
            // namelabel1
            // 
            this.namelabel1.AutoSize = true;
            this.namelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel1.Location = new System.Drawing.Point(210, 47);
            this.namelabel1.Name = "namelabel1";
            this.namelabel1.Size = new System.Drawing.Size(148, 44);
            this.namelabel1.TabIndex = 17;
            this.namelabel1.Text = "(name)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "What are you looking for?";
            // 
            // programname1
            // 
            this.programname1.AutoSize = true;
            this.programname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programname1.Location = new System.Drawing.Point(239, 115);
            this.programname1.Name = "programname1";
            this.programname1.Size = new System.Drawing.Size(0, 24);
            this.programname1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome, ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 65);
            this.button1.TabIndex = 26;
            this.button1.Text = "View Programs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 31);
            this.button2.TabIndex = 27;
            this.button2.Text = "Update payment details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Keep up with your subscriptions!";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 30);
            this.button3.TabIndex = 29;
            this.button3.Text = "See my Board";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Premium_Dieter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 480);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editinfoButton1);
            this.Controls.Add(this.logoutButton1);
            this.Controls.Add(this.viewbox1);
            this.Controls.Add(this.Addmenu2);
            this.Controls.Add(this.workoutButton1);
            this.Controls.Add(this.dietButton1);
            this.Controls.Add(this.progbutton2);
            this.Controls.Add(this.namelabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.programname1);
            this.Controls.Add(this.label1);
            this.Name = "Premium_Dieter";
            this.Text = "Premium_Dieter";
            this.Load += new System.EventHandler(this.Premium_Dieter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editinfoButton1;
        private System.Windows.Forms.Button logoutButton1;
        private System.Windows.Forms.ComboBox viewbox1;
        private System.Windows.Forms.ComboBox Addmenu2;
        private System.Windows.Forms.Button workoutButton1;
        private System.Windows.Forms.Button dietButton1;
        private System.Windows.Forms.Button progbutton2;
        private System.Windows.Forms.Label namelabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label programname1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}