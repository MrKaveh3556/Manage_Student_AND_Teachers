namespace Manager
{
    partial class Authorization_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.Enter_Button = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Password = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Username = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Username.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazirmatn Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Pragram";
            // 
            // Enter_Button
            // 
            this.Enter_Button.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Enter_Button.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Enter_Button.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Enter_Button.Appearance.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Button.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Enter_Button.Appearance.Options.UseBackColor = true;
            this.Enter_Button.Appearance.Options.UseBorderColor = true;
            this.Enter_Button.Appearance.Options.UseFont = true;
            this.Enter_Button.Appearance.Options.UseForeColor = true;
            this.Enter_Button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Enter_Button.ImageOptions.Image")));
            this.Enter_Button.Location = new System.Drawing.Point(109, 120);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(97, 35);
            this.Enter_Button.TabIndex = 11;
            this.Enter_Button.Text = "ورود";
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            this.Enter_Button.DoubleClick += new System.EventHandler(this.Enter_Button_DoubleClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(238, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 22);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = ": نام کاربری";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(84, 86);
            this.Password.Name = "Password";
            this.Password.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(243)))));
            this.Password.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9.75F);
            this.Password.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.Password.Properties.Appearance.Options.UseBackColor = true;
            this.Password.Properties.Appearance.Options.UseFont = true;
            this.Password.Properties.Appearance.Options.UseForeColor = true;
            this.Password.Size = new System.Drawing.Size(148, 28);
            this.Password.TabIndex = 10;
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(238, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 22);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = ": رمز عبور";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(84, 48);
            this.Username.Name = "Username";
            this.Username.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(243)))));
            this.Username.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9.75F);
            this.Username.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(32)))));
            this.Username.Properties.Appearance.Options.UseBackColor = true;
            this.Username.Properties.Appearance.Options.UseFont = true;
            this.Username.Properties.Appearance.Options.UseForeColor = true;
            this.Username.Size = new System.Drawing.Size(148, 28);
            this.Username.TabIndex = 9;
            this.Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username_KeyPress);
            // 
            // Authorization_Form
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 199);
            this.Controls.Add(this.Enter_Button);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Name = "Authorization_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Username.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton Enter_Button;
        public DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit Password;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Username;
    }
}