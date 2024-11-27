using NTierArchitecture.UI.Forms;
using NTierArchitecture.UI.Tools;

namespace NTierArchitecture.UI
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }
        private void MasterForm_Load(object sender, EventArgs e) {
            ToolStripMenuItem masterMenu = new("FORMS");
            ToolStripMenuItem[] childs = [
                new("KATEGORÝ FORMU", null, new EventHandler(Category_Click!)),
                new("ÜRÜN FORMU", null, new EventHandler(Product_Click!)),
                new("MÜÞTERÝ FORMU",null, new EventHandler(Customer_Click!)),
                new("ÇALIÞAN FORMU",null,new EventHandler(Employee_Click!)),
                new("TEDARÝKÇÝ FORMU",null,new EventHandler(Supplier_Click!)),
                new("SÝPARÝÞ FORMU",null,new EventHandler(Order_Click!)),
                new("SÝPARÝÞ FORMU V2",null,new EventHandler(OrderV2_Click!))
            ];
            masterMenu.DropDownItems.AddRange(childs);
            MenuStrip ms = new()
            {
                MdiWindowListItem = masterMenu,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI Black", 15f, FontStyle.Bold)
            };
            ms.Items.Add(masterMenu);
            this.MainMenuStrip = ms;
            this.Controls.Add(ms);
        }
        void Category_Click(object sender, EventArgs e) { FP.FormControlAndOpenInMdi(this, new CategoryForm()); }
        void Product_Click(object sender, EventArgs e) { FP.FormControlAndOpenInMdi(this, new ProductForm()); }
        void Customer_Click(object sender, EventArgs e) { FP.FormControlAndOpenInMdi(this, new CustormerForm()); }
        void Employee_Click(object sender, EventArgs e) { FP.FormControlAndOpenInMdi(this, new EmployeeForm()); }
        void Supplier_Click(object sender, EventArgs e) { FP.FormControlAndOpenInMdi(this, new SupplierForm()); }
        void Order_Click(object sender, EventArgs e) { FP.FormControlAndOpenInMdi(this, new OrderForm()); }
        void OrderV2_Click(object sender, EventArgs e) { FP.FormControlAndOpenInMdi(this, new OrderFormV2()); }
    }
}
