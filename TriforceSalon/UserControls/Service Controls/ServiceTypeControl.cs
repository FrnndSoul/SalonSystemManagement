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
    public partial class ServiceTypeControl : UserControl
    {
        ManagerPage manager = new ManagerPage();
        private ServiceTypes serviceType = new ServiceTypes();
        public static ServiceTypeControl serviceTypeInstance;
        public KeypressNumbersRestrictions keypressNumbersRestrictions = new KeypressNumbersRestrictions();

        public ServiceTypeControl()
        {
            InitializeComponent();
            serviceTypeInstance = this;
            ServiceTypeTxtB.KeyPress += keypressNumbersRestrictions.KeyPress;
        }

        private async void ServiceTypeControl_Load(object sender, EventArgs e)
        {
            await serviceType.ServiceTypeInfoDGV(ServiceTypeDGV);
        }

        private void AddImageServiceTypeBtn_Click(object sender, EventArgs e)
        {
            serviceType.AddServiceTypeImage();
        }

        private async void AddServiceTypeBtn_Click(object sender, EventArgs e)
        {
            AddServiceTypeBtn.Enabled = false;

            if (ServiceTypeTxtB.Text is null || ServiceTypePicB is null)
            {
                MessageBox.Show("Please fill all the required information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddServiceTypeBtn.Enabled = true;
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string serviceTypeName = ServiceTypeTxtB.Text;
                await serviceType.AddServiceType(serviceTypeName);
            }
            AddServiceTypeBtn.Enabled = true;

        }

        private void EditServiceTBtn_Click(object sender, EventArgs e)
        {
            manager.DisableButtons(false);

            serviceType.EditServiceTypes();

        }

        private async void UpdateServiceTBtn_Click(object sender, EventArgs e)
        {
            UpdateServiceTBtn.Enabled = false;

            if (ServiceTypeTxtB.Text is null || ServiceTypePicB is null)
            {
                MessageBox.Show("Please fill all the required information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int sID = Convert.ToInt32(ServiceTypeDGV.SelectedRows[0].Cells["ServiceID"].Value);
                await serviceType.UpdateServiceType(sID);
                manager.DisableButtons(true);

            }
            UpdateServiceTBtn.Enabled = false;

        }

        private void CancelEditBtn_Click(object sender, EventArgs e)
        {
            serviceType.ClearServiceTypes();
            serviceType.HideButton(true, true, false, false);
            manager.DisableButtons(true);
        }

        private async void SearchServiceBtn_Click(object sender, EventArgs e)
        {
            string type = SearchServiceTypeTxtB.Text;
            await serviceType.SearechServiceType(ServiceTypeDGV, type);
        }

        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            await serviceType.ServiceTypeInfoDGV(ServiceTypeDGV);
        }
    }
}
