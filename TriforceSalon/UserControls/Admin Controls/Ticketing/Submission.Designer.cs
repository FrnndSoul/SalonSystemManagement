namespace TriforceSalon.UserControls.Admin_Controls.Ticketing
{
    partial class Submission
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
            this.FileNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DiscardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceptionistCheckbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.EssayBox = new System.Windows.Forms.RichTextBox();
            this.ManagerCheckbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminCheckbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NoneCheckbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TypeBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // FileNameBox
            // 
            this.FileNameBox.BackColor = System.Drawing.Color.Transparent;
            this.FileNameBox.BorderColor = System.Drawing.Color.Black;
            this.FileNameBox.BorderThickness = 0;
            this.FileNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FileNameBox.DefaultText = "";
            this.FileNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FileNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FileNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileNameBox.Enabled = false;
            this.FileNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileNameBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.FileNameBox.ForeColor = System.Drawing.Color.Black;
            this.FileNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileNameBox.Location = new System.Drawing.Point(189, 696);
            this.FileNameBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.PasswordChar = '\0';
            this.FileNameBox.PlaceholderText = "File name";
            this.FileNameBox.ReadOnly = true;
            this.FileNameBox.SelectedText = "";
            this.FileNameBox.Size = new System.Drawing.Size(480, 38);
            this.FileNameBox.TabIndex = 112;
            // 
            // UploadBtn
            // 
            this.UploadBtn.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.UploadBtn.Location = new System.Drawing.Point(69, 694);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(120, 42);
            this.UploadBtn.TabIndex = 111;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.label4.Location = new System.Drawing.Point(42, 665);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(459, 26);
            this.label4.TabIndex = 110;
            this.label4.Text = "4. Upload a image as proof (Maximum of 5MB).";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Animated = true;
            this.SubmitBtn.BackColor = System.Drawing.Color.Transparent;
            this.SubmitBtn.BorderRadius = 20;
            this.SubmitBtn.BorderThickness = 1;
            this.SubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.SubmitBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(444, 789);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(225, 45);
            this.SubmitBtn.TabIndex = 109;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseTransparentBackground = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // DiscardBtn
            // 
            this.DiscardBtn.Animated = true;
            this.DiscardBtn.BackColor = System.Drawing.Color.Transparent;
            this.DiscardBtn.BorderRadius = 20;
            this.DiscardBtn.BorderThickness = 1;
            this.DiscardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DiscardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DiscardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DiscardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DiscardBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.DiscardBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.DiscardBtn.ForeColor = System.Drawing.Color.White;
            this.DiscardBtn.Location = new System.Drawing.Point(47, 789);
            this.DiscardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DiscardBtn.Name = "DiscardBtn";
            this.DiscardBtn.Size = new System.Drawing.Size(225, 45);
            this.DiscardBtn.TabIndex = 108;
            this.DiscardBtn.Text = "Discard";
            this.DiscardBtn.UseTransparentBackground = true;
            this.DiscardBtn.Click += new System.EventHandler(this.DiscardBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.label2.Location = new System.Drawing.Point(42, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 26);
            this.label2.TabIndex = 103;
            this.label2.Text = "1. What kind of bug are you experiencing?";
            // 
            // ReceptionistCheckbox
            // 
            this.ReceptionistCheckbox.AutoSize = true;
            this.ReceptionistCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReceptionistCheckbox.CheckedState.BorderRadius = 0;
            this.ReceptionistCheckbox.CheckedState.BorderThickness = 0;
            this.ReceptionistCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReceptionistCheckbox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.ReceptionistCheckbox.Location = new System.Drawing.Point(189, 612);
            this.ReceptionistCheckbox.Name = "ReceptionistCheckbox";
            this.ReceptionistCheckbox.Size = new System.Drawing.Size(231, 30);
            this.ReceptionistCheckbox.TabIndex = 107;
            this.ReceptionistCheckbox.Text = "Receptionist Account";
            this.ReceptionistCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ReceptionistCheckbox.UncheckedState.BorderRadius = 0;
            this.ReceptionistCheckbox.UncheckedState.BorderThickness = 0;
            this.ReceptionistCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ReceptionistCheckbox.CheckedChanged += new System.EventHandler(this.ReceptionistCheckbox_CheckedChanged);
            // 
            // EssayBox
            // 
            this.EssayBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.EssayBox.Location = new System.Drawing.Point(69, 159);
            this.EssayBox.Name = "EssayBox";
            this.EssayBox.Size = new System.Drawing.Size(600, 333);
            this.EssayBox.TabIndex = 100;
            this.EssayBox.Text = "";
            // 
            // ManagerCheckbox
            // 
            this.ManagerCheckbox.AutoSize = true;
            this.ManagerCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ManagerCheckbox.CheckedState.BorderRadius = 0;
            this.ManagerCheckbox.CheckedState.BorderThickness = 0;
            this.ManagerCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ManagerCheckbox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.ManagerCheckbox.Location = new System.Drawing.Point(189, 576);
            this.ManagerCheckbox.Name = "ManagerCheckbox";
            this.ManagerCheckbox.Size = new System.Drawing.Size(197, 30);
            this.ManagerCheckbox.TabIndex = 106;
            this.ManagerCheckbox.Text = "Manager Account";
            this.ManagerCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ManagerCheckbox.UncheckedState.BorderRadius = 0;
            this.ManagerCheckbox.UncheckedState.BorderThickness = 0;
            this.ManagerCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ManagerCheckbox.CheckedChanged += new System.EventHandler(this.ManagerCheckbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.label1.Location = new System.Drawing.Point(42, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 26);
            this.label1.TabIndex = 101;
            this.label1.Text = "2. Bug Duplication Steps (Give at least 3):\r\n";
            // 
            // AdminCheckbox
            // 
            this.AdminCheckbox.AutoSize = true;
            this.AdminCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminCheckbox.CheckedState.BorderRadius = 0;
            this.AdminCheckbox.CheckedState.BorderThickness = 0;
            this.AdminCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminCheckbox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.AdminCheckbox.Location = new System.Drawing.Point(189, 540);
            this.AdminCheckbox.Name = "AdminCheckbox";
            this.AdminCheckbox.Size = new System.Drawing.Size(173, 30);
            this.AdminCheckbox.TabIndex = 105;
            this.AdminCheckbox.Text = "Admin Account";
            this.AdminCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AdminCheckbox.UncheckedState.BorderRadius = 0;
            this.AdminCheckbox.UncheckedState.BorderThickness = 0;
            this.AdminCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AdminCheckbox.CheckedChanged += new System.EventHandler(this.AdminCheckbox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.label3.Location = new System.Drawing.Point(42, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(504, 26);
            this.label3.TabIndex = 104;
            this.label3.Text = "3. Types of account/s affected. Check all that apply.\r\n";
            // 
            // NoneCheckbox
            // 
            this.NoneCheckbox.AutoSize = true;
            this.NoneCheckbox.Checked = true;
            this.NoneCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NoneCheckbox.CheckedState.BorderRadius = 0;
            this.NoneCheckbox.CheckedState.BorderThickness = 0;
            this.NoneCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NoneCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NoneCheckbox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.NoneCheckbox.Location = new System.Drawing.Point(69, 540);
            this.NoneCheckbox.Name = "NoneCheckbox";
            this.NoneCheckbox.Size = new System.Drawing.Size(77, 30);
            this.NoneCheckbox.TabIndex = 113;
            this.NoneCheckbox.Text = "None";
            this.NoneCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NoneCheckbox.UncheckedState.BorderRadius = 0;
            this.NoneCheckbox.UncheckedState.BorderThickness = 0;
            this.NoneCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NoneCheckbox.CheckedChanged += new System.EventHandler(this.NoneCheckbox_CheckedChanged);
            // 
            // TypeBox
            // 
            this.TypeBox.BackColor = System.Drawing.Color.Transparent;
            this.TypeBox.BorderColor = System.Drawing.Color.Black;
            this.TypeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TypeBox.DefaultText = "";
            this.TypeBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TypeBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TypeBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TypeBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TypeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.TypeBox.ForeColor = System.Drawing.Color.Black;
            this.TypeBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeBox.Location = new System.Drawing.Point(66, 77);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.PasswordChar = '\0';
            this.TypeBox.PlaceholderText = "";
            this.TypeBox.SelectedText = "";
            this.TypeBox.Size = new System.Drawing.Size(603, 38);
            this.TypeBox.TabIndex = 114;
            // 
            // Submission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.NoneCheckbox);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.DiscardBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReceptionistCheckbox);
            this.Controls.Add(this.EssayBox);
            this.Controls.Add(this.ManagerCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminCheckbox);
            this.Controls.Add(this.label3);
            this.Name = "Submission";
            this.Size = new System.Drawing.Size(710, 880);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox FileNameBox;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button SubmitBtn;
        public  Guna.UI2.WinForms.Guna2Button DiscardBtn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CheckBox ReceptionistCheckbox;
        private System.Windows.Forms.RichTextBox EssayBox;
        private Guna.UI2.WinForms.Guna2CheckBox ManagerCheckbox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox AdminCheckbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CheckBox NoneCheckbox;
        private Guna.UI2.WinForms.Guna2TextBox TypeBox;
    }
}
