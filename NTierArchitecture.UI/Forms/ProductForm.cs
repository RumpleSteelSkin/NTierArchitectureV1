using NTierArchitecture.Entities.Models;
using NTierArchitecture.UI.Tools;

namespace NTierArchitecture.UI.Forms
{
    public partial class ProductForm : BaseForm
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        #region GLOBALS
        private Product? selectedProduct;
        #endregion

        #region EVENTS
        private void ProductForm_Load(object sender, EventArgs e)
        {
            GetAllEntityToListBox();
            FP.UpdateComboBox(cmbCategory, "ID", "Name", FP.CategoryService?.GetAll()!);
            FP.UpdateComboBox(cmbSupplier, "ID", "Name", FP.SupplierService?.GetAll()!);
        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product newProduct = new()
                {
                    Name = txtName.Text,
                    UnitPrice = Convert.ToDouble(txtUnitPrice.Text),
                    UnitsInStock = Convert.ToInt32(txtUnitInStock.Text),
                    Discontinued = !chkContinued.Checked,
                    IsActive = chkPassive.Checked,
                    CategoryID = Guid.Parse(cmbCategory.SelectedValue?.ToString() ?? throw new Exception("Kategori Seçiniz.")),
                    SupplierID = Guid.Parse(cmbSupplier.SelectedValue?.ToString() ?? throw new Exception("Tedarikçi Seçiniz."))
                };
                FP.ProductService?.Create(newProduct);
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
                if (selectedProduct != null)
                {
                    FP.ProductService?.Delete(selectedProduct.ID);
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
                if (selectedProduct != null)
                {
                    selectedProduct.Name = txtName.Text;
                    selectedProduct.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
                    selectedProduct.UnitsInStock = Convert.ToInt32(txtUnitInStock.Text);
                    selectedProduct.Discontinued = !chkContinued.Checked;
                    selectedProduct.IsActive = chkPassive.Checked;
                    selectedProduct.CategoryID = Guid.Parse(cmbCategory.SelectedValue?.ToString() ?? throw new Exception("Kategori Seçiniz."));
                    selectedProduct.SupplierID = Guid.Parse(cmbSupplier.SelectedValue?.ToString() ?? throw new Exception("Tedarikçi Seçiniz."));
                    FP.ProductService?.Update(selectedProduct);
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
                    selectedProduct = (Product?)lstList.SelectedItem;
                    if (selectedProduct != null)
                    {
                        txtName.Text = selectedProduct.Name;
                        txtUnitPrice.Text = selectedProduct.UnitPrice.ToString();
                        txtUnitInStock.Text = selectedProduct.UnitsInStock.ToString();
                        chkContinued.Checked = !selectedProduct.Discontinued;
                        chkPassive.Checked = selectedProduct.IsActive;
                        cmbCategory.SelectedValue = selectedProduct.CategoryID;
                        cmbSupplier.SelectedValue = selectedProduct.SupplierID;
                    }
                }
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        private void ChkContinued_CheckedChanged(object sender, EventArgs e)
        {
            chkContinued.Text = chkContinued.Checked ? "DEVAM EDİYOR" : "DURDURULDU";
        }

        private void ChkPassive_CheckedChanged(object sender, EventArgs e)
        {
            chkPassive.Text = chkPassive.Checked ? "AKTİF" : "PASİF";
        }
        #endregion

        #region METHODS
        private void GetAllEntityToListBox()
        {
            FP.UpdateListBox(lstList, "ID", "Name", FP.ProductService?.GetAll()!, LstList_SelectedIndexChanged!);
            FP.FormClear(this);
        }
        #endregion
    }
}
