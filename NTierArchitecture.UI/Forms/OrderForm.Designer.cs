namespace NTierArchitecture.UI.Forms
{
    partial class OrderForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtOrderDate = new DateTimePicker();
            label1 = new Label();
            txtAddress = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtCountry = new TextBox();
            cmbCustomer = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cmbEmployee = new ComboBox();
            lstOrder = new ListBox();
            label7 = new Label();
            lblSelectedOrder = new Label();
            label9 = new Label();
            cmbProduct = new ComboBox();
            label10 = new Label();
            txtQuantity = new TextBox();
            lstOrderDetail = new ListBox();
            btnShoppingCartAdd = new Button();
            btnShoppingCartUpdate = new Button();
            btnShoppingCartDelete = new Button();
            btnOrderDetailSuccess = new Button();
            btnOrderDetailQuit = new Button();
            btnShoppingCartClear = new Button();
            lblOrderDetailMessage = new Label();
            chkPassive = new CheckBox();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 348);
            txtMessage.Size = new Size(599, 107);
            // 
            // dtOrderDate
            // 
            dtOrderDate.Format = DateTimePickerFormat.Short;
            dtOrderDate.Location = new Point(136, 153);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(251, 29);
            dtOrderDate.TabIndex = 1000;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 159);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 1001;
            label1.Text = "Sipariş Tarihi:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(136, 258);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(251, 80);
            txtAddress.TabIndex = 1002;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 261);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 1001;
            label2.Text = "Varış Adresi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 226);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 1001;
            label3.Text = "Şehir:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(136, 223);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(251, 29);
            txtCity.TabIndex = 1002;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 191);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 1001;
            label4.Text = "Ülke:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(136, 188);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(251, 29);
            txtCountry.TabIndex = 1002;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(136, 83);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(251, 29);
            cmbCustomer.TabIndex = 1003;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 86);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 1001;
            label5.Text = "Müşteri:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 121);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 1001;
            label6.Text = "Çalışan:";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(136, 118);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(251, 29);
            cmbEmployee.TabIndex = 1003;
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.IntegralHeight = false;
            lstOrder.ItemHeight = 21;
            lstOrder.Location = new Point(393, 12);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(219, 326);
            lstOrder.TabIndex = 1004;
            lstOrder.SelectedIndexChanged += LstOrder_SelectedIndexChanged;
            lstOrder.MouseDoubleClick += LstOrder_MouseDoubleClick;
            // 
            // label7
            // 
            label7.BackColor = Color.DimGray;
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(618, 12);
            label7.Name = "label7";
            label7.Size = new Size(12, 443);
            label7.TabIndex = 1005;
            // 
            // lblSelectedOrder
            // 
            lblSelectedOrder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSelectedOrder.BackColor = Color.FromArgb(255, 192, 128);
            lblSelectedOrder.Location = new Point(636, 12);
            lblSelectedOrder.Name = "lblSelectedOrder";
            lblSelectedOrder.Size = new Size(579, 24);
            lblSelectedOrder.TabIndex = 1006;
            lblSelectedOrder.Text = "Seçili Sipariş: YOK";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(636, 44);
            label9.Name = "label9";
            label9.Size = new Size(54, 21);
            label9.TabIndex = 1001;
            label9.Text = "Ürün:";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(721, 40);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(251, 29);
            cmbProduct.TabIndex = 1003;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(636, 78);
            label10.Name = "label10";
            label10.Size = new Size(72, 21);
            label10.TabIndex = 1001;
            label10.Text = "Miktar: ";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(721, 75);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(251, 29);
            txtQuantity.TabIndex = 1007;
            // 
            // lstOrderDetail
            // 
            lstOrderDetail.FormattingEnabled = true;
            lstOrderDetail.IntegralHeight = false;
            lstOrderDetail.ItemHeight = 21;
            lstOrderDetail.Location = new Point(636, 146);
            lstOrderDetail.Name = "lstOrderDetail";
            lstOrderDetail.Size = new Size(336, 309);
            lstOrderDetail.TabIndex = 1008;
            lstOrderDetail.SelectedIndexChanged += LstOrderDetail_SelectedIndexChanged;
            // 
            // btnShoppingCartAdd
            // 
            btnShoppingCartAdd.Location = new Point(636, 110);
            btnShoppingCartAdd.Name = "btnShoppingCartAdd";
            btnShoppingCartAdd.Size = new Size(108, 30);
            btnShoppingCartAdd.TabIndex = 1009;
            btnShoppingCartAdd.Text = "Ekle";
            btnShoppingCartAdd.UseVisualStyleBackColor = true;
            btnShoppingCartAdd.Click += BtnShoppingCartAdd_Click_1;
            // 
            // btnShoppingCartUpdate
            // 
            btnShoppingCartUpdate.Location = new Point(750, 110);
            btnShoppingCartUpdate.Name = "btnShoppingCartUpdate";
            btnShoppingCartUpdate.Size = new Size(108, 30);
            btnShoppingCartUpdate.TabIndex = 1009;
            btnShoppingCartUpdate.Text = "Güncelle";
            btnShoppingCartUpdate.UseVisualStyleBackColor = true;
            btnShoppingCartUpdate.Click += BtnShoppingCartUpdate_Click;
            // 
            // btnShoppingCartDelete
            // 
            btnShoppingCartDelete.Location = new Point(864, 110);
            btnShoppingCartDelete.Name = "btnShoppingCartDelete";
            btnShoppingCartDelete.Size = new Size(108, 30);
            btnShoppingCartDelete.TabIndex = 1009;
            btnShoppingCartDelete.Text = "Sil";
            btnShoppingCartDelete.UseVisualStyleBackColor = true;
            btnShoppingCartDelete.Click += BtnShoppingCartDelete_Click;
            // 
            // btnOrderDetailSuccess
            // 
            btnOrderDetailSuccess.BackColor = Color.FromArgb(128, 255, 128);
            btnOrderDetailSuccess.Location = new Point(978, 405);
            btnOrderDetailSuccess.Name = "btnOrderDetailSuccess";
            btnOrderDetailSuccess.Size = new Size(237, 50);
            btnOrderDetailSuccess.TabIndex = 1009;
            btnOrderDetailSuccess.Text = "Siparişi Onayla";
            btnOrderDetailSuccess.UseVisualStyleBackColor = false;
            btnOrderDetailSuccess.Click += BtnOrderDetailSuccess_Click;
            // 
            // btnOrderDetailQuit
            // 
            btnOrderDetailQuit.BackColor = Color.FromArgb(255, 128, 128);
            btnOrderDetailQuit.Location = new Point(978, 40);
            btnOrderDetailQuit.Name = "btnOrderDetailQuit";
            btnOrderDetailQuit.Size = new Size(237, 50);
            btnOrderDetailQuit.TabIndex = 1009;
            btnOrderDetailQuit.Text = "Geri Dön";
            btnOrderDetailQuit.UseVisualStyleBackColor = false;
            btnOrderDetailQuit.Click += BtnOrderDetailQuit_Click;
            // 
            // btnShoppingCartClear
            // 
            btnShoppingCartClear.BackColor = Color.FromArgb(255, 192, 192);
            btnShoppingCartClear.Location = new Point(978, 90);
            btnShoppingCartClear.Name = "btnShoppingCartClear";
            btnShoppingCartClear.Size = new Size(237, 50);
            btnShoppingCartClear.TabIndex = 1009;
            btnShoppingCartClear.Text = "Ürünleri İptal Et";
            btnShoppingCartClear.UseVisualStyleBackColor = false;
            btnShoppingCartClear.Click += BtnShoppingCartClear_Click;
            // 
            // lblOrderDetailMessage
            // 
            lblOrderDetailMessage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblOrderDetailMessage.BackColor = Color.FromArgb(192, 255, 192);
            lblOrderDetailMessage.Location = new Point(978, 146);
            lblOrderDetailMessage.Name = "lblOrderDetailMessage";
            lblOrderDetailMessage.Size = new Size(237, 256);
            lblOrderDetailMessage.TabIndex = 1006;
            // 
            // chkPassive
            // 
            chkPassive.AutoSize = true;
            chkPassive.Location = new Point(12, 313);
            chkPassive.Name = "chkPassive";
            chkPassive.Size = new Size(75, 25);
            chkPassive.TabIndex = 1010;
            chkPassive.Text = "PASİF";
            chkPassive.UseVisualStyleBackColor = true;
            chkPassive.CheckedChanged += ChkPassive_CheckedChanged;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 467);
            Controls.Add(chkPassive);
            Controls.Add(btnShoppingCartClear);
            Controls.Add(btnOrderDetailQuit);
            Controls.Add(btnOrderDetailSuccess);
            Controls.Add(btnShoppingCartDelete);
            Controls.Add(btnShoppingCartUpdate);
            Controls.Add(btnShoppingCartAdd);
            Controls.Add(lstOrderDetail);
            Controls.Add(txtQuantity);
            Controls.Add(lblOrderDetailMessage);
            Controls.Add(lblSelectedOrder);
            Controls.Add(label7);
            Controls.Add(lstOrder);
            Controls.Add(cmbEmployee);
            Controls.Add(cmbProduct);
            Controls.Add(cmbCustomer);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtOrderDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            Controls.SetChildIndex(gbProccessMenu, 0);
            Controls.SetChildIndex(dtOrderDate, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtAddress, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(label10, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtCity, 0);
            Controls.SetChildIndex(txtCountry, 0);
            Controls.SetChildIndex(cmbCustomer, 0);
            Controls.SetChildIndex(cmbProduct, 0);
            Controls.SetChildIndex(cmbEmployee, 0);
            Controls.SetChildIndex(lstOrder, 0);
            Controls.SetChildIndex(txtMessage, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(lblSelectedOrder, 0);
            Controls.SetChildIndex(lblOrderDetailMessage, 0);
            Controls.SetChildIndex(txtQuantity, 0);
            Controls.SetChildIndex(lstOrderDetail, 0);
            Controls.SetChildIndex(btnShoppingCartAdd, 0);
            Controls.SetChildIndex(btnShoppingCartUpdate, 0);
            Controls.SetChildIndex(btnShoppingCartDelete, 0);
            Controls.SetChildIndex(btnOrderDetailSuccess, 0);
            Controls.SetChildIndex(btnOrderDetailQuit, 0);
            Controls.SetChildIndex(btnShoppingCartClear, 0);
            Controls.SetChildIndex(chkPassive, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtOrderDate;
        private Label label1;
        private TextBox txtAddress;
        private Label label2;
        private Label label3;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtCountry;
        private ComboBox cmbCustomer;
        private Label label5;
        private Label label6;
        private ComboBox cmbEmployee;
        private ListBox lstOrder;
        private Label label7;
        private Label lblSelectedOrder;
        private Label label9;
        private ComboBox cmbProduct;
        private Label label10;
        private TextBox txtQuantity;
        private ListBox lstOrderDetail;
        private Button btnShoppingCartAdd;
        private Button btnShoppingCartUpdate;
        private Button btnShoppingCartDelete;
        private Button btnOrderDetailSuccess;
        private Button btnOrderDetailQuit;
        private Button btnShoppingCartClear;
        private Label lblOrderDetailMessage;
        private CheckBox chkPassive;
    }
}