using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls
{
    public partial class ServiceType_ServicePage : UserControl
    {
        public static ServiceType_ServicePage servicePageInstance;
        private ServiceTypes serviceType = new ServiceTypes();
        private SalonServices salonServices = new SalonServices();
        public KeypressLettersRestrictions keypressLettersRestrictions = new KeypressLettersRestrictions();
        public KeypressNumbersRestrictions keypressNumbersRestrictions = new KeypressNumbersRestrictions();

        public ServiceType_ServicePage()
        {
            InitializeComponent();
            servicePageInstance = this;
            ServiceTypePanel.BringToFront();

            serviceType.ServiceTypeInfoDGV();
            salonServices.PopulateServiceType();
            salonServices.GetSalonServices();

            //For the services
            ServiceNameTxtB.KeyPress += keypressNumbersRestrictions.KeyPress;
            ServiceAmountTxtb.KeyPress += keypressLettersRestrictions.KeyPress;

            //For the service type
            ServiceTypeTxtB.KeyPress += keypressNumbersRestrictions.KeyPress;


        }

        private void SetButtonProperties(Guna.UI2.WinForms.Guna2Button button, Color fillColor, Color foreColor, Image image)
        {
            button.FillColor = fillColor;
            button.ForeColor = foreColor;
            button.Image = image;
        }

        private void ServiceTypeBtn_Click(object sender, EventArgs e)
        {
            SetButtonProperties(ServiceTypeBtn, Color.FromArgb(52, 42, 83), Color.White, Properties.Resources.service_type_icon__2_);
            ServiceTypeBtn.BringToFront();
            ServiceTypePanel.BringToFront();
            ServiceTypePanel.Visible = true;

            SetButtonProperties(ServiceBtn, Color.FromArgb(255, 228, 242), Color.Black, Properties.Resources.service_black_icon);
            ServiceBtn.SendToBack();
            ServicePanel.Visible = false;
        }

        private void ServiceBtn_Click(object sender, EventArgs e)
        {
            salonServices.GetItemInInventory();
            SetButtonProperties(ServiceBtn, Color.FromArgb(52, 42, 83), Color.White, Properties.Resources.service_icon);
            ServiceBtn.BringToFront();
            ServicePanel.Visible = true;

            SetButtonProperties(ServiceTypeBtn, Color.FromArgb(255, 228, 242), Color.Black, Properties.Resources.service_type_black_icon);
            ServiceTypeBtn.SendToBack();
            ServiceTypePanel.Visible = false;
        }


        //For service type

        private void AddImageServiceTypeBtn_Click(object sender, EventArgs e)
        {
            serviceType.AddServiceTypeImage();

        }
        private void AddServiceTypeBtn_Click(object sender, EventArgs e)
        {
            if (ServiceTypeTxtB.Text is null || ServiceTypePicB is null)
            {
                MessageBox.Show("Please fill all the required information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string serviceTypeName = ServiceTypeTxtB.Text;
                serviceType.AddServiceType(serviceTypeName);
            }
        }

        private void UpdateServiceTBtn_Click(object sender, EventArgs e)
        {
            if (ServiceTypeTxtB.Text is null || ServiceTypePicB is null)
            {
                MessageBox.Show("Please fill all the required information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int sID = Convert.ToInt32(ServiceTypeDGV.SelectedRows[0].Cells["ServiceID"].Value);
                serviceType.UpdateServiceType(sID);
            }
        }

        private void EditServiceTBtn_Click(object sender, EventArgs e)
        {
            serviceType.EditServiceTypes();

        }

        private void CancelEditBtn_Click(object sender, EventArgs e)
        {
            serviceType.ClearServiceTypes();
            serviceType.HideButton(true, true, false, false);
        }


        //For services
        private void AddServiceImageBtn_Click(object sender, EventArgs e)
        {
            salonServices.AddServiceImage();
        }

        private void AddServiceBtn_Click(object sender, EventArgs e)
        {
            if (ServiceNameTxtB.Text is null || ServiceAmountTxtb.Text is null ||
                AddSalonServices.SelectedItem is null || InventoryItemsComB.SelectedItem is null
                || ServiceImagePicB.Image is null)
            {
                MessageBox.Show("Please fill all the required information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string serviceTypeName = AddSalonServices.SelectedItem.ToString();
                salonServices.GetServiceTypeID(serviceTypeName);
                salonServices.AddSalonServices();
            }
        }

        private void UpdateServBtn_Click(object sender, EventArgs e)
        {
            if (ServiceNameTxtB.Text is null || ServiceAmountTxtb.Text is null ||
               AddSalonServices.SelectedItem is null || InventoryItemsComB.SelectedItem is null
               || ServiceImagePicB.Image is null)
            {
                MessageBox.Show("Please fill all the required information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int servarID = Convert.ToInt32(SalonServicesDGV.SelectedRows[0].Cells["ServiceVariationID"].Value);
                salonServices.UpdateSalonServices(servarID);

            }
        }

        private void EditServBtn_Click(object sender, EventArgs e)
        {
            salonServices.EditSalonServices();
        }

        private void CancelEditServiceBtn_Click(object sender, EventArgs e)
        {
            salonServices.ClearServices();
            salonServices.HideButton(true, true, false, false);

        }
    }
}
