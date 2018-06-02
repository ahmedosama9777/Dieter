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
    public partial class Guide : Form
    {
        public Guide()
        {
            InitializeComponent();
        }

        private void dietButton_Click(object sender, EventArgs e)
        {
            DietGuide DG = new DietGuide();
            DG.Show();
            Hide();
        }

        private void cheatButton_Click(object sender, EventArgs e)
        {
            Cheat_Guide CG = new Cheat_Guide();
            CG.Show();
            Hide();
        }
    }
}
