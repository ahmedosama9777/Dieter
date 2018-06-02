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
    public partial class View_Dieters : Form
    {
        public View_Dieters()
        {
            InitializeComponent();
        }

        private void View_Dieters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Dieter' table. You can move, or remove it, as needed.
            this.DieterTableAdapter.Fill(this.DataSet1.Dieter);

            this.reportViewer1.RefreshReport();
        }
    }
}
