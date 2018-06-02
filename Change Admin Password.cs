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
    public partial class Change_Admin_Password : Form
    {
        Controller controllerObj;
        public Change_Admin_Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataRow res = controllerObj.ViewAdmins(44444).Rows[0];
            if (oldpassTextBox.Text == (string)res["pass_word"])
            {
                int ch0 = controllerObj.UpdateAdminPass(44444, newpassTextBox2.Text);
                if (ch0 > 0) { MessageBox.Show("Your password has been changed"); }
            }
            else { MessageBox.Show("The password you entered is not correct. Please renter your password"); }
                
        }
    }
}
