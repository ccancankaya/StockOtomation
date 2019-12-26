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
    public partial class Finance : Form
    {
        moneyDal _moneyDal = new moneyDal();
        DateTime time = new DateTime();

        public Finance()
        {
            InitializeComponent();
        }
       
        public void LoadProcesses()
        {
           listOfCash.DataSource= _moneyDal.GetAll();
        }

        private void Finance_Load(object sender, EventArgs e)
        {
            LoadProcesses();
            this.listOfCash.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.listOfCash.Columns[0].Visible = false;
            this.listOfCash.Columns[1].HeaderText = "İşlem türü";
            this.listOfCash.Columns[2].HeaderText = "Ödeme yöntemi";
            this.listOfCash.Columns[3].HeaderText = "Cari adı";
            this.listOfCash.Columns[4].HeaderText = "Tutar";
            this.listOfCash.Columns[5].HeaderText = "Açıklama";
            this.listOfCash.Columns[6].HeaderText = "İşlem tarihi";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _moneyDal.Add(new Money
            {
                Processtype = cbType.SelectedItem.ToString(),
                PaymentMethod=cbSellType.SelectedItem.ToString(),
                CariName=txtName.Text,
                Price=Convert.ToDouble( txtCost.Text),
                Description=txtDescription.Text,
                ProcessDate=DateTime.Now
            }) ;
            LoadProcesses();
            MessageBox.Show("İşlem yapıldı!");
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            listOfCash.DataSource = _moneyDal.GetByToday();
        }

        private void BtnWeek_Click(object sender, EventArgs e)
        {
            listOfCash.DataSource = _moneyDal.GetByThisWeek();
        }

        private void BtnMounth_Click(object sender, EventArgs e)
        {
            listOfCash.DataSource = _moneyDal.GetByThisMonth();
        }

        private void BtnYear_Click(object sender, EventArgs e)
        {
            listOfCash.DataSource = _moneyDal.GetByThisYear();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            DateTime d1 = dtpFirst.Value;
            DateTime d2 = dtpLast.Value;
            listOfCash.DataSource = _moneyDal.GetByDate(d1, d2);
        }

        private void ListOfCash_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbType.Text = listOfCash.SelectedRows[0].Cells[1].Value.ToString();
            cbSellType.Text = listOfCash.SelectedRows[0].Cells[2].Value.ToString();
            txtName.Text = listOfCash.SelectedRows[0].Cells[3].Value.ToString();
            txtCost.Text = listOfCash.SelectedRows[0].Cells[4].Value.ToString();
            txtDescription.Text = listOfCash.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _moneyDal.Delete(new Money
            {
                Id = Convert.ToInt32(listOfCash.SelectedRows[0].Cells[0].Value)
            });
            LoadProcesses();
            MessageBox.Show("İşlem silindi!");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _moneyDal.Update(new Money
            {
                Id = Convert.ToInt32(listOfCash.SelectedRows[0].Cells[0].Value),
                Processtype = cbType.SelectedItem.ToString(),
                PaymentMethod = cbSellType.SelectedItem.ToString(),
                CariName = txtName.Text,
                Price = Convert.ToDouble(txtCost.Text),
                Description = txtDescription.Text,
                ProcessDate = DateTime.Now
            });
            LoadProcesses();
            MessageBox.Show("İşlem güncellendi");
        }
    }
}
