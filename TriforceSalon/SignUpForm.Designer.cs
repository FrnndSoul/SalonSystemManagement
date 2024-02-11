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
            this.NameBox.Location = new System.Drawing.Point(535, 414);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(330, 20);
            this.NameBox.TabIndex = 0;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(535, 466);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(330, 20);
            this.UsernameBox.TabIndex = 2;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(535, 518);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(330, 20);
            this.EmailBox.TabIndex = 4;
            // 
            // PasswordBox1
            // 
            this.PasswordBox1.Location = new System.Drawing.Point(535, 674);
            this.PasswordBox1.Name = "PasswordBox1";
            this.PasswordBox1.Size = new System.Drawing.Size(330, 20);
            this.PasswordBox1.TabIndex = 8;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(535, 622);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(330, 20);
            this.PasswordBox.TabIndex = 7;
            // 
            // Photo
            // 
            this.Photo.Location = new System.Drawing.Point(575, 37);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(250, 250);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 9;
            this.Photo.TabStop = false;
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(626, 293);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(148, 23);
            this.UploadBtn.TabIndex = 11;
            this.UploadBtn.Text = "Upload Profile Photo";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Location = new System.Drawing.Point(535, 570);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(330, 20);
            this.BirthdayPicker.TabIndex = 12;
            // 
            // TogglePassword
            // 
            this.TogglePassword.AutoSize = true;
            this.TogglePassword.Location = new System.Drawing.Point(535, 700);
            this.TogglePassword.Name = "TogglePassword";
            this.TogglePassword.Size = new System.Drawing.Size(102, 17);
            this.TogglePassword.TabIndex = 13;
            this.TogglePassword.Text = "Show Password";
            this.TogglePassword.UseVisualStyleBackColor = true;
            this.TogglePassword.CheckedChanged += new System.EventHandler(this.TogglePassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 658);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Confirm Password";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(535, 755);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 21;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(790, 755);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 22;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Name = "SignUpForm";
            this.Size = new System.Drawing.Size(1400, 1060);
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
