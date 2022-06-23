using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDB
{
    public partial class FinReport : Form
    {
        public FinReport()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker1.ShowUpDown = true;
        }

        private void b_search_Click(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value == null)//start date is later then second
            {
                string message = "Choose month please!";
                string title = "Warning!";
                MessageBox.Show(message, title);
            }
            else
            {
                DateTime dateMonth = dateTimePicker1.Value;


                using (var db = new Excursions1Context())
                {
                    var select = (from x in db.Excursions.AsEnumerable()
                                  join y in db.Payments.AsEnumerable()
                                  on x.excursionId equals y.excursionId
                                  where x.startDate.Month == dateMonth.Month
                                  group x by x.startDate into p
                                 select p).ToDictionary(g=>g.Key,g=>g.ToList())
                                 .Select(x=> new 
                                 { 
                                    Date = x.Key,
                                    CountOfExcursions = x.Value.Count(),
                                    TotalPricePaid = x.Value.Sum(y=>y.Payments.FirstOrDefault()?.paid)
                                 }).ToList();
                    dataGridView1.DataSource = select;
                    dataGridView1.Columns["startDateDataGridViewTextBoxColumn"].DataPropertyName = "Date";
                    dataGridView1.Columns["CountOfExcursions"].DataPropertyName = "CountOfExcursions";
                    dataGridView1.Columns["TotalPricePaid"].DataPropertyName = "TotalPricePaid";

                }
            }
        }
    }
}
