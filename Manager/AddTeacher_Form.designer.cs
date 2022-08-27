namespace Manager
{
    partial class AddTeacher_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacher_Form));
            this.Add_Teacher = new DevExpress.XtraEditors.SimpleButton();
            this.Teacher_Lastname = new DevExpress.XtraEditors.TextEdit();
            this.Teacher_Fathername = new DevExpress.XtraEditors.TextEdit();
            this.Teacher_Codemeli = new DevExpress.XtraEditors.TextEdit();
            this.Teacher_Firstname = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Teacher_Day = new DevExpress.XtraEditors.TextEdit();
            this.Teacher_Month = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Teacher_Year = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Lastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Fathername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Codemeli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Firstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Day.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Month.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Year.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Teacher
            // 
            this.Add_Teacher.Appearance.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Teacher.Appearance.Options.UseFont = true;
            this.Add_Teacher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Add_Teacher.ImageOptions.SvgImage")));
            this.Add_Teacher.Location = new System.Drawing.Point(65, 232);
            this.Add_Teacher.Name = "Add_Teacher";
            this.Add_Teacher.Size = new System.Drawing.Size(128, 30);
            this.Add_Teacher.TabIndex = 21;
            this.Add_Teacher.Text = "افزودن";
            this.Add_Teacher.Click += new System.EventHandler(this.Add_Teacher_Click);
            // 
            // Teacher_Lastname
            // 
            this.Teacher_Lastname.Location = new System.Drawing.Point(65, 40);
            this.Teacher_Lastname.Name = "Teacher_Lastname";
            this.Teacher_Lastname.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Lastname.Properties.Appearance.Options.UseFont = true;
            this.Teacher_Lastname.Properties.MaxLength = 20;
            this.Teacher_Lastname.Size = new System.Drawing.Size(128, 26);
            this.Teacher_Lastname.TabIndex = 20;
            // 
            // Teacher_Fathername
            // 
            this.Teacher_Fathername.Location = new System.Drawing.Point(65, 72);
            this.Teacher_Fathername.Name = "Teacher_Fathername";
            this.Teacher_Fathername.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Fathername.Properties.Appearance.Options.UseFont = true;
            this.Teacher_Fathername.Properties.MaxLength = 20;
            this.Teacher_Fathername.Size = new System.Drawing.Size(128, 26);
            this.Teacher_Fathername.TabIndex = 19;
            // 
            // Teacher_Codemeli
            // 
            this.Teacher_Codemeli.Location = new System.Drawing.Point(65, 104);
            this.Teacher_Codemeli.Name = "Teacher_Codemeli";
            this.Teacher_Codemeli.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Codemeli.Properties.Appearance.Options.UseFont = true;
            this.Teacher_Codemeli.Properties.MaxLength = 15;
            this.Teacher_Codemeli.Size = new System.Drawing.Size(128, 26);
            this.Teacher_Codemeli.TabIndex = 18;
            this.Teacher_Codemeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teacher_Codemeli_KeyPress);
            // 
            // Teacher_Firstname
            // 
            this.Teacher_Firstname.Location = new System.Drawing.Point(65, 8);
            this.Teacher_Firstname.Name = "Teacher_Firstname";
            this.Teacher_Firstname.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Firstname.Properties.Appearance.Options.UseFont = true;
            this.Teacher_Firstname.Properties.MaxLength = 20;
            this.Teacher_Firstname.Size = new System.Drawing.Size(128, 26);
            this.Teacher_Firstname.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 41);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "نام خانوادگی معلم :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 73);
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
            this.label3.Location = new System.Drawing.Point(199, 105);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "کد ملی معلم :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "نام معلم :";
            // 
            // Teacher_Day
            // 
            this.Teacher_Day.Location = new System.Drawing.Point(65, 200);
            this.Teacher_Day.Name = "Teacher_Day";
            this.Teacher_Day.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Day.Properties.Appearance.Options.UseFont = true;
            this.Teacher_Day.Properties.MaxLength = 2;
            this.Teacher_Day.Size = new System.Drawing.Size(128, 26);
            this.Teacher_Day.TabIndex = 27;
            this.Teacher_Day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teacher_Day_KeyPress);
            // 
            // Teacher_Month
            // 
            this.Teacher_Month.Location = new System.Drawing.Point(65, 168);
            this.Teacher_Month.Name = "Teacher_Month";
            this.Teacher_Month.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Month.Properties.Appearance.Options.UseFont = true;
            this.Teacher_Month.Properties.MaxLength = 2;
            this.Teacher_Month.Size = new System.Drawing.Size(128, 26);
            this.Teacher_Month.TabIndex = 26;
            this.Teacher_Month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teacher_Month_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 169);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "ماه تولد معلم :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 201);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "روز تولد معلم :";
            // 
            // Teacher_Year
            // 
            this.Teacher_Year.Location = new System.Drawing.Point(65, 136);
            this.Teacher_Year.Name = "Teacher_Year";
            this.Teacher_Year.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Year.Properties.Appearance.Options.UseFont = true;
            this.Teacher_Year.Properties.MaxLength = 4;
            this.Teacher_Year.Size = new System.Drawing.Size(128, 26);
            this.Teacher_Year.TabIndex = 23;
            this.Teacher_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teacher_Year_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(199, 137);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(91, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "سال تولد معلم :";
            // 
            // AddTeacher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 314);
            this.Controls.Add(this.Teacher_Day);
            this.Controls.Add(this.Teacher_Month);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Teacher_Year);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Add_Teacher);
            this.Controls.Add(this.Teacher_Lastname);
            this.Controls.Add(this.Teacher_Fathername);
            this.Controls.Add(this.Teacher_Codemeli);
            this.Controls.Add(this.Teacher_Firstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("AddTeacher_Form.IconOptions.SvgImage")));
            this.Name = "AddTeacher_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Lastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Fathername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Codemeli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Firstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Day.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Month.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Year.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Add_Teacher;
        private DevExpress.XtraEditors.TextEdit Teacher_Lastname;
        private DevExpress.XtraEditors.TextEdit Teacher_Fathername;
        private DevExpress.XtraEditors.TextEdit Teacher_Codemeli;
        private DevExpress.XtraEditors.TextEdit Teacher_Firstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit Teacher_Day;
        private DevExpress.XtraEditors.TextEdit Teacher_Month;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit Teacher_Year;
        private System.Windows.Forms.Label label8;
    }
}