using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Victoria_Brown_C969_PA
{
    public partial class Main : Form
    {
        //current user
        public static User currentUser;
        
        //binding lists for customers, appointments, and types
        public static BindingList<Customer> customerList = new BindingList<Customer>();
        public static BindingList<Appointment> apptList = new BindingList<Appointment>();
        public static BindingList<Types> typeList = new BindingList<Types>();
        //dictionaries for addresses, cities, and countries
        public static Dictionary<int, Address> dictionaryAddress = new Dictionary<int, Address>();
        public static Dictionary<int, City> dictionaryCity = new Dictionary<int, City>();
        public static Dictionary<int, Country> dictionaryCountry = new Dictionary<int, Country>();

        //update selection
        public void UpdateSelection()
        {
        }

        public Main(User user)
        {
            InitializeComponent();
            currentUser = user;
            //updating label according to logged in user
            mainApptLabel.Text = $"Appointments for { currentUser.userName}";
        }

		//main form load
		private void Main_Load(object sender, EventArgs e)
		{
           
                SQL_Data.getAddress();
                SQL_Data.getCities();
                SQL_Data.getCountries();
                SQL_Data.getCustomers();
                //appointments DGV
                mainApptDGV.AutoGenerateColumns = true;
                SQL_Data.getAppointment();
                mainApptDGV.DataSource = Main.apptList;
            
            
            
        }
      

        //appointment buttons
        //add appointment button clicked
		private void mainApptAddButton_Click(object sender, EventArgs e)
		{
            
            Add_Modify_Appointment form = new Add_Modify_Appointment(this);
            //type combo box
            form.typeComboBox.DataSource = new[] { "In-Person", "Virtual" };
            form.typeComboBox.SelectedItem = null;
            
            //populating customer combobox
            form.comboBox();
            form.Show();
           
		}

        //modify appointment button
		private void mainApptModifyButton_Click(object sender, EventArgs e)
		{
            
            //getting appt id
            DataGridViewRow selectedRow = mainApptDGV.SelectedRows[0];
            var selectedApptId = Convert.ToInt32(selectedRow.Cells[0].Value);
            Add_Modify_Appointment ma = new Add_Modify_Appointment(this, selectedApptId);



            Dictionary<int, string> dictionaryCustomer = Main.customerList.ToDictionary(list => list.customerID, list => list.customerName);
            
            //values for customerID combo box
            ma.customerIDComboBox.DisplayMember = "Value";
            ma.customerIDComboBox.ValueMember = "Key";
            ma.customerIDComboBox.DataSource = new BindingSource(dictionaryCustomer, null);
            ma.customerIDComboBox.SelectedItem = null;

            //type combo box
            ma.typeComboBox.DataSource = new[] { "In-Person", "Virtual" };
            ma.typeComboBox.SelectedItem = null;

            //populating form
            ma.addApptLabel.Text = "Modify Appointment";
            Appointment appointment = Main.apptList.Where(appt => appt.appointmentID == selectedApptId).FirstOrDefault();
            ma.customerIDComboBox.Text = appointment.customerID.ToString();
            ma.titleText.Text = appointment.title;
            ma.typeComboBox.Text = appointment.type;
            ma.startDatePicker.Value = appointment.startDate;
            ma.endDatePicker.Value = appointment.endDate;
            ma.addApptIDLabel.Text = appointment.appointmentID.ToString();

            ma.Show();

        }


        //delete appointment button clicked
        private void mainApptDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if no appointment is selected
                if (mainApptDGV.SelectedRows.Count < 1)
                {
                    throw new ApplicationException("Please select an appointment to delete.");
                }
                DialogResult deleteConfirm = MessageBox.Show("Are you sure you want to delete this appointment? This cannot be undone.",
                    "Application Instruction", MessageBoxButtons.YesNo);
                //if delete confirmed
                if (deleteConfirm == DialogResult.Yes)
                {
                    var selectedRow = mainApptDGV.SelectedRows[0];
                    int selectedApptID = Convert.ToInt32(selectedRow.Cells[0].Value);
                    Appointment selectedAppointment = Main.apptList.Where(appt => appt.appointmentID == selectedApptID).Single();
                    SQL_Data.deleteAppt(selectedAppointment);
                    UpdateSelection();
                }
                else
                {
                    mainApptDGV.ClearSelection();
                }
            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

      

        //log off button clicked
		private void mainLogOffButton_Click(object sender, EventArgs e)
		{
            this.Close();
            //new login form
            login login = new login();
            login.Show();
		}

        //view appointments button clicked
		private void viewApptButton_Click(object sender, EventArgs e)
		{
            View_Appointments form = new View_Appointments();
            form.Show();
		}

        //consultant schedule button clicked
		private void consultantScheButton_Click(object sender, EventArgs e)
		{
            Consultant_Schedule form = new Consultant_Schedule();
            form.Show();
		}

        //appointment types button clicked
		private void apptTypesButton_Click(object sender, EventArgs e)
		{
            Appointment_Types form = new Appointment_Types();
            form.Show();
		}

        //appointments by customer button clicked
		private void apptCustomerButton_Click(object sender, EventArgs e)
		{
            Appointments_by_Customer form = new Appointments_by_Customer();
            form.Show();
		}

        //customers button clicked
		private void customersButton_Click(object sender, EventArgs e)
		{
            var customerForm = new Customers(this);
            customerForm.Show();
		}

        //appointments happening in next 15 min
		private void Main_Shown(object sender, EventArgs e)
		{
            var apptFifteen = apptList.Where(appt =>
            {
                var timeNow = DateTime.Now;
                var fifteenMin = new TimeSpan(0, 15, 0);
                var timeRemaining = appt.startDate - timeNow;

                if (timeRemaining > new TimeSpan(0, 0, 0) && timeRemaining <= fifteenMin)
                {
                    return true;
                }
                return false;
            });

            //message popup to show upcoming appointment
            if (apptFifteen.Count() > 0)
            {
                var appointment = apptFifteen.First();
                //lambda expression ensuring customer in list equals a known customer ID
                MessageBox.Show($"You have an upcoming appointment with {customerList.Where(cust => cust.customerID == appointment.customerID).Single().customerName}" +
                    $" at {appointment.startDate.ToString("h:mm tt")}.", "Upcooming Appointment", MessageBoxButtons.OK);
            }

        }
	}
}
