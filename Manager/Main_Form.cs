using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class Main_Form : XtraForm
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            new AddStudent_Form().ShowDialog();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            new UpdateStudent_Form().ShowDialog();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            new DeleteStudent_Form().ShowDialog();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            new ShowStudents_Form().ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            new DeleteTeacher_Form().ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            new AddTeacher_Form().ShowDialog();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            new UpdateTeacher_Form().ShowDialog();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            new ShowTeachers_Form().ShowDialog();
        }
    }
}