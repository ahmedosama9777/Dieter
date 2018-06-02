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
    
    public partial class Dieter : Form
    {
        Controller controllerObj;
        //String select = "";
        public Dieter()
        {
            InitializeComponent();
        }

        private void Dieter_Load(object sender, EventArgs e)
        {
            //Datacontainer.loginDID = 123456;
            controllerObj = new Controller();
            DataRow res = controllerObj.ViewDieter(Datacontainer.loginDID).Rows[0];
            namelabel1.Text = (string)res["Fname"];
            DataRow res2 = controllerObj.getsubdiet(Datacontainer.loginDID).Rows[0];
            DataRow res3 = controllerObj.getsubworkout(Datacontainer.loginDID).Rows[0];
            if ((int)res2["DtID"] == 100004 && (int)res3["WoID"] == 100005) 
            {   programname1.Hide();
            andlabel.Hide();
            prognamelabel2.Hide();
                notificationlabel.Text = "You are currently not subscribed to any programs";
                suggestionlabel.Text = "Check out our latest programs!";
                unsubscribebutton.Hide();
            }
            if ((int)res2["DtID"] == 100004 && (int)res3["WoID"] != 100005)
            {
                DataRow result1 = controllerObj.getWorkoutname((int)res3["WoID"]).Rows[0];
                programname1.Text = (string)result1["Title"];
                prognamelabel2.Hide();
                andlabel.Hide();
            }
            if ((int)res2["DtID"] != 100004 && (int)res3["WoID"] == 100005)
            {
                DataRow result2 = controllerObj.getDietname((int)res2["DtID"]).Rows[0];
                programname1.Text = (string)result2["Title"];
                prognamelabel2.Hide();
                andlabel.Hide();
            }
            if ((int)res2["DtID"] != 100004 && (int)res3["WoID"] != 100005)
            {
                DataRow result3 = controllerObj.getWorkoutname((int)res3["WoID"]).Rows[0];
                DataRow result4 = controllerObj.getDietname((int)res2["DtID"]).Rows[0];
                programname1.Text = (string)result3["Title"];
                prognamelabel2.Text = (string)result4["Title"];
            }

        }

        private void dietButton1_Click(object sender, EventArgs e)
        {
            Diets D = new Diets(); 
            D.Show();
        }

        private void workoutButton1_Click(object sender, EventArgs e)
        {
            Workouts W = new Workouts();
            W.Show();
        }

        private void progbutton1_Click(object sender, EventArgs e)
        {
            Progress_Diary ProgD = new Progress_Diary();
            ProgD.Show();
        }

        private void viewbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select = viewbox1.SelectedItem.ToString();
            if (viewbox1.SelectedItem.ToString() == "Recipes")
            { Recipes RF = new Recipes();
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

        private void Addmenu1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        public void editinfoButton1_Click(object sender, EventArgs e)
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

        private void unsubscribebutton_Click(object sender, EventArgs e)
        {
            //Datacontainer.loginDID = 123456;
            controllerObj = new Controller();
            DataRow get1 = controllerObj.getsubdiet(Datacontainer.loginDID).Rows[0];
            DataRow get2 = controllerObj.getsubworkout(Datacontainer.loginDID).Rows[0];
            if ((int)get1["DtID"] != 100004 && (int)get2["WoID"] != 100005)
            {
                Unsubscribe UF = new Unsubscribe();
                UF.Show();
                this.Close();
            }
            if ((int)get1["DtID"] == 100004 && (int)get2["WoID"] != 100005)
            {
                int un1 = controllerObj.unSubRegtoWorkout(Datacontainer.loginDID);
                if (un1 > 0)
                {
                    programname1.Hide();
                    notificationlabel.Text = "You are currently not subscribed to any programs";
                    suggestionlabel.Text = "Check out our latest programs!";
                    unsubscribebutton.Enabled = false;
                }
                else { MessageBox.Show("Try again later..."); }
            }
            if ((int)get1["DtID"] != 100004 && (int)get2["WoID"] == 100005)
            {
                int un2 = controllerObj.unSubRegtoDiet(Datacontainer.loginDID);
                if (un2 > 0)
                {
                    programname1.Hide();
                    notificationlabel.Text = "You are currently not subscribed to any programs";
                    suggestionlabel.Text = "Check out our latest programs!";
                    unsubscribebutton.Enabled = false;
                }
                else { MessageBox.Show("Try again later..."); }
            }
            
            

        }
    }
}
