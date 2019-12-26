using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakKayıt
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        productDal _productDal = new productDal();

        public void LoadProducts()
        {
            ınventoryTable.DataSource = _productDal.GetAll();
        }

        public void CountProduct()
        {
            lblCount.Text = ınventoryTable.RowCount.ToString();
        }

        private void SearchProduct(string key)
        {
            ınventoryTable.DataSource = _productDal.GetAll().Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
            //var result = _productDal.GetByName(key);
        }
        private void SearchProduct(int code)
        {
            ınventoryTable.DataSource = _productDal.GetByCode(code).ToString().ToList();
            //var result = _productDal.GetByName(key);
        }
        private void TxtProductCodeorName_Enter(object sender, EventArgs e)
        {
            txtProductCodeorName.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form = new AddProduct();
            form.Show();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            LoadProducts();
            CountProduct();
            this.ınventoryTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ınventoryTable.Columns[0].Visible = false;
            this.ınventoryTable.Columns[1].HeaderText = "Ürün kodu";
            this.ınventoryTable.Columns[2].HeaderText = "Barkod no";
            this.ınventoryTable.Columns[3].HeaderText = "Ürün adı";
            this.ınventoryTable.Columns[4].HeaderText = "Marka";
            this.ınventoryTable.Columns[5].HeaderText = "Model";
            this.ınventoryTable.Columns[6].HeaderText = "kategori";
            this.ınventoryTable.Columns[7].HeaderText = "Adet";
            this.ınventoryTable.Columns[8].HeaderText = "Fiyat";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void TxtProductCodeorName_TextChanged(object sender, EventArgs e)
        {
            var key = txtProductCodeorName.Text;
            //if (Convert.ToInt32(key))
            //{

            //}
            SearchProduct(txtProductCodeorName.Text);
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }
        public int ıd;
        private void InventoryTable_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                int row = ınventoryTable.HitTest(e.X, e.Y).RowIndex;
                if (row>-1)
                {
                    ınventoryTable.Rows[row].Selected = true;
                     ıd = Convert.ToInt32(ınventoryTable.Rows[row].Cells[0].Value);
                    
                }
            }
        }

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = ıd
            }) ;
            LoadProducts();
            CountProduct();
            MessageBox.Show("Stok silindi!");
        }
   
        private void GüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            InventoryUpdate ıp = new InventoryUpdate();
            ıp.ıd = Convert.ToInt32(ınventoryTable.SelectedRows[0].Cells[0].Value.ToString());
            ıp.productCode = Convert.ToInt32(ınventoryTable.SelectedRows[0].Cells[1].Value.ToString());
            ıp.productName = ınventoryTable.SelectedRows[0].Cells[3].Value.ToString();
            ıp.barcodeNo = ınventoryTable.SelectedRows[0].Cells[2].Value.ToString();
            ıp.brand = ınventoryTable.SelectedRows[0].Cells[4].Value.ToString();
            ıp.model = ınventoryTable.SelectedRows[0].Cells[5].Value.ToString();
            ıp.category = ınventoryTable.SelectedRows[0].Cells[6].Value.ToString();
            ıp.price = Convert.ToDouble(ınventoryTable.SelectedRows[0].Cells[8].Value);
            ıp.quantityy = Convert.ToInt32(ınventoryTable.SelectedRows[0].Cells[7].Value);
            ıp.ShowDialog();
        }
    }
}
