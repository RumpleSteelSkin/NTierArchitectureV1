namespace NTierArchitecture.UI.Forms
{
    partial class OrderFormV2SaveOrderDialog
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
            label2 = new Label();
            cmbEmployee = new ComboBox();
            label3 = new Label();
            cmbCustomer = new ComboBox();
            txtCountry = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtCity = new TextBox();
            dtOrderDate = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            txtAddress = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(619, 63);
            label1.TabIndex = 0;
            label1.Text = "Sipariş kayıt edilebilmesi için siparişi onaylayan çalışan, sipariş edilen müşteri ve birtakım bilgiler girilmesi gerekmektedir.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 126);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 1;
            label2.Text = "Çalışan:";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(164, 123);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(467, 36);
            cmbEmployee.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 168);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 1;
            label3.Text = "Müşteri:";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(164, 165);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(467, 36);
            cmbCustomer.TabIndex = 3;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(164, 207);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(467, 34);
            txtCountry.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 210);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 1;
            label4.Text = "Ülke:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(19, 250);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 1;
            label5.Text = "Şehir:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(164, 247);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(467, 34);
            txtCity.TabIndex = 5;
            // 
            // dtOrderDate
            // 
            dtOrderDate.Format = DateTimePickerFormat.Short;
            dtOrderDate.Location = new Point(164, 83);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(467, 34);
            dtOrderDate.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(19, 88);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 1;
            label6.Text = "Sipariş Tarihi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(19, 290);
            label7.Name = "label7";
            label7.Size = new Size(71, 28);
            label7.TabIndex = 1;
            label7.Text = "Adres:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(164, 287);
            txtAddress.MaxLength = 500;
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(467, 88);
            txtAddress.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Location = new Point(450, 381);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(181, 41);
            btnSave.TabIndex = 7;
            btnSave.Text = "Siparişi Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 192);
            btnCancel.Location = new Point(164, 381);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(181, 41);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Şimdilik Vazgeç";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // OrderFormV2SaveOrderDialog
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(643, 429);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtOrderDate);
            Controls.Add(txtAddress);
            Controls.Add(txtCity);
            Controls.Add(label7);
            Controls.Add(txtCountry);
            Controls.Add(label5);
            Controls.Add(cmbCustomer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbEmployee);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrderFormV2SaveOrderDialog";
            Text = "OrderFormV2SaveOrderDialog";
            TopMost = true;
            Load += OrderFormV2SaveOrderDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbEmployee;
        private Label label3;
        private ComboBox cmbCustomer;
        private TextBox txtCountry;
        private Label label4;
        private Label label5;
        private TextBox txtCity;
        private DateTimePicker dtOrderDate;
        private Label label6;
        private Label label7;
        private TextBox txtAddress;
        private Button btnSave;
        private Button btnCancel;
    }
}