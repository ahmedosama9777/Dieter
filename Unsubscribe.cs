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
    public partial class Unsubscribe : Form
    {
        Controller controllerObj;
        public Unsubscribe()
        {
            InitializeComponent();
        }

        private void unsubbutton_Click(object sender, EventArgs e)
        {
            int unsub1 = 100004;
            int unsub2 = 100005;
           // Datacontainer.loginDID = 123456;
            controllerObj = new Controller();
            DataRow get1 = controllerObj.getsubdiet(Datacontainer.loginDID).Rows[0];
            DataRow get2 = controllerObj.getsubworkout(Datacontainer.loginDID).Rows[0];
            if (DietOnlyradiobutton.Checked)
            {
                int r = controllerObj.SubRegtoDiet(Datacontainer.loginDID, unsub1);
                if (r > 0)
                {
                    Dieter D = new Dieter();
                    D.Show();
                    this.Close();
                }
                else { MessageBox.Show("Something went wrong try again later.."); }
                    
            }
            if (WorkoutOnlyradiobutton.Checked)
            {
                int r4 = controllerObj.SubRegtoWorkout(Datacontainer.loginDID, unsub2);
                if (r4 > 0)
                {
                    Dieter D = new Dieter();
                    D.Show();
                    this.Close();
                }
                else { MessageBox.Show("Something went wrong try again later.."); }
            }
            if (BothradioButton.Checked)
            {
                
                int r2 = controllerObj.SubRegtoDiet(Datacontainer.loginDID, unsub1);
                int r3 = controllerObj.SubRegtoWorkout(Datacontainer.loginDID, unsub2);
                if (r2 > 0 && r3 > 0)
                {
                    Dieter D = new Dieter();
                    D.Show();
                    this.Close();
                }
                else { MessageBox.Show("Something went wrong try again later.."); }
            }
            
        }

        private void Unsubscribe_Load(object sender, EventArgs e)
        {

        }
    }
}
