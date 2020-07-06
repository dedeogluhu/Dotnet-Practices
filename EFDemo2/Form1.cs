using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EFDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void LoadProductsBySearch(string key)
        {
            using (BankAppContext context = new BankAppContext())
            {
                dgwProducts.DataSource = context.Products.Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _productDal.AddProduct(new Product
            {
                Name = tbxProductName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            _productDal.UpdateProduct(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxUpdateName.Text,
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxUpdateStockAmount.Text)
            });
            LoadProducts();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            _productDal.RemoveProduct(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
        }

        private void tbxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSearchProduct.Text))
            {
                LoadProducts();
            }
            else
            {
                LoadProductsBySearch(tbxSearchProduct.Text);
            }
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateUnitPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateStockAmount.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
