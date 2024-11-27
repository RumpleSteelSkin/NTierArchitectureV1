namespace NTierArchitecture.UI.Forms
{
    partial class CategoryForm
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
            txtKategoriAdi = new TextBox();
            label1 = new Label();
            lstListe = new ListBox();
            cbAktifPasif = new CheckBox();
            txtAciklama = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 240);
            txtMessage.Size = new Size(617, 94);
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(127, 89);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(260, 29);
            txtKategoriAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 999;
            label1.Text = "Kategori Adı";
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 21;
            lstListe.Location = new Point(393, 22);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(236, 214);
            lstListe.TabIndex = 4;
            lstListe.SelectedIndexChanged += LstListe_SelectedIndexChanged;
            // 
            // cbAktifPasif
            // 
            cbAktifPasif.AutoSize = true;
            cbAktifPasif.Location = new Point(312, 211);
            cbAktifPasif.Name = "cbAktifPasif";
            cbAktifPasif.Size = new Size(75, 25);
            cbAktifPasif.TabIndex = 3;
            cbAktifPasif.Text = "PASİF";
            cbAktifPasif.UseVisualStyleBackColor = true;
            cbAktifPasif.CheckedChanged += CbAktifPasif_CheckedChanged;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(127, 124);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(260, 81);
            txtAciklama.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 999;
            label2.Text = "Açıklama";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 346);
            Controls.Add(cbAktifPasif);
            Controls.Add(lstListe);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAciklama);
            Controls.Add(txtKategoriAdi);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            Controls.SetChildIndex(txtMessage, 0);
            Controls.SetChildIndex(txtKategoriAdi, 0);
            Controls.SetChildIndex(txtAciklama, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(lstListe, 0);
            Controls.SetChildIndex(cbAktifPasif, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKategoriAdi;
        private Label label1;
        private ListBox lstListe;
        private CheckBox cbAktifPasif;
        private TextBox txtAciklama;
        private Label label2;
    }
}