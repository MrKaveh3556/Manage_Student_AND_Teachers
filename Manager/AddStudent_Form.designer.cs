namespace Manager
{
    partial class AddStudent_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Student_Firstname = new DevExpress.XtraEditors.TextEdit();
            this.Student_Year = new DevExpress.XtraEditors.TextEdit();
            this.Student_Codemeli = new DevExpress.XtraEditors.TextEdit();
            this.Student_Fathername = new DevExpress.XtraEditors.TextEdit();
            this.Student_Lastname = new DevExpress.XtraEditors.TextEdit();
            this.Add_Student = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Student_Month = new DevExpress.XtraEditors.TextEdit();
            this.Student_Day = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Firstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Codemeli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Fathername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Lastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Month.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Day.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام دانش آموز :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 137);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "سال تولد دانش آموز :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 105);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "کد ملی دانش آموز :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 73);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "نام پدر :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 41);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "نام خانوادگی دانش آموز :";
            // 
            // Student_Firstname
            // 
            this.Student_Firstname.Location = new System.Drawing.Point(63, 8);
            this.Student_Firstname.Name = "Student_Firstname";
            this.Student_Firstname.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Firstname.Properties.Appearance.Options.UseFont = true;
            this.Student_Firstname.Properties.MaxLength = 20;
            this.Student_Firstname.Size = new System.Drawing.Size(128, 26);
            this.Student_Firstname.TabIndex = 5;
            // 
            // Student_Year
            // 
            this.Student_Year.Location = new System.Drawing.Point(63, 136);
            this.Student_Year.Name = "Student_Year";
            this.Student_Year.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Year.Properties.Appearance.Options.UseFont = true;
            this.Student_Year.Properties.MaxLength = 4;
            this.Student_Year.Size = new System.Drawing.Size(128, 26);
            this.Student_Year.TabIndex = 6;
            this.Student_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Student_Birthdate_KeyPress);
            // 
            // Student_Codemeli
            // 
            this.Student_Codemeli.Location = new System.Drawing.Point(63, 104);
            this.Student_Codemeli.Name = "Student_Codemeli";
            this.Student_Codemeli.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Codemeli.Properties.Appearance.Options.UseFont = true;
            this.Student_Codemeli.Properties.MaxLength = 15;
            this.Student_Codemeli.Size = new System.Drawing.Size(128, 26);
            this.Student_Codemeli.TabIndex = 7;
            this.Student_Codemeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Student_Codemeli_KeyPress);
            // 
            // Student_Fathername
            // 
            this.Student_Fathername.Location = new System.Drawing.Point(63, 72);
            this.Student_Fathername.Name = "Student_Fathername";
            this.Student_Fathername.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Fathername.Properties.Appearance.Options.UseFont = true;
            this.Student_Fathername.Properties.MaxLength = 20;
            this.Student_Fathername.Size = new System.Drawing.Size(128, 26);
            this.Student_Fathername.TabIndex = 8;
            // 
            // Student_Lastname
            // 
            this.Student_Lastname.Location = new System.Drawing.Point(63, 40);
            this.Student_Lastname.Name = "Student_Lastname";
            this.Student_Lastname.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Lastname.Properties.Appearance.Options.UseFont = true;
            this.Student_Lastname.Properties.MaxLength = 20;
            this.Student_Lastname.Size = new System.Drawing.Size(128, 26);
            this.Student_Lastname.TabIndex = 9;
            // 
            // Add_Student
            // 
            this.Add_Student.Appearance.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Student.Appearance.Options.UseFont = true;
            this.Add_Student.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Add_Student.ImageOptions.SvgImage")));
            this.Add_Student.Location = new System.Drawing.Point(63, 232);
            this.Add_Student.Name = "Add_Student";
            this.Add_Student.Size = new System.Drawing.Size(128, 30);
            this.Add_Student.TabIndex = 10;
            this.Add_Student.Text = "افزودن";
            this.Add_Student.Click += new System.EventHandler(this.Add_Student_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 201);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "روز تولد دانش آموز :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 169);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "ماه تولد دانش آموز :";
            // 
            // Student_Month
            // 
            this.Student_Month.Location = new System.Drawing.Point(63, 168);
            this.Student_Month.Name = "Student_Month";
            this.Student_Month.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Month.Properties.Appearance.Options.UseFont = true;
            this.Student_Month.Properties.MaxLength = 2;
            this.Student_Month.Size = new System.Drawing.Size(128, 26);
            this.Student_Month.TabIndex = 13;
            this.Student_Month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Student_Month_KeyPress);
            // 
            // Student_Day
            // 
            this.Student_Day.Location = new System.Drawing.Point(63, 200);
            this.Student_Day.Name = "Student_Day";
            this.Student_Day.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Day.Properties.Appearance.Options.UseFont = true;
            this.Student_Day.Properties.MaxLength = 2;
            this.Student_Day.Size = new System.Drawing.Size(128, 26);
            this.Student_Day.TabIndex = 14;
            this.Student_Day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Student_Day_KeyPress);
            // 
            // AddStudent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 314);
            this.Controls.Add(this.Student_Day);
            this.Controls.Add(this.Student_Month);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Add_Student);
            this.Controls.Add(this.Student_Lastname);
            this.Controls.Add(this.Student_Fathername);
            this.Controls.Add(this.Student_Codemeli);
            this.Controls.Add(this.Student_Year);
            this.Controls.Add(this.Student_Firstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("AddStudent_Form.IconOptions.SvgImage")));
            this.Name = "AddStudent_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            ((System.ComponentModel.ISupportInitialize)(this.Student_Firstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Codemeli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Fathername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Lastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Month.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Day.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit Student_Firstname;
        private DevExpress.XtraEditors.TextEdit Student_Year;
        private DevExpress.XtraEditors.TextEdit Student_Codemeli;
        private DevExpress.XtraEditors.TextEdit Student_Fathername;
        private DevExpress.XtraEditors.TextEdit Student_Lastname;
        private DevExpress.XtraEditors.SimpleButton Add_Student;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit Student_Month;
        private DevExpress.XtraEditors.TextEdit Student_Day;
    }
}