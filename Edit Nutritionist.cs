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
    public partial class Edit_Nutritionist : Form
    {
        Controller controllerObj;
        public Edit_Nutritionist()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updinfobutton_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (Datacontainer.Click == 4)
            {
                int r = controllerObj.UpdateNutritionist(Datacontainer.NutID, fnametextBox.Text, lnametextBox.Text, degtextBox.Text);
                if (r > 0) { MessageBox.Show("Your info has been updated successfully!"); }
                else { MessageBox.Show("Something went wrong. Try again later.."); }
                Hide();
            }
            if (Datacontainer.Click == 3)
            {
                int r = controllerObj.UpdateTrainer(Datacontainer.TraID, fnametextBox.Text, lnametextBox.Text, degtextBox.Text);
                if (r > 0) { MessageBox.Show("Your info has been updated successfully!"); }
                else { MessageBox.Show("Something went wrong. Try again later.."); }
                Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void stwtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Nutritionist_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (Datacontainer.Click == 4)
            {
                DataRow res = controllerObj.ViewNutritionists(Datacontainer.NutID).Rows[0];
                fnametextBox.Text = (string)res["Fname"];
                lnametextBox.Text = (string)res["Lname"];
                degtextBox.Text = (string)res["Degree"];
            }
            if (Datacontainer.Click == 3)
            {
                DataRow res = controllerObj.ViewTrainers(Datacontainer.TraID).Rows[0];
                fnametextBox.Text = (string)res["Fname"];
                lnametextBox.Text = (string)res["Lname"];
                degtextBox.Text = (string)res["Degree"];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Password Pass = new Password();
            Pass.Show();
        }
    }
}
