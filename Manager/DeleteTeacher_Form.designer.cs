namespace Manager
{
    partial class DeleteTeacher_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteTeacher_Form));
            this.Teacher_Lastname = new System.Windows.Forms.Label();
            this.Teacher_Fathername = new System.Windows.Forms.Label();
            this.Teacher_Codemeli = new System.Windows.Forms.Label();
            this.Teacher_Birthdate = new System.Windows.Forms.Label();
            this.Teacher_Firstname = new System.Windows.Forms.Label();
            this.Delete_Teacher = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Teacher_Listbox = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Listbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Teacher_Lastname
            // 
            this.Teacher_Lastname.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Lastname.Location = new System.Drawing.Point(187, 45);
            this.Teacher_Lastname.Name = "Teacher_Lastname";
            this.Teacher_Lastname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Teacher_Lastname.Size = new System.Drawing.Size(219, 22);
            this.Teacher_Lastname.TabIndex = 37;
            this.Teacher_Lastname.Text = "...";
            // 
            // Teacher_Fathername
            // 
            this.Teacher_Fathername.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Fathername.Location = new System.Drawing.Point(187, 77);
            this.Teacher_Fathername.Name = "Teacher_Fathername";
            this.Teacher_Fathername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Teacher_Fathername.Size = new System.Drawing.Size(219, 22);
            this.Teacher_Fathername.TabIndex = 36;
            this.Teacher_Fathername.Text = "...";
            // 
            // Teacher_Codemeli
            // 
            this.Teacher_Codemeli.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Codemeli.Location = new System.Drawing.Point(187, 109);
            this.Teacher_Codemeli.Name = "Teacher_Codemeli";
            this.Teacher_Codemeli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Teacher_Codemeli.Size = new System.Drawing.Size(219, 22);
            this.Teacher_Codemeli.TabIndex = 35;
            this.Teacher_Codemeli.Text = "...";
            // 
            // Teacher_Birthdate
            // 
            this.Teacher_Birthdate.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Birthdate.Location = new System.Drawing.Point(187, 141);
            this.Teacher_Birthdate.Name = "Teacher_Birthdate";
            this.Teacher_Birthdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Teacher_Birthdate.Size = new System.Drawing.Size(219, 22);
            this.Teacher_Birthdate.TabIndex = 34;
            this.Teacher_Birthdate.Text = "...";
            // 
            // Teacher_Firstname
            // 
            this.Teacher_Firstname.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Firstname.Location = new System.Drawing.Point(187, 13);
            this.Teacher_Firstname.Name = "Teacher_Firstname";
            this.Teacher_Firstname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Teacher_Firstname.Size = new System.Drawing.Size(219, 22);
            this.Teacher_Firstname.TabIndex = 33;
            this.Teacher_Firstname.Text = "...";
            // 
            // Delete_Teacher
            // 
            this.Delete_Teacher.Appearance.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Teacher.Appearance.Options.UseFont = true;
            this.Delete_Teacher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Delete_Teacher.ImageOptions.SvgImage")));
            this.Delete_Teacher.Location = new System.Drawing.Point(278, 172);
            this.Delete_Teacher.Name = "Delete_Teacher";
            this.Delete_Teacher.Size = new System.Drawing.Size(128, 30);
            this.Delete_Teacher.TabIndex = 32;
            this.Delete_Teacher.Text = "حذف معلم";
            this.Delete_Teacher.Click += new System.EventHandler(this.Delete_Teacher_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 45);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "نام خانوادگی معلم :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 77);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "نام پدر :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 109);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "کد ملی معلم :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 141);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "تاریخ تولد معلم :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "نام معلم :";
            // 
            // Teacher_Listbox
            // 
            this.Teacher_Listbox.Location = new System.Drawing.Point(12, 12);
            this.Teacher_Listbox.Name = "Teacher_Listbox";
            this.Teacher_Listbox.Size = new System.Drawing.Size(159, 312);
            this.Teacher_Listbox.TabIndex = 38;
            this.Teacher_Listbox.SelectedIndexChanged += new System.EventHandler(this.Teacher_Listbox_SelectedIndexChanged);
            // 
            // DeleteTeacher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 422);
            this.Controls.Add(this.Teacher_Listbox);
            this.Controls.Add(this.Teacher_Lastname);
            this.Controls.Add(this.Teacher_Fathername);
            this.Controls.Add(this.Teacher_Codemeli);
            this.Controls.Add(this.Teacher_Birthdate);
            this.Controls.Add(this.Teacher_Firstname);
            this.Controls.Add(this.Delete_Teacher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteTeacher_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteTeacher_Form";
            this.Load += new System.EventHandler(this.DeleteTeacher_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_Listbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Teacher_Lastname;
        private System.Windows.Forms.Label Teacher_Fathername;
        private System.Windows.Forms.Label Teacher_Codemeli;
        private System.Windows.Forms.Label Teacher_Birthdate;
        private System.Windows.Forms.Label Teacher_Firstname;
        private DevExpress.XtraEditors.SimpleButton Delete_Teacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ListBoxControl Teacher_Listbox;
    }
}