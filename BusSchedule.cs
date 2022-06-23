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
    public partial class BusSchedule : Form
    {
        public BusSchedule()
        {
            InitializeComponent();
        }

        private void BusSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'excursions1DataSet.ExcursionBusDriver' table. You can move, or remove it, as needed.
            this.excursionBusDriverTableAdapter.Fill(this.excursions1DataSet.ExcursionBusDriver);

        }

        private void b_search_Click(object sender, EventArgs e)
        {
            DateTime start = dateStart.Value;
            DateTime end = dateEnd.Value;
            if (DateTime.Compare(start, end) > 0)//start date is later then second
            {
                string message = "Start date must be earlier then end date!";
                string title = "Warning!";
                MessageBox.Show(message, title);
            }
            else
            {
                using (var db = new Excursions1Context())
                {
                    var select = (from x in db.ExcursionBusDrivers.AsEnumerable()
                                  join y in db.Excursions.AsEnumerable()
                                  on x.excursionId equals y.excursionId
                                  where y.startDate <= end && y.startDate >= start
                                  select new
                                  {
                                      excursionId = x.excursionId,
                                      busId = x.busId,
                                      driverId = x.driverId,
                                      Date = y.startDate
                                  }).ToList();
                    dataGridView1.DataSource = select;
                    dataGridView1.Columns["Date"].DataPropertyName = "Date";
                    dataGridView1.Columns["Date"].Visible = true;
                }
            }
        }
    }
}
