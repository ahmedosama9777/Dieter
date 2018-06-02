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
    public partial class Workouts_and_Programs : Form
    {
        Controller controllerObj;
        public Workouts_and_Programs()
        {
            InitializeComponent();
        }

        private void View_All_Workouts_and_Programs_Load(object sender, EventArgs e)
        {
            int id = Datacontainer.TraID;
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewProgramByID(id);
            DataTable dt1 = controllerObj.ViewWorkoutByID(id);
            dt1 = controllerObj.ViewWorkoutByID(id);
            ProgramsGridView1.DataSource = dt;
            ProgramsGridView1.Refresh();
            WorkoutGridView1.DataSource = dt1;
            WorkoutGridView1.Refresh();
        }
    }
}
