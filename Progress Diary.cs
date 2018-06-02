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
    public partial class Progress_Diary : Form
    {
        Controller controllerObj;
        public Progress_Diary()
        {
            InitializeComponent();
        }

        public void editprogbutton_Click(object sender, EventArgs e)
        {
            //Datacontainer.loginDID = 123456;
            controllerObj = new Controller();
             int r = controllerObj.UpdateProg(Datacontainer.loginDID,(int)calcountNumericUpDown.Value, (int)calburnnumericUpDown.Value, (int)currweightnumericUpDown.Value);
             if (r > 0) { MessageBox.Show("Your progress is updated successfully!"); }   //edit_Progress_Diary PD = new edit_Progress_Diary() ;
             else { MessageBox.Show("Your progress wasn't updated"); }
            //PD.Show();
        }

        private void ProgIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //getCalBurn
                //getCal 
        }

        public void Progress_Diary_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            if (Datacontainer.Click == 1)
            {
                DataRow result2 = controllerObj.ViewDieterProg(Datacontainer.loginDID).Rows[0];
                calcountNumericUpDown.Value = (int)result2["Daily_calorie_Count"];
                calburnnumericUpDown.Value = (int)result2["Daily_calorie_burn"];
                currweightnumericUpDown.Value = (int)result2["Current_Weight"];
                progsfinishednumeric.Value = (int)result2["Programs_Finished"];
                DataRow result1 = controllerObj.ViewDieter(Datacontainer.loginDID).Rows[0];
                stwtnumericUpDown.Value = (int)result1["St_Weight"];
            }
            if (Datacontainer.Click == 2)
            {
                DataRow result3 = controllerObj.ViewDieterProg(Datacontainer.loginPDID).Rows[0];
                calcountNumericUpDown.Value = (int)result3["Daily_calorie_Count"];
                calburnnumericUpDown.Value = (int)result3["Daily_calorie_burn"];
                currweightnumericUpDown.Value = (int)result3["Current_Weight"];
                progsfinishednumeric.Value = (int)result3["Programs_Finished"];
                DataRow result4 = controllerObj.ViewDieter(Datacontainer.loginPDID).Rows[0];
                stwtnumericUpDown.Value = (int)result4["St_Weight"];
            }
        }

        private void calcounttextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
