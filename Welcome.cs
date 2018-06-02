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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datacontainer.Click = 1;
            Log_in l1 = new Log_in();
            l1.Show();
            //Dieter D1 = new Dieter();
            //D1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datacontainer.Click = 3;
            Log_in l2 = new Log_in();
            l2.Show();
            //Trainer T1 = new Trainer();
            //T1.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Datacontainer.Click = 2;
            Log_in l3 = new Log_in();
            l3.Show();
            //Premium_Dieter PDF1 = new Premium_Dieter();
            //PDF1.Show();
            Hide();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Signing_up_ptions SUO = new Signing_up_ptions();
            SUO.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Datacontainer.Click = 4;
            Log_in l4 = new Log_in();
            l4.Show();
           // Nutritionst NF1 = new Nutritionst();
            //NF1.Show();
            Hide();
        }

        private void joinform_Click(object sender, EventArgs e)
        {
            JoininForm JF = new JoininForm();
            JF.Show();
            Hide();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Admin_Login AF = new Admin_Login();
            AF.Show();
            Hide();
            //this.Close();
        }
    }
}
