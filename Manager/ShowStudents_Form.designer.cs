namespace Manager
{
    partial class ShowStudents_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowStudents_Form));
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Physic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arabi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adabiat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save_Data = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToDeleteRows = false;
            this.datagridview.AllowUserToResizeColumns = false;
            this.datagridview.AllowUserToResizeRows = false;
            this.datagridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fullname,
            this.Math,
            this.Physic,
            this.Shimi,
            this.Arabi,
            this.Adabiat,
            this.Average});
            this.datagridview.Location = new System.Drawing.Point(12, 12);
            this.datagridview.Name = "datagridview";
            this.datagridview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagridview.Size = new System.Drawing.Size(845, 373);
            this.datagridview.TabIndex = 0;
            this.datagridview.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datagridview_KeyPress);
            // 
            // ID
            // 
            this.ID.HeaderText = "ردیف";
            this.ID.MaxInputLength = 1000;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "نام و نام خانوادگی";
            this.Fullname.MaxInputLength = 100;
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            this.Fullname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Math
            // 
            this.Math.HeaderText = "ریاضی";
            this.Math.MaxInputLength = 100;
            this.Math.Name = "Math";
            this.Math.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Physic
            // 
            this.Physic.HeaderText = "فیزیک";
            this.Physic.MaxInputLength = 100;
            this.Physic.Name = "Physic";
            this.Physic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Shimi
            // 
            this.Shimi.HeaderText = "شیمی";
            this.Shimi.MaxInputLength = 100;
            this.Shimi.Name = "Shimi";
            this.Shimi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Arabi
            // 
            this.Arabi.HeaderText = "عربی";
            this.Arabi.MaxInputLength = 100;
            this.Arabi.Name = "Arabi";
            this.Arabi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Adabiat
            // 
            this.Adabiat.HeaderText = "ادبیات";
            this.Adabiat.MaxInputLength = 100;
            this.Adabiat.Name = "Adabiat";
            this.Adabiat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Average
            // 
            this.Average.HeaderText = "معدل";
            this.Average.Name = "Average";
            this.Average.ReadOnly = true;
            // 
            // Save_Data
            // 
            this.Save_Data.Appearance.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Data.Appearance.Options.UseFont = true;
            this.Save_Data.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Save_Data.ImageOptions.Image")));
            this.Save_Data.Location = new System.Drawing.Point(440, 391);
            this.Save_Data.Name = "Save_Data";
            this.Save_Data.Size = new System.Drawing.Size(128, 30);
            this.Save_Data.TabIndex = 11;
            this.Save_Data.Text = "ذخیره نمرات";
            this.Save_Data.Click += new System.EventHandler(this.Save_Data_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(306, 391);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(128, 30);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "ثبت معدل";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ShowStudents_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 476);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.Save_Data);
            this.Controls.Add(this.datagridview);
            this.Name = "ShowStudents_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentGrade_Form";
            this.Load += new System.EventHandler(this.StudentGrade_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Math;
        private System.Windows.Forms.DataGridViewTextBoxColumn Physic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arabi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adabiat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        public System.Windows.Forms.DataGridView datagridview;
        public DevExpress.XtraEditors.SimpleButton Save_Data;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}