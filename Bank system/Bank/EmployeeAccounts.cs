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
    public partial class EmployeeAccounts : Form
    {
        public EmployeeAccounts()
        {
            InitializeComponent();
        }

        private void EmployeeAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSysDataSet.ACCOUNT' table. You can move, or remove it, as needed.
            this.aCCOUNTTableAdapter.Fill(this.bankSysDataSet.ACCOUNT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee wuu = new Employee();
            wuu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.aCCOUNTTableAdapter.Fill(this.bankSysDataSet.ACCOUNT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO ACCOUNT VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Add an account is Successfully Completed !");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "Update ACCOUNT SET A_TYPE = '" + textBox2.Text + "' , SSN = '" + textBox3.Text + "' , BALANCE = '" + textBox4.Text + "' WHERE ACCOUNTNO = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update an account is Successfully Completed !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM ACCOUNT WHERE ACCOUNTNO = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update an account is Successfully Completed !");
        }
    }
}
