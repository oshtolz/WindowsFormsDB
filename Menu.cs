using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace WindowsFormsDB
{
    public partial class Menu : Form
    {

        string ConnectionString = @"Data Source=DESKTOP-1479TM1;Initial Catalog=Excursions1;Integrated Security=True";

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'excursions1DataSet.ExcursionBus' table. You can move, or remove it, as needed.
            this.excursionBusTableAdapter.Fill(this.excursions1DataSet.ExcursionBus);
            // TODO: This line of code loads data into the 'excursions1DataSet.ExcursionClient' table. You can move, or remove it, as needed.
            this.excursionClientTableAdapter.Fill(this.excursions1DataSet.ExcursionClient);
            // TODO: This line of code loads data into the 'excursions1DataSet.ExcursionBusDriver' table. You can move, or remove it, as needed.
            this.excursionBusDriverTableAdapter.Fill(this.excursions1DataSet.ExcursionBusDriver);
            // TODO: This line of code loads data into the 'excursions1DataSet.BusMark' table. You can move, or remove it, as needed.
            this.busMarkTableAdapter.Fill(this.excursions1DataSet.BusMark);
            // TODO: This line of code loads data into the 'excursions1DataSet.ExcursionType' table. You can move, or remove it, as needed.
            this.excursionTypeTableAdapter.Fill(this.excursions1DataSet.ExcursionType);
            // TODO: This line of code loads data into the 'excursions1DataSet.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.excursions1DataSet.Driver);
            // TODO: This line of code loads data into the 'excursions1DataSet.Bus' table. You can move, or remove it, as needed.
            this.busTableAdapter.Fill(this.excursions1DataSet.Bus);
            // TODO: This line of code loads data into the 'excursions1DataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.excursions1DataSet.Payment);
            // TODO: This line of code loads data into the 'excursions1DataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.excursions1DataSet.Client);
            // TODO: This line of code loads data into the 'excursions1DataSet.Excursion' table. You can move, or remove it, as needed.
            this.excursionTableAdapter.Fill(this.excursions1DataSet.Excursion);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.excursionTableAdapter.FillBy(this.excursions1DataSet.Excursion);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //--------------------------------- SAVE - BUTTONS ----------------------------------------
        //excursion save
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.excursionTableAdapter.Update(this.excursions1DataSet.Excursion);
        }
        //client save
        private void saveToolStripButton1_Click(object sender, EventArgs e)
        {
            this.clientTableAdapter.Update(this.excursions1DataSet.Client);

        }
        //payment save
        private void saveToolStripButton2_Click(object sender, EventArgs e)
        {
            this.paymentTableAdapter.Update(this.excursions1DataSet.Payment);
        }
        //bus save 
        private void saveToolStripButton3_Click(object sender, EventArgs e)
        {
            this.busTableAdapter.Update(this.excursions1DataSet.Bus);
        }
        //driver save
        private void saveToolStripButton4_Click(object sender, EventArgs e)
        {
            this.driverTableAdapter.Update(this.excursions1DataSet.Driver);
        }
        //excursionBusDriver save
        private void saveToolStripButton5_Click(object sender, EventArgs e)
        {
            this.excursionBusDriverTableAdapter.Update(this.excursions1DataSet.ExcursionBusDriver);
        }
        //excursionClient save
        private void saveToolStripButton6_Click(object sender, EventArgs e)
        {
            this.excursionClientTableAdapter.Update(this.excursions1DataSet.ExcursionClient);
        }
        //excursionBus save
        private void saveToolStripButton7_Click(object sender, EventArgs e)
        {
            this.excursionBusTableAdapter.Update(this.excursions1DataSet.ExcursionBus);
        }

        //------------------------------------- FILTERS --------------------------------------------------------
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (toolStripComboBox5 != null)
            {
                //toolStripComboBox5 = (System.Windows.Controls.ComboBox)e.Control;
                toolStripComboBox5.SelectedIndexChanged += new EventHandler(toolStripComboBox5_SelectedIndexChanged);
            }
        }

        //excursion filter
        private void toolStripComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = toolStripComboBox5.SelectedItem.ToString();

            if (selected.Equals("all"))
            {
                using (var db = new Excursions1Context())
                {
                    var select = db.Excursions.ToList();
                    dataGridView3.DataSource = select;
                }
            }
            else if (selected.Equals("coming"))
            {
                using(var db = new Excursions1Context())
                {
                    var select = db.Excursions.Where(p=>p.startDate >= DateTime.Now).ToList();
                    dataGridView1.DataSource = select;
                }
            }
            else if (selected.Equals("finished"))
            {
                using (var db = new Excursions1Context())
                {
                    var select = db.Excursions.Where(p => p.startDate <= DateTime.Now).ToList();
                    dataGridView1.DataSource = select;
                }
            }
        }

        // clients filter 
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = toolStripComboBox1.SelectedItem.ToString();

            if (selected.Equals("all"))
            {
                using (var db = new Excursions1Context())
                {
                    var select = db.Clients.ToList();
                    dataGridView3.DataSource = select;
                }
            }
            else if (selected.Equals("with debts"))
            {
                using (var db = new Excursions1Context())
                {
                    var select = (from x in db.Clients.AsEnumerable()
                                 join y in db.Payments.AsEnumerable()
                                 on x.clientId equals y.clientId
                                 where y.isPaid == false
                                 select x).ToList();
                    dataGridView1.DataSource = select;
                }
            }
            else if (selected.Equals("without debts"))
            {
                using (var db = new Excursions1Context())
                {
                    var select = (from x in db.Clients.AsEnumerable()
                                  join y in db.Payments.AsEnumerable()
                                  on x.clientId equals y.clientId
                                  where y.isPaid == true
                                  select x).ToList();
                    dataGridView1.DataSource = select;
                }
            }
        }

        //payment filter
        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = toolStripComboBox2.SelectedItem.ToString();

            if (selected.Equals("all"))
            {
                using (var db = new Excursions1Context())
                {
                    var select = db.Payments.ToList();
                    dataGridView3.DataSource = select;
                }
            }
            else if (selected.Equals("paid"))
            {
                using (var db = new Excursions1Context())
                {
                    var select = db.Payments.Where(p => p.isPaid == true).ToList();
                    dataGridView3.DataSource = select;
                }
            }
            else if (selected.Equals("not paid"))
            {
                using (var db = new Excursions1Context())
                {
                    var select = db.Payments.Where(p => p.isPaid == false).ToList();
                    dataGridView3.DataSource = select;
                }
            }
        }

        //bus filter
        private void toolStripComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = toolStripComboBox4.SelectedItem.ToString();

            if (selected.Equals("all"))
            {
                using (var db = new Excursions1Context())
                {
                    var select = db.Buses.ToList();
                    dataGridView3.DataSource = select;
                }
            }
            else if (selected.Equals("free"))
            {
                using (var db = new Excursions1Context())
                {
                    var select = db.Buses.Where(p => p.isOnGoing == false).ToList();
                    dataGridView4.DataSource = select;
                }
            }
        }

        //drivers filter
        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = toolStripComboBox3.SelectedItem.ToString();

            if (selected.Equals("all"))
            {
                using (var db = new Excursions1Context())
                {
                    var select = db.Drivers.ToList();
                    dataGridView3.DataSource = select;
                }
            }
            else if (selected.Equals("free"))
            {
                using (var db = new Excursions1Context())
                {
                    var select = db.Drivers.Where(p => p.isOnGoing == false&& p.isOnVocation == false).ToList();
                    dataGridView4.DataSource = select;
                }
            }
        }


        //statistics buttons
        private void button1_Click(object sender, EventArgs e)
        {
            ExcursionForPeriod exc = new ExcursionForPeriod();
            exc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusSchedule busSchedule = new BusSchedule();
            busSchedule.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerPay customerPay = new CustomerPay();
            customerPay.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FinReport finReport = new FinReport();
            finReport.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //sql connection object
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                //set stored procedure name
                string spName = @"dbo.[price_for_excursions]";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);

                cmd.Parameters.Add(new SqlParameter("@startDate", SqlDbType.Date)).Value = "01/01/2022";

                //open connection
                conn.Open();

                //set the SQLCommand type to StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;


                //execute the stored procedure                   
                cmd.ExecuteNonQuery();


                //close connection
                conn.Close();
            }
            this.paymentTableAdapter.Fill(this.excursions1DataSet.Payment);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //sql connection object
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                //set stored procedure name
                string spName = @"dbo.[pay_for_excursions]";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);

                cmd.Parameters.Add(new SqlParameter("@startDate", SqlDbType.Date)).Value = "01/01/2022";

                //open connection
                conn.Open();

                //set the SQLCommand type to StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;


                //execute the stored procedure                   
                cmd.ExecuteNonQuery();


                //close connection
                conn.Close();
            }
            this.paymentTableAdapter.Fill(this.excursions1DataSet.Payment);
        }
    }
}
