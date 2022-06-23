
namespace WindowsFormsDB
{
    partial class BusSchedule
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
            this.excursions1DataSet = new WindowsFormsDB.Excursions1DataSet();
            this.excursionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excursionTableAdapter = new WindowsFormsDB.Excursions1DataSetTableAdapters.ExcursionTableAdapter();
            this.b_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.excursionBusDriverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excursionBusDriverTableAdapter = new WindowsFormsDB.Excursions1DataSetTableAdapters.ExcursionBusDriverTableAdapter();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excursionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excursions1DataSet1 = new WindowsFormsDB.Excursions1DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.excursions1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBusDriverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursions1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bus usage schedule for a certain period of time";
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
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(12, 178);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(94, 46);
            this.b_search.TabIndex = 11;
            this.b_search.Text = "Search";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "End date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start date";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(12, 121);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 26);
            this.dateEnd.TabIndex = 8;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(16, 57);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 26);
            this.dateStart.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.excursionIdDataGridViewTextBoxColumn,
            this.busIdDataGridViewTextBoxColumn,
            this.driverIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.excursionBusDriverBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(284, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(872, 440);
            this.dataGridView1.TabIndex = 14;
            // 
            // excursionBusDriverBindingSource
            // 
            this.excursionBusDriverBindingSource.DataMember = "ExcursionBusDriver";
            this.excursionBusDriverBindingSource.DataSource = this.excursions1DataSet;
            // 
            // excursionBusDriverTableAdapter
            // 
            this.excursionBusDriverTableAdapter.ClearBeforeFill = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "excursionId";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // excursionIdDataGridViewTextBoxColumn
            // 
            this.excursionIdDataGridViewTextBoxColumn.DataPropertyName = "excursionId";
            this.excursionIdDataGridViewTextBoxColumn.HeaderText = "excursionId";
            this.excursionIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.excursionIdDataGridViewTextBoxColumn.Name = "excursionIdDataGridViewTextBoxColumn";
            this.excursionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // busIdDataGridViewTextBoxColumn
            // 
            this.busIdDataGridViewTextBoxColumn.DataPropertyName = "busId";
            this.busIdDataGridViewTextBoxColumn.HeaderText = "busId";
            this.busIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.busIdDataGridViewTextBoxColumn.Name = "busIdDataGridViewTextBoxColumn";
            // 
            // driverIdDataGridViewTextBoxColumn
            // 
            this.driverIdDataGridViewTextBoxColumn.DataPropertyName = "driverId";
            this.driverIdDataGridViewTextBoxColumn.HeaderText = "driverId";
            this.driverIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.driverIdDataGridViewTextBoxColumn.Name = "driverIdDataGridViewTextBoxColumn";
            // 
            // excursions1DataSet1
            // 
            this.excursions1DataSet1.DataSetName = "Excursions1DataSet";
            this.excursions1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BusSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BusSchedule";
            this.Text = "BusSchedule";
            this.Load += new System.EventHandler(this.BusSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.excursions1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBusDriverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursions1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Excursions1DataSet excursions1DataSet;
        private System.Windows.Forms.BindingSource excursionBindingSource;
        private Excursions1DataSetTableAdapters.ExcursionTableAdapter excursionTableAdapter;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource excursionBusDriverBindingSource;
        private Excursions1DataSetTableAdapters.ExcursionBusDriverTableAdapter excursionBusDriverTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn excursionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverIdDataGridViewTextBoxColumn;
        private Excursions1DataSet excursions1DataSet1;
    }
}