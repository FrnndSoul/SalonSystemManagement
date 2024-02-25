namespace TriforceSalon
{
    partial class AdminForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UserTab = new System.Windows.Forms.TabPage();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DiscardBtn = new System.Windows.Forms.Button();
            this.ChangeRoleBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.UserDGV = new System.Windows.Forms.DataGridView();
            this.ServiceTypesTab = new System.Windows.Forms.TabPage();
            this.ServiceTypesGDV = new System.Windows.Forms.DataGridView();
            this.SignoutBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.UserTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            this.ServiceTypesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypesGDV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UserTab);
            this.tabControl1.Controls.Add(this.ServiceTypesTab);
            this.tabControl1.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(50, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1800, 1000);
            this.tabControl1.TabIndex = 0;
            // 
            // UserTab
            // 
            this.UserTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.UserTab.Controls.Add(this.EditBtn);
            this.UserTab.Controls.Add(this.DiscardBtn);
            this.UserTab.Controls.Add(this.ChangeRoleBtn);
            this.UserTab.Controls.Add(this.SaveBtn);
            this.UserTab.Controls.Add(this.label6);
            this.UserTab.Controls.Add(this.label5);
            this.UserTab.Controls.Add(this.label4);
            this.UserTab.Controls.Add(this.label3);
            this.UserTab.Controls.Add(this.label2);
            this.UserTab.Controls.Add(this.label1);
            this.UserTab.Controls.Add(this.BirthdayPicker);
            this.UserTab.Controls.Add(this.UploadBtn);
            this.UserTab.Controls.Add(this.Photo);
            this.UserTab.Controls.Add(this.StatusBox);
            this.UserTab.Controls.Add(this.IDBox);
            this.UserTab.Controls.Add(this.EmailBox);
            this.UserTab.Controls.Add(this.UsernameBox);
            this.UserTab.Controls.Add(this.NameBox);
            this.UserTab.Controls.Add(this.UserDGV);
            this.UserTab.Location = new System.Drawing.Point(4, 35);
            this.UserTab.Name = "UserTab";
            this.UserTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserTab.Size = new System.Drawing.Size(1792, 961);
            this.UserTab.TabIndex = 0;
            this.UserTab.Text = "List of Users";
            this.UserTab.Click += new System.EventHandler(this.UserTab_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(1262, 623);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(84, 23);
            this.EditBtn.TabIndex = 48;
            this.EditBtn.Text = "Edit User";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DiscardBtn
            // 
            this.DiscardBtn.Location = new System.Drawing.Point(1262, 681);
            this.DiscardBtn.Name = "DiscardBtn";
            this.DiscardBtn.Size = new System.Drawing.Size(84, 23);
            this.DiscardBtn.TabIndex = 44;
            this.DiscardBtn.Text = "Discard";
            this.DiscardBtn.UseVisualStyleBackColor = true;
            this.DiscardBtn.Visible = false;
            this.DiscardBtn.Click += new System.EventHandler(this.DiscardBtn_Click);
            // 
            // ChangeRoleBtn
            // 
            this.ChangeRoleBtn.Location = new System.Drawing.Point(1132, 681);
            this.ChangeRoleBtn.Name = "ChangeRoleBtn";
            this.ChangeRoleBtn.Size = new System.Drawing.Size(124, 23);
            this.ChangeRoleBtn.TabIndex = 43;
            this.ChangeRoleBtn.Text = "Promote/Demote";
            this.ChangeRoleBtn.UseVisualStyleBackColor = true;
            this.ChangeRoleBtn.Visible = false;
            this.ChangeRoleBtn.Click += new System.EventHandler(this.ChangeRoleBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(1016, 681);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 23);
            this.SaveBtn.TabIndex = 41;
            this.SaveBtn.Text = "Save Changes";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1191, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 26);
            this.label6.TabIndex = 37;
            this.label6.Text = "Account Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1013, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 26);
            this.label5.TabIndex = 36;
            this.label5.Text = "ID Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1013, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 35;
            this.label4.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1013, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1013, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1013, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name";
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Enabled = false;
            this.BirthdayPicker.Location = new System.Drawing.Point(1016, 516);
            this.BirthdayPicker.MaxDate = new System.DateTime(2024, 2, 12, 0, 0, 0, 0);
            this.BirthdayPicker.MinDate = new System.DateTime(1753, 12, 21, 0, 0, 0, 0);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(330, 34);
            this.BirthdayPicker.TabIndex = 30;
            this.BirthdayPicker.Value = new System.DateTime(2024, 2, 12, 0, 0, 0, 0);
            this.BirthdayPicker.ValueChanged += new System.EventHandler(this.BirthdayPicker_ValueChanged);
            // 
            // UploadBtn
            // 
            this.UploadBtn.Enabled = false;
            this.UploadBtn.Location = new System.Drawing.Point(1108, 310);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(148, 23);
            this.UploadBtn.TabIndex = 29;
            this.UploadBtn.Text = "Update Profile Photo";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // Photo
            // 
            this.Photo.Location = new System.Drawing.Point(1057, 54);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(250, 250);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 28;
            this.Photo.TabStop = false;
            // 
            // StatusBox
            // 
            this.StatusBox.Enabled = false;
            this.StatusBox.Location = new System.Drawing.Point(1277, 568);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(69, 34);
            this.StatusBox.TabIndex = 27;
            // 
            // IDBox
            // 
            this.IDBox.Enabled = false;
            this.IDBox.Location = new System.Drawing.Point(1073, 568);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(97, 34);
            this.IDBox.TabIndex = 26;
            // 
            // EmailBox
            // 
            this.EmailBox.Enabled = false;
            this.EmailBox.Location = new System.Drawing.Point(1016, 464);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(330, 34);
            this.EmailBox.TabIndex = 25;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Enabled = false;
            this.UsernameBox.Location = new System.Drawing.Point(1016, 412);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(330, 34);
            this.UsernameBox.TabIndex = 24;
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(1016, 360);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(330, 34);
            this.NameBox.TabIndex = 23;
            // 
            // UserDGV
            // 
            this.UserDGV.AllowUserToAddRows = false;
            this.UserDGV.AllowUserToDeleteRows = false;
            this.UserDGV.AllowUserToResizeColumns = false;
            this.UserDGV.AllowUserToResizeRows = false;
            this.UserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDGV.BackgroundColor = System.Drawing.Color.White;
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDGV.Location = new System.Drawing.Point(3, 3);
            this.UserDGV.MultiSelect = false;
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.ReadOnly = true;
            this.UserDGV.RowHeadersWidth = 51;
            this.UserDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDGV.Size = new System.Drawing.Size(952, 697);
            this.UserDGV.TabIndex = 0;
            this.UserDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDGV_CellContentClick_1);
            // 
            // ServiceTypesTab
            // 
            this.ServiceTypesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ServiceTypesTab.Controls.Add(this.ServiceTypesGDV);
            this.ServiceTypesTab.Location = new System.Drawing.Point(4, 35);
            this.ServiceTypesTab.Name = "ServiceTypesTab";
            this.ServiceTypesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceTypesTab.Size = new System.Drawing.Size(1386, 839);
            this.ServiceTypesTab.TabIndex = 1;
            this.ServiceTypesTab.Text = "Service Types";
            // 
            // ServiceTypesGDV
            // 
            this.ServiceTypesGDV.AllowUserToAddRows = false;
            this.ServiceTypesGDV.AllowUserToDeleteRows = false;
            this.ServiceTypesGDV.AllowUserToResizeColumns = false;
            this.ServiceTypesGDV.AllowUserToResizeRows = false;
            this.ServiceTypesGDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceTypesGDV.BackgroundColor = System.Drawing.Color.White;
            this.ServiceTypesGDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceTypesGDV.Location = new System.Drawing.Point(3, 3);
            this.ServiceTypesGDV.MultiSelect = false;
            this.ServiceTypesGDV.Name = "ServiceTypesGDV";
            this.ServiceTypesGDV.ReadOnly = true;
            this.ServiceTypesGDV.RowHeadersWidth = 51;
            this.ServiceTypesGDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceTypesGDV.Size = new System.Drawing.Size(952, 697);
            this.ServiceTypesGDV.TabIndex = 1;
            // 
            // SignoutBtn
            // 
            this.SignoutBtn.Location = new System.Drawing.Point(1298, 1034);
            this.SignoutBtn.Name = "SignoutBtn";
            this.SignoutBtn.Size = new System.Drawing.Size(96, 23);
            this.SignoutBtn.TabIndex = 1;
            this.SignoutBtn.Text = "Signout";
            this.SignoutBtn.UseVisualStyleBackColor = true;
            this.SignoutBtn.Click += new System.EventHandler(this.SignoutBtn_Click);
            // 
            // AdminForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            this.Controls.Add(this.SignoutBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Size = new System.Drawing.Size(1900, 1060);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.UserTab.ResumeLayout(false);
            this.UserTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            this.ServiceTypesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypesGDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.TabPage ServiceTypesTab;
        private System.Windows.Forms.DataGridView UserDGV;
        private System.Windows.Forms.Button SignoutBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker BirthdayPicker;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button DiscardBtn;
        private System.Windows.Forms.Button ChangeRoleBtn;
        private System.Windows.Forms.DataGridView ServiceTypesGDV;
        private System.Windows.Forms.Button EditBtn;
    }
}
