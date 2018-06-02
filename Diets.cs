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
    public partial class Diets : Form
    {
        Controller controllerObj;
        public Diets()
        {
            InitializeComponent();
        }

        private void subdbutton_Click(object sender, EventArgs e)
        {
            //Datacontainer.loginDID = 123456;
            Dieter D = new Dieter(); ; // = new Dieter();
            D.Hide();
            controllerObj = new Controller();
            if (DietIDtextBox.Text == "") { MessageBox.Show("Please Enter ID for your desired Diet first"); }
            //int DietID = int.Parse(DietIDtextBox.Text);
            else
            {
                DataRow res = controllerObj.getsubdiet(Datacontainer.loginDID).Rows[0];
                DataRow res1 = controllerObj.ViewRegDieters(Datacontainer.loginDID).Rows[0];
                int Loyalty = (int)res1["Loyalty"];
                if ((int)res["DtID"] != 100004) { MessageBox.Show("You are currently subscribed to a Diet."); }
                else
                {

                    if (Loyalty < 100) { Loyalty = Loyalty + 1; }
                    int r = controllerObj.SubRegtoDiet(Datacontainer.loginDID, int.Parse(DietIDtextBox.Text));
                    int r1 = controllerObj.upRegtoDiet(Datacontainer.loginDID, Loyalty);
                    DataRow result = controllerObj.getDietname(int.Parse(DietIDtextBox.Text)).Rows[0];
                    if (r > 0)
                    {
                        MessageBox.Show("You are now subscribed to " + result["Title"] + "!");
                        Dieter D2 = new Dieter();
                        D2.Show();
                    }
                    else { MessageBox.Show("Try again later.."); }
                }
            }
            
            
            

        }

        private void dietGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Diets_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewAllDiets();
            
            dietGridView1.DataSource = dt;
            dietGridView1.Refresh();
        }

        private void dietGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
