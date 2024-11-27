using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;

namespace NTierArchitecture.UI.Tools
{
    public static class FP //Form Proccess
    {
        /// <summary>
        ///  Formun açık olup olmadığını kontrol ederek belirtilen fMdiParent formun içine fMdiChild açmasını sağlar
        /// </summary>
        public static void FormControlAndOpenInMdi(Form fMdiParent, Form fMdiChild)
        {
            bool isOpen = false;
            fMdiChild.MdiParent = fMdiParent;
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == fMdiChild.GetType())
                {
                    isOpen = true;
                }
            }
            if (isOpen)
            {
                MessageBox.Show("Bu Form zaten açık durumda.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                fMdiChild.Show();
            }
        }

        /// <summary>
        ///  Form içerisinde bulunan tüm elementler arasında textbox ve maskedtexboxların içini temizler.
        /// </summary>
        public static void FormClear(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox box)
                {
                    box.Clear();
                }
                else if (item is MaskedTextBox mbox)
                {
                    mbox.Clear();
                }
                else if (item is CheckBox cbox)
                {
                    cbox.Checked = false;
                }
                else if (item.TabIndex == 1)
                {
                    item.Focus();
                }
                else if (item.Controls.Count > 0)
                {
                    FormClear(item);
                }
            }
        }

        /// <summary>
        ///  Basit hata ekranı gösterici.
        /// </summary>
        public static void ShowError(Exception ex)
        {
            MessageBox.Show($"{ex.Message}\n{ex.InnerException}", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        ///  Textbox içerisine hata mesajı verme.
        /// </summary>
        public static void ShowErrorInTxt(TextBox txt, Exception? ex = null)
        {
            if (ex != null)
            {
                txt.BackColor = Color.Red;
                txt.ForeColor = Color.White;
                txt.TextAlign = HorizontalAlignment.Left;
                txt.Text = ($"{ex.Message}\n{(ex.InnerException != null ? ex.InnerException.Message : string.Empty)}").Replace("\n", "\r\n");
            }
            else
            {
                txt.BackColor = Color.Green;
                txt.ForeColor = Color.White;
                txt.TextAlign = HorizontalAlignment.Center;
                txt.Text = "Sorun Yok";
            }
        }

        /// <summary>
        /// Belirtilen ListBox'un veri kaynağını (DataSource) günceller ve istenilen özelliklere göre yapılandırır.
        /// Seçilen değeri sıfırlar (SelectedIndex = -1) ve istenirse, `SelectedIndexChanged` olayını geçici olarak devre dışı bırakıp yeniden ekler.
        /// </summary>
        /// <param name="listBox">Veri kaynağı güncellenecek olan ListBox kontrolü.</param>
        /// <param name="valueMember">ListBox'un ValueMember özelliği olarak ayarlanacak özellik adı.</param>
        /// <param name="displayMember">ListBox'un DisplayMember özelliği olarak ayarlanacak özellik adı.</param>
        /// <param name="dataSource">ListBox için kullanılacak yeni veri kaynağı.</param>
        /// <param name="selectedIndexChangedHandler">Eğer tanımlı ise, `SelectedIndexChanged` olayını geçici olarak devre dışı bırakıp yeniden eklemek için kullanılacak olay işleyicisi.</param>
        public static void UpdateListBox(ListBox listBox, string valueMember, string displayMember, object dataSource, EventHandler? selectedIndexChangedHandler = null)
        {
            if (selectedIndexChangedHandler != null)
                listBox.SelectedIndexChanged -= selectedIndexChangedHandler;
            listBox.DataSource = null;
            listBox.ValueMember = valueMember;
            listBox.DisplayMember = displayMember;
            listBox.DataSource = dataSource;
            listBox.SelectedIndex = -1;
            if (selectedIndexChangedHandler != null)
                listBox.SelectedIndexChanged += selectedIndexChangedHandler;
        }

        public static void UpdateComboBox(ComboBox comboBox, string valueMember, string displayMember, object dataSource)
        {
            comboBox.DataSource = null;
            comboBox.ValueMember = valueMember;
            comboBox.DisplayMember = displayMember;
            comboBox.DataSource = dataSource;
            comboBox.SelectedIndex = -1;
        }

        private static OrderDetailService? _orderDetailService;
        private static ApplicationDBContext? _applicationDB;
        private static CategoryService? _categoryService;
        private static CustomerService? _customerService;
        private static EmployeeService? _employeeService;
        private static SupplierService? _supplierService;
        private static ProductService? _productService;
        private static OrderService? _orderService;
        public static OrderDetailService? OrderDetailService { get => _orderDetailService; }
        public static ApplicationDBContext? ApplicationDB { get => _applicationDB; }
        public static CustomerService? CustomerService { get => _customerService; }
        public static CategoryService? CategoryService { get => _categoryService; }
        public static EmployeeService? EmployeeService { get => _employeeService; }
        public static SupplierService? SupplierService { get => _supplierService; }
        public static ProductService? ProductService { get => _productService; }
        public static OrderService? OrderService { get => _orderService; }
        /// <summary>
        ///  Tüm generic servislerin tanımlanması bu metod içerisinde gerçekleşir.
        ///  Bir kere çalıştırılması yeterlidir.
        /// </summary>
        public static void DefineServices() //Bunu düşünmene gerek yok Program.cs tetikliyor.
        {
            _applicationDB = new();
            _orderDetailService = new(new OrderDetailRepository(_applicationDB));
            _categoryService = new(new CategoryRepository(_applicationDB));
            _customerService = new(new CustomerRepository(_applicationDB));
            _employeeService = new(new EmployeeRepository(_applicationDB));
            _supplierService = new(new SupplierRepository(_applicationDB));
            _productService = new(new ProductRepository(_applicationDB));
            _orderService = new(new OrderRepository(_applicationDB));
        }
    }
}
