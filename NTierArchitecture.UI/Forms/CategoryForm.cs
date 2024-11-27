using NTierArchitecture.Entities.Models;
using NTierArchitecture.UI.Tools;

namespace NTierArchitecture.UI.Forms
{
    public partial class CategoryForm : BaseForm
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        #region GLOBALS
        private Category? secilenCategory;
        #endregion

        #region EVENTS
        private void CategoryForm_Load(object sender, EventArgs e) { GetAllCategories(); }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Category newCategory = new()
                {
                    Name = txtKategoriAdi.Text,
                    Description = txtAciklama.Text,
                    IsActive = cbAktifPasif.Checked
                };
                FP.CategoryService?.Create(newCategory);
                GetAllCategories();
                FP.FormClear(this);
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenCategory != null)
                {
                    FP.CategoryService?.Delete(secilenCategory.ID);
                    GetAllCategories();
                }
                FP.ShowErrorInTxt(txtMessage);
                FP.FormClear(this);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        protected override void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                GetAllCategories();
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenCategory != null)
                {
                    secilenCategory.Name = txtKategoriAdi.Text;
                    secilenCategory.Description = txtAciklama.Text;
                    secilenCategory.IsActive = cbAktifPasif.Checked;
                    FP.CategoryService?.Update(secilenCategory);
                    GetAllCategories();
                    FP.FormClear(this);
                }
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        private void CbAktifPasif_CheckedChanged(object sender, EventArgs e)
        {
            cbAktifPasif.Text = cbAktifPasif.Checked ? "AKTİF" : "PASİF";
        }
        private void LstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstListe.SelectedIndex != -1)
                {
                    secilenCategory = (Category?)lstListe.SelectedItem;
                    txtAciklama.Text = secilenCategory?.Description;
                    txtKategoriAdi.Text = secilenCategory?.Name;
                    cbAktifPasif.Checked = secilenCategory!.IsActive;
                }
                FP.ShowErrorInTxt(txtMessage);
            }
            catch (Exception ex)
            {
                FP.ShowErrorInTxt(txtMessage, ex);
            }
        }
        #endregion

        #region METHODS
        private void GetAllCategories()
        {
            FP.UpdateListBox(lstListe, "ID", "Name", FP.CategoryService?.GetAll()!, LstListe_SelectedIndexChanged!);
        }
        #endregion
    }
}
