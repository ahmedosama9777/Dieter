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
    public partial class Add_Recipe : Form
    {
        Controller controllerObj;
        //Datacontainer.RecID = 131111;
        public Add_Recipe()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Recipe_Load(object sender, EventArgs e)
        {

        }

        public void Addrecbutton_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            Datacontainer.RecID = Datacontainer.RecID + 1;
            //DataRow check = controllerObj.CheckRecID(Datacontainer.RecID).Rows[0];
            //while (Datacontainer.RecID == (int)check["ID"])
            //{ Datacontainer.RecID = Datacontainer.RecID + 1; }
            //if ((int)check["ID"] == null)
           
                if (Datacontainer.Click == 1)
                {
                    int r = controllerObj.InsertRecipe(Datacontainer.RecID, rectittextBox.Text, int.Parse(rechrtextBox.Text), int.Parse(recmintextBox.Text), reccaltextBox.Text,
                        reccarbtextBox.Text, recprotextBox.Text, recfattextBox.Text, ingtextBox.Text, reclinktextBox.Text, Datacontainer.loginDID, 100002, 100003);
                    if (r > 0) { MessageBox.Show("Your recipe has been added successfully!"); }
                    else { MessageBox.Show("Your recipe was not added"); }
                    Hide();
                }
                if (Datacontainer.Click == 2)
                {
                    int r1 = controllerObj.InsertRecipe(Datacontainer.RecID, rectittextBox.Text, int.Parse(rechrtextBox.Text), int.Parse(recmintextBox.Text), reccaltextBox.Text,
                        reccarbtextBox.Text, recprotextBox.Text, recfattextBox.Text, ingtextBox.Text, reclinktextBox.Text, Datacontainer.loginPDID, 100002, 100003);
                    if (r1 > 0) { MessageBox.Show("Your recipe has been added successfully!"); }
                    else { MessageBox.Show("Your recipe was not added"); }
                    Hide();
                }
                if (Datacontainer.Click == 3)
                {
                    int r2 = controllerObj.InsertRecipe(Datacontainer.RecID, rectittextBox.Text, int.Parse(rechrtextBox.Text), int.Parse(recmintextBox.Text), reccaltextBox.Text,
                        reccarbtextBox.Text, recprotextBox.Text, recfattextBox.Text, ingtextBox.Text, reclinktextBox.Text, 100001, 100002, Datacontainer.TraID);
                    if (r2 > 0) { MessageBox.Show("Your recipe has been added successfully!"); }
                    else { MessageBox.Show("Your recipe was not added"); }
                    Hide();
                }
                if (Datacontainer.Click == 4)
                {
                    int r3 = controllerObj.InsertRecipe(Datacontainer.RecID, rectittextBox.Text, int.Parse(rechrtextBox.Text), int.Parse(recmintextBox.Text), reccaltextBox.Text,
                        reccarbtextBox.Text, recprotextBox.Text, recfattextBox.Text, ingtextBox.Text, reclinktextBox.Text, 100001, Datacontainer.NutID, 100003);
                    if (r3 > 0) { MessageBox.Show("Your recipe has been added successfully!"); }
                    else { MessageBox.Show("Your recipe was not added"); }
                    Hide();
                }
            
            
        }
    }
}
