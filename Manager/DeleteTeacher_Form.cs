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
    public partial class DeleteTeacher_Form : DevExpress.XtraEditors.XtraForm
    {
        public DeleteTeacher_Form()
        {
            InitializeComponent();
        }

        private void DeleteTeacher_Form_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Teacher_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show($"Are you sure to Delete Teacher?!",
                $"{Teacher_Firstname.Text} {Teacher_Lastname.Text}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (message == DialogResult.Yes)
            {
                #region Error Manage
                if (Teacher_Firstname.Text == string.Empty
                    && Teacher_Lastname.Text == string.Empty
                    && Teacher_Fathername.Text == string.Empty
                    && Teacher_Codemeli.Text == string.Empty
                    && Teacher_Birthdate.Text == string.Empty)
                    MessageBox.Show($"Please Select Student from List");

                #endregion
                else
                {
                    try
                    {
                        MessageBox.Show($"Teacher:  Deleted Successfully");
                        #region String.Empty
                        Teacher_Firstname.Text = string.Empty;
                        Teacher_Lastname.Text = string.Empty;
                        Teacher_Fathername.Text = string.Empty;
                        Teacher_Codemeli.Text = string.Empty;
                        Teacher_Birthdate.Text = string.Empty;
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

        private void Teacher_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}