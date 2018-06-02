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
    public partial class View_Trainers : Form
    {
        public View_Trainers()
        {
            InitializeComponent();
        }

        private void View_Trainers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet3.trainer' table. You can move, or remove it, as needed.
            this.trainerTableAdapter.Fill(this.DataSet3.trainer);

            this.reportViewer1.RefreshReport();
        }
    }
}
