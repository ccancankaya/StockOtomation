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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        productDal _productDal = new productDal();

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TxtCode_Click(object sender, EventArgs e)
        {
            txtCode.Font = new Font(txtCode.Font.FontFamily, 14);
            txtCode.Text = "";          
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtName.Font = new Font(txtName.Font.FontFamily,14);
        }

        private void TxtBarcode_Enter(object sender, EventArgs e)
        {
            txtBarcode.Text = "";
            txtBarcode.Font = new Font(txtBarcode.Font.FontFamily,14);
        }

        private void TxtBrand_Enter(object sender, EventArgs e)
        {
            txtBrand.Text = "";
            txtBrand.Font = new Font(txtBrand.Font.FontFamily,14);
        }

        private void TxtModel_Enter(object sender, EventArgs e)
        {
            txtModel.Text = "";
            txtModel.Font = new Font(txtModel.Font.FontFamily,14);
        }

        private void TxtCategory_Enter(object sender, EventArgs e)
        {
            txtCategory.Text = "";
            txtCategory.Font = new Font(txtCategory.Font.FontFamily,14);
        }

        private void TxtPrice_Enter(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtPrice.Font = new Font(txtPrice.Font.FontFamily,14);
        }

        private void BtnBarcode_Click(object sender, EventArgs e)
        {
            var form = new createBarcode();
            form.Show();
        }

        public string barcode { get; set; }

        public void TextboxFill()
        {
            txtBarcode.Text = barcode;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product

            {
                ProductCode = Convert.ToInt32(txtCode.Text),
                ProductName = txtName.Text,
                BarcodeNo =txtBarcode.Text,
                Brand = txtBrand.Text,
                Model=txtModel.Text,
                Category=txtCategory.Text,
                Price=Convert.ToDouble(txtPrice.Text),
                Quantitiy=Convert.ToInt32(quantity.Value)

            });

            //If we want to update gridView when product added, we can use this code
            Inventory ıv = (Inventory)Application.OpenForms["Inventory"];
            ıv.LoadProducts();
            ıv.CountProduct();
            MessageBox.Show("Stok kartı eklendi!");


              
        }
    }
}
