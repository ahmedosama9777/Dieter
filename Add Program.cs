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
    public partial class Add_Program : Form
    {
        Controller controllerObj;
        public Add_Program()
        {
            InitializeComponent();
        }

        private void Add_Program_Load(object sender, EventArgs e)
        {

        }

        private void Addsuppbutton_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            Datacontainer.ProgID = Datacontainer.ProgID + 1;
            //DataRow check = controllerObj.CheckProgID(Datacontainer.ProgID).Rows[0];
            //if (check == null)
            //{
                if (ProgTitletextBox.Text == "" || typetextBox.Text == "" || PeriodtextBox.Text == "" || estwtlosstextBox.Text == "" || dietpathtextBox.Text == "" || workoutpathtextBox.Text == "")
                { MessageBox.Show("Please insert all fields first!"); }
                else
                {
                    int r = controllerObj.InsertProgram(Datacontainer.ProgID, ProgTitletextBox.Text, typetextBox.Text, PeriodtextBox.Text, estwtlosstextBox.Text, dietpathtextBox.Text, workoutpathtextBox.Text);
                    if (Datacontainer.Click == 3)
                    {
                        int r2 = controllerObj.InsertProgMaker(Datacontainer.ProgID, 100002, Datacontainer.TraID);
                        if (r > 0 && r2 > 0) { MessageBox.Show("Your Program has been added!"); }
                        else { MessageBox.Show("Something went wrong. Try again later.."); }
                    }

                    if (Datacontainer.Click == 4)
                    {
                        int r3 = controllerObj.InsertProgMaker(Datacontainer.ProgID, Datacontainer.NutID, 100003);
                        if (r > 0 && r3 > 0) { MessageBox.Show("Your Program has been added!"); }
                        else { MessageBox.Show("Something went wrong. Try again later.."); }
                    }
                }


            //}
            //while (Datacontainer.ProgID == (int)check["ID"])
            //{ Datacontainer.ProgID = Datacontainer.ProgID + 1; }//MessageBox.Show("Already exists"); }
            //if (ProgTitletextBox.Text == "" || typetextBox.Text == "" || PeriodtextBox.Text == "" || estwtlosstextBox.Text == "" || dietpathtextBox.Text == "" || workoutpathtextBox.Text == "")
            //{ MessageBox.Show("Please insert all fields first!"); }
            //else
            //{
            //    int r4 = controllerObj.InsertProgram(Datacontainer.ProgID, ProgTitletextBox.Text, typetextBox.Text, PeriodtextBox.Text, estwtlosstextBox.Text, dietpathtextBox.Text, workoutpathtextBox.Text);
            //    if (Datacontainer.Click == 3)
            //    {
            //        int r5 = controllerObj.InsertProgMaker(Datacontainer.ProgID, 100002, Datacontainer.TraID);
            //        if (r4 > 0 && r5 > 0) { MessageBox.Show("Your Program has been added!"); }
            //        else { MessageBox.Show("Something went wrong. Try again later.."); }
            //    }

            //    if (Datacontainer.Click == 4)
            //    {
            //        int r6 = controllerObj.InsertProgMaker(Datacontainer.ProgID, Datacontainer.NutID, 100003);
            //        if (r4 > 0 && r6 > 0) { MessageBox.Show("Your Program has been added!"); }
            //        else { MessageBox.Show("Something went wrong. Try again later.."); }
            //    }
            //}

        }
    }
}
