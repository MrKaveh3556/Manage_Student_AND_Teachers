namespace Manager
{
    partial class UpdateStudent_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStudent_Form));
            this.combobox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Update_Student = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Previous_Student_Firstname = new System.Windows.Forms.Label();
            this.Previous_Student_Birthday = new System.Windows.Forms.Label();
            this.Previous_Student_Codemeli = new System.Windows.Forms.Label();
            this.Previous_Student_Fathername = new System.Windows.Forms.Label();
            this.Previous_Student_Lastname = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.New_Student_Firstname = new DevExpress.XtraEditors.TextEdit();
            this.New_Student_Birthdate = new DevExpress.XtraEditors.TextEdit();
            this.New_Student_Codemeli = new DevExpress.XtraEditors.TextEdit();
            this.New_Student_Fathername = new DevExpress.XtraEditors.TextEdit();
            this.New_Student_Lastname = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Student_Firstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Student_Birthdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Student_Codemeli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Student_Fathername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Student_Lastname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // combobox
            // 
            this.combobox.Location = new System.Drawing.Point(12, 12);
            this.combobox.Name = "combobox";
            this.combobox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combobox.Size = new System.Drawing.Size(118, 20);
            this.combobox.TabIndex = 0;
            // 
            // Update_Student
            // 
            this.Update_Student.Appearance.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Student.Appearance.Options.UseFont = true;
            this.Update_Student.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add_Student.ImageOptions.Image")));
            this.Update_Student.Location = new System.Drawing.Point(136, 142);
            this.Update_Student.Name = "Update_Student";
            this.Update_Student.Size = new System.Drawing.Size(143, 30);
            this.Update_Student.TabIndex = 21;
            this.Update_Student.Text = "ویرایش اطلاعات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(686, 38);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "نام خانوادگی فعلی دانش آموز :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(686, 64);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "نام فعلی پدر :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(686, 90);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "کد ملی فعلی دانش آموز :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(686, 116);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "تاریخ تولد فعلی دانش آموز :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(686, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "نام فعلی دانش آموز :";
            // 
            // Previous_Student_Firstname
            // 
            this.Previous_Student_Firstname.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_Student_Firstname.Location = new System.Drawing.Point(454, 12);
            this.Previous_Student_Firstname.Name = "Previous_Student_Firstname";
            this.Previous_Student_Firstname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Previous_Student_Firstname.Size = new System.Drawing.Size(226, 22);
            this.Previous_Student_Firstname.TabIndex = 22;
            this.Previous_Student_Firstname.Text = "...";
            // 
            // Previous_Student_Birthday
            // 
            this.Previous_Student_Birthday.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_Student_Birthday.Location = new System.Drawing.Point(454, 116);
            this.Previous_Student_Birthday.Name = "Previous_Student_Birthday";
            this.Previous_Student_Birthday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Previous_Student_Birthday.Size = new System.Drawing.Size(226, 22);
            this.Previous_Student_Birthday.TabIndex = 23;
            this.Previous_Student_Birthday.Text = "...";
            // 
            // Previous_Student_Codemeli
            // 
            this.Previous_Student_Codemeli.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_Student_Codemeli.Location = new System.Drawing.Point(454, 90);
            this.Previous_Student_Codemeli.Name = "Previous_Student_Codemeli";
            this.Previous_Student_Codemeli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Previous_Student_Codemeli.Size = new System.Drawing.Size(226, 22);
            this.Previous_Student_Codemeli.TabIndex = 24;
            this.Previous_Student_Codemeli.Text = "...";
            // 
            // Previous_Student_Fathername
            // 
            this.Previous_Student_Fathername.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_Student_Fathername.Location = new System.Drawing.Point(454, 64);
            this.Previous_Student_Fathername.Name = "Previous_Student_Fathername";
            this.Previous_Student_Fathername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Previous_Student_Fathername.Size = new System.Drawing.Size(226, 22);
            this.Previous_Student_Fathername.TabIndex = 25;
            this.Previous_Student_Fathername.Text = "...";
            // 
            // Previous_Student_Lastname
            // 
            this.Previous_Student_Lastname.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_Student_Lastname.Location = new System.Drawing.Point(454, 38);
            this.Previous_Student_Lastname.Name = "Previous_Student_Lastname";
            this.Previous_Student_Lastname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Previous_Student_Lastname.Size = new System.Drawing.Size(226, 22);
            this.Previous_Student_Lastname.TabIndex = 26;
            this.Previous_Student_Lastname.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(285, 38);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(165, 22);
            this.label11.TabIndex = 31;
            this.label11.Text = "نام خانوادگی جدید دانش آموز :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(285, 64);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 30;
            this.label12.Text = "نام جدید پدر :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(285, 90);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(137, 22);
            this.label13.TabIndex = 29;
            this.label13.Text = "کد ملی جدید دانش آموز :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(285, 116);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(151, 22);
            this.label14.TabIndex = 28;
            this.label14.Text = "تاریخ تولد جدید دانش آموز :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(285, 12);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(117, 22);
            this.label15.TabIndex = 27;
            this.label15.Text = "نام جدید دانش آموز :";
            // 
            // New_Student_Firstname
            // 
            this.New_Student_Firstname.Location = new System.Drawing.Point(136, 12);
            this.New_Student_Firstname.Name = "New_Student_Firstname";
            this.New_Student_Firstname.Size = new System.Drawing.Size(143, 20);
            this.New_Student_Firstname.TabIndex = 32;
            // 
            // New_Student_Birthdate
            // 
            this.New_Student_Birthdate.Location = new System.Drawing.Point(136, 116);
            this.New_Student_Birthdate.Name = "New_Student_Birthdate";
            this.New_Student_Birthdate.Size = new System.Drawing.Size(143, 20);
            this.New_Student_Birthdate.TabIndex = 33;
            // 
            // New_Student_Codemeli
            // 
            this.New_Student_Codemeli.Location = new System.Drawing.Point(136, 90);
            this.New_Student_Codemeli.Name = "New_Student_Codemeli";
            this.New_Student_Codemeli.Size = new System.Drawing.Size(143, 20);
            this.New_Student_Codemeli.TabIndex = 34;
            // 
            // New_Student_Fathername
            // 
            this.New_Student_Fathername.Location = new System.Drawing.Point(136, 64);
            this.New_Student_Fathername.Name = "New_Student_Fathername";
            this.New_Student_Fathername.Size = new System.Drawing.Size(143, 20);
            this.New_Student_Fathername.TabIndex = 35;
            // 
            // New_Student_Lastname
            // 
            this.New_Student_Lastname.Location = new System.Drawing.Point(136, 38);
            this.New_Student_Lastname.Name = "New_Student_Lastname";
            this.New_Student_Lastname.Size = new System.Drawing.Size(143, 20);
            this.New_Student_Lastname.TabIndex = 36;
            // 
            // UpdateStudent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 465);
            this.Controls.Add(this.New_Student_Lastname);
            this.Controls.Add(this.New_Student_Fathername);
            this.Controls.Add(this.New_Student_Codemeli);
            this.Controls.Add(this.New_Student_Birthdate);
            this.Controls.Add(this.New_Student_Firstname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Previous_Student_Lastname);
            this.Controls.Add(this.Previous_Student_Fathername);
            this.Controls.Add(this.Previous_Student_Codemeli);
            this.Controls.Add(this.Previous_Student_Birthday);
            this.Controls.Add(this.Previous_Student_Firstname);
            this.Controls.Add(this.Update_Student);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox);
            this.Name = "UpdateStudent_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateStudent_Form";
            ((System.ComponentModel.ISupportInitialize)(this.combobox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Student_Firstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Student_Birthdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Student_Codemeli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Student_Fathername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_Student_Lastname.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit combobox;
        private DevExpress.XtraEditors.SimpleButton Update_Student;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Previous_Student_Firstname;
        private System.Windows.Forms.Label Previous_Student_Birthday;
        private System.Windows.Forms.Label Previous_Student_Codemeli;
        private System.Windows.Forms.Label Previous_Student_Fathername;
        private System.Windows.Forms.Label Previous_Student_Lastname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.TextEdit New_Student_Firstname;
        private DevExpress.XtraEditors.TextEdit New_Student_Birthdate;
        private DevExpress.XtraEditors.TextEdit New_Student_Codemeli;
        private DevExpress.XtraEditors.TextEdit New_Student_Fathername;
        private DevExpress.XtraEditors.TextEdit New_Student_Lastname;
    }
}