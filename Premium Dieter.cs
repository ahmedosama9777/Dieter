using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dieter
{
    public partial class Premium_Dieter : Form
    {
        Controller controllerObj;
        public Premium_Dieter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Programs PF1 = new Programs();
            PF1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment_Details PDF = new Payment_Details();
            PDF.Show();
        }

        private void progbutton2_Click(object sender, EventArgs e)
        {
            Progress_Diary PDiary = new Progress_Diary();
            PDiary.Show();
        }

        private void dietButton1_Click(object sender, EventArgs e)
        {
            Diets D2 = new Diets();
            D2.Show();
        }

        private void workoutButton1_Click(object sender, EventArgs e)
        {
            Workouts W2 = new Workouts();
            W2.Show();
        }

        private void Addmenu2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Addmenu2.SelectedItem.ToString() == "Add Recipe")
            {
                Add_Recipe RF = new Add_Recipe();
                RF.Show();
            }
            if (Addmenu2.SelectedItem.ToString() == "Add Supplement")
            {
                Supplement SF = new Supplement();
                SF.Show();
            }
            if (Addmenu2.SelectedItem.ToString() == "Add Diet Guide")
            {
                Add_Guide DGF = new Add_Guide();
                DGF.Show();
            }
            if (Addmenu2.SelectedItem.ToString() == "Add Cheat Guide")
            {
                Add_Cheat_Guide CGF = new Add_Cheat_Guide();
                CGF.Show();
            }
        }

        private void viewbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewbox1.SelectedItem.ToString() == "Recipes")
            {
                Recipes RF = new Recipes();
                RF.Show();
            }
            if (viewbox1.SelectedItem.ToString() == "Supplements")
            {
                Supplements SF = new Supplements();
                SF.Show();
            }
            if (viewbox1.SelectedItem.ToString() == "Guides")
            {
                Guide GF = new Guide();
                GF.Show();
            }
        }

        private void editinfoButton1_Click(object sender, EventArgs e)
        {
            Editing_info EI = new Editing_info();
            EI.Show();
        }

        private void logoutButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome wel = new Welcome();
            wel.Show();
        }

        private void Premium_Dieter_Load(object sender, EventArgs e)
        {
            //Datacontainer.loginDID = 123456;
            controllerObj = new Controller();
            DataRow res = controllerObj.ViewDieter(Datacontainer.loginPDID).Rows[0];
            namelabel1.Text = (string)res["Fname"];
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Board B = new Board();
            B.Show();
        }
    }
}
