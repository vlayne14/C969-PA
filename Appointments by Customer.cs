using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Victoria_Brown_C969_PA.Database;

namespace Victoria_Brown_C969_PA
{
    public partial class Appointments_by_Customer : Form
    {
        public Appointments_by_Customer()
        {
            InitializeComponent();
        }

		private void Appointments_by_Customer_Load(object sender, EventArgs e)
		{

            MySqlConnection conn = ConnectToDB.newConnection();

            var sqlQuery = "SELECT appointment.title, customer.customerName, appointment.start, appointment.end FROM appointment JOIN customer ON appointment.customerId = customer.customerId GROUP BY customer.customerName, appointment.title;";
            MySqlDataAdapter da = new MySqlDataAdapter(sqlQuery, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //datagridview fill
            apptByCustDGV.DataSource = dt;
            apptByCustDGV.Refresh();
            
        }

        private void formatDGV()
        {
            var DGV = apptByCustDGV;
            DGV.AutoResizeColumns();
            DGV.RowHeadersVisible = false;
            DGV.ReadOnly = true;
        }



		private void apptByCustomerCloseButton_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void apptByCustDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
            formatDGV();
		}
	}
}
