namespace NTierArchitecture.UI.Forms
{
    partial class ProductForm
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtUnitPrice = new TextBox();
            label3 = new Label();
            txtUnitInStock = new TextBox();
            cmbCategory = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cmbSupplier = new ComboBox();
            chkPassive = new CheckBox();
            chkContinued = new CheckBox();
            lstList = new ListBox();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 293);
            txtMessage.Size = new Size(674, 94);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 86);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 1000;
            label1.Text = "Ürün Adı:";
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 29);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1000;
            label2.Text = "Fiyatı:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(134, 118);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(253, 29);
            txtUnitPrice.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 1000;
            label3.Text = "Stok:";
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(134, 153);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(253, 29);
            txtUnitInStock.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(134, 188);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(253, 29);
            cmbCategory.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 191);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 1000;
            label4.Text = "Kategori:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 226);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 1000;
            label5.Text = "Tedarikçi:";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(134, 223);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(253, 29);
            cmbSupplier.TabIndex = 5;
            // 
            // chkPassive
            // 
            chkPassive.AutoSize = true;
            chkPassive.Location = new Point(312, 258);
            chkPassive.Name = "chkPassive";
            chkPassive.Size = new Size(75, 25);
            chkPassive.TabIndex = 7;
            chkPassive.Text = "PASİF";
            chkPassive.UseVisualStyleBackColor = true;
            chkPassive.CheckedChanged += ChkPassive_CheckedChanged;
            // 
            // chkContinued
            // 
            chkContinued.AutoSize = true;
            chkContinued.Location = new Point(134, 258);
            chkContinued.Name = "chkContinued";
            chkContinued.Size = new Size(144, 25);
            chkContinued.TabIndex = 6;
            chkContinued.Text = "DURDURULDU";
            chkContinued.UseVisualStyleBackColor = true;
            chkContinued.CheckedChanged += ChkContinued_CheckedChanged;
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.IntegralHeight = false;
            lstList.ItemHeight = 21;
            lstList.Location = new Point(393, 12);
            lstList.Name = "lstList";
            lstList.Size = new Size(293, 271);
            lstList.TabIndex = 8;
            lstList.SelectedIndexChanged += LstList_SelectedIndexChanged;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 399);
            Controls.Add(lstList);
            Controls.Add(chkContinued);
            Controls.Add(chkPassive);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbCategory);
            Controls.Add(label5);
            Controls.Add(txtUnitInStock);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtUnitPrice);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            Controls.SetChildIndex(txtMessage, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtUnitPrice, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtUnitInStock, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(cmbCategory, 0);
            Controls.SetChildIndex(cmbSupplier, 0);
            Controls.SetChildIndex(chkPassive, 0);
            Controls.SetChildIndex(chkContinued, 0);
            Controls.SetChildIndex(lstList, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtUnitPrice;
        private Label label3;
        private TextBox txtUnitInStock;
        private ComboBox cmbCategory;
        private Label label4;
        private Label label5;
        private ComboBox cmbSupplier;
        private CheckBox chkPassive;
        private CheckBox chkContinued;
        private ListBox lstList;
    }
}