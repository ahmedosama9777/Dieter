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
    public partial class Add_Workout : Form
    {
        Controller controllerObj;
        public Add_Workout()
        {
            InitializeComponent();
        }

        private void Add_Workout_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addsuppbutton_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            Datacontainer.WorkoutID = Datacontainer.WorkoutID + 1;
            //DataRow check = controllerObj.CheckWorkoutID(Datacontainer.WorkoutID).Rows[0];
            //if (check == null)
            //{
                if (TitletextBox.Text == "" || difftextBox.Text == "" || typetextBox.Text == "" || estcalburnnumericUpDown.Value == 0 || durminnumericUpDown.Value == 0 || workoutpathtextBox.Text == "")
                { MessageBox.Show("The fields marked with * are mandatory for inserting a guide"); }
                else
                {

                    int r = controllerObj.InsertWorkOut(Datacontainer.WorkoutID, TitletextBox.Text, difftextBox.Text, workoutpathtextBox.Text, (int)estcalburnnumericUpDown.Value, (int)durminnumericUpDown.Value, typetextBox.Text, Datacontainer.TraID);
                    if (r > 0)
                    { MessageBox.Show("Your Workout has been added!"); }
                    else { MessageBox.Show("Something went wrong. Try again later.."); }
                    Hide();
                }
            //}
            //while (Datacontainer.WorkoutID == (int)check["ID"])
            //{ Datacontainer.WorkoutID = Datacontainer.WorkoutID + 1; }
            //if (TitletextBox.Text == "" || difftextBox.Text == "" || typetextBox.Text == "" || estcalburnnumericUpDown.Value == 0 || durminnumericUpDown.Value == 0 || workoutpathtextBox.Text == "")
            //{ MessageBox.Show("The fields marked with * are mandatory for inserting a guide"); }
            //else
            //{

            //    int r2 = controllerObj.InsertWorkOut(Datacontainer.WorkoutID, TitletextBox.Text, difftextBox.Text, workoutpathtextBox.Text, (int)estcalburnnumericUpDown.Value, (int)durminnumericUpDown.Value, typetextBox.Text, Datacontainer.TraID);
            //    if (r2 > 0)
            //    { MessageBox.Show("Your Workout has been added!"); }
            //    else { MessageBox.Show("Something went wrong. Try again later.."); }
            //    Hide();
            //}
        }
    }
}
