namespace TriforceSalon
{
    partial class SignUpForm
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PasswordBox1 = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.BirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.TogglePassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(713, 510);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(439, 22);
            this.NameBox.TabIndex = 0;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(713, 574);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(439, 22);
            this.UsernameBox.TabIndex = 2;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(713, 638);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(439, 22);
            this.EmailBox.TabIndex = 4;
            this.EmailBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailBox_KeyPress);
            // 
            // PasswordBox1
            // 
            this.PasswordBox1.Location = new System.Drawing.Point(713, 830);
            this.PasswordBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordBox1.Name = "PasswordBox1";
            this.PasswordBox1.Size = new System.Drawing.Size(439, 22);
            this.PasswordBox1.TabIndex = 8;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(713, 766);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(439, 22);
            this.PasswordBox.TabIndex = 7;
            // 
            // Photo
            // 
            this.Photo.Location = new System.Drawing.Point(767, 46);
            this.Photo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(333, 308);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 9;
            this.Photo.TabStop = false;
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(835, 361);
            this.UploadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(197, 28);
            this.UploadBtn.TabIndex = 11;
            this.UploadBtn.Text = "Upload Profile Photo";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Location = new System.Drawing.Point(713, 702);
            this.BirthdayPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(439, 22);
            this.BirthdayPicker.TabIndex = 12;
            // 
            // TogglePassword
            // 
            this.TogglePassword.AutoSize = true;
            this.TogglePassword.Location = new System.Drawing.Point(713, 862);
            this.TogglePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TogglePassword.Name = "TogglePassword";
            this.TogglePassword.Size = new System.Drawing.Size(125, 20);
            this.TogglePassword.TabIndex = 13;
            this.TogglePassword.Text = "Show Password";
            this.TogglePassword.UseVisualStyleBackColor = true;
            this.TogglePassword.CheckedChanged += new System.EventHandler(this.TogglePassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 490);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 554);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 618);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 682);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 746);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(709, 810);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Confirm Password";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(713, 929);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(100, 28);
            this.CreateBtn.TabIndex = 21;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(1053, 929);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(100, 28);
            this.BackBtn.TabIndex = 22;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TogglePassword);
            this.Controls.Add(this.BirthdayPicker);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.PasswordBox1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.NameBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignUpForm";
            this.Size = new System.Drawing.Size(1867, 1305);
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PasswordBox1;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.DateTimePicker BirthdayPicker;
        private System.Windows.Forms.CheckBox TogglePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}
