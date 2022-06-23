
namespace WindowsFormsDB
{
    partial class CustomerPay
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.excursions1DataSet = new WindowsFormsDB.Excursions1DataSet();
            this.excursionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excursionTableAdapter = new WindowsFormsDB.Excursions1DataSetTableAdapters.ExcursionTableAdapter();
            this.excursionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceKMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countOfCustomersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excursionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_search = new System.Windows.Forms.Button();
            this.busMarkTableAdapter1 = new WindowsFormsDB.Excursions1DataSetTableAdapters.BusMarkTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsDB.Excursions1DataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursions1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientBindingSource;
            this.comboBox1.DisplayMember = "clientId";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 27);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose client ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(494, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clients certificate indicating the ordered excursions and payments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.excursionIdDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.distanceKMDataGridViewTextBoxColumn,
            this.countOfCustomersDataGridViewTextBoxColumn,
            this.excursionTypeDataGridViewTextBoxColumn,
            this.Payment});
            this.dataGridView1.DataSource = this.excursionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(238, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(928, 409);
            this.dataGridView1.TabIndex = 8;
            // 
            // excursions1DataSet
            // 
            this.excursions1DataSet.DataSetName = "Excursions1DataSet";
            this.excursions1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // excursionBindingSource
            // 
            this.excursionBindingSource.DataMember = "Excursion";
            this.excursionBindingSource.DataSource = this.excursions1DataSet;
            // 
            // excursionTableAdapter
            // 
            this.excursionTableAdapter.ClearBeforeFill = true;
            // 
            // excursionIdDataGridViewTextBoxColumn
            // 
            this.excursionIdDataGridViewTextBoxColumn.DataPropertyName = "excursionId";
            this.excursionIdDataGridViewTextBoxColumn.HeaderText = "excursionId";
            this.excursionIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.excursionIdDataGridViewTextBoxColumn.Name = "excursionIdDataGridViewTextBoxColumn";
            this.excursionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // distanceKMDataGridViewTextBoxColumn
            // 
            this.distanceKMDataGridViewTextBoxColumn.DataPropertyName = "distanceKM";
            this.distanceKMDataGridViewTextBoxColumn.HeaderText = "distanceKM";
            this.distanceKMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.distanceKMDataGridViewTextBoxColumn.Name = "distanceKMDataGridViewTextBoxColumn";
            // 
            // countOfCustomersDataGridViewTextBoxColumn
            // 
            this.countOfCustomersDataGridViewTextBoxColumn.DataPropertyName = "countOfCustomers";
            this.countOfCustomersDataGridViewTextBoxColumn.HeaderText = "countOfCustomers";
            this.countOfCustomersDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.countOfCustomersDataGridViewTextBoxColumn.Name = "countOfCustomersDataGridViewTextBoxColumn";
            // 
            // excursionTypeDataGridViewTextBoxColumn
            // 
            this.excursionTypeDataGridViewTextBoxColumn.DataPropertyName = "excursionType";
            this.excursionTypeDataGridViewTextBoxColumn.HeaderText = "excursionType";
            this.excursionTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.excursionTypeDataGridViewTextBoxColumn.Name = "excursionTypeDataGridViewTextBoxColumn";
            // 
            // Payment
            // 
            this.Payment.DataPropertyName = "excursionId";
            this.Payment.HeaderText = "Payment";
            this.Payment.MinimumWidth = 8;
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(12, 147);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(94, 46);
            this.b_search.TabIndex = 9;
            this.b_search.Text = "Search";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // busMarkTableAdapter1
            // 
            this.busMarkTableAdapter1.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.excursions1DataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 517);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CustomerPay";
            this.Text = "CustomerPay";
            this.Load += new System.EventHandler(this.CustomerPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursions1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Excursions1DataSet excursions1DataSet;
        private System.Windows.Forms.BindingSource excursionBindingSource;
        private Excursions1DataSetTableAdapters.ExcursionTableAdapter excursionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn excursionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countOfCustomersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn excursionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.Button b_search;
        private Excursions1DataSetTableAdapters.BusMarkTableAdapter busMarkTableAdapter1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Excursions1DataSetTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}