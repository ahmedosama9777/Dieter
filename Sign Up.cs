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
    
    public partial class Sign_Up : Form
    {
        //int dummy;
        Controller controllerObj;
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Datacontainer.DieterID = 111115;
            controllerObj = new Controller();
            if (fnameTextBox.Text == "" || lnameTextBox.Text == "")
            { MessageBox.Show("Please insert your first and last name!"); }
            else
            {
                Datacontainer.DieterID = Datacontainer.DieterID + 1;
                int r = controllerObj.InsertDieter(Datacontainer.DieterID, fnameTextBox.Text, lnameTextBox.Text, int.Parse(textBox1.Text));
                int k = controllerObj.InsertRegDieter(Datacontainer.DieterID,1, passwordtextBox.Text );
                if (r > 0 && k > 0) 
                {
                    MessageBox.Show("You are now signed up! Please memorize your ID " + Datacontainer.DieterID +
                       " You will need it when logging in.");
                }
                else MessageBox.Show("Try Again Later");
            }
            Dieter D = new Dieter();
            D.Show();
            Hide();
        }
    }
}
