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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeCustomers F1122 = new EmployeeCustomers();
            F1122.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home F112 = new Home();
            F112.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeCustomersBank Fv1122 = new EmployeeCustomersBank();
            Fv1122.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeAccounts Fv1122 = new EmployeeAccounts();
            Fv1122.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeeLoans jm = new EmployeeLoans();
            jm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateUser jm = new CreateUser();
            jm.Show();
            this.Hide();
        }
    }
}
