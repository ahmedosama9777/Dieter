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
    public partial class WorkoutsNT : Form
    {
        Controller controllerObj;
        public WorkoutsNT()
        {
            InitializeComponent();
        }

        private void WorkoutsNT_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewAllWorkouts();
            workoutGridView1.DataSource = dt;
            workoutGridView1.Refresh();
        }

        private void dietGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
