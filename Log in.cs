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
    public partial class Log_in : Form
    {
        Controller controllerObj;
        public Log_in()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginingbutton_Click(object sender, EventArgs e) //10000 - 11999
        {
            controllerObj = new Controller();
            if (Datacontainer.Click == 1) //User clicked on dieter
            {
                if (int.Parse(IDtextBox.Text) >= 111111 && int.Parse(IDtextBox.Text) <= 119999)
                {
                    DataRow res = controllerObj.ViewRegDieters(int.Parse(IDtextBox.Text)).Rows[0];
                    if (PasswordtextBox.Text == (string)res["pass_word"])
                    {
                        Datacontainer.loginDID = (int)res["ID"];
                        Dieter D1 = new Dieter();
                        D1.Show();
                        Hide();
                    }
                    else MessageBox.Show("The password you entered is not correct. Please renter your password and log in");

                }
                else MessageBox.Show("Please enter a valid regular Dieter ID");
            }
            if (Datacontainer.Click == 2) //User clicked on premdieter //12000 - 12999
            {
                if (int.Parse(IDtextBox.Text) >= 121111 && int.Parse(IDtextBox.Text) <= 129999)
                {
                    DataRow res = controllerObj.ViewPremiumDieters(int.Parse(IDtextBox.Text)).Rows[0];
                    if (PasswordtextBox.Text == (string)res["pass_word"])
                    {
                        Datacontainer.loginPDID = (int)res["ID"];//khali el id bta3 el dieter b el qema 
                        Premium_Dieter PD1 = new Premium_Dieter();
                        PD1.Show();
                        Hide();
                    }
                    else MessageBox.Show("The password you entered is not correct. Please renter your password and log in");

                }
                else MessageBox.Show("Please enter a valid premium Dieter ID");
            }
            if (Datacontainer.Click == 3) //User clicked on trainer  //16000 - 16999
            {
                if (int.Parse(IDtextBox.Text) >= 161111 && int.Parse(IDtextBox.Text) <= 169999)
                {
                    DataRow res = controllerObj.ViewTrainers(int.Parse(IDtextBox.Text)).Rows[0];
                    if (PasswordtextBox.Text == (string)res["pass_word"])
                    {
                        Datacontainer.TraID = int.Parse(IDtextBox.Text);
                        Trainer T1 = new Trainer();
                        T1.Show();
                        Hide();
                    }
                    else MessageBox.Show("The password you entered is not correct. Please renter your password and log in");

                }
                else MessageBox.Show("Please enter a valid Triainer ID");
            }
            if (Datacontainer.Click == 4) //User clicked on nutritionist 17000 - 17999
            {
                if (int.Parse(IDtextBox.Text) >= 171111 && int.Parse(IDtextBox.Text) <= 179999)
                {
                    DataRow res = controllerObj.ViewNutritionists(int.Parse(IDtextBox.Text)).Rows[0];
                    if (PasswordtextBox.Text == (string)res["pass_word"])
                    {
                        Datacontainer.NutID = int.Parse(IDtextBox.Text);
                        Nutritionst N1 = new Nutritionst();
                        N1.Show();
                        Hide();
                    }
                    else MessageBox.Show("The password you entered is not correct. Please renter your password and log in");

                }
                else MessageBox.Show("Please enter a valid regular Nutritionist ID");
            }
           
        }
        private void Log_in_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {

        }
        

        
    }
}
