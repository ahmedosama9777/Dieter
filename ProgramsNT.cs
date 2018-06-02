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
    public partial class ProgramsNT : Form
    {
        Controller controllerObj;
        public ProgramsNT()
        {
            InitializeComponent();
        }

        private void ProgramsNT_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.ViewAllPrograms();
            progGridView1.DataSource = dt;
            progGridView1.Refresh();
        }

        private void progGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add dietpath to prog
            if (Datacontainer.Click == 4)
            {
                controllerObj.AddDiettoProg(int.Parse(progIDTextBox.Text), addTextBox.Text);
            }
            if (Datacontainer.Click == 3)
            {
                Addtoprogbutton.Text = "Add Workout to Program";
                addTextBox.Text = "Enter Workout ...";
                controllerObj.AddWorkouttoProg(int.Parse(progIDTextBox.Text), addTextBox.Text);
            }
        }
    }
}
