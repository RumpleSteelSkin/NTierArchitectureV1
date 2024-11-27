using FluentValidation.Results;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.UI.Tools;
namespace NTierArchitecture.UI.Forms
{
    public partial class OrderFormV2SaveOrderDialog : Form
    {

        public OrderFormV2SaveOrderDialog()
        {
            InitializeComponent();
        }
        #region GLOBALS
        public Order? OrderDialog { get; private set; }
        #endregion

        #region EVENTS
        private void OrderFormV2SaveOrderDialog_Load(object sender, EventArgs e)
        {
            FP.UpdateComboBox(cmbEmployee, "ID", "Name", FP.EmployeeService?.GetAll()!);
            FP.UpdateComboBox(cmbCustomer, "ID", "Name", FP.CustomerService?.GetAll()!);
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomer.SelectedItem != null && cmbEmployee.SelectedItem != null)
                {
                    Order o = new()
                    {
                        OrderDate = DateOnly.FromDateTime(dtOrderDate.Value),
                        Employee = (Employee?)cmbEmployee.SelectedItem,
                        Customer = (Customer?)cmbCustomer.SelectedItem,
                        CustomerID = ((Customer?)cmbCustomer.SelectedItem!).ID,
                        EmployeeID = ((Employee?)cmbEmployee.SelectedItem!).ID,
                        ShipCountry = txtCountry.Text,
                        ShipCity = txtCity.Text,
                        ShipAddress = txtAddress.Text
                    };
                    if (o != null)
                    {
                        ValidationResult result = new OrderValidator().Validate(o);
                        if (!result.IsValid)
                            MessageBox.Show(string.Join("\n", result.Errors));
                        OrderDialog = o;
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sipariş Bilgileri Boş!");
                    }
                }
                else
                {
                    MessageBox.Show("Müşteri ve Çalışan giriniz!");
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        #endregion
    }
}
