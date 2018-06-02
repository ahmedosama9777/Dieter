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
    public partial class Editing_info : Form
    {
        Controller controllerObj;
        public Editing_info()
        {
            InitializeComponent();
        }
        
        public void Editing_info_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (Datacontainer.Click == 1)
            {
                DataRow res = controllerObj.ViewDieter(Datacontainer.loginDID).Rows[0];
                fnametextBox.Text = (string)res["Fname"];
                lnametextBox.Text = (string)res["Lname"];
                stwtnumericUpDown.Value = (int)res["St_Weight"];
            }
            //}
            if (Datacontainer.Click == 2)
            {
                DataRow res = controllerObj.ViewDieter(Datacontainer.loginPDID).Rows[0];
                fnametextBox.Text = (string)res["Fname"];
                lnametextBox.Text = (string)res["Lname"];
                stwtnumericUpDown.Value = (int)res["St_Weight"];
            }
            
            
           
        }

        public void updinfobutton_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int r = controllerObj.UpdateRegDieter(Datacontainer.loginDID, fnametextBox.Text, lnametextBox.Text, (int)stwtnumericUpDown.Value);
            if (r > 0) { MessageBox.Show("Your info has been updated successfully!"); }
            else { MessageBox.Show("Something went wrong. Try again later.."); }
                Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Password Pass = new Password();
            Pass.Show();
        }
    }
}
