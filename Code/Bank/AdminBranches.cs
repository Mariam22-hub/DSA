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
    public partial class AdminBranches : Form
    {
        public AdminBranches()
        {
            InitializeComponent();
        }

        private void AdminBranches_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSysDataSet.BANK_BRANCH' table. You can move, or remove it, as needed.
            this.bANK_BRANCHTableAdapter.Fill(this.bankSysDataSet.BANK_BRANCH);

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO BANK_BRANCH VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Add a Branch is Successfully Completed !");
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM BANK_BRANCH WHERE BRANCH_NO = '" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Delete a Branch is Successfully Completed !");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SE37CM9\\SQLEXPRESS;Initial Catalog=BankSys;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "Update BANK_BRANCH SET BB_ADDRESS = '" + textBox1.Text + "' , BANK_ID = '" + textBox2.Text + "' WHERE BRANCH_NO = '" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update a Branch is Successfully Completed !");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.bANK_BRANCHTableAdapter.Fill(this.bankSysDataSet.BANK_BRANCH);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin F2f = new Admin();
            F2f.Show();
            this.Hide();
        }
    }
}
