namespace Manager
{
    partial class DeleteStudent_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStudent_Form));
            this.Student_Listbox = new DevExpress.XtraEditors.ListBoxControl();
            this.Add_Student = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Student_Firstname = new System.Windows.Forms.Label();
            this.Student_Birthdate = new System.Windows.Forms.Label();
            this.Student_Codemeli = new System.Windows.Forms.Label();
            this.Student_Fathername = new System.Windows.Forms.Label();
            this.Student_Lastname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Listbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Student_Listbox
            // 
            this.Student_Listbox.Location = new System.Drawing.Point(12, 12);
            this.Student_Listbox.Name = "Student_Listbox";
            this.Student_Listbox.Size = new System.Drawing.Size(159, 312);
            this.Student_Listbox.TabIndex = 0;
            this.Student_Listbox.SelectedIndexChanged += new System.EventHandler(this.Student_Listbox_SelectedIndexChanged);
            // 
            // Add_Student
            // 
            this.Add_Student.Appearance.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Student.Appearance.Options.UseFont = true;
            this.Add_Student.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add_Student.ImageOptions.Image")));
            this.Add_Student.Location = new System.Drawing.Point(268, 172);
            this.Add_Student.Name = "Add_Student";
            this.Add_Student.Size = new System.Drawing.Size(128, 30);
            this.Add_Student.TabIndex = 21;
            this.Add_Student.Text = "حذف دانش آموز";
            this.Add_Student.Click += new System.EventHandler(this.Add_Student_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 45);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "نام خانوادگی دانش آموز :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 77);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "نام پدر :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 109);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "کد ملی دانش آموز :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 141);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "تاریخ تولد دانش آموز :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "نام دانش آموز :";
            // 
            // Student_Firstname
            // 
            this.Student_Firstname.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Firstname.Location = new System.Drawing.Point(177, 13);
            this.Student_Firstname.Name = "Student_Firstname";
            this.Student_Firstname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Student_Firstname.Size = new System.Drawing.Size(219, 22);
            this.Student_Firstname.TabIndex = 22;
            this.Student_Firstname.Text = "...";
            // 
            // Student_Birthdate
            // 
            this.Student_Birthdate.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Birthdate.Location = new System.Drawing.Point(177, 141);
            this.Student_Birthdate.Name = "Student_Birthdate";
            this.Student_Birthdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Student_Birthdate.Size = new System.Drawing.Size(219, 22);
            this.Student_Birthdate.TabIndex = 23;
            this.Student_Birthdate.Text = "...";
            // 
            // Student_Codemeli
            // 
            this.Student_Codemeli.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Codemeli.Location = new System.Drawing.Point(177, 109);
            this.Student_Codemeli.Name = "Student_Codemeli";
            this.Student_Codemeli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Student_Codemeli.Size = new System.Drawing.Size(219, 22);
            this.Student_Codemeli.TabIndex = 24;
            this.Student_Codemeli.Text = "...";
            // 
            // Student_Fathername
            // 
            this.Student_Fathername.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Fathername.Location = new System.Drawing.Point(177, 77);
            this.Student_Fathername.Name = "Student_Fathername";
            this.Student_Fathername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Student_Fathername.Size = new System.Drawing.Size(219, 22);
            this.Student_Fathername.TabIndex = 25;
            this.Student_Fathername.Text = "...";
            // 
            // Student_Lastname
            // 
            this.Student_Lastname.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Lastname.Location = new System.Drawing.Point(177, 45);
            this.Student_Lastname.Name = "Student_Lastname";
            this.Student_Lastname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Student_Lastname.Size = new System.Drawing.Size(219, 22);
            this.Student_Lastname.TabIndex = 26;
            this.Student_Lastname.Text = "...";
            // 
            // DeleteStudent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 379);
            this.Controls.Add(this.Student_Lastname);
            this.Controls.Add(this.Student_Fathername);
            this.Controls.Add(this.Student_Codemeli);
            this.Controls.Add(this.Student_Birthdate);
            this.Controls.Add(this.Student_Firstname);
            this.Controls.Add(this.Add_Student);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Student_Listbox);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DeleteStudent_Form.IconOptions.LargeImage")));
            this.Name = "DeleteStudent_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Student";
            this.Load += new System.EventHandler(this.DeleteStudent_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Student_Listbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl Student_Listbox;
        private DevExpress.XtraEditors.SimpleButton Add_Student;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Student_Firstname;
        private System.Windows.Forms.Label Student_Birthdate;
        private System.Windows.Forms.Label Student_Codemeli;
        private System.Windows.Forms.Label Student_Fathername;
        private System.Windows.Forms.Label Student_Lastname;
    }
}