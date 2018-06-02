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
    public partial class DietsNT : Form
    {
        Controller controllerObj;
        public DietsNT()
        {
            InitializeComponent();
        }

        private void DietsNT_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewAllDiets();
            dietGridView1.DataSource = dt;
            dietGridView1.Refresh();
        }
    }
}
