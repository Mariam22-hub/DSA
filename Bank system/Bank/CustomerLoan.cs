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
    public partial class CustomerLoan : Form
    {
        public CustomerLoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer wmq = new Customer();
            wmq.Show();
            this.Hide();
        }

        private void CustomerLoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSysDataSet.LOANS' table. You can move, or remove it, as needed.
            this.lOANSTableAdapter.Fill(this.bankSysDataSet.LOANS);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO LOANS VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "',5)";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Request loan is Successfully Completed !");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.lOANSTableAdapter.Fill(this.bankSysDataSet.LOANS);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "Update LOANS SET AMOUNT = '" + textBox2.Text + "' , LOAN_TYPE = '" + textBox3.Text + "' , ACCOUNTNO = '" + textBox4.Text + "' WHERE LOANSNO = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update loan is Successfully Completed !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM LOANS WHERE LOANSNO = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Delete loan is Successfully Completed !");
        }
    }
}
