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
    public partial class Signing_up_ptions : Form
    {
        public Signing_up_ptions()
        {
            InitializeComponent();
        }

        private void Prembutton_Click(object sender, EventArgs e)
        {
            Sign_up_Premium SUP = new Sign_up_Premium();
            SUP.Show();
            Hide();
        }

        private void FreeSignupbutton_Click(object sender, EventArgs e)
        {
            Sign_Up SUF = new Sign_Up();
            SUF.Show();
            Hide();
        }
    }
}
