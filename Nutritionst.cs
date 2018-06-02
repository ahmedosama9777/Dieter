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
    public partial class Nutritionst : Form
    {
        Controller controllerObj;
        public Nutritionst()
        {
            InitializeComponent();
        }

        private void Addmenu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Addmenu1.SelectedItem.ToString() == "Add Diet")
            {
                Add_Diet ADF1 = new Add_Diet();
                ADF1.Show();
            }
            if (Addmenu1.SelectedItem.ToString() == "Add Program")
            {
                Add_Program APF1 = new Add_Program();
                APF1.Show();
            }
            if (Addmenu1.SelectedItem.ToString() == "Add Recipe")
            {
                Add_Recipe RF = new Add_Recipe();
                RF.Show();
            }
            if (Addmenu1.SelectedItem.ToString() == "Add Supplement")
            {
                Supplement SF = new Supplement();
                SF.Show();
            }
            if (Addmenu1.SelectedItem.ToString() == "Add Diet Guide")
            {
                Add_Guide DGF = new Add_Guide();
                DGF.Show();
            }
            if (Addmenu1.SelectedItem.ToString() == "Add Cheat Guide")
            {
                Add_Cheat_Guide CGF = new Add_Cheat_Guide();
                CGF.Show();
            }
        }

        private void namelabel1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void viewbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select = viewbox1.SelectedItem.ToString();
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
            Edit_Nutritionist EDF1 = new Edit_Nutritionist();
            EDF1.Show();
        }

        private void dietButton1_Click(object sender, EventArgs e)
        {
            DietsNT DNT = new DietsNT();
            DNT.Show();
        }

        private void programname1_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome wel = new Welcome();
            wel.Show();
        }

        private void workoutButton1_Click(object sender, EventArgs e)
        {
            WorkoutsNT WNT = new WorkoutsNT();
            WNT.Show();
        }

        private void progbutton1_Click(object sender, EventArgs e)
        {
            Diets_and_Programs DP1 = new Diets_and_Programs();
            DP1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramsNT PNTF1 = new ProgramsNT();
            PNTF1.Show();
        }

        private void Nutritionst_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataRow res = controllerObj.ViewNutritionists(Datacontainer.NutID).Rows[0];
            namelabel1.Text = (string)res["Fname"];
        }
    }
}
