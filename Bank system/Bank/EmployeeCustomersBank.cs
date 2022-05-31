using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank
{
    public partial class EmployeeCustomersBank : Form
    {
        public EmployeeCustomersBank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee q3 = new Employee();
            q3.Show();
            this.Hide();
        }

        private void EmployeeCustomersBank_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSysDataSet.CUSTOMER_BANK' table. You can move, or remove it, as needed.
            this.cUSTOMER_BANKTableAdapter.Fill(this.bankSysDataSet.CUSTOMER_BANK);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.cUSTOMER_BANKTableAdapter.Fill(this.bankSysDataSet.CUSTOMER_BANK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO CUSTOMER_BANK VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Add a bank to the customer is Successfully Completed !");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "Update CUSTOMER_BANK SET BANK_ID = '" + textBox2.Text + "' WHERE SSN = '" + textBox1.Text + "'";

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update customer's bank is Successfully Completed !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM CUSTOMER_BANK WHERE SSN = '" + textBox1.Text + "' AND  BANK_ID = '" + textBox2.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Delete a Customer's bank is Successfully Completed !");
        }
    }
}
