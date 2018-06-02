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
    public partial class Add_Diet : Form
    {
        Controller controllerObj;
        public Add_Diet()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addsuppbutton_Click(object sender, EventArgs e)
        { 
            controllerObj = new Controller();
            Datacontainer.DietID = Datacontainer.DietID + 1;
            //DataRow check = controllerObj.CheckDietID(Datacontainer.DietID).Rows[0];
            //if (check == null)
            //{
                if (diettitletextBox.Text == "" || estwtlosstextBox.Text == "" || durtextBox.Text == "" || dietpathtextBox.Text == "")
                { MessageBox.Show("The fields marked with * are mandatory for inserting a guide"); }
                else
                {

                    int r = controllerObj.InsertDiet(Datacontainer.DietID, diettitletextBox.Text, estwtlosstextBox.Text, durtextBox.Text, dietpathtextBox.Text, Datacontainer.NutID);
                    if (r > 0)
                    { MessageBox.Show("Your Diet has been added!"); }
                    else { MessageBox.Show("Something went wrong. Try again later.."); }
                    Hide();
                }
            //}
            
        }
    }
}
