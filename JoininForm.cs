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
    public partial class JoininForm : Form
    {
        Controller controllerObj;
        public JoininForm()
        {
            InitializeComponent();
        }

        private void JoininForm_Load(object sender, EventArgs e)
        {
            

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            if (fnameTextBox.Text == "" || lnameTextBox.Text == "" || DegtextBox.Text == "")
            { MessageBox.Show("Please enter all fields"); }
            if (TcheckBox.Checked == true)
            {
                Datacontainer.TraID = Datacontainer.TraID + 1;
                int i = controllerObj.InsertTrainer(Datacontainer.TraID, fnameTextBox.Text, lnameTextBox.Text, DegtextBox.Text, passtextBox.Text);
                if (i > 0) { MessageBox.Show("You are now signed up and your ID is " + Datacontainer.TraID + ". You will need it when signing in."); }
                else { MessageBox.Show("An error occured, Try again later..."); }
            }
            if (NcheckBox.Checked == true)
            {
                Datacontainer.NutID = Datacontainer.NutID + 1;
                int i2 = controllerObj.InsertNutritionist(Datacontainer.NutID, fnameTextBox.Text, lnameTextBox.Text, DegtextBox.Text, passtextBox.Text);
                if (i2 > 0) { MessageBox.Show("You are now signed up and your ID is " + Datacontainer.TraID + ". You will need it when signing in."); }
                else { MessageBox.Show("An error occured, Try again later..."); }
            }
        }
    }
}
