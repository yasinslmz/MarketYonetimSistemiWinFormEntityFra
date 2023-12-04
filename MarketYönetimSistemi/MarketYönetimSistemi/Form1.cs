using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MarketYönetimSistemi
{
    public partial class Form1 : Form
    {
        UserCrud userCrud = new UserCrud();
        public static int currentUserId;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginstatuslabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            this.Hide();
            User user = new User()
            {
                Email = textBox1.Text,
                Password = PasswordTxt.Text,
            };


            User foundUser = userCrud.GetByIntros(user);

            if (foundUser != null)
            {
                if (foundUser.Id == 1)
                {
                    MessageBox.Show("Admin hoşgeldiniz");
                    this.Hide();
                    AdminDashboard admin = new AdminDashboard();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Müşteri hoşgeldiniz");
                    this.Hide();
                    currentUserId = foundUser.Id;
                    CustomerDashboard customer = new CustomerDashboard();
                    customer.Show();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
