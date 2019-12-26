using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakKayıt
{
    public partial class createBarcode : Form
    {
        public createBarcode()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string BarcodeNo;
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument(); //for write

            Ean13Barcode2005.Ean13 barcode = new Ean13Barcode2005.Ean13();

            barcode.CountryCode = txtCountryCode.Text;
            barcode.ManufacturerCode = txtCompanyCode.Text;
            barcode.ProductCode = txtProductCode.Text;
            lblBarcodeNo.Text = barcode.CountryCode + barcode.ManufacturerCode + barcode.ProductCode;
            BarcodeNo= barcode.CountryCode + barcode.ManufacturerCode + barcode.ProductCode;
            picBarcode.Image = barcode.CreateBitmap();

            AddProduct ap = (AddProduct)Application.OpenForms["AddProduct"];
            ap.barcode = BarcodeNo;
            ap.TextboxFill();
            


        }
        private void TxtCountryCode_Click(object sender, EventArgs e)
        {
            txtCountryCode.Text = "";
        }
        private void TxtCompanyCode_Enter(object sender, EventArgs e)
        {
            txtCompanyCode.Text = "";
        }

        private void TxtProductCode_Enter(object sender, EventArgs e)
        {
            txtProductCode.Text = "";
        }

        private void CreateBarcode_Load(object sender, EventArgs e)
        {
            this.Location = new Point(600,500);
        }
    }
}
