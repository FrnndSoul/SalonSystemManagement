using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
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

            //For the services
            ServiceNameTxtB.KeyPress += keypressNumbersRestrictions.KeyPress;
            ServiceAmountTxtb.KeyPress += keypressLettersRestrictions.KeyPress;

            //For the service type
            ServiceTypeTxtB.KeyPress += keypressNumbersRestrictions.KeyPress;
        }

        private async void ServiceType_ServicePage_Load(object sender, EventArgs e)
        {
            await serviceType.ServiceTypeInfoDGV();
            await salonServices.PopulateServiceType();
            await salonServices.GetSalonServicesAsync();
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

        private async void AddServiceTypeBtn_Click(object sender, EventArgs e)
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
                await serviceType.AddServiceType(serviceTypeName);
            }
        }

        private async void UpdateServiceTBtn_Click(object sender, EventArgs e)
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
                await serviceType.UpdateServiceType(sID);
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

        private async void AddServiceBtn_Click(object sender, EventArgs e)
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
                await salonServices.AddSalonServices();
                salonServices.ClearServices();

            }
        }

        private async void UpdateServBtn_Click(object sender, EventArgs e)
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
                await salonServices.UpdateSalonServices(servarID);

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

        private async void InventoryItemsComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chosenItem = InventoryItemsComB.SelectedItem.ToString();
            if (chosenItem == null)
            {
                ItemIDTxtB.Text = string.Empty;
            }
            else
            {
                ItemIDTxtB.Text = Convert.ToString(await salonServices.GetItemId(chosenItem));
            }
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            string chosenItem = InventoryItemsComB.SelectedItem.ToString();
            int itemID = Convert.ToInt32(ItemIDTxtB.Text);

            BindedServiceItemDGV.Rows.Add(chosenItem, itemID, "-", 1, "+", "X");
        }

        private void BindedServiceItemDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < BindedServiceItemDGV.Rows.Count)
            {
                if(e.ColumnIndex == BindedServiceItemDGV.Columns["DecrementCol"].Index)
                {
                    int currentQty = int.Parse(BindedServiceItemDGV.Rows[e.RowIndex].Cells["ProdQuantityCol"].Value.ToString());
                    if(currentQty > 1)
                    {
                        currentQty--;
                        BindedServiceItemDGV.Rows[e.RowIndex].Cells[3].Value = currentQty;
                    }
                }
                else if (e.ColumnIndex == BindedServiceItemDGV.Columns["IncrementCol"].Index)
                {
                    int currentQty = int.Parse(BindedServiceItemDGV.Rows[e.RowIndex].Cells["ProdQuantityCol"].Value.ToString());
                    currentQty++;
                    BindedServiceItemDGV.Rows[e.RowIndex].Cells[3].Value = currentQty;
                }
                else if(e.ColumnIndex == BindedServiceItemDGV.Columns["RemoveCol"].Index)
                {
                    BindedServiceItemDGV.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
