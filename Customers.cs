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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        customerDal _customerDal = new customerDal();

        public void LoadCustomers()
        {
            customerList.DataSource = _customerDal.GetAll();
        }

        private void SearchProduct(string key)
        {
            customerList.DataSource = _customerDal.GetAll().Where(c => c.CustomerName.ToLower().Contains(key.ToLower())).ToList();
        }

        private void TxtCustomerName_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
        }

        private void TxtCustomerCode_Click(object sender, EventArgs e)
        {
            txtCustomerCode.Text = "";
        }

        private void TxtCustomerNumber_Click(object sender, EventArgs e)
        {
            txtCustomerNumber.Text = "";
        }

        private void TxtCustomerAddress_Click(object sender, EventArgs e)
        {
            txtCustomerAddress.Text = "";
        }

        private void TxtCustomerNa_Click(object sender, EventArgs e)
        {
            txtCustomerNa.Text = "";
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            this.customerList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.customerList.Columns[0].HeaderText = "Müşteri ID";
            this.customerList.Columns[1].HeaderText = "Müşteri Kodu";
            this.customerList.Columns[2].HeaderText = "Müşteri Adı";
            this.customerList.Columns[3].HeaderText = "Numara";
            this.customerList.Columns[4].HeaderText = "Adres";
            this.customerList.Columns[5].HeaderText = "Müşteri tipi";

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _customerDal.Add(new Customer
            {
                CustomerCode = Convert.ToInt32(txtCustomerCode.Text),
                CustomerName = txtCustomerNa.Text,
                Number = Convert.ToInt32(txtCustomerNumber.Text),
                Address = txtCustomerAddress.Text,
                Type = cmbType.SelectedItem.ToString()
            });
            LoadCustomers();
            MessageBox.Show("Müşteri eklendi!");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _customerDal.Delete(new Customer
            {
                Id = Convert.ToInt32(customerList.CurrentRow.Cells[0].Value)
            });
            LoadCustomers();
            MessageBox.Show("Müşteri silindi!");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _customerDal.Update(new Customer
            {
                Id = Convert.ToInt32(customerList.CurrentRow.Cells[0].Value),
                CustomerCode = Convert.ToInt32(txtCustomerCode.Text),
                CustomerName = txtCustomerNa.Text,
                Number = Convert.ToInt32(txtCustomerNumber.Text),
                Address = txtCustomerAddress.Text,
                Type = cmbType.SelectedItem.ToString()
            });
            LoadCustomers();
            MessageBox.Show("Müşteri güncellendi!");
        }

        private void CustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerCode.Text = customerList.SelectedRows[0].Cells[1].Value.ToString();
            txtCustomerNa.Text = customerList.SelectedRows[0].Cells[2].Value.ToString();
            txtCustomerNumber.Text = customerList.SelectedRows[0].Cells[3].Value.ToString();
            txtCustomerAddress.Text = customerList.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void TxtCustomerName_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(txtCustomerName.Text);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var key = cmbCustomerType.SelectedItem.ToString();
            customerList.DataSource = _customerDal.GetAll().Where(c => c.Type == key).ToList();
        }
    }
}
