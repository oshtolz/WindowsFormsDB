using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsDB
{
    public partial class Form1 : Form
    {

        private const string adminLogin = "admin";
        private const string adminPassword = "admin123";

        //private const string login = "admin";
        //private const string password = "admin123";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_SignIn_Click(object sender, EventArgs e)
        {
            if (t_password.Text.ToString().Equals(adminPassword) && t_login.Text.ToString().Equals(adminLogin))
            {
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter correct login and password");
                t_password.Text = null;
            }
        }
    }
}
