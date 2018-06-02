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
    public partial class Workouts : Form
    {
        Controller controllerObj;
        public Workouts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Workouts_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewAllWorkouts();
            workoutGridView1.DataSource = dt;
            workoutGridView1.Refresh();
        }

        private void subwbutton_Click(object sender, EventArgs e)
        {
            Datacontainer.loginDID = 123456;
            controllerObj = new Controller();
            if (WorkoutIDtextBox.Text == "") { MessageBox.Show("Please Enter ID for your desired Workout first"); }
            //int WorkoutID = int.Parse(WorkoutIDtextBox.Text);
            else
            {
                DataRow res = controllerObj.getsubworkout(Datacontainer.loginDID).Rows[0];
                if ((int)res["WoID"] != 100005) { MessageBox.Show("You are currently subscribed to a workout."); }
                else
                {
                    int r = controllerObj.SubRegtoWorkout(Datacontainer.loginDID, int.Parse(WorkoutIDtextBox.Text));
                    // DataTable result = controllerObj.getWorkoutname(int.Parse(WorkoutIDtextBox.Text));
                    //workoutnamelistBox.DisplayMember = "Title";
                    //workoutnamelistBox.DataSource = result;
                    //String Workoutname = workoutnamelistBox.Text;
                    DataRow result = controllerObj.getWorkoutname(int.Parse(WorkoutIDtextBox.Text)).Rows[0];
                    if (r > 0) { MessageBox.Show("You are now subscribed to " + result["Title"] + "!"); }
                    else { MessageBox.Show("Try again later.."); }
                }
            }
        }

        private void WorkoutIDtextBox_TextChanged(object sender, EventArgs e)
        {
            //WorkoutIDtextBox.Clear();
            
        }
    }
}
