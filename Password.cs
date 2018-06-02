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
    public partial class Password : Form
    {
        Controller controllerObj;
        public Password()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (Datacontainer.Click == 1) //User clicked on dieter
            {
                //if (int.Parse(IDtextBox.Text) >= 111111 && int.Parse(IDtextBox.Text) <= 119999)
                
                    DataRow res = controllerObj.ViewRegDieters(Datacontainer.loginDID).Rows[0];
                    if (oldpassTextBox.Text == (string)res["pass_word"])
                    {
                       int ch0 = controllerObj.UpdateRDPass(Datacontainer.loginDID,newpassTextBox2.Text);
                       if (ch0 > 0) { MessageBox.Show("Your password has been changed"); }
                    }
                    else { MessageBox.Show("The password you entered is not correct. Please renter your password"); }
                
            }
            if (Datacontainer.Click == 2) //User clicked on dieter
            {
                //if (int.Parse(IDtextBox.Text) >= 111111 && int.Parse(IDtextBox.Text) <= 119999)

                DataRow res1 = controllerObj.ViewPremDieter(Datacontainer.loginPDID).Rows[0];
                if (oldpassTextBox.Text == (string)res1["pass_word"])
                {
                    int ch1 = controllerObj.UpdatePDPass(Datacontainer.loginPDID, newpassTextBox2.Text);
                    if (ch1 > 0) { MessageBox.Show("Your password has been changed"); }
                }
                else { MessageBox.Show("The password you entered is not correct. Please renter your password"); }

            }
            if (Datacontainer.Click == 3) //User clicked on dieter
            {
                //if (int.Parse(IDtextBox.Text) >= 111111 && int.Parse(IDtextBox.Text) <= 119999)

                DataRow res2 = controllerObj.ViewTrainers(Datacontainer.TraID).Rows[0];
                if (oldpassTextBox.Text == (string)res2["Pass_word"])
                {
                    int ch2 = controllerObj.UpdateTPass(Datacontainer.TraID, newpassTextBox2.Text);
                    if (ch2 > 0) { MessageBox.Show("Your password has been changed"); }
                }
                else { MessageBox.Show("The password you entered is not correct. Please renter your password"); }

            }
            if (Datacontainer.Click == 4) //User clicked on dieter
            {
                //if (int.Parse(IDtextBox.Text) >= 111111 && int.Parse(IDtextBox.Text) <= 119999)
                //controllerObj = new Controller();
                DataRow res2 = controllerObj.ViewNutritionists(Datacontainer.NutID).Rows[0];
                if (oldpassTextBox.Text == (string)res2["Pass_word"])
                {
                    int ch3 = controllerObj.UpdateNPass(Datacontainer.NutID, newpassTextBox2.Text);
                    if (ch3 > 0) { MessageBox.Show("Your password has been changed"); }
                }
                else { MessageBox.Show("The password you entered is not correct. Please renter your password"); }

            }
                    

                
                 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newpassTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void oldpassTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
