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
    public partial class View_Nutritionists : Form
    {
        public View_Nutritionists()
        {
            InitializeComponent();
        }

        private void View_Nutritionists_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.Nutritionist' table. You can move, or remove it, as needed.
            this.NutritionistTableAdapter.Fill(this.DataSet2.Nutritionist);

            this.reportViewer1.RefreshReport();
        }
    }
}
