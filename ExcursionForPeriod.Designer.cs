
namespace WindowsFormsDB
{
    partial class ExcursionForPeriod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcursionForPeriod));
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.excursionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excursions1DataSet = new WindowsFormsDB.Excursions1DataSet();
            this.excursionTableAdapter = new WindowsFormsDB.Excursions1DataSetTableAdapters.ExcursionTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.excursionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceKMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countOfCustomersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excursionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursions1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(16, 58);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 26);
            this.dateStart.TabIndex = 0;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(12, 125);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 26);
            this.dateEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "End date";
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(12, 185);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(94, 48);
            this.b_search.TabIndex = 4;
            this.b_search.Text = "Search";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(236, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(930, 474);
            this.dataGridView1.TabIndex = 5;
            // 
            // excursionBindingSource
            // 
            this.excursionBindingSource.DataMember = "Excursion";
            this.excursionBindingSource.DataSource = this.excursions1DataSet;
            // 
            // excursions1DataSet
            // 
            this.excursions1DataSet.DataSetName = "Excursions1DataSet";
            this.excursions1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // excursionTableAdapter
            // 
            this.excursionTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "List of excursions for a certain period of time with price";
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
            this.Payment.DataPropertyName = "distanceKM";
            this.Payment.HeaderText = "Payment";
            this.Payment.MinimumWidth = 8;
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // ExcursionForPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcursionForPeriod";
            this.Text = "ExcursionForPeriod";
            this.Load += new System.EventHandler(this.ExcursionForPeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursions1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Excursions1DataSet excursions1DataSet;
        private System.Windows.Forms.BindingSource excursionBindingSource;
        private Excursions1DataSetTableAdapters.ExcursionTableAdapter excursionTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn excursionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countOfCustomersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn excursionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
    }
}