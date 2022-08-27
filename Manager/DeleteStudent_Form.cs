using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
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
    public partial class DeleteStudent_Form : XtraForm
    {
        public DeleteStudent_Form()
        {
            InitializeComponent();
        }
        private void DeleteStudent_Form_Load(object sender, EventArgs e)
        {

        }
        private void Student_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Show information
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Please select item");
            }
            #endregion
        }
        private void Add_Student_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show($"Are you sure to Delete Student?!",
                $"{Student_Firstname.Text} {Student_Lastname.Text}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (message == DialogResult.Yes)
            {
                #region Error Manage
                if (Student_Firstname.Text == string.Empty
                    && Student_Lastname.Text == string.Empty
                    && Student_Fathername.Text == string.Empty
                    && Student_Codemeli.Text == string.Empty
                    && Student_Birthdate.Text == string.Empty)
                    MessageBox.Show($"Please Select Student from List");

                #endregion
                else
                {
                    try
                    {

                        MessageBox.Show($"Student: Deleted Successfully");
                        #region String.Empty
                        Student_Firstname.Text = string.Empty;
                        Student_Lastname.Text = string.Empty;
                        Student_Fathername.Text = string.Empty;
                        Student_Codemeli.Text = string.Empty;
                        Student_Birthdate.Text = string.Empty;
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }
                }
            }
            else
                MessageBox.Show("Operation Canceled");
        }
    }
}