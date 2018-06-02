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
    public partial class Supplement : Form
    {
        Controller controllerObj;
        public Supplement()
        {
            InitializeComponent();
        }

        private void Addsuppbutton_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            Datacontainer.SupID = Datacontainer.SupID + 1;
            //DataRow check = controllerObj.CheckSuppID(Datacontainer.SupID).Rows[0];
            //while (Datacontainer.SupID == (int)check["ID"]) { Datacontainer.SupID = Datacontainer.SupID + 1; }
            //if (check == null)
            //{
                if (Datacontainer.Click == 1)
                {
                    int r = controllerObj.InsertSuppD(Datacontainer.SupID, suppnametextBox.Text, int.Parse(supcaltextBox.Text), int.Parse(supcarbtextBox.Text), int.Parse(supprotextBox.Text), int.Parse(supfattextBox.Text),
                       int.Parse(supratetextBox.Text), Datacontainer.loginDID, 100002, 100003);
                    if (r > 0) { MessageBox.Show("Your Supplement has been added successfully!"); }
                    else { MessageBox.Show("Your Supplement was not added"); }

                    Hide();
                }
                if (Datacontainer.Click == 2)
                {
                    int r1 = controllerObj.InsertSuppD(Datacontainer.SupID, suppnametextBox.Text, int.Parse(supcaltextBox.Text), int.Parse(supcarbtextBox.Text), int.Parse(supprotextBox.Text), int.Parse(supfattextBox.Text),
                   int.Parse(supratetextBox.Text), Datacontainer.loginPDID, 100002, 100003);
                    if (r1 > 0) { MessageBox.Show("Your Supplement has been added successfully!"); }
                    else { MessageBox.Show("Your Supplement was not added"); }
                    Hide();
                }
                if (Datacontainer.Click == 3)
                {
                    int r2 = controllerObj.InsertSuppD(Datacontainer.SupID, suppnametextBox.Text, int.Parse(supcaltextBox.Text), int.Parse(supcarbtextBox.Text), int.Parse(supprotextBox.Text), int.Parse(supfattextBox.Text),
                     int.Parse(supratetextBox.Text), 100001, 100002, Datacontainer.TraID);
                    if (r2 > 0) { MessageBox.Show("Your Supplement has been added successfully!"); }
                    else { MessageBox.Show("Your Supplement was not added"); }
                    Hide();
                }
                if (Datacontainer.Click == 4)
                {
                    int r3 = controllerObj.InsertSuppD(Datacontainer.SupID, suppnametextBox.Text, int.Parse(supcaltextBox.Text), int.Parse(supcarbtextBox.Text), int.Parse(supprotextBox.Text), int.Parse(supfattextBox.Text),
                  int.Parse(supratetextBox.Text), 100001, Datacontainer.NutID, 100003);
                    if (r3 > 0) { MessageBox.Show("Your Supplement has been added successfully!"); }
                    else { MessageBox.Show("Your Supplement was not added"); }
                    Hide();
                }
           // }
        }
    }
}
