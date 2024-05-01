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
    public partial class ServiceSubTypeControl : UserControl
    {
        public static ServiceSubTypeControl categoryInstance;
        ServiceSubType categoryMethods = new ServiceSubType();
        public ServiceSubTypeControl()
        {
            InitializeComponent();
            categoryInstance = this;
        }

        private void AddImageCategoryBtn_Click(object sender, EventArgs e)
        {
            categoryMethods.AddServiceTypeImage();
        }

        private async void ServiceSubTypeControl_Load(object sender, EventArgs e)
        {
            await categoryMethods.GetAllServiceType(ServiceTypeComB);
            await categoryMethods.GetAllCategory(CategoryDGV);
        }

        private async void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategoryBtn.Enabled = false;

            if (ServiceCategoryTxtB.Text is null || CategoryPicB is null 
                || ServiceTypeComB.SelectedItem is null || ServiceTypeComB.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the required information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddCategoryBtn.Enabled = true;
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await categoryMethods.GetServiceTypeID(ServiceTypeComB.Text);
                string categoryName = ServiceCategoryTxtB.Text;
                await categoryMethods.AddCategory(categoryName);
            }

            AddCategoryBtn.Enabled = false;
        }

        private async void UpdateCategoryBtn_Click(object sender, EventArgs e)
        {
            UpdateCategoryBtn.Enabled = false;

            if (ServiceCategoryTxtB.Text is null || CategoryPicB is null ||
               ServiceTypeComB.SelectedItem is null || ServiceTypeComB.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the required information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                int categoryID = Convert.ToInt32(CategoryDGV.SelectedRows[0].Cells["CategoryIDCol"].Value);
                string serviceType = ServiceSubTypeControl.categoryInstance.ServiceTypeComB.SelectedItem.ToString();
                string categoryName = ServiceCategoryTxtB.Text;
                int serviceTypeID = await categoryMethods.GetServiceTypeID(serviceType);

                await categoryMethods.UpdateCategory(categoryID, serviceTypeID, categoryName, CategoryDGV);

            }
        }

        private async void EditCategoryBtn_Click(object sender, EventArgs e)
        {
            await categoryMethods.EditCategory(CategoryDGV, ServiceCategoryTxtB, ServiceTypeComB);
        }

        private void CancelEditBtn_Click(object sender, EventArgs e)
        {
            categoryMethods.ClearCategory();
            categoryMethods.HideCategoryButtons(true, true, false, false);
        }

        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            await categoryMethods.GetAllCategory(CategoryDGV);
            categoryMethods.ClearCategory();
        }

        private async void SearchCategoryBtn_Click(object sender, EventArgs e)
        {
            string search = SearchCategoryTxtB.Text;
            await categoryMethods.SearchCategory(search, CategoryDGV);

        }
    }
}
