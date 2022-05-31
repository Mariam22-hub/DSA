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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home F112 = new Home();
            F112.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminBanks F2 = new AdminBanks();
            F2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminBranches F32 = new AdminBranches();
            F32.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
