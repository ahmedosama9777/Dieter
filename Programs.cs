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
    public partial class Programs : Form
    {
        Controller controllerObj;
        public Programs()
        {
            InitializeComponent();
        }

        private void progGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Programs_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewAllPrograms();
            progGridView1.DataSource = dt;
            progGridView1.Refresh();
            //view

        }
    }
}
