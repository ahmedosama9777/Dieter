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
    public partial class DietGuide : Form
    {
        Controller controllerObj;
        public DietGuide()
        {
            InitializeComponent();
        }

        private void dietguideGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DietGuide_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewAllDietsGuides();
            dietguideGridView1.DataSource = dt;
            dietguideGridView1.Refresh();
        }
    }
}
