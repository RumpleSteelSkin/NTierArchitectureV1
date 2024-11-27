namespace NTierArchitecture.UI.Forms
{
    partial class CustormerForm
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
            txtCountry = new TextBox();
            label3 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtPhone = new MaskedTextBox();
            cbPassiveActive = new CheckBox();
            lstList = new ListBox();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 257);
            txtMessage.Size = new Size(582, 94);
            txtMessage.TabIndex = 999;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 86);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 2;
            label1.Text = "Müşteri Adı:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(267, 29);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 2;
            label2.Text = "Ülke:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(120, 118);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(267, 29);
            txtCountry.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 2;
            label3.Text = "Şehir:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(120, 153);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(267, 29);
            txtCity.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 191);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 2;
            label4.Text = "Telefon:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(120, 188);
            txtPhone.Mask = "(999) 000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(267, 29);
            txtPhone.TabIndex = 4;
            // 
            // cbPassiveActive
            // 
            cbPassiveActive.AutoSize = true;
            cbPassiveActive.Location = new Point(312, 223);
            cbPassiveActive.Name = "cbPassiveActive";
            cbPassiveActive.Size = new Size(75, 25);
            cbPassiveActive.TabIndex = 5;
            cbPassiveActive.Text = "PASİF";
            cbPassiveActive.UseVisualStyleBackColor = true;
            cbPassiveActive.CheckedChanged += CbPassiveActive_CheckedChanged;
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 21;
            lstList.Location = new Point(393, 12);
            lstList.Name = "lstList";
            lstList.Size = new Size(201, 235);
            lstList.TabIndex = 6;
            lstList.SelectedIndexChanged += LstList_SelectedIndexChanged;
            // 
            // CustormerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 360);
            Controls.Add(lstList);
            Controls.Add(cbPassiveActive);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(txtCountry);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "CustormerForm";
            Text = "CustormerForm";
            Load += CustormerForm_Load;
            Controls.SetChildIndex(txtMessage, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtName, 0);
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

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtCountry;
        private Label label3;
        private TextBox txtCity;
        private Label label4;
        private MaskedTextBox txtPhone;
        private CheckBox cbPassiveActive;
        private ListBox lstList;
    }
}