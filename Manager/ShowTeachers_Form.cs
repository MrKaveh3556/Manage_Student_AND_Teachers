using DevExpress.XtraEditors;
using Manager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Manager
{
    public partial class ShowTeachers_Form : XtraForm
    {
        public ShowTeachers_Form()
        {
            InitializeComponent();
        }
        private void ShowTeachers_Form_Load(object sender, EventArgs e)
        {
            ShowClass show = new ShowClass();
            show.show_techer = this;
            show.Add_Teachers();
        }
    }
}