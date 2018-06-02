namespace Dieter
{
    partial class Dieter
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
            this.programname1 = new System.Windows.Forms.Label();
            this.notificationlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.namelabel1 = new System.Windows.Forms.Label();
            this.progbutton1 = new System.Windows.Forms.Button();
            this.suggestionlabel = new System.Windows.Forms.Label();
            this.dietButton1 = new System.Windows.Forms.Button();
            this.workoutButton1 = new System.Windows.Forms.Button();
            this.Addmenu1 = new System.Windows.Forms.ComboBox();
            this.viewbox1 = new System.Windows.Forms.ComboBox();
            this.logoutButton1 = new System.Windows.Forms.Button();
            this.editinfoButton1 = new System.Windows.Forms.Button();
            this.prognamelabel2 = new System.Windows.Forms.Label();
            this.andlabel = new System.Windows.Forms.Label();
            this.unsubscribebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, ";
            // 
            // programname1
            // 
            this.programname1.AutoSize = true;
            this.programname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programname1.Location = new System.Drawing.Point(332, 113);
            this.programname1.Name = "programname1";
            this.programname1.Size = new System.Drawing.Size(70, 24);
            this.programname1.TabIndex = 1;
            this.programname1.Text = "(name)";
            // 
            // notificationlabel
            // 
            this.notificationlabel.AutoSize = true;
            this.notificationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationlabel.Location = new System.Drawing.Point(34, 113);
            this.notificationlabel.Name = "notificationlabel";
            this.notificationlabel.Size = new System.Drawing.Size(276, 24);
            this.notificationlabel.TabIndex = 2;
            this.notificationlabel.Text = "You are currently subscribed to ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "What are you looking for?";
            // 
            // namelabel1
            // 
            this.namelabel1.AutoSize = true;
            this.namelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel1.Location = new System.Drawing.Point(218, 41);
            this.namelabel1.Name = "namelabel1";
            this.namelabel1.Size = new System.Drawing.Size(148, 44);
            this.namelabel1.TabIndex = 4;
            this.namelabel1.Text = "(name)";
            // 
            // progbutton1
            // 
            this.progbutton1.Location = new System.Drawing.Point(468, 166);
            this.progbutton1.Name = "progbutton1";
            this.progbutton1.Size = new System.Drawing.Size(104, 30);
            this.progbutton1.TabIndex = 5;
            this.progbutton1.Text = "See Progress";
            this.progbutton1.UseVisualStyleBackColor = true;
            this.progbutton1.Click += new System.EventHandler(this.progbutton1_Click);
            // 
            // suggestionlabel
            // 
            this.suggestionlabel.AutoSize = true;
            this.suggestionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestionlabel.Location = new System.Drawing.Point(78, 139);
            this.suggestionlabel.Name = "suggestionlabel";
            this.suggestionlabel.Size = new System.Drawing.Size(80, 18);
            this.suggestionlabel.TabIndex = 6;
            this.suggestionlabel.Text = "Keept it up!";
            // 
            // dietButton1
            // 
            this.dietButton1.Location = new System.Drawing.Point(90, 286);
            this.dietButton1.Name = "dietButton1";
            this.dietButton1.Size = new System.Drawing.Size(120, 65);
            this.dietButton1.TabIndex = 7;
            this.dietButton1.Text = "View Diets";
            this.dietButton1.UseVisualStyleBackColor = true;
            this.dietButton1.Click += new System.EventHandler(this.dietButton1_Click);
            // 
            // workoutButton1
            // 
            this.workoutButton1.Location = new System.Drawing.Point(246, 286);
            this.workoutButton1.Name = "workoutButton1";
            this.workoutButton1.Size = new System.Drawing.Size(120, 65);
            this.workoutButton1.TabIndex = 8;
            this.workoutButton1.Text = "View Workouts";
            this.workoutButton1.UseVisualStyleBackColor = true;
            this.workoutButton1.Click += new System.EventHandler(this.workoutButton1_Click);
            // 
            // Addmenu1
            // 
            this.Addmenu1.FormattingEnabled = true;
            this.Addmenu1.Items.AddRange(new object[] {
            "Add Recipe",
            "Add Supplement",
            "Add Diet Guide",
            "Add Cheat Guide"});
            this.Addmenu1.Location = new System.Drawing.Point(451, 12);
            this.Addmenu1.Name = "Addmenu1";
            this.Addmenu1.Size = new System.Drawing.Size(121, 24);
            this.Addmenu1.TabIndex = 9;
            this.Addmenu1.Text = "Add Menu";
            this.Addmenu1.SelectedIndexChanged += new System.EventHandler(this.Addmenu1_SelectedIndexChanged);
            // 
            // viewbox1
            // 
            this.viewbox1.FormattingEnabled = true;
            this.viewbox1.Items.AddRange(new object[] {
            "Recipes",
            "Supplements",
            "Guides"});
            this.viewbox1.Location = new System.Drawing.Point(298, 384);
            this.viewbox1.Name = "viewbox1";
            this.viewbox1.Size = new System.Drawing.Size(121, 24);
            this.viewbox1.TabIndex = 10;
            this.viewbox1.SelectedIndexChanged += new System.EventHandler(this.viewbox1_SelectedIndexChanged);
            // 
            // logoutButton1
            // 
            this.logoutButton1.Location = new System.Drawing.Point(507, 425);
            this.logoutButton1.Name = "logoutButton1";
            this.logoutButton1.Size = new System.Drawing.Size(86, 31);
            this.logoutButton1.TabIndex = 11;
            this.logoutButton1.Text = "Log out";
            this.logoutButton1.UseVisualStyleBackColor = true;
            this.logoutButton1.Click += new System.EventHandler(this.logoutButton1_Click);
            // 
            // editinfoButton1
            // 
            this.editinfoButton1.Location = new System.Drawing.Point(415, 425);
            this.editinfoButton1.Name = "editinfoButton1";
            this.editinfoButton1.Size = new System.Drawing.Size(86, 31);
            this.editinfoButton1.TabIndex = 12;
            this.editinfoButton1.Text = "Edit info";
            this.editinfoButton1.UseVisualStyleBackColor = true;
            this.editinfoButton1.Click += new System.EventHandler(this.editinfoButton1_Click);
            // 
            // prognamelabel2
            // 
            this.prognamelabel2.AutoSize = true;
            this.prognamelabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prognamelabel2.Location = new System.Drawing.Point(502, 113);
            this.prognamelabel2.Name = "prognamelabel2";
            this.prognamelabel2.Size = new System.Drawing.Size(70, 24);
            this.prognamelabel2.TabIndex = 13;
            this.prognamelabel2.Text = "(name)";
            // 
            // andlabel
            // 
            this.andlabel.AutoSize = true;
            this.andlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.andlabel.Location = new System.Drawing.Point(435, 113);
            this.andlabel.Name = "andlabel";
            this.andlabel.Size = new System.Drawing.Size(42, 24);
            this.andlabel.TabIndex = 14;
            this.andlabel.Text = "and";
            // 
            // unsubscribebutton
            // 
            this.unsubscribebutton.Location = new System.Drawing.Point(358, 166);
            this.unsubscribebutton.Name = "unsubscribebutton";
            this.unsubscribebutton.Size = new System.Drawing.Size(104, 30);
            this.unsubscribebutton.TabIndex = 15;
            this.unsubscribebutton.Text = "Finish";
            this.unsubscribebutton.UseVisualStyleBackColor = true;
            this.unsubscribebutton.Click += new System.EventHandler(this.unsubscribebutton_Click);
            // 
            // Dieter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 481);
            this.Controls.Add(this.unsubscribebutton);
            this.Controls.Add(this.andlabel);
            this.Controls.Add(this.prognamelabel2);
            this.Controls.Add(this.editinfoButton1);
            this.Controls.Add(this.logoutButton1);
            this.Controls.Add(this.viewbox1);
            this.Controls.Add(this.Addmenu1);
            this.Controls.Add(this.workoutButton1);
            this.Controls.Add(this.dietButton1);
            this.Controls.Add(this.suggestionlabel);
            this.Controls.Add(this.progbutton1);
            this.Controls.Add(this.namelabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.notificationlabel);
            this.Controls.Add(this.programname1);
            this.Controls.Add(this.label1);
            this.Name = "Dieter";
            this.Text = "Dieter";
            this.Load += new System.EventHandler(this.Dieter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label programname1;
        private System.Windows.Forms.Label notificationlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label namelabel1;
        private System.Windows.Forms.Button progbutton1;
        private System.Windows.Forms.Label suggestionlabel;
        private System.Windows.Forms.Button dietButton1;
        private System.Windows.Forms.Button workoutButton1;
        private System.Windows.Forms.ComboBox Addmenu1;
        private System.Windows.Forms.ComboBox viewbox1;
        private System.Windows.Forms.Button logoutButton1;
        private System.Windows.Forms.Button editinfoButton1;
        private System.Windows.Forms.Label prognamelabel2;
        private System.Windows.Forms.Label andlabel;
        private System.Windows.Forms.Button unsubscribebutton;
    }
}