using FluentValidation.Results;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.UI.Tools;

namespace NTierArchitecture.UI.Forms
{
    public partial class OrderForm : BaseForm
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        #region GLOBALS
        private Order? selectedOrder;
        private OrderDetail? selectedOrderDetail;
        private readonly List<OrderDetail>? lstFirstOD = [], lstNewOD = [];
        private readonly OrderDetailRepository odRepo = new(FP.ApplicationDB!); //Silinme işlemi farklı yeterlilikler gerektiriyor.
        #endregion

        #region EVENTS
        private void OrderForm_Load(object sender, EventArgs e)
        {
            GetAllEntityToListBox();
            OrderLockdown(true);
            FP.UpdateComboBox(cmbCustomer, "ID", "Name", FP.CustomerService!.GetAll()!.Where(x => x.IsActive == true).ToList());
            FP.UpdateComboBox(cmbEmployee, "ID", "Name", FP.EmployeeService!.GetAll()!.Where(x => x.IsActive == true).ToList());
        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newOrder = new Order
                {
                    OrderDate = DateOnly.FromDateTime(dtOrderDate.Value),
                    ShipAddress = txtAddress.Text,
                    ShipCity = txtCity.Text,
                    ShipCountry = txtCountry.Text,
                    IsActive = chkPassive.Checked,
                    EmployeeID = Guid.TryParse(cmbEmployee.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir çalışan seçiniz."),
                    CustomerID = Guid.TryParse(cmbCustomer.SelectedValue?.ToString(), out var customerId) ? customerId : throw new Exception("Geçerli bir müşteri seçiniz."),
                    Customer = (Customer?)cmbCustomer.SelectedItem,
                    Employee = (Employee?)cmbEmployee.SelectedItem
                };
                FP.OrderService?.Create(newOrder);
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
                if (selectedOrder != null)
                {
                    FP.OrderService?.Delete(selectedOrder.ID);
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
                if (selectedOrder != null)
                {
                    selectedOrder.OrderDate = DateOnly.FromDateTime(dtOrderDate.Value);
                    selectedOrder.ShipAddress = txtAddress.Text;
                    selectedOrder.ShipCity = txtCity.Text;
                    selectedOrder.ShipCountry = txtCountry.Text;
                    selectedOrder.IsActive = chkPassive.Checked;
                    selectedOrder.EmployeeID = Guid.Parse(cmbEmployee.SelectedValue?.ToString() ?? throw new Exception("Çalışan Seçiniz."));
                    selectedOrder.CustomerID = Guid.Parse(cmbCustomer.SelectedValue?.ToString() ?? throw new Exception("Müşteri Seçiniz."));
                    selectedOrder.Customer = (Customer?)cmbCustomer.SelectedItem;
                    selectedOrder.Employee = (Employee?)cmbEmployee.SelectedItem;
                    FP.OrderService?.Update(selectedOrder);
                    GetAllEntityToListBox();
                }
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        private void LstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstOrder.SelectedIndex != -1)
                {
                    selectedOrder = (Order?)lstOrder.SelectedItem;
                    if (selectedOrder != null)
                    {
                        dtOrderDate.Value = selectedOrder.OrderDate.ToDateTime(new TimeOnly(0, 0));
                        txtAddress.Text = selectedOrder.ShipAddress;
                        txtCity.Text = selectedOrder.ShipCity;
                        txtCountry.Text = selectedOrder.ShipCountry;
                        cmbCustomer.SelectedValue = selectedOrder.CustomerID;
                        cmbEmployee.SelectedValue = selectedOrder.EmployeeID;
                        chkPassive.Checked = selectedOrder.IsActive;
                    }
                }
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        private void ChkPassive_CheckedChanged(object sender, EventArgs e)
        {
            chkPassive.Text = chkPassive.Checked ? "AKTİF" : "PASİF";
        }
        private void LstOrder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstOrder.SelectedIndex != -1 && lstOrder.SelectedItem != null)
            {
                Order order = (Order)lstOrder.SelectedItem;
                DialogResult dr = MessageBox.Show($"Sayın {order.Employee?.FullName} çalışanımız\n{order.Customer?.Name} isimli müşteriye sipariş başlatmak istediğinize emin misiniz?", "Sipariş Başlatma.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    lstNewOD?.Clear();
                    lstFirstOD?.Clear();
                    lblSelectedOrder.Text = $"Seçili Sipariş: {order.Customer?.Name} - {order.OrderDate}";
                    OrderLockdown(false);
                    FP.UpdateComboBox(cmbProduct, "ID", "Name", FP.ProductService?.GetAll()!.Where(x => x.IsActive == true && x.Discontinued == false).ToList()!);
                    foreach (OrderDetail item in FP.OrderDetailService!.GetAll()!)
                    {
                        if (item.OrderID == selectedOrder?.ID)
                        {
                            lstOrderDetail.Items.Add(item);
                            lstNewOD?.Add(item);
                            var oldItemButNotRefference = new OrderDetail
                            {
                                ID = item.ID,
                                CreatedDate = item.CreatedDate,
                                IsActive = item.IsActive,
                                Order = item.Order,
                                OrderID = item.OrderID,
                                Product = item.Product,
                                ProductID = item.ProductID,
                                Quantity = item.Quantity,
                                UnitPrice = item.UnitPrice
                            };
                            lstFirstOD?.Add(oldItemButNotRefference);
                        }
                    }
                    UpdateOrderDetailMessage();
                }
            }
        }
        private void LstOrderDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstOrderDetail.SelectedIndex != -1)
                {
                    selectedOrderDetail = (OrderDetail?)lstOrderDetail.SelectedItem;
                    if (selectedOrderDetail != null)
                    {
                        cmbProduct.SelectedValue = selectedOrderDetail.ProductID;
                        txtQuantity.Text = selectedOrderDetail.Quantity.ToString();
                    }
                }
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        private void BtnShoppingCartDelete_Click(object sender, EventArgs e)
        {
            if (lstOrderDetail.SelectedIndex != -1)
            {
                lstNewOD?.Remove((OrderDetail?)lstOrderDetail.SelectedItem!);
                lstOrderDetail.Items.RemoveAt(lstOrderDetail.SelectedIndex);
                UpdateOrderDetailMessage();
            }
        }
        private void BtnShoppingCartClear_Click(object sender, EventArgs e)
        {
            try
            {
                lstNewOD?.Clear();
                lstOrderDetail.Items.Clear();
                UpdateOrderDetailMessage();
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        private void BtnOrderDetailQuit_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetailQuit();
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        private void BtnShoppingCartAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (selectedOrder != null)
                {
                    OrderDetail newOrderDetail = new()
                    {
                        Order = selectedOrder,
                        Product = (Product?)cmbProduct.SelectedItem,
                        OrderID = selectedOrder.ID,
                        ProductID = Guid.TryParse(cmbProduct.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir ürün seçiniz."),
                        Quantity = Convert.ToInt32(txtQuantity.Text),
                        UnitPrice = Convert.ToInt32(txtQuantity.Text) * ((Product?)cmbProduct.SelectedItem!).UnitPrice
                    };
                    OrderDetailValidation(newOrderDetail);
                    lstOrderDetail.ValueMember = "ID";
                    lstOrderDetail.DisplayMember = null!;
                    lstOrderDetail.Items.Add(newOrderDetail);
                    lstNewOD?.Add(newOrderDetail);
                    UpdateOrderDetailMessage();
                    FP.ShowErrorInTxt(txtMessage);
                }
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        private void BtnShoppingCartUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedOrder != null && selectedOrderDetail != null && lstOrderDetail.SelectedIndex != -1)
                {
                    lstNewOD?.Remove((OrderDetail?)lstOrderDetail.SelectedItem!);
                    lstOrderDetail.Items.Remove((OrderDetail?)lstOrderDetail.SelectedItem!);
                    selectedOrderDetail.Quantity = Convert.ToInt32(txtQuantity.Text);
                    selectedOrderDetail.ProductID = Guid.TryParse(cmbProduct.SelectedValue?.ToString(), out var employeeId) ? employeeId : throw new Exception("Geçerli bir ürün seçiniz.");
                    selectedOrderDetail.OrderID = selectedOrder.ID;
                    selectedOrderDetail.UnitPrice = Convert.ToInt32(txtQuantity.Text) * ((Product?)cmbProduct.SelectedItem!).UnitPrice;
                    selectedOrderDetail.Order = selectedOrder;
                    selectedOrderDetail.Product = (Product)cmbProduct.SelectedItem;
                    OrderDetailValidation(selectedOrderDetail);
                    lstOrderDetail.Items.Add(selectedOrderDetail);
                    lstNewOD?.Add(selectedOrderDetail);
                    UpdateOrderDetailMessage();
                }
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        private void BtnOrderDetailSuccess_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Siparişi onaylamak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (lstNewOD != null)
                    {
                        // Stok Kontrol Simülasyonu ----------------------------------------------------▼▼▼
                        foreach (OrderDetail yeniOrderDetail in lstNewOD)
                        {
                            Product product = FP.ProductService?.GetById(yeniOrderDetail.ProductID)!;
                            int mevcutStok = product.UnitsInStock;

                            // Önceki listede aynı ürün varsa miktar farkını al
                            var oncekiOrderDetail = lstFirstOD?.FirstOrDefault(o => o.ProductID == yeniOrderDetail.ProductID);
                            int stokFarki = yeniOrderDetail.Quantity - (oncekiOrderDetail?.Quantity ?? 0);

                            // Stok kontrolü - eğer fark stoktan fazla ise hata fırlat
                            if (mevcutStok - stokFarki < 0)
                            {
                                if (oncekiOrderDetail?.Quantity != yeniOrderDetail.Quantity)
                                {
                                    throw new Exception($"Stok yetersiz! {product.Name} ürününün kalan stoğu: {mevcutStok}");
                                }
                            }
                        }

                        // Stok Fark Gerçek ----------------------------------------------------▼▼▼
                        // Önceden var olup yeni listede olmayanlar (silinenler)
                        var silinenler = lstFirstOD?.Where(x => lstNewOD?.All(y => y.ID != x.ID) == true).ToList();

                        foreach (OrderDetail silinenOrderDetail in silinenler!)
                        {
                            Product product = FP.ProductService?.GetById(silinenOrderDetail.ProductID)!;

                            // Silinen ürün miktarını stoka geri ekliyoruz
                            product.UnitsInStock += silinenOrderDetail.Quantity;
                            FP.ProductService?.Update(product);

                            // Eski order detayını veritabanından siliyoruz
                            odRepo.Delete(silinenOrderDetail.OrderID, silinenOrderDetail.ProductID);
                        }

                        // Yeni listede güncelleme veya ekleme işlemi
                        foreach (OrderDetail yeniOrderDetail in lstNewOD)
                        {
                            Product product = FP.ProductService?.GetById(yeniOrderDetail.ProductID)!;
                            int mevcutStok = product.UnitsInStock;

                            // Önceki listede varsa güncelle, yoksa ekle
                            var oncekiOrderDetail = lstFirstOD?.FirstOrDefault(o => o.ProductID == yeniOrderDetail.ProductID);

                            if (oncekiOrderDetail != null)
                            {
                                // Miktar farkını alarak stok güncelle
                                int stokFarki = yeniOrderDetail.Quantity - oncekiOrderDetail.Quantity;
                                product.UnitsInStock -= stokFarki;
                                FP.ProductService?.Update(product);

                                // Mevcut order detayını güncelle
                                oncekiOrderDetail.Quantity = yeniOrderDetail.Quantity;
                                FP.OrderDetailService?.Update(oncekiOrderDetail);
                            }
                            else
                            {
                                // Yeni order detayı ekle
                                if (yeniOrderDetail.Quantity > mevcutStok)
                                {
                                    throw new Exception($"Stok yetersiz! {product.Name} ürününün kalan stoğu: {mevcutStok}");
                                }
                                product.UnitsInStock -= yeniOrderDetail.Quantity;
                                FP.ProductService?.Update(product);
                                FP.OrderDetailService?.Create(yeniOrderDetail);
                            }
                        }
                        OrderDetailQuit();
                    }
                }
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        #endregion

        #region METHODS
        private void OrderLockdown(bool UnLock)
        {
            //SİPARİŞ
            txtAddress.Enabled = UnLock;
            txtCity.Enabled = UnLock;
            txtCountry.Enabled = UnLock;
            dtOrderDate.Enabled = UnLock;
            lstOrder.Enabled = UnLock;
            cmbCustomer.Enabled = UnLock;
            cmbEmployee.Enabled = UnLock;
            chkPassive.Enabled = UnLock;
            gbProccessMenu.Enabled = UnLock;
            //SEPET
            cmbProduct.Enabled = !UnLock;
            txtQuantity.Enabled = !UnLock;
            btnShoppingCartAdd.Enabled = !UnLock;
            btnShoppingCartClear.Enabled = !UnLock;
            btnShoppingCartDelete.Enabled = !UnLock;
            btnShoppingCartUpdate.Enabled = !UnLock;
            btnOrderDetailQuit.Enabled = !UnLock;
            btnOrderDetailSuccess.Enabled = !UnLock;
            lstOrderDetail.Enabled = !UnLock;
        }
        private void GetAllEntityToListBox()
        {
            FP.UpdateListBox(lstOrder, "ID", null!, FP.OrderService?.GetAll()!, LstOrder_SelectedIndexChanged!);
            FP.FormClear(this);
        }
        private void OrderDetailValidation(OrderDetail orderDetail)
        {
            foreach (OrderDetail item in lstOrderDetail.Items)
            {
                if (item.ProductID == orderDetail.ProductID)
                {
                    throw new Exception("Bu ürün zaten mevcut");
                }
            }
            ValidationResult result = new OrderDetailValidator().Validate(orderDetail);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
        }
        private void UpdateOrderDetailMessage()
        {
            double sumPrice = 0;
            foreach (OrderDetail item in lstOrderDetail.Items)
                sumPrice += item.UnitPrice;
            if (selectedOrder != null)
                lblOrderDetailMessage.Text = $"Sipariş Tarihi\n{selectedOrder.OrderDate}\nMüşteri Bilgileri\n{selectedOrder.Customer?.Name}\n{selectedOrder.Customer?.Phone}\nÇalışan Bilgileri\n{selectedOrder.Employee?.FullName}\n{selectedOrder.Employee?.Phone}\nToplam Ürün Girdisi\n{lstOrderDetail.Items.Count}\nToplam Ürün Fiyatı\n{sumPrice}TL";
        }
        private void OrderDetailQuit()
        {
            FP.FormClear(this);
            OrderLockdown(true);
            selectedOrderDetail = null;
            lstOrderDetail.Items.Clear();
            lblOrderDetailMessage.Text = "";
            lblSelectedOrder.Text = "Seçili Sipariş: YOK";
        }

        #endregion
    }
}