using DevExpress.XtraEditors;
using Manager.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Manager
{
    public partial class AddStudent_Form : XtraForm
    {
        public AddStudent_Form()
        {
            InitializeComponent();
        }
        private void Add_Student_Click(object sender, EventArgs e)
        {
            #region NullException Handle
            if (Student_Firstname.Text == string.Empty
                && Student_Lastname.Text == string.Empty
                && Student_Fathername.Text == string.Empty
                && Student_Codemeli.Text == string.Empty
                && Student_Year.Text == string.Empty)
                MessageBox.Show("Please fill all fields");
            #endregion
            else
            {
                try
                {
                    #region Save in variable
                    string firstname = Student_Firstname.Text,
                    lastname = Student_Lastname.Text,
                    father = Student_Fathername.Text,
                    codemeli = Student_Codemeli.Text,
                    birthday = $"{Student_Year.Text}/{Student_Month.Text}/{Student_Day.Text}";
                    #endregion
                    #region Add TO List
                    List<string> firstname_list = new List<string>();
                    firstname_list.Add(firstname);
                    List<string> lastname_list = new List<string>();
                    lastname_list.Add(lastname);
                    List<string> father_list = new List<string>();
                    father_list.Add(father);
                    List<string> codemeli_list = new List<string>();
                    codemeli_list.Add(codemeli);
                    List<string> birthdate_list = new List<string>();
                    birthdate_list.Add(birthday);
                    #endregion
                    #region Check Setting Null
                    if (Settings.Default.Student_Firstname == null)
                        Settings.Default.Student_Firstname = new StringCollection();
                    if (Settings.Default.Student_Lastname == null)
                        Settings.Default.Student_Lastname = new StringCollection();
                    if (Settings.Default.Student_Fathername == null)
                        Settings.Default.Student_Fathername = new StringCollection();
                    if (Settings.Default.Student_Codemeli == null)
                        Settings.Default.Student_Codemeli = new StringCollection();
                    if (Settings.Default.Student_Birthdate == null)
                        Settings.Default.Student_Birthdate = new StringCollection();
                    #endregion
                    #region Save in Setting
                    Settings.Default.Student_Firstname.AddRange(firstname_list.ToArray());
                    Settings.Default.Student_Lastname.AddRange(lastname_list.ToArray());
                    Settings.Default.Student_Fathername.AddRange(father_list.ToArray());
                    Settings.Default.Student_Codemeli.AddRange(father_list.ToArray());
                    Settings.Default.Student_Birthdate.AddRange(birthdate_list.ToArray());
                    Settings.Default.Save();
                    #endregion
                    MessageBox.Show($"{firstname} {lastname}{Environment.NewLine}Add to students successfully!!");
                    #region String.Empty
                    Student_Firstname.Text = string.Empty;
                    Student_Lastname.Text = string.Empty;
                    Student_Fathername.Text = string.Empty;
                    Student_Codemeli.Text = string.Empty;
                    Student_Year.Text = string.Empty;
                    Student_Month.Text = string.Empty;
                    Student_Day.Text = string.Empty;
                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }
        private void Student_Codemeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
            && e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }
        private void Student_Birthdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
            && e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }
        private void Student_Month_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
&& e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }
        private void Student_Day_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
&& e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }
    }
}