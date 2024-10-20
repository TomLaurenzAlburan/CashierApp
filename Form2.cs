using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form1
    {
        private Cashier cashman;
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TextUser.Text;
            string password = TextPass.Text;

            if (username == "Riku" && password == "ItsmeRiku")
            {
                Cashier cashier = new Cashier(username, password, "Riku", "ItsmeRiku");

                MessageBox.Show("Welcome " + cashier.FullName);


                this.Hide();
                frmPurchaseDiscountedItem form1 = new frmPurchaseDiscountedItem();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        
    }
}
