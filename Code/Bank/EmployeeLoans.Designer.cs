namespace Bank
{
    partial class EmployeeLoans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lOANSNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bankSysDataSet = new Bank.BankSysDataSet();
            this.lOANSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lOANSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOANSTableAdapter = new Bank.BankSysDataSetTableAdapters.LOANSTableAdapter();
            this.EMPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 48);
            this.label3.TabIndex = 57;
            this.label3.Text = "Pending Loans";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(503, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 48);
            this.button5.TabIndex = 56;
            this.button5.Text = "Show data";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(15, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 48);
            this.button4.TabIndex = 55;
            this.button4.Text = "Accept";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(165, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 48);
            this.button3.TabIndex = 54;
            this.button3.Text = "Reject";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 52;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 24);
            this.textBox1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Loan no.:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lOANSNODataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.lOANTYPEDataGridViewTextBoxColumn,
            this.aCCOUNTNODataGridViewTextBoxColumn,
            this.EMPID});
            this.dataGridView1.DataSource = this.lOANSBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(319, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(760, 304);
            this.dataGridView1.TabIndex = 47;
            // 
            // lOANSNODataGridViewTextBoxColumn
            // 
            this.lOANSNODataGridViewTextBoxColumn.DataPropertyName = "LOANSNO";
            this.lOANSNODataGridViewTextBoxColumn.HeaderText = "LOANSNO";
            this.lOANSNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOANSNODataGridViewTextBoxColumn.Name = "lOANSNODataGridViewTextBoxColumn";
            this.lOANSNODataGridViewTextBoxColumn.ReadOnly = true;
            this.lOANSNODataGridViewTextBoxColumn.Width = 125;
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            this.aMOUNTDataGridViewTextBoxColumn.Width = 125;
            // 
            // lOANTYPEDataGridViewTextBoxColumn
            // 
            this.lOANTYPEDataGridViewTextBoxColumn.DataPropertyName = "LOAN_TYPE";
            this.lOANTYPEDataGridViewTextBoxColumn.HeaderText = "LOAN_TYPE";
            this.lOANTYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOANTYPEDataGridViewTextBoxColumn.Name = "lOANTYPEDataGridViewTextBoxColumn";
            this.lOANTYPEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCCOUNTNODataGridViewTextBoxColumn
            // 
            this.aCCOUNTNODataGridViewTextBoxColumn.DataPropertyName = "ACCOUNTNO";
            this.aCCOUNTNODataGridViewTextBoxColumn.HeaderText = "ACCOUNTNO";
            this.aCCOUNTNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCOUNTNODataGridViewTextBoxColumn.Name = "aCCOUNTNODataGridViewTextBoxColumn";
            this.aCCOUNTNODataGridViewTextBoxColumn.Width = 125;
            // 
            // lOANSBindingSource2
            // 
            this.lOANSBindingSource2.DataMember = "LOANS";
            this.lOANSBindingSource2.DataSource = this.bankSysDataSet;
            // 
            // bankSysDataSet
            // 
            this.bankSysDataSet.DataSetName = "BankSysDataSet";
            this.bankSysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOANSBindingSource1
            // 
            this.lOANSBindingSource1.DataMember = "LOANS";
            this.lOANSBindingSource1.DataSource = this.bankSysDataSet;
            // 
            // lOANSBindingSource
            // 
            this.lOANSBindingSource.DataMember = "LOANS";
            this.lOANSBindingSource.DataSource = this.bankSysDataSet;
            // 
            // lOANSTableAdapter
            // 
            this.lOANSTableAdapter.ClearBeforeFill = true;
            // 
            // EMPID
            // 
            this.EMPID.DataPropertyName = "EMPID";
            this.EMPID.HeaderText = "EMPID";
            this.EMPID.MinimumWidth = 6;
            this.EMPID.Name = "EMPID";
            this.EMPID.Width = 125;
            // 
            // EmployeeLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeLoans";
            this.Text = "EmployeeLoans";
            this.Load += new System.EventHandler(this.EmployeeLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BankSysDataSet bankSysDataSet;
        private System.Windows.Forms.BindingSource lOANSBindingSource;
        private BankSysDataSetTableAdapters.LOANSTableAdapter lOANSTableAdapter;
        private System.Windows.Forms.BindingSource lOANSBindingSource1;
        private System.Windows.Forms.BindingSource lOANSBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANSNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPID;
    }
}