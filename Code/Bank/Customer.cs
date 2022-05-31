using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home wuqu = new Home();
            wuqu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerLoan wm = new CustomerLoan();
            wm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateUser yy = new CreateUser();
            yy.Show();
            this.Hide();
        }
    }
}
