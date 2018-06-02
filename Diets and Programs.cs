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
    public partial class Diets_and_Programs : Form
    {
        Controller controllerObj;
        public Diets_and_Programs()
        {
            InitializeComponent();
        }

        private void Diets_and_Programs_Load(object sender, EventArgs e)
        {
            int id = Datacontainer.NutID;
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewProgramByIDN(id);
            DataTable dt1 = controllerObj.ViewDietByID(id);
            //dt1 = controllerObj.ViewWorkoutByID(id);
            ProgramsGridView1.DataSource = dt;
            ProgramsGridView1.Refresh();
            DietsGridView1.DataSource = dt1;
            DietsGridView1.Refresh();
        }
    }
}
