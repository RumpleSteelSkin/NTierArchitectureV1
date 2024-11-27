using NTierArchitecture.Entities.Models;
using NTierArchitecture.UI.Tools;
using System.Data;

namespace NTierArchitecture.UI.Forms
{
    public partial class OrderFormV2 : Form
    {
        public OrderFormV2()
        {
            InitializeComponent();
        }
        #region GLOBALS
        private readonly Card card = new();
        #endregion

        #region EVENTS
        private void OrderFormV2_Load(object sender, EventArgs e)
        {
            DataToDGW(true);
            GetSearchedProduct();
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            GetSearchedProduct();
        }
        private void LstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstProductList.SelectedIndex != -1 && lstProductList.SelectedValue != null)
                    txtUnitPrice.Text = FP.ProductService?.GetById(Guid.TryParse(lstProductList.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir ürün seçiniz."))?.UnitPrice.ToString();
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void BtnAddBasket_Click(object sender, EventArgs e)
        {
            try
            {
                CardItem item = new()
                {
                    ProductID = ((Product?)lstProductList.SelectedItem!).ID,
                    ProductName = ((Product?)lstProductList.SelectedItem!).Name,
                    Quantity = Convert.ToInt32(nmrQuantity.Value),
                    UnitPrice = ((Product?)lstProductList.SelectedItem!).UnitPrice
                };
                card.AddItem(item);
                GetBasket();
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstBasket.SelectedItem != null)
                {
                    card.DeleteItem(((CardItem?)lstBasket.SelectedItem!).CardItemID);
                    GetBasket();
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void BtnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (card.CardItems.Count > 0)
                {
                    using OrderFormV2SaveOrderDialog saveOrderDialog = new();
                    if (saveOrderDialog.ShowDialog() == DialogResult.Yes)
                    {
                        if (saveOrderDialog.OrderDialog != null)
                        {
                            FP.OrderService?.Create(saveOrderDialog.OrderDialog);
                            foreach (CardItem item in lstBasket.Items)
                            {
                                OrderDetail oD = new()
                                {
                                    Order = saveOrderDialog.OrderDialog,
                                    ProductID = item.ProductID,
                                    OrderID = saveOrderDialog.OrderDialog.ID,
                                    Quantity = item.Quantity,
                                    UnitPrice = item.UnitPrice
                                };
                                FP.OrderDetailService?.Create(oD);
                            }
                            DataToDGW(true);
                            MessageBox.Show("Sipariş Kayıt Başarılı!", "Onaylandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CurrentBasketEviscerate();
                        }
                        else
                        {
                            MessageBox.Show("Beklenmeyen Hata!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("İşlem İptal Edildi.");
                    }
                }
                else
                {
                    MessageBox.Show("Sepette herhangi bir ürün bulunmamaktadır.");
                }
            }
            catch (Exception ex)
            {
                FP.ShowError(ex);
            }
        }
        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Mevcut siparişi iptal edip, yeni sipariş oluşturmak istediğinize emin misiniz?", "Yeni Sipariş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                CurrentBasketEviscerate();
        }
        private void DgwOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataToDGW();
        }
        #endregion

        #region METHODS
        private void GetBasket()
        {
            FP.UpdateListBox(lstBasket, "ID", null!, card.CardItems);
            lblBasketCount.Text = $"Ürün Adedi: {card.CardItems.Count}";
            lblBasketTotal.Text = $"Sepet Toplamı: {card.CardItems.Sum(x => x.UnitPrice)} TL";
        }
        private void GetSearchedProduct()
        {
            if (txtSearch.TextLength > 2)
                FP.UpdateListBox(lstProductList, "ID", "Name", FP.ProductService?.GetAll()?.Where(x => x.Name!.Contains(txtSearch.Text, StringComparison.CurrentCultureIgnoreCase)).ToList()!);
            else if (txtSearch.TextLength == 0)
                FP.UpdateListBox(lstProductList, "ID", "Name", FP.ProductService?.GetAll()!);
        }
        private void CurrentBasketEviscerate()
        {
            card.CardItems.Clear();
            lstBasket.DataSource = null;
            GetBasket();
        }
        private void DataToDGW(bool allData = false)
        {
            if (allData)
                dgwOrderList.DataSource = FP.OrderService?.GetAll()?.Select(OL => new { OL.ID, OL.OrderDate, OL.ShipCountry, OL.ShipCity }).ToList();
            if (dgwOrderList.SelectedRows[0].DataBoundItem != null)
            {
                dynamic selectedRow = dgwOrderList.SelectedRows[0].DataBoundItem;
                dgwOrderDetailList.DataSource = FP.OrderDetailService?.GetAll()?.Where(x => x.OrderID == selectedRow.ID).Select(ODL => new { ProductName = ODL.Product?.Name, ODL.Quantity, ODL.UnitPrice }).ToList();
                lblTotal.Text = $"Fatura Toplam Tutarı :  {FP.OrderDetailService?.GetAll()?.Where(x => x.OrderID == selectedRow.ID).Sum(x => x.UnitPrice)} %20KDVli Fiyat: {FP.OrderDetailService?.GetAll()?.Where(x => x.OrderID == selectedRow.ID).Sum(x => x.UnitPrice) * 1.20}";
            }
        }
        #endregion
    }
}
