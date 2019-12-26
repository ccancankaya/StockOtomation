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
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var inventory = new Inventory();
            inventory.TopLevel = false;
            mainPanel.Controls.Add(inventory);
            inventory.Show();
            inventory.Dock = DockStyle.Fill;
            inventory.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(pnlAna);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var form = new Customers();
            form.TopLevel = false;
            mainPanel.Controls.Add(form);
            form.Show();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
        }

        private void BtnCasa_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var form = new Cariler();
            form.TopLevel = false;
            mainPanel.Controls.Add(form);
            form.Show();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
        }

        private void BtnCurrent_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var form = new Finance();
            form.TopLevel = false;
            mainPanel.Controls.Add(form);
            form.Show();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
        }

       
    }
}
