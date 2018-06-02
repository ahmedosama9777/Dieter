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
    public partial class Cheat_Guide : Form
    {
        Controller controllerObj;
        public Cheat_Guide()
        {
            InitializeComponent();
        }

        private void Cheat_Guide_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewAllCheatGuides();
            cheatguideGridView1.DataSource = dt;
            cheatguideGridView1.Refresh();
        }
    }
}
