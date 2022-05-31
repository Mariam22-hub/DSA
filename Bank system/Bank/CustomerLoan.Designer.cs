namespace Bank
{
    partial class CustomerLoan
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lOANSNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSysDataSet = new Bank.BankSysDataSet();
            this.bankSysDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOANSTableAdapter = new Bank.BankSysDataSetTableAdapters.LOANSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSysDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(136, 261);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 24);
            this.textBox4.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "LOAN no.:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 24);
            this.textBox3.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 48);
            this.label3.TabIndex = 57;
            this.label3.Text = "Request loans";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(422, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(298, 48);
            this.button5.TabIndex = 56;
            this.button5.Text = "Show data";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(104, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 48);
            this.button4.TabIndex = 55;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(202, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 48);
            this.button3.TabIndex = 54;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 48);
            this.button2.TabIndex = 53;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 52;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 24);
            this.textBox2.TabIndex = 51;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 24);
            this.textBox1.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Account no.:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lOANSNODataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.lOANTYPEDataGridViewTextBoxColumn,
            this.aCCOUNTNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lOANSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(308, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(531, 304);
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
            // lOANSBindingSource
            // 
            this.lOANSBindingSource.DataMember = "LOANS";
            this.lOANSBindingSource.DataSource = this.bankSysDataSet;
            // 
            // bankSysDataSet
            // 
            this.bankSysDataSet.DataSetName = "BankSysDataSet";
            this.bankSysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankSysDataSetBindingSource
            // 
            this.bankSysDataSetBindingSource.DataSource = this.bankSysDataSet;
            this.bankSysDataSetBindingSource.Position = 0;
            // 
            // lOANSTableAdapter
            // 
            this.lOANSTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerLoan";
            this.Text = "CustomerLoan";
            this.Load += new System.EventHandler(this.CustomerLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSysDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bankSysDataSetBindingSource;
        private BankSysDataSet bankSysDataSet;
        private System.Windows.Forms.BindingSource lOANSBindingSource;
        private BankSysDataSetTableAdapters.LOANSTableAdapter lOANSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANSNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTNODataGridViewTextBoxColumn;
    }
}