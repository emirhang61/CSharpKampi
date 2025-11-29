using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ListeyiYenile()
        {
            using (FinancialCrmDbEntities context = new FinancialCrmDbEntities())
            {
                // DbSet adını Categories olarak düzelttik ve anonim obje kullandık.
                // Artık Lazy Loading'den kaynaklanan hata gelmeyecektir.
                dgvCategories.DataSource = context.Categories
                    .Select(c => new
                    {
                        // Entity'deki property isimlerinizin bu şekilde olduğunu varsayıyoruz.
                        // Eğer Kategori ID sütun adı farklıysa (örneğin Category_ID), burayı düzeltin.
                        ID = c.CategoryId,
                        Ad = c.CategoryName
                    })
                    .ToList();
            }
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // DataGridView'de bir satır seçili olduğundan emin olun
            if (dgvCategories.SelectedRows.Count > 0)
            {
                // Seçili satırdan Kategori ID'sini alın
                int categoryId = (int)dgvCategories.SelectedRows[0].Cells["CategoryId"].Value;

                using (FinancialCrmDbEntities context = new FinancialCrmDbEntities())
                {
                    var categoryToDelete = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

                    if (categoryToDelete != null)
                    {
                        context.Categories.Remove(categoryToDelete);
                        context.SaveChanges();
                        MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListeyiYenile();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FinancialCrmDbEntities context = new FinancialCrmDbEntities())
            {
                Categories newCategory = new Categories();
                // txtCategoryName (TextBox'ın yeni adı)
                newCategory.CategoryName = txtCategoryName.Text;

                context.Categories.Add(newCategory);
                context.SaveChanges();

                MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeyiYenile();
            }
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {

        }
    }
}
