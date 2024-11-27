using NTierArchitecture.Entities.Models;
using NTierArchitecture.UI.Tools;

namespace NTierArchitecture.UI.Forms
{
    public partial class SupplierForm : BaseForm
    {
        public SupplierForm()
        {
            InitializeComponent();
        }
        #region GLOBALS
        private Supplier? selectedSupplier;
        #endregion

        #region EVENTS
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            GetAllEntityToListBox();
        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier newSupplier = new()
                {
                    Name = txtName.Text,
                    ContactTitle = txtContactTitle.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Phone = txtPhone.Text,
                    IsActive = cbPassiveActive.Checked
                };
                FP.SupplierService?.Create(newSupplier);
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
                if (selectedSupplier != null)
                {
                    FP.SupplierService?.Delete(selectedSupplier.ID);
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
                if (selectedSupplier != null)
                {
                    selectedSupplier.Name = txtName.Text;
                    selectedSupplier.ContactTitle = txtContactTitle.Text;
                    selectedSupplier.Phone = txtPhone.Text;
                    selectedSupplier.City = txtCity.Text;
                    selectedSupplier.Country = txtCountry.Text;
                    selectedSupplier.IsActive = cbPassiveActive.Checked;
                    FP.SupplierService?.Update(selectedSupplier);
                    GetAllEntityToListBox();
                }
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }

        private void LstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstList.SelectedIndex != -1)
                {
                    selectedSupplier = (Supplier?)lstList.SelectedItem;
                    if (selectedSupplier != null)
                    {
                        txtName.Text = selectedSupplier.Name;
                        txtContactTitle.Text = selectedSupplier.ContactTitle;
                        txtCity.Text = selectedSupplier.City;
                        txtCountry.Text = selectedSupplier.Country;
                        txtPhone.Text = selectedSupplier.Phone;
                        cbPassiveActive.Checked = selectedSupplier.IsActive;
                    }
                }
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        private void CbPassiveActive_CheckedChanged_1(object sender, EventArgs e)
        {
            cbPassiveActive.Text = cbPassiveActive.Checked ? "AKTİF" : "PASİF";
        }
        #endregion

        #region METHODS
        private void GetAllEntityToListBox()
        {
            FP.UpdateListBox(lstList, "ID", "Name", FP.SupplierService?.GetAll()!, LstList_SelectedIndexChanged!);
            FP.FormClear(this);
        }
        #endregion
    }
}
