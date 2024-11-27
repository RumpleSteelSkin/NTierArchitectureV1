using NTierArchitecture.Entities.Models;
using NTierArchitecture.UI.Tools;

namespace NTierArchitecture.UI.Forms
{
    public partial class EmployeeForm : BaseForm
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        #region GLOBALS
        private Employee? selectedEmployee;
        #endregion

        #region EVENTS
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            GetAllEntityToListBox();
        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Employee newEmployee = new()
                {
                    Name = txtName.Text,
                    SurName = txtSurname.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Phone = txtPhone.Text,
                    IsActive = cbPassiveActive.Checked
                };
                FP.EmployeeService?.Create(newEmployee);
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
                if (selectedEmployee != null)
                {
                    FP.EmployeeService?.Delete(selectedEmployee.ID);
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
                if (selectedEmployee != null)
                {
                    selectedEmployee.Name = txtName.Text;
                    selectedEmployee.SurName = txtSurname.Text;
                    selectedEmployee.Phone = txtPhone.Text;
                    selectedEmployee.City = txtCity.Text;
                    selectedEmployee.Country = txtCountry.Text;
                    selectedEmployee.IsActive = cbPassiveActive.Checked;
                    FP.EmployeeService?.Update(selectedEmployee);
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
                    selectedEmployee = (Employee?)lstList.SelectedItem;
                    if (selectedEmployee != null)
                    {
                        txtName.Text = selectedEmployee.Name;
                        txtSurname.Text = selectedEmployee.SurName;
                        txtCity.Text = selectedEmployee.City;
                        txtCountry.Text = selectedEmployee.Country;
                        txtPhone.Text = selectedEmployee.Phone;
                        cbPassiveActive.Checked = selectedEmployee.IsActive;
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
            FP.UpdateListBox(lstList, "ID", "FullName", FP.EmployeeService?.GetAll()!, LstList_SelectedIndexChanged!);
            FP.FormClear(this);
        }
        #endregion
    }
}
