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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        userDal _userDal = new userDal();
        private void PanelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblClose_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (chxRemember.Checked)
            {
                Properties.Settings.Default["uName"] = txtUser.Text;
                Properties.Settings.Default["uPass"] = txtPass.Text;
            }
           
            Properties.Settings.Default.Save();

            if (_userDal.verifyUser(txtUser.Text, txtPass.Text))
            {
                MainForm mn = new MainForm();
                this.Hide();
                mn.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Text = Properties.Settings.Default["uName"].ToString();
            txtPass.Text = Properties.Settings.Default["uPass"].ToString();
            if (txtUser.Text.Count() > 1)
            {
                chxRemember.Checked = true;
            }
        }
    }
}
