namespace NTierArchitecture.UI.Forms
{
    partial class OrderFormV2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnAddBasket = new Button();
            label3 = new Label();
            label2 = new Label();
            nmrQuantity = new NumericUpDown();
            label1 = new Label();
            txtUnitPrice = new TextBox();
            txtSearch = new TextBox();
            lstProductList = new ListBox();
            dgwOrderList = new DataGridView();
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            groupBox3 = new GroupBox();
            dgwOrderDetailList = new DataGridView();
            groupBox4 = new GroupBox();
            btnDelete = new Button();
            btnSaveOrder = new Button();
            btnNewOrder = new Button();
            lstBasket = new ListBox();
            lblBasketCount = new Label();
            lblBasketTotal = new Label();
            Id = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            ShipCountry = new DataGridViewTextBoxColumn();
            ShipCity = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwOrderList).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwOrderDetailList).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddBasket);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nmrQuantity);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(lstProductList);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(590, 344);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Listesi";
            // 
            // btnAddBasket
            // 
            btnAddBasket.Location = new Point(13, 288);
            btnAddBasket.Margin = new Padding(2);
            btnAddBasket.Name = "btnAddBasket";
            btnAddBasket.Size = new Size(564, 45);
            btnAddBasket.TabIndex = 2;
            btnAddBasket.Text = "Sepete Ekle";
            btnAddBasket.UseVisualStyleBackColor = true;
            btnAddBasket.Click += BtnAddBasket_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 256);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 1;
            label3.Text = "Birim Fiyat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 251);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 1;
            label2.Text = "Adet";
            // 
            // nmrQuantity
            // 
            nmrQuantity.Location = new Point(101, 251);
            nmrQuantity.Margin = new Padding(11, 15, 11, 15);
            nmrQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrQuantity.Name = "nmrQuantity";
            nmrQuantity.Size = new Size(111, 34);
            nmrQuantity.TabIndex = 3;
            nmrQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 28);
            label1.TabIndex = 1;
            label1.Text = "Lütfen aramak istediğiniz ürünü giriniz:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(353, 251);
            txtUnitPrice.Margin = new Padding(2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(225, 34);
            txtUnitPrice.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(13, 69);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(566, 34);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lstProductList
            // 
            lstProductList.FormattingEnabled = true;
            lstProductList.ItemHeight = 28;
            lstProductList.Location = new Point(13, 106);
            lstProductList.Margin = new Padding(2);
            lstProductList.Name = "lstProductList";
            lstProductList.Size = new Size(566, 144);
            lstProductList.TabIndex = 4;
            lstProductList.SelectedIndexChanged += LstProductList_SelectedIndexChanged;
            // 
            // dgwOrderList
            // 
            dgwOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgwOrderList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOrderList.Columns.AddRange(new DataGridViewColumn[] { Id, OrderDate, ShipCountry, ShipCity });
            dgwOrderList.Location = new Point(13, 47);
            dgwOrderList.Margin = new Padding(2);
            dgwOrderList.Name = "dgwOrderList";
            dgwOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwOrderList.Size = new Size(564, 133);
            dgwOrderList.TabIndex = 5;
            dgwOrderList.CellClick += DgwOrderList_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgwOrderList);
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Location = new Point(0, 357);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(597, 213);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sipariş Bilgisi";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(8, 182);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(373, 28);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Fatura Toplam Tutarı :  12.500 + %20 KDV";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgwOrderDetailList);
            groupBox3.Location = new Point(608, 357);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(527, 204);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sipariş Detay Raporu";
            // 
            // dgwOrderDetailList
            // 
            dgwOrderDetailList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgwOrderDetailList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwOrderDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOrderDetailList.Location = new Point(13, 38);
            dgwOrderDetailList.Margin = new Padding(2);
            dgwOrderDetailList.Name = "dgwOrderDetailList";
            dgwOrderDetailList.Size = new Size(509, 153);
            dgwOrderDetailList.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDelete);
            groupBox4.Controls.Add(btnSaveOrder);
            groupBox4.Controls.Add(btnNewOrder);
            groupBox4.Controls.Add(lstBasket);
            groupBox4.Controls.Add(lblBasketCount);
            groupBox4.Controls.Add(lblBasketTotal);
            groupBox4.Location = new Point(604, 8);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(527, 336);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Müşteri Sepeti";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(457, 240);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 42);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(349, 290);
            btnSaveOrder.Margin = new Padding(2);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(173, 42);
            btnSaveOrder.TabIndex = 2;
            btnSaveOrder.Text = "Sipariş Kaydet";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += BtnSaveOrder_Click;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Location = new Point(172, 290);
            btnNewOrder.Margin = new Padding(2);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(173, 42);
            btnNewOrder.TabIndex = 2;
            btnNewOrder.Text = "Yeni Sipariş";
            btnNewOrder.UseVisualStyleBackColor = true;
            btnNewOrder.Click += BtnNewOrder_Click;
            // 
            // lstBasket
            // 
            lstBasket.FormattingEnabled = true;
            lstBasket.ItemHeight = 28;
            lstBasket.Location = new Point(4, 46);
            lstBasket.Margin = new Padding(2);
            lstBasket.Name = "lstBasket";
            lstBasket.Size = new Size(520, 172);
            lstBasket.TabIndex = 5;
            // 
            // lblBasketCount
            // 
            lblBasketCount.AutoSize = true;
            lblBasketCount.Location = new Point(4, 258);
            lblBasketCount.Margin = new Padding(2, 0, 2, 0);
            lblBasketCount.Name = "lblBasketCount";
            lblBasketCount.Size = new Size(132, 28);
            lblBasketCount.TabIndex = 1;
            lblBasketCount.Text = "Ürün Adedi: 5";
            // 
            // lblBasketTotal
            // 
            lblBasketTotal.AutoSize = true;
            lblBasketTotal.Location = new Point(4, 227);
            lblBasketTotal.Margin = new Padding(2, 0, 2, 0);
            lblBasketTotal.Name = "lblBasketTotal";
            lblBasketTotal.Size = new Size(228, 28);
            lblBasketTotal.TabIndex = 1;
            lblBasketTotal.Text = "Sepet Toplamı: 12.500 TL";
            // 
            // Id
            // 
            Id.DataPropertyName = "ID";
            Id.FillWeight = 5F;
            Id.HeaderText = "Sipariş No";
            Id.Name = "Id";
            Id.Resizable = DataGridViewTriState.False;
            Id.Width = 127;
            // 
            // OrderDate
            // 
            OrderDate.DataPropertyName = "OrderDate";
            OrderDate.HeaderText = "Sipariş Tarihi";
            OrderDate.Name = "OrderDate";
            OrderDate.Width = 146;
            // 
            // ShipCountry
            // 
            ShipCountry.DataPropertyName = "ShipCountry";
            ShipCountry.HeaderText = "Ülke";
            ShipCountry.Name = "ShipCountry";
            ShipCountry.Width = 76;
            // 
            // ShipCity
            // 
            ShipCity.DataPropertyName = "ShipCity";
            ShipCity.HeaderText = "Şehir";
            ShipCity.Name = "ShipCity";
            ShipCity.Width = 81;
            // 
            // OrderFormV2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1143, 571);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "OrderFormV2";
            Text = "OrderFormV2";
            Load += OrderFormV2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwOrderList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwOrderDetailList).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }


        #endregion
        private GroupBox groupBox1;
        private ListBox lstProductList;
        private NumericUpDown nmrQuantity;
        private Button btnAddBasket;
        private Label label1;
        private TextBox txtSearch;
        private Label label3;
        private Label label2;
        private TextBox txtUnitPrice;
        private DataGridView dgwOrderList;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgwOrderDetailList;
        private GroupBox groupBox4;
        private Button btnSaveOrder;
        private Button btnNewOrder;
        private ListBox lstBasket;
        private Label lblBasketCount;
        private Label lblBasketTotal;
        private Button btnDelete;
        private Label lblTotal;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn ShipCountry;
        private DataGridViewTextBoxColumn ShipCity;
    }
}