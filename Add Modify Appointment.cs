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
    public partial class Add_Modify_Appointment : Form
    {
        private Main LastForm;
        private int selectedApptID = -1;
		private Main main;

		public Add_Modify_Appointment(Main lastForm, int appointmentID)
        {
            InitializeComponent();
            LastForm = lastForm;
            selectedApptID = appointmentID;
        }

		public Add_Modify_Appointment(Main lastForm)
		{
            InitializeComponent();
            LastForm = lastForm;
        }

		//public Add_Modify_Appointment(Main main)
		//{
  //          InitializeComponent();
  //          this.main = main;
		//}

        public void comboBox()
        {
            string sqlQuery = "SELECT DISTINCT customerName from customer";
            var conn = ConnectToDB.newConnection();
            MySqlDataAdapter da = new MySqlDataAdapter(sqlQuery, conn);
            DataSet dt = new DataSet();
            da.Fill(dt, "customerName");
            customerIDComboBox.DisplayMember = "customerName";
            customerIDComboBox.ValueMember = "customerId";
            customerIDComboBox.DataSource = dt.Tables["customerName"];
            if (customerIDComboBox.Items.Count > 1)
            {
                customerIDComboBox.SelectedIndex = -1;
            }
        }
        //form load
        private void Add_Modify_Appointment_Load(object sender, EventArgs e)
        {
           
        }

        //close button clicked
		private void addApptCloseButton_Click(object sender, EventArgs e)
		{
            this.Close();
            
		}

        //save button clicked
        private void addApptSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                //business hours
                TimeSpan businessOpen = new DateTime(now.Year, now.Month, now.Day, 9, 0, 0).TimeOfDay;
                TimeSpan businessClose = new DateTime(now.Year, now.Month, now.Day, 18, 0, 0).TimeOfDay;
                int selectedCustomerID = Convert.ToInt32(customerIDComboBox.SelectedValue);
                string title = titleText.Text.ToString();
                string typeSelected = typeComboBox.SelectedItem.ToString();
                DateTime selectedStartDate = startDatePicker.Value;
                DateTime selectedEndDate = endDatePicker.Value;
                bool overlap = false;

                //overlapping appointments
                for (int i = 0; i < Main.apptList.Count; i++)
                {
                    Appointment appt = Main.apptList[i];
                    if (appt.startDate <= selectedStartDate && appt.endDate > selectedStartDate && (!(selectedApptID >= 0)) || selectedApptID >= 0)
                    {
                        overlap = true;
                    }
                    if (selectedStartDate <= appt.startDate && selectedEndDate > appt.startDate && (!(selectedApptID >= 0)) || selectedApptID >= 0)
                    {
                        overlap = true;
                    }
                }

                //customer must be selected
                if (selectedCustomerID < 1)
                {
                    throw new ApplicationException("Please select a customer.");
                }

                //title must be added
                if (titleText.Text == "")
                {
                    throw new ApplicationException("Appointments must have a title.");
                }

                //selecting an end date that is before the start date
                if (selectedStartDate > selectedEndDate)
                {
                    throw new ApplicationException("The start time must be before the end time.");
                }

                //selecting a time outside of business hours
                if ((selectedStartDate.TimeOfDay < businessOpen) || (selectedStartDate.TimeOfDay > businessClose) ||
                    (selectedEndDate.TimeOfDay < businessOpen) || (selectedEndDate.TimeOfDay > businessClose))
                {
                    throw new ApplicationException("Appointments cannot be scheduled outside of the business hours of 9am - 6pm");
                }

                //appointment times overlapping
                if (overlap)
                {
                    throw new ApplicationException("Appointments cannot overlap");
                }

                if (selectedApptID >= 0)
                {
                    Appointment appointment = Main.apptList.Where(appt => appt.appointmentID == selectedApptID).Single();
                    SQL_Data.modifyAppt(appointment, selectedCustomerID, title, typeSelected, selectedStartDate, selectedEndDate);
                }
                else
                {
                    SQL_Data.addAppt(selectedCustomerID, title, typeSelected, selectedStartDate, selectedEndDate);
                }
                Close();
            }
            //if appointment type is not selected
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select an appointment type.", "Instructions", MessageBoxButtons.OK);
            }
            catch (ApplicationException err)
            {
                MessageBox.Show(err.Message, "Instructions", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
		}

        //form closed
		private void Add_Modify_Appointment_FormClosed(object sender, FormClosedEventArgs e)
		{
            LastForm.UpdateSelection();
            LastForm.Show();
		}

        //start date picker pressed
		private void startDatePicker_KeyPress(object sender, KeyPressEventArgs e)
		{
            e.Handled = true;
		}

        //end date picker pressed
		private void endDatePicker_KeyPress(object sender, KeyPressEventArgs e)
		{
            e.Handled = true;
		}


	}
}
