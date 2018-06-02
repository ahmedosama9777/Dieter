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
    public partial class Recipes : Form
    {
        Controller controllerObj;
        public Recipes()
        {
            InitializeComponent();
        }

        private void Recipes_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewAllRecipes();
            recipiesGridView1.DataSource = dt;
            recipiesGridView1.Refresh();
        }
    }
}
