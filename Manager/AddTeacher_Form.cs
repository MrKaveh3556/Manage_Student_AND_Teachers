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
    public partial class AddTeacher_Form : XtraForm
    {
        public AddTeacher_Form()
        {
            InitializeComponent();
        }
        private void Add_Teacher_Click(object sender, EventArgs e)
        {
            #region NullException Handle
            if (Teacher_Firstname.Text == string.Empty
                && Teacher_Lastname.Text == string.Empty
                && Teacher_Fathername.Text == string.Empty
                && Teacher_Codemeli.Text == string.Empty
                && Teacher_Year.Text == string.Empty)
                MessageBox.Show("Please fill all fields");
            #endregion
            else
            {
                try
                {
                    #region Save in variable
                    string firstname = Teacher_Firstname.Text,
                    lastname = Teacher_Lastname.Text,
                    father = Teacher_Fathername.Text,
                    codemeli = Teacher_Codemeli.Text,
                    birthday = $"{Teacher_Year.Text}/{Teacher_Month.Text}/{Teacher_Day.Text}";
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
                    #region Save in Setting
                    #region Check Setting Null
                    if (Settings.Default.Teacher_Firstname == null)
                        Settings.Default.Teacher_Firstname = new StringCollection();
                    if (Settings.Default.Teacher_Lastname == null)
                        Settings.Default.Teacher_Lastname = new StringCollection();
                    if (Settings.Default.Teacher_Fathername == null)
                        Settings.Default.Teacher_Fathername = new StringCollection();
                    if (Settings.Default.Teacher_Codemeli == null)
                        Settings.Default.Teacher_Codemeli = new StringCollection();
                    if (Settings.Default.Teacher_Birthdate == null)
                        Settings.Default.Teacher_Birthdate = new StringCollection();
                    #endregion
                    Settings.Default.Teacher_Firstname.AddRange(firstname_list.ToArray());
                    Settings.Default.Teacher_Lastname.AddRange(lastname_list.ToArray());
                    Settings.Default.Teacher_Fathername.AddRange(father_list.ToArray());
                    Settings.Default.Teacher_Codemeli.AddRange(codemeli_list.ToArray());
                    Settings.Default.Teacher_Birthdate.AddRange(birthdate_list.ToArray());
                    Settings.Default.Save();
                    #endregion
                    MessageBox.Show($"{firstname} {lastname}{Environment.NewLine}Add to Teachers successfully!!");
                    #region String.Empty
                    Teacher_Firstname.Text = string.Empty;
                    Teacher_Lastname.Text = string.Empty;
                    Teacher_Fathername.Text = string.Empty;
                    Teacher_Codemeli.Text = string.Empty;
                    Teacher_Year.Text = string.Empty;
                    Teacher_Month.Text = string.Empty;
                    Teacher_Day.Text = string.Empty;
                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }
        private void Teacher_Codemeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
&& e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }
        private void Teacher_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
&& e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }
        private void Teacher_Month_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
&& e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }
        private void Teacher_Day_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
&& e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }
    }
}