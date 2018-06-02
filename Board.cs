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
    public partial class Board : Form
    {
        Controller controllerObj;
        public Board()
        {
            InitializeComponent();
        }

        private void Board_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataRow res1 = controllerObj.getpsubprog(Datacontainer.loginPDID).Rows[0];
            if (res1 != null)
            {
                DataTable dt = controllerObj.getprogname((int)res1["PID"]);
                 progGridView.DataSource = dt;
                 progGridView.Refresh();
            }
            DataRow res2 = controllerObj.getpsubdiet(Datacontainer.loginPDID).Rows[0];
            if (res2 != null)
            {
                DataTable dt1 = controllerObj.getDietname((int)res2["DTID"]);
                dietsGridView.DataSource = dt1;
                dietsGridView.Refresh();
            }
            DataRow res3 = controllerObj.getpsubworkout(Datacontainer.loginPDID).Rows[0];
            if (res3 != null)
            {
                DataTable dt2 = controllerObj.getWorkoutname((int)res3["WID"]); workoutsGridView.DataSource = dt2;
                workoutsGridView.Refresh();
            }
            if (res1 == null) { MessageBox.Show("You're not subscribed to any programs"); }
            if (res2 == null) { MessageBox.Show("You're not subscribed to any diets"); }
            if (res3 == null) { MessageBox.Show("You're not subscribed to any workouts"); }
            
           
            
            
           
        }

        private void unsubbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
