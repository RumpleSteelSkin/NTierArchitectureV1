namespace NTierArchitecture.UI.Forms
{
    partial class SupplierForm
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
            lstList = new ListBox();
            cbPassiveActive = new CheckBox();
            txtPhone = new MaskedTextBox();
            label4 = new Label();
            txtCity = new TextBox();
            label3 = new Label();
            txtCountry = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            label5 = new Label();
            txtContactTitle = new TextBox();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 290);
            txtMessage.Size = new Size(675, 94);
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.IntegralHeight = false;
            lstList.ItemHeight = 21;
            lstList.Location = new Point(393, 12);
            lstList.Name = "lstList";
            lstList.Size = new Size(295, 271);
            lstList.TabIndex = 7;
            // 
            // cbPassiveActive
            // 
            cbPassiveActive.AutoSize = true;
            cbPassiveActive.Location = new Point(312, 258);
            cbPassiveActive.Name = "cbPassiveActive";
            cbPassiveActive.Size = new Size(75, 25);
            cbPassiveActive.TabIndex = 6;
            cbPassiveActive.Text = "PASİF";
            cbPassiveActive.UseVisualStyleBackColor = true;
            cbPassiveActive.CheckedChanged += CbPassiveActive_CheckedChanged_1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(120, 223);
            txtPhone.Mask = "(999) 000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(267, 29);
            txtPhone.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 226);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 1001;
            label4.Text = "Telefon:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(120, 188);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(267, 29);
            txtCity.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 1002;
            label3.Text = "Şehir:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(120, 153);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(267, 29);
            txtCountry.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 156);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 1004;
            label2.Text = "Ülke:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(267, 29);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 86);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 1005;
            label1.Text = "Tedarikçi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 121);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 1005;
            label5.Text = "İletişim Adı:";
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(120, 118);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(267, 29);
            txtContactTitle.TabIndex = 2;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 396);
            Controls.Add(lstList);
            Controls.Add(cbPassiveActive);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(txtCountry);
            Controls.Add(label2);
            Controls.Add(txtContactTitle);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "SupplierForm";
            Text = "SupplierForm";
            Load += SupplierForm_Load;
            Controls.SetChildIndex(gbProccessMenu, 0);
            Controls.SetChildIndex(txtMessage, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtContactTitle, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtCountry, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtCity, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtPhone, 0);
            Controls.SetChildIndex(cbPassiveActive, 0);
            Controls.SetChildIndex(lstList, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstList;
        private CheckBox cbPassiveActive;
        private MaskedTextBox txtPhone;
        private Label label4;
        private TextBox txtCity;
        private Label label3;
        private TextBox txtCountry;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Label label5;
        private TextBox txtContactTitle;
    }
}