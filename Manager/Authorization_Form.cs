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
    public partial class Authorization_Form : XtraForm
    {
        public Authorization_Form()
        {
            InitializeComponent();
        }
        private void Enter_Button_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            if (username == "MrKaveh" && password == "BreakingBad")
                Close();
            else
                MessageBox.Show("نام کاربری و رمز عبور اشتباه است");
        }
        private void Enter_Button_DoubleClick(object sender, EventArgs e)
        {
            string username = Username.Text;
            string passsword = Password.Text;
            if (username == "MrKaveh" && passsword == "BreakingBad")
                Close();
            else
                MessageBox.Show("نام کاربری و رمز عبور اشتباه است");
        }
        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
            && e.KeyChar < '0' || e.KeyChar > '9'
            && e.KeyChar < 'a' || e.KeyChar > 'z'
            && e.KeyChar < 'A' || e.KeyChar > 'Z')
                e.Handled = true;
        }
        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
            && e.KeyChar < '0' || e.KeyChar > '9'
            && e.KeyChar < 'a' || e.KeyChar > 'z'
            && e.KeyChar < 'A' || e.KeyChar > 'Z')
                e.Handled = true;
        }
    }
}