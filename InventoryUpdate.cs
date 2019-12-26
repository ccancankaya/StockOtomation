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
    public partial class InventoryUpdate : Form
    {

        productDal _productDal = new productDal();

        public int ıd { get; set; }
        public int productCode { get; set; }
        public string productName { get; set; }
        public string barcodeNo { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string category { get; set; }
        public double price { get; set; }
        public int quantityy { get; set; }


        public InventoryUpdate()
        {
            InitializeComponent();
            
        }

        private void InventoryUpdate_Load(object sender, EventArgs e)
        {
            txtCode.Text = productCode.ToString();
            txtName.Text = productName;
            txtBarcode.Text = barcodeNo.ToString();
            txtBrand.Text = brand;
            txtModel.Text = model;
            txtCategory.Text = category;
            txtPrice.Text = price.ToString();
            quantity.Value = quantityy;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = ıd,
                ProductCode = Convert.ToInt32(txtCode.Text),
                BarcodeNo = txtBarcode.Text,
                ProductName = txtName.Text,
                Brand = txtBrand.Text,
                Model = txtModel.Text,
                Category = txtCategory.Text,
                Quantitiy = Convert.ToInt32(quantity.Value),
                Price = Convert.ToDouble(txtPrice.Text)
            });
            Inventory ıv = (Inventory)Application.OpenForms["Inventory"];
            ıv.LoadProducts();
            MessageBox.Show("Stok güncellendi!");

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
