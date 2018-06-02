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
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Dieters V1 = new View_Dieters();
            V1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Nutritionists V2 = new View_Nutritionists();
            V2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View_Trainers V3 = new View_Trainers();
            V3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_New_Admin Add = new Add_New_Admin();
            Add.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            w.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Change_Admin_Password Pass = new Change_Admin_Password();
            Pass.Show();
        }
    }
}
