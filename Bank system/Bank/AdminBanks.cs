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
    public partial class AdminBanks : Form
    {
        public AdminBanks()
        {
            InitializeComponent();
        }

        private void AdminBanks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSysDataSet.BANK' table. You can move, or remove it, as needed.
            this.bANKTableAdapter.Fill(this.bankSysDataSet.BANK);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO BANK VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Add a Bank is Successfully Completed !");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "Update BANK SET BANK_NAME = '" + textBox1.Text + "' , BANK_ADDRESS = '" + textBox2.Text + "' WHERE BANK_ID = '" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update a Bank is Successfully Completed !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM BANK WHERE BANK_ID = '" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Delete a Bank is Successfully Completed !");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.bANKTableAdapter.Fill(this.bankSysDataSet.BANK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin F2 = new Admin();
            F2.Show();
            this.Hide();
        }
    }
}
