namespace Manager
{
    partial class ShowTeachers_Form
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
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeMeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.FatherName,
            this.CodeMeli,
            this.BirthDate});
            this.datagridview.Cursor = System.Windows.Forms.Cursors.No;
            this.datagridview.Location = new System.Drawing.Point(12, 12);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagridview.Size = new System.Drawing.Size(544, 452);
            this.datagridview.TabIndex = 1;
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
            // FatherName
            // 
            this.FatherName.HeaderText = "نام پدر";
            this.FatherName.Name = "FatherName";
            this.FatherName.ReadOnly = true;
            // 
            // CodeMeli
            // 
            this.CodeMeli.HeaderText = "کدملی";
            this.CodeMeli.Name = "CodeMeli";
            this.CodeMeli.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "تاریخ تولد";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // ShowTeachers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 476);
            this.Controls.Add(this.datagridview);
            this.Name = "ShowTeachers_Form";
            this.Text = "ShowTeachers_Form";
            this.Load += new System.EventHandler(this.ShowTeachers_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeMeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
    }
}