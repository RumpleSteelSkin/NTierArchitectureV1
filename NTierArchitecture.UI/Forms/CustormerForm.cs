using NTierArchitecture.Entities.Models;
using NTierArchitecture.UI.Tools;

namespace NTierArchitecture.UI.Forms
{
    public partial class CustormerForm : BaseForm
    {
        public CustormerForm()
        {
            InitializeComponent();
        }
        #region GLOBALS
        private Customer? selectedCustomer;
        #endregion

        #region EVENTS
        private void CustormerForm_Load(object sender, EventArgs e)
        {
            GetAllEntityToListBox();
        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer newCustomer = new()
                {
                    Name = txtName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Phone = txtPhone.Text,
                    IsActive = cbPassiveActive.Checked
                };
                FP.CustomerService?.Create(newCustomer);
                GetAllEntityToListBox();
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCustomer != null)
                {
                    FP.CustomerService?.Delete(selectedCustomer.ID);
                    GetAllEntityToListBox();
                }
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        protected override void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                GetAllEntityToListBox();
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCustomer != null)
                {
                    selectedCustomer.Name = txtName.Text;
                    selectedCustomer.Phone = txtPhone.Text;
                    selectedCustomer.City = txtCity.Text;
                    selectedCustomer.Country = txtCountry.Text;
                    selectedCustomer.IsActive = cbPassiveActive.Checked;
                    FP.CustomerService?.Update(selectedCustomer);
                    GetAllEntityToListBox();
                }
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        private void CbPassiveActive_CheckedChanged(object sender, EventArgs e)
        {
            cbPassiveActive.Text = cbPassiveActive.Checked ? "AKTİF" : "PASİF";
        }
        private void LstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstList.SelectedIndex != -1)
                {
                    selectedCustomer = (Customer?)lstList.SelectedItem;
                    if (selectedCustomer!=null)
                    {
                        txtName.Text = selectedCustomer.Name;
                        txtCity.Text = selectedCustomer.City;
                        txtCountry.Text = selectedCustomer.Country;
                        txtPhone.Text = selectedCustomer.Phone;
                        cbPassiveActive.Checked = selectedCustomer.IsActive;
                    }
                }
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        #endregion

        #region METHODS
        private void GetAllEntityToListBox()
        {
            FP.UpdateListBox(lstList, "ID", "Name", FP.CustomerService?.GetAll()!, LstList_SelectedIndexChanged!);
            FP.FormClear(this);
        }
        #endregion
    }
}
