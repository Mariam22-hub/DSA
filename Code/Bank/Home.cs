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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin F2 = new Admin();
            F2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee qq = new Employee();
            qq.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer qq = new Customer();
            qq.Show();
            this.Hide();
        }
    }
}
