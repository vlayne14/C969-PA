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
    public partial class Add_Modify_Customer : Form
    {
        //connecting to database
        MySqlConnection conn = ConnectToDB.newConnection();
        private Main LastForm;
        private int selectedCustomerID = -1;
        private Main main;
        public Add_Modify_Customer(Main lastForm, int customerID)
        {
            InitializeComponent();
            LastForm = lastForm;
            selectedCustomerID = customerID;
        }

        public Add_Modify_Customer(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

		public Add_Modify_Customer()
		{
            InitializeComponent();
        }

		private void Add_Modify_Customer_Load(object sender, EventArgs e)
        {
            //city combobox
            Dictionary<int, string> cityNameDict = Main.dictionaryCity.ToDictionary(dict => dict.Key, dict => dict.Value.cityName);
           
            modifyCustomerCityComboBox.DisplayMember = "Value";
            modifyCustomerCityComboBox.ValueMember = "Key";
            modifyCustomerCityComboBox.DataSource = new BindingSource(cityNameDict, null);
            modifyCustomerCityComboBox.SelectedItem = null;

            //country combobox
            Dictionary<int, string> countryNameDict = Main.dictionaryCountry.ToDictionary(dict => dict.Key, dict => dict.Value.countryName);
           
            modifyCustomerCityComboBox.DisplayMember = "Value";
            modifyCustomerCityComboBox.ValueMember = "Key";
            modifyCustomerCityComboBox.DataSource = new BindingSource(cityNameDict, null);
            modifyCustomerCityComboBox.SelectedItem = null;

        }

        private void modifyCustomerSaveButton_Click(object sender, EventArgs e)
        {

                try
                {
                    if (modifyCustomerNameText.Text == "")
                    {
                        throw new ApplicationException("Please enter a customer name.");
                    }

                    if (modifyAddressLine1Text.Text == "")
                    {
                        throw new ApplicationException("Please enter an address.");
                    }
                    if (modifyCustomerCityComboBox.SelectedItem == null)
                    {
                        throw new ApplicationException("Please select a city.");
                    }
                    if (modifyCustomerZipcodeText.Text == "")
                    {
                        throw new ApplicationException("Please enter a zipcode.");
                    }

                    if (modifyCustomerPhoneText.Text == "")
                    {
                        throw new ApplicationException("Please enter a phone number.");
                    }

                    string customerName = modifyCustomerNameText.Text;
                    string addressLine1 = modifyAddressLine1Text.Text;
                    string addressLine2 = modifyAddressLine2Text.Text;
                    string zipCode = modifyCustomerZipcodeText.Text;
                    string phoneNumber = modifyCustomerPhoneText.Text;
                    int cityID = Convert.ToInt32(modifyCustomerCityComboBox.SelectedValue);
                    int customerID;

                    if (modifyCustomerIDText.Text == "")
                    {
                        int addressID = SQL_Data.addAddress(addressLine1, addressLine2, cityID, zipCode, phoneNumber, Main.currentUser.userName);
                        customerID = SQL_Data.addCustomer(customerName, addressID, Main.currentUser.userName);
                        modifyCustomerIDText.Text = customerID.ToString();
                    }
                    else
                    {
                        customerID = Convert.ToInt32(modifyCustomerIDText.Text);
                        Customer currentCustomer = Main.customerList.Where(cust => cust.customerID == customerID).Single();
                        Address address = Main.dictionaryAddress[currentCustomer.addressID];

                        SQL_Data.modifyCustomer(currentCustomer, customerName, Main.currentUser.userName);
                        SQL_Data.modifyAddress(address, addressLine1, addressLine2, cityID, zipCode, phoneNumber, Main.currentUser.userName);
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

		private void modifyCustomerCloseButton_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}


	
}
