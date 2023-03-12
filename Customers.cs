using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Victoria_Brown_C969_PA
{
	
	public partial class Customers : Form
	{
		public static bool existingCustomer { get; set; }
		private Form MainScreen;
		public Customers(Form mainScreen)
		{
			InitializeComponent();
			customersDGV.DataSource = Main.customerList;
			
			MainScreen = mainScreen;

			//hiding certain columns
			customersDGV.Columns[8].Visible = false;
			customersDGV.Columns[9].Visible = false;
			customersDGV.Columns[10].Visible = false;
			customersDGV.Columns[11].Visible = false;
			customersDGV.Columns[12].Visible = false;
		}

		//form load
		private void Customers_Load(object sender, EventArgs e)
		{
			//city combo box
			Dictionary<int, string> cityNames = Main.dictionaryCity.ToDictionary(dict => dict.Key, dict => dict.Value.cityName);
			
			cityComboBox.DisplayMember = "Value";
			cityComboBox.ValueMember = "Key";
			cityComboBox.DataSource = new BindingSource(cityNames, null);
			cityComboBox.SelectedItem = null;
			cityComboBox.BindingContext = this.BindingContext;

			//country combo box
			Dictionary<int, string> countryNames = Main.dictionaryCountry.ToDictionary(dict => dict.Key, dict => dict.Value.countryName);
			
			countryComboBox.DisplayMember = "Value";
			countryComboBox.ValueMember = "Key";
			countryComboBox.DataSource = new BindingSource(countryNames, null);
			countryComboBox.SelectedItem = null;
			cityComboBox.BindingContext = this.BindingContext;
		}

		//form closed
		private void Customers_FormClosed(object sender, FormClosedEventArgs e)
		{
			MainScreen.Show();
		}

		//clearing textboxes
		private void clearText()
		{
			customerNameText.Text = "";
			IDText.Text = "";
			addressLine1Text.Text = "";
			addressLine2Text.Text = "";
			cityComboBox.Text = "";
			countryComboBox.Text = "";
			zipCodeText.Text = "";
			phoneText.Text = "";
		}

		//active inputs
		private void activeInputs(bool active)
		{
			customerNameText.Enabled = active;
			countryComboBox.Enabled = active;
			cityComboBox.Enabled = active;
			addressLine1Text.Enabled = active;
			addressLine2Text.Enabled = active;
			zipCodeText.Enabled = active;
			phoneText.Enabled = active;
			saveButton.Visible = active;
			cancelButton.Visible = active;
			//buttons not visible when modifying/adding a customer
			editButton.Visible = !active;
			addButton.Visible = !active;
			deleteButton.Visible = !active;
			closeButton.Visible = !active;
			customersDGV.Enabled = !active;
		}

		//populating text boxes from clicking DGV
		private void customersDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//row selected
			var selectedRow = customersDGV.SelectedRows[0];
			int selectedCustomerID = Convert.ToInt32(selectedRow.Cells[0].Value);
			Customer selectedCustomer = Main.customerList.Where(customer => customer.customerID == selectedCustomerID).Single();
			int selectedAddressID = Convert.ToInt32(selectedCustomer.addressID);
			int selectedCityID = Main.dictionaryAddress[selectedAddressID].cityID;
			int selectedCountryID = Main.dictionaryCity[selectedCityID].countryID;
			customerNameText.Text = selectedCustomer.customerName;
			IDText.Text = selectedCustomer.customerID.ToString();
			addressLine1Text.Text = Main.dictionaryAddress[selectedAddressID].addressLine1;
			addressLine2Text.Text = Main.dictionaryAddress[selectedAddressID].addressLine2;
			zipCodeText.Text = Main.dictionaryAddress[selectedAddressID].zipCode;
			phoneText.Text = Main.dictionaryAddress[selectedAddressID].phoneNumber;
			cityComboBox.Text = Main.dictionaryCity[selectedCityID].cityName;
			countryComboBox.Text = Main.dictionaryCountry[selectedCountryID].countryName;
	
		}

		//add button
		private void addButton_Click(object sender, EventArgs e)
		{
			customersDGV.ClearSelection();
			clearText();
			
			//adding values to city combobox
			Dictionary<int, string> cityNames = Main.dictionaryCity.ToDictionary(dict => dict.Key, dict => dict.Value.cityName);
			cityComboBox.DataSource = new BindingSource(cityNames, null);
			cityComboBox.DisplayMember = "Value";
			cityComboBox.ValueMember = "Key";
			cityComboBox.SelectedItem = null;
			activeInputs(true);
		}

		//modify button clicked
		private void editButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (customersDGV.SelectedRows.Count < 1)
				{
					throw new ApplicationException("Please select a customer to  modify.");
				}
				activeInputs(true);
				var selectedCountry = Convert.ToInt32(countryComboBox.SelectedValue);
				var newCityNames = Main.dictionaryCity.Where(dict => dict.Value.countryID == selectedCountry).ToDictionary
					(dict => dict.Key, dict => dict.Value.cityName);
				//city combo box
				cityComboBox.DataSource = new BindingSource(newCityNames, null);
				cityComboBox.DisplayMember = "Value";
				cityComboBox.ValueMember = "Key";
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

		//save button clicked
		private void saveButton_Click(object sender, EventArgs e)
		{
			try
			{
				//no customer name is entered
				if (customerNameText.Text == "")
				{
					throw new ApplicationException("Please enter a customer name.");
				}

				//no address is entered
				if (addressLine1Text.Text == "")
				{
					throw new ApplicationException("Please enter an address.");
				}

				//no city is selected
				if (cityComboBox.SelectedItem == null)
				{
					throw new ApplicationException("Please select a city.");
				}

				//no zipcode is entered
				if (zipCodeText.Text == "")
				{
					throw new ApplicationException("Please enter a zipcode.");
				}

				//no phone number is entered
				if (phoneText.Text == "")
				{
					throw new ApplicationException("Please enter a phone number.");
				}

				string customerName = customerNameText.Text;
				string addressLine1 = addressLine1Text.Text;
				string addressLine2 = addressLine2Text.Text;
				string zipCode = zipCodeText.Text;
				string phoneNumber = phoneText.Text;
				int cityID = Convert.ToInt32(cityComboBox.SelectedValue);
				int customerID;

				//updating existing customer
				if (existingCustomer == true)
				{
					customerID = Convert.ToInt32(IDText.Text);
					Customer currentCustomer = Main.customerList.Where(cust => cust.customerID == customerID).Single();
					Address address = Main.dictionaryAddress[currentCustomer.addressID];

					SQL_Data.modifyCustomer(currentCustomer, customerName, Main.currentUser.userName);
					SQL_Data.modifyAddress(address, addressLine1, addressLine2, cityID, zipCode, phoneNumber, Main.currentUser.userName);
					
				}
				//if new customer
				else
				{
					int addressID = SQL_Data.addAddress(addressLine1, addressLine2, cityID, zipCode, phoneNumber, Main.currentUser.userName);
					customerID = SQL_Data.addCustomer(customerName, addressID, Main.currentUser.userName);
					IDText.Text = customerID.ToString();
				}

				activeInputs(false);
				customersDGV.Rows.Cast<DataGridViewRow>().Where(row => Convert.ToInt32(row.Cells[0].Value) == customerID).Single().Selected = true;
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

		//delete button clicked
		private void deleteButton_Click(object sender, EventArgs e)
		{
			try
			{
				//no customer selected
				if (customersDGV.SelectedRows.Count < 1)
				{
					throw new ApplicationException("Please select a customer to delete.");
				}
				DialogResult deleteConfirm = MessageBox.Show("Are you sure you want to delete this customer? This cannot be undone.",
					"Application Instruction", MessageBoxButtons.YesNo);
				//delete confirmed
				if (deleteConfirm == DialogResult.Yes)
				{
					bool appointmentsScheduled = false;
					var selectedRow = customersDGV.SelectedRows[0];
					int selectedCustomerID = Convert.ToInt32(selectedRow.Cells[0].Value);

					for (int i = 0; i < Main.apptList.Count; i++)
					{
						Appointment appt = Main.apptList[i];
						if (appt.customerID == selectedCustomerID)
						{
							appointmentsScheduled = true;
						}
					}

					//customers who have upcoming appointments should not be deleted
					if (appointmentsScheduled)
					{
						throw new ApplicationException("Customers with scheduled appointments cannot be deleted.");
					}

					Customer selectedCustomer = Main.customerList.Where(customer => customer.customerID == selectedCustomerID).Single();
					SQL_Data.deleteCustomer(selectedCustomer);
					clearText();
				}
				else
				{
					customersDGV.ClearSelection();
					clearText();
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

		//close button clicked
		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}


		//city combo box selection committed
		private void cityComboBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (countryComboBox.Text == "")
			{
				var selectedCity = cityComboBox.SelectedValue;
				int selectedCountry = Main.dictionaryCity[Convert.ToInt32(selectedCity)].countryID;
				//populating combo box with country names instead of ids
				countryComboBox.Text = Main.dictionaryCountry[selectedCountry].countryName;
			}
		}

		//country combo box selection committed
		private void countryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			var selectedCountry = Convert.ToInt32(countryComboBox.SelectedValue);
			//cities matching with matching countryID
			var newCityNames = Main.dictionaryCity.Where(dict => dict.Value.countryID == selectedCountry).ToDictionary(dict => dict.Key, dict => dict.Value.cityName);
			cityComboBox.DataSource = new BindingSource(newCityNames, null);
			cityComboBox.DisplayMember = "Value";
			cityComboBox.ValueMember = "Key";
			cityComboBox.SelectedItem = null;

		}

		private void cityComboBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void countryComboBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		//cancel button clicked
		private void cancelButton_Click(object sender, EventArgs e)
		{
			customersDGV.ClearSelection();
			clearText();
			activeInputs(false);
		}

		//validating zipcode 
		private void zipCodeText_Leave(object sender, EventArgs e)
		{
			if ((zipCodeText.Text.Length < 5)  && (zipCodeText.Text.Length == 0))
			{
				MessageBox.Show("Zip Code must be 5 digits.");
				zipCodeText.Focus();
			}
		}

		
	}
}
