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
    public partial class Consultant_Schedule : Form
    {
        
        //connecting to database
        MySqlConnection conn = ConnectToDB.newConnection();
        public Consultant_Schedule()
        {
            InitializeComponent();
        }


        //form load
        private void Consultant_Schedule_Load(object sender, EventArgs e)
		{
            comboBox();
            display_DGV();
		}

        private void comboBox()
        {
            string sqlQuery = "SELECT DISTINCT userName from user";
            MySqlDataAdapter da = new MySqlDataAdapter(sqlQuery, conn);
            DataSet dt = new DataSet();
            da.Fill(dt, "userName");
            consultantScheduleComboBox.DisplayMember = "userName";
            consultantScheduleComboBox.ValueMember = "userId";
            consultantScheduleComboBox.DataSource = dt.Tables["userName"];
            if (consultantScheduleComboBox.Items.Count > 1)
            {
                consultantScheduleComboBox.SelectedIndex = -1;
            }
        }

        private void display_DGV()
        {
            MySqlCommand sqlQuery2 = new MySqlCommand("SELECT appointmentId, customerId, userId, title, type, start, end, createDate, createdBy, lastUpdate, lastUpdateBy FROM appointment WHERE createdBy LIKE '%" + consultantScheduleComboBox.Text + "'", conn);
            MySqlDataAdapter da2 = new MySqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = sqlQuery2;
            dt2.Clear();
            da2.Fill(dt2);
            consultantScheduleDGV.DataSource = dt2;
        }



            //close button
            private void consultantScheduleCloseButton_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void consultantScheduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
            display_DGV();
		}
	}
}
