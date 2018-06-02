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
    public partial class Payment_Details : Form
    {
        Controller controllerObj;
        public Payment_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int res = controllerObj.UpdatePremDieter(Datacontainer.loginDID, paydettextBox.Text);   
            Hide();
        }

        private void Payment_Details_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataRow res = controllerObj.ViewPremDieter(Datacontainer.loginPDID).Rows[0];
            paydettextBox.Text = (string)res["Payment_Details"];
        }
    }
}
