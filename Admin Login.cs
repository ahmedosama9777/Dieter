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
    public partial class Admin_Login : Form
    {
        Controller controllerObj;
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void loginingbutton_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (int.Parse(IDtextBox.Text) >= 44444 && int.Parse(IDtextBox.Text) <= 44999)
                {
                    DataRow res = controllerObj.ViewAdmins(int.Parse(IDtextBox.Text)).Rows[0];
                    if (PasswordtextBox.Text == (string)res["pass_word"])
                    {
                        Datacontainer.LoginAID = (int)res["ID"];
                        Admin_Form A1 = new Admin_Form();
                        A1.Show();
                        Hide();
                        //this.Close();
                    }
                    else MessageBox.Show("The password you entered is not correct. Please renter your password and log in");

                }
                else MessageBox.Show("Please enter a valid Admin ID");
            
        }
    }
}
