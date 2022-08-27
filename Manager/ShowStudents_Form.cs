using DevExpress.XtraEditors;
using Manager.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Manager
{
    public partial class ShowStudents_Form : XtraForm
    {
        public ShowStudents_Form()
        {
            InitializeComponent();
        }
        private void StudentGrade_Form_Load(object sender, EventArgs e)
        {
            ShowClass show = new ShowClass();
            show.show_student = this;
            show.Add_Student();
        }
        private void Save_Data_Click(object sender, EventArgs e)
        {
            ShowClass show = new ShowClass();
            show.show_student = this;
            show.Save_Students();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ShowClass show = new ShowClass();
            show.show_student = this;
            show.Add_Average();
        }
        private void datagridview_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
                && e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }
    }
}