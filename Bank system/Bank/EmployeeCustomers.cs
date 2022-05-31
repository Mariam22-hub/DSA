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
    public partial class EmployeeCustomers : Form
    {
        public EmployeeCustomers()
        {
            InitializeComponent();
        }

        private void EmployeeCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSysDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.bankSysDataSet.CUSTOMER);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee F2aq = new Employee();
            F2aq.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO CUSTOMER VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Add a Customer is Successfully Completed !");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "Update CUSTOMER SET CUSTOMER_ADDRESS = '" + textBox2.Text + "' , CUSTOMER_NAME = '" + textBox3.Text + "' , PHONE_NO = '" + textBox4.Text + "' , CUSTOMER_LNAME = '" + textBox5.Text + "' WHERE SSN = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update a Customer is Successfully Completed !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM CUSTOMER WHERE SSN = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Delete a Customer is Successfully Completed !");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Fill(this.bankSysDataSet.CUSTOMER);
        }
    }
}
