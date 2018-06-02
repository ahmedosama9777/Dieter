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
    public partial class Sign_up_Premium : Form
    {
        int DieterID = 111111;
        int PDieterID = 121111;
        Controller controllerObj;
        public Sign_up_Premium()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (fnameTextBox.Text == "" || lnameTextBox.Text == "" )
            { MessageBox.Show("Please insert your first and last name!"); }
            if (textBox1.Text == "")
            { MessageBox.Show("Please enter your payment details. If you'd rather not, why don't you try siging up free!"); }
            else
            {
                PDieterID = PDieterID + 1;
                
                int c = controllerObj.CheckID(PDieterID);
                while (c > 0) { PDieterID = PDieterID + 1; }
                int r = controllerObj.InsertDieter(PDieterID, fnameTextBox.Text, lnameTextBox.Text, int.Parse(stweightTextBox.Text));
                int k = controllerObj.InsertPremDieter(PDieterID, textBox1.Text, passwordtextBox.Text);
                if (r > 0 && k > 0)
                {
                    MessageBox.Show("You are now signed up! Please memorize your ID " + DieterID +
                       " You will need it when logging in.");
                }
                else MessageBox.Show("Try Again Later");
            }
            Premium_Dieter PD = new Premium_Dieter();
            PD.Show();
            Hide();
        }
    }
}
