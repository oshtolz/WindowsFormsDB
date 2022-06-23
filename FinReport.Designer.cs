
namespace WindowsFormsDB
{
    partial class FinReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfExcursions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPricePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.excursions1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Financial report for the month";
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDateDataGridViewTextBoxColumn,
            this.CountOfExcursions,
            this.TotalPricePaid});
            this.dataGridView1.DataSource = this.excursionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(236, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(930, 450);
            this.dataGridView1.TabIndex = 12;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // CountOfExcursions
            // 
            this.CountOfExcursions.HeaderText = "Count Of Excursions";
            this.CountOfExcursions.MinimumWidth = 8;
            this.CountOfExcursions.Name = "CountOfExcursions";
            // 
            // TotalPricePaid
            // 
            this.TotalPricePaid.HeaderText = "Total price paid";
            this.TotalPricePaid.MinimumWidth = 8;
            this.TotalPricePaid.Name = "TotalPricePaid";
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(12, 136);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(94, 46);
            this.b_search.TabIndex = 11;
            this.b_search.Text = "Search";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose month:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // FinReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 517);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FinReport";
            this.Text = "FinReport";
            ((System.ComponentModel.ISupportInitialize)(this.excursions1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Excursions1DataSet excursions1DataSet;
        private System.Windows.Forms.BindingSource excursionBindingSource;
        private Excursions1DataSetTableAdapters.ExcursionTableAdapter excursionTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOfExcursions;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPricePaid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}