using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls.Admin_Controls.Ticketing
{
    public partial class Submission : UserControl
    {
        string type;
        string essay;
        string accounts;
        byte[] PhotoByte;

        public Submission()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            type = TypeBox.Text;
            essay = EssayBox.Text;
            accounts = string.Empty;

            if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(essay) || PhotoByte == null)
            {
                MessageBox.Show("Please fill in all fields.", "Warning.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (NoneCheckbox.Checked)
            {
                accounts = "None";
            }
            else
            {
                if (AdminCheckbox.Checked)
                {
                    accounts += "Admin";
                }
                if (ManagerCheckbox.Checked)
                {
                    accounts += "\nManager";
                }
                if (ReceptionistCheckbox.Checked)
                {
                    accounts += "\nReceptionist";
                }
            }
            AdminTicketing.UploadData(type, accounts, essay, PhotoByte);
            DiscardBtn_Click(null, null);
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;

                FileInfo fileInfo = new FileInfo(selectedFile);
                long fileSizeInBytes = fileInfo.Length;
                long fileSizeInMegabytes = fileSizeInBytes / (1024 * 1024);

                if (fileSizeInMegabytes > 5)
                {
                    MessageBox.Show("File size exceeds the limit of 5MB. Please select a smaller file.", "File Size Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Image image = Image.FromFile(selectedFile);
                string fileName = Path.GetFileName(selectedFile);
                FileNameBox.Text = fileName;

                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    PhotoByte = ms.ToArray();
                }
            }
        }

        public void DiscardBtn_Click(object sender, EventArgs e)
        {
            TypeBox.SelectedIndex = -1;
            EssayBox.Text = string.Empty;
            NoneCheckbox.Checked = true;
            FileNameBox.Text = string.Empty;
        }

        private void NoneCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (NoneCheckbox.Checked)
            {
                AdminCheckbox.Checked = false;
                ManagerCheckbox.Checked = false;
                ReceptionistCheckbox.Checked = false;
            } else
            {
                if (AdminCheckbox.Checked || ManagerCheckbox.Checked || ReceptionistCheckbox.Checked)
                {
                    NoneCheckbox.Checked = false;
                } else
                {
                    NoneCheckbox.Checked = true;
                    NoneCheckbox.Checked = true;
                }
            }
        }

        private void AdminCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdminCheckbox.Checked)
            {
                NoneCheckbox.Checked = false;
            }
        }

        private void ManagerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ManagerCheckbox.Checked)
            {
                NoneCheckbox.Checked = false;
            }
        }

        private void ReceptionistCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ReceptionistCheckbox.Checked)
            {
                NoneCheckbox.Checked = false;
            }
        }
    }
}
