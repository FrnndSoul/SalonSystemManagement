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

namespace TriforceSalon.UserControls.Service_Controls
{
    public partial class ServiceVariationControl : UserControl
    {
        ManagerPage manager = new ManagerPage();
        private SalonServices salonServices = new SalonServices();
        public static ServiceVariationControl serviceVariationInstance;
        ServiceTransitions serviceTransitions = new ServiceTransitions();
        public KeypressLettersRestrictions keypressLettersRestrictions = new KeypressLettersRestrictions();
        public KeypressNumbersRestrictions keypressNumbersRestrictions = new KeypressNumbersRestrictions();

        public ServiceVariationControl()
        {
            InitializeComponent();
            serviceVariationInstance = this;
            ServiceNameTxtB.KeyPress += keypressNumbersRestrictions.KeyPress;
            ServiceAmountTxtb.KeyPress += keypressLettersRestrictions.KeyPress;

        }
        private async void ServiceVariationControl_Load(object sender, EventArgs e)
        {
            await salonServices.PopulateServiceType(ServiceFilterComB);
            await salonServices.PopulateServiceTypeForInsert();

            if (ServiceType_ServicePage.isFiltered == false)
            {
                await salonServices.GetSalonServicesAsync(SalonServicesDGV);
            }
            else if (ServiceType_ServicePage.isFiltered == true)
            {
                await serviceTransitions.GetFilteredServices(SalonServicesDGV, ServiceSubTypeControl.categoryName);
            }
        }

        private void AddServiceImageBtn_Click(object sender, EventArgs e)
        {
            salonServices.AddServiceImage();
        }

        private async void AddServiceBtn_Click(object sender, EventArgs e)
        {
            AddServiceBtn.Enabled = false;

            if (ServiceNameTxtB.Text is null || ServiceAmountTxtb.Text is null ||
                AddSalonServices.SelectedItem is null || ServiceImagePicB.Image is null)
            {
                MessageBox.Show("Please fill all the required information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddServiceBtn.Enabled = true;
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string serviceTypeName = AddSalonServices.SelectedItem.ToString();
                salonServices.GetServiceTypeID(serviceTypeName);
                await salonServices.AddSalonServices(SalonServicesDGV);
                salonServices.ClearServices();
            }
            AddServiceBtn.Enabled = true;

        }

        private void EditServBtn_Click(object sender, EventArgs e)
        {
            manager.DisableButtons(false);
            salonServices.EditSalonServices();
        }

        private async void UpdateServBtn_Click(object sender, EventArgs e)
        {
            UpdateServBtn.Enabled = false;

            if (ServiceNameTxtB.Text is null || ServiceAmountTxtb.Text is null ||
               AddSalonServices.SelectedItem is null || ServiceImagePicB.Image is null)
            {
                MessageBox.Show("Please fill all the required information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int servarID = Convert.ToInt32(SalonServicesDGV.SelectedRows[0].Cells["ServiceVariationID"].Value);
                await salonServices.UpdateSalonServices(servarID, SalonServicesDGV);
                MessageBox.Show("Service has been updated", "Service Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                salonServices.ClearServices();
                manager.DisableButtons(true);
            }

            UpdateServBtn.Enabled = true;

        }

        private void CancelEditServiceBtn_Click(object sender, EventArgs e)
        {
            salonServices.ClearServices();
            salonServices.HideButton(true, true, false, false);
            manager.DisableButtons(true);
        }

        private async void ServiceFilterComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = ServiceFilterComB.SelectedItem.ToString();
            await salonServices.FilterServices(selectedType, SalonServicesDGV);

        }

        private async void SearchServiceBtn_Click(object sender, EventArgs e)
        {
            string name = SearchServiceTxtB.Text;
            await salonServices.SearchService(name, SalonServicesDGV);
        }

        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            await salonServices.GetSalonServicesAsync(SalonServicesDGV);
        }
    }
}
