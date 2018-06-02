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
    public partial class Add_New_Admin : Form
    {
        Controller controllerObj;
        public Add_New_Admin()
        {
            InitializeComponent();
        }

        private void Add_New_Admin_Load(object sender, EventArgs e)
        {

        }

        private void addadminbutton_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            Datacontainer.AdminID = Datacontainer.AdminID + 1 ;
            if (fnameTextBox.Text == "" || lnameTextBox.Text == "" || passwordtextBox.Text == "" || usernametextBox.Text == "")
            { MessageBox.Show("Please enter all fields specified first!"); }
            else
            {
                int r = controllerObj.InsertAdmin(Datacontainer.AdminID, fnameTextBox.Text, lnameTextBox.Text, passwordtextBox.Text, usernametextBox.Text);
                if (r > 0)
                { MessageBox.Show("New Admin has been added"); }
                else
                { MessageBox.Show("Something went wrong, please try again later"); }
            }
        }
    }
}
