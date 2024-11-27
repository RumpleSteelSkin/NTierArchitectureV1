namespace NTierArchitecture.UI.Forms
{
    partial class BaseForm
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
            gbProccessMenu = new GroupBox();
            btnList = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtMessage = new TextBox();
            gbProccessMenu.SuspendLayout();
            SuspendLayout();
            // 
            // gbProccessMenu
            // 
            gbProccessMenu.Controls.Add(btnList);
            gbProccessMenu.Controls.Add(btnUpdate);
            gbProccessMenu.Controls.Add(btnDelete);
            gbProccessMenu.Controls.Add(btnAdd);
            gbProccessMenu.Location = new Point(12, 12);
            gbProccessMenu.Name = "gbProccessMenu";
            gbProccessMenu.Size = new Size(375, 65);
            gbProccessMenu.TabIndex = 0;
            gbProccessMenu.TabStop = false;
            gbProccessMenu.Text = "İşlem Menüsü";
            // 
            // btnList
            // 
            btnList.Location = new Point(282, 28);
            btnList.Name = "btnList";
            btnList.Size = new Size(80, 29);
            btnList.TabIndex = 999;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(178, 28);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 29);
            btnUpdate.TabIndex = 999;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(92, 28);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 29);
            btnDelete.TabIndex = 999;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 29);
            btnAdd.TabIndex = 999;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtMessage
            // 
            txtMessage.AcceptsReturn = true;
            txtMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMessage.BackColor = Color.Green;
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.CausesValidation = false;
            txtMessage.Location = new Point(12, 284);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.ScrollBars = ScrollBars.Both;
            txtMessage.Size = new Size(375, 94);
            txtMessage.TabIndex = 999;
            txtMessage.WordWrap = false;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(399, 390);
            Controls.Add(txtMessage);
            Controls.Add(gbProccessMenu);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "BaseForm";
            Text = "BaseForm";
            gbProccessMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnList;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        public TextBox txtMessage;
        public GroupBox gbProccessMenu;
    }
}