using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Globalization;
using Victoria_Brown_C969_PA.Database;

namespace Victoria_Brown_C969_PA
{
	class SQL_Data
    {

        //user list
        public static List<User> getUsers()
        {
            List<User> userList = new List<User>();
            string sqlQuery = "SELECT * FROM user";

            var conn = ConnectToDB.newConnection();
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //converting info from database
            while (dataReader.Read())
            {
                int userID = Convert.ToInt32(dataReader[0]);
                string userName = dataReader[1].ToString();
                string password = dataReader[2].ToString();
                int active = Convert.ToInt32(dataReader[3]);
                DateTime dateCreated = Convert.ToDateTime(dataReader[4]).ToLocalTime();
                string createdBy = dataReader[5].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[6]).ToLocalTime();
                string updatedBy = dataReader[7].ToString();

                userList.Add(new User(userID, userName, password, active, dateCreated, createdBy, lastUpdate, updatedBy));
            }

            return userList;
        }

        //getting appointments from database
        public static void getAppointment()
        {
            string sqlQuery = $"SELECT * FROM appointment WHERE userId={Main.currentUser.userID}";

            //opening database connection
            var conn = ConnectToDB.newConnection();
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //converting info from database
            while (dataReader.Read())
            {
                int appointmentID = Convert.ToInt32(dataReader[0]);
                int customerID = Convert.ToInt32(dataReader[1]);
                int userID = Convert.ToInt32(dataReader[2]);
                string title = dataReader[3].ToString();
                string type = dataReader[7].ToString();
                DateTime startDate = Convert.ToDateTime(dataReader[9]).ToLocalTime();
                DateTime endDate = Convert.ToDateTime(dataReader[10]).ToLocalTime();
                DateTime dateCreated = Convert.ToDateTime(dataReader[11]).ToLocalTime();
                string createdBy = dataReader[12].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[13]).ToLocalTime();
                string lastUpdatedBy = dataReader[14].ToString();

                Main.apptList.Add(new Appointment(appointmentID, customerID, userID, title, type, startDate, endDate,
                    dateCreated, createdBy, lastUpdate, lastUpdatedBy));
            }
            ConnectToDB.closeConnection();
        }

        //add new appointment
        public static void addAppt(int customerID, string title, string type, DateTime startDate, DateTime endDate)
        {
            DateTime now = DateTime.Now;
            var newAppt = new Appointment(customerID, Main.currentUser.userID, title, type, startDate, endDate, now,
                Main.currentUser.userName, now, Main.currentUser.userName);
            //opening database connection
            var conn = ConnectToDB.newConnection();
            //inserting appointment into database
            string sqlQuery = $"INSERT INTO `appointment` VALUES ({newAppt.appointmentID},{newAppt.customerID},{newAppt.userID}," +
                $"'{newAppt.title}','not needed','not needed','not needed','{newAppt.type}','not needed','" +
                $"{newAppt.startDate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','" +
                $"{newAppt.endDate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','" +
                $"{newAppt.dateCreated.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','" +
                $"{newAppt.createdBy}','{newAppt.lastUpdate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','{newAppt.lastUpdatedBy}')";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();


            Main.apptList.Add(newAppt);
        }

        //deleting appointment
        public static void deleteAppt(Appointment appointment)
        {
            //opening database connection
            var conn = ConnectToDB.newConnection();
            string sqlQuery = $"DELETE FROM appointment WHERE appointmentId={appointment.appointmentID};";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();
            //closing database connection
            conn.Close();
            Main.apptList.Remove(appointment);
        }

        //modifying appointment
        public static void modifyAppt(Appointment appointment, int customerID, string title, string type, DateTime startDate, DateTime endDate)
        {
            DateTime now = DateTime.Now;
            //string to hold time conversion
            string timeString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            //opening database connection
            var conn = ConnectToDB.newConnection();
            string sqlQuery = $"UPDATE appointment SET customerId={customerID},userId={Main.currentUser.userID},title='{title}',type='{type}'," +
                $"start='{startDate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', " +
                $"end='{endDate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}',lastUpdate='{timeString}'," +
                $"lastUpdateBy='{Main.currentUser.userName}' WHERE appointmentId={appointment.appointmentID};";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();


            //modified appointment
            Appointment modifiedAppt = new Appointment(appointment.appointmentID, customerID, Main.currentUser.userID, title, type, startDate,
                endDate, appointment.dateCreated, appointment.createdBy, now, Main.currentUser.userName);
            int apptListIndex = Main.apptList.IndexOf(appointment);
            Main.apptList.RemoveAt(apptListIndex);
            Main.apptList.Insert(apptListIndex, modifiedAppt);
        }

        //customer commands
        //getting customers from database
        public static void getCustomers()
        {
            string sqlQuery = "SELECT * FROM customer";

            //opening database connection
            var conn = ConnectToDB.newConnection();
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //converting info from database
            while (dataReader.Read())
            {
                int customerID = Convert.ToInt32(dataReader[0]);
                string customerName = dataReader[1].ToString();
                int addressID = Convert.ToInt32(dataReader[2]);
                int active = Convert.ToInt32(dataReader[3]);
                DateTime dateCreated = Convert.ToDateTime(dataReader[4]).ToLocalTime();
                string createdBy = dataReader[5].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[6]).ToLocalTime();
                string lastUpdatedBy = dataReader[7].ToString();

                //adding to list of customers
                Main.customerList.Add(new Customer(customerID, customerName, addressID, active, dateCreated, createdBy, lastUpdate, lastUpdatedBy));
            }
            ConnectToDB.closeConnection();
        }

        //adding customer
        public static int addCustomer(string customerName, int addressID, string user)
        {
            DateTime now = DateTime.Now;
            var newCustomer = new Customer(customerName, addressID, 1, now, user, now, user);

            //opening database connection
            var conn = ConnectToDB.newConnection();
            string sqlQuery = $"INSERT INTO `customer` VALUES ({newCustomer.customerID}, '{newCustomer.customerName}', {newCustomer.addressID}, " +
                $"{newCustomer.active},'{newCustomer.dateCreated.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','" +
                $"{newCustomer.createdBy}','{newCustomer.lastUpdate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}','" +
                $"{newCustomer.lastUpdatedBy}')";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();


            Main.customerList.Add(newCustomer);
            return newCustomer.customerID;
        }



        //delete customer
        public static void deleteCustomer(Customer customer)
        {
            //opening database connection
            var conn = ConnectToDB.newConnection();
            string sqlQuery = $"DELETE FROM customer WHERE customerId={customer.customerID};";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();

            //removing from customer list
            Main.customerList.Remove(customer);
            deleteAddress(customer.addressID);
        }

        //modify customer
        public static void modifyCustomer(Customer customer, string customerName, string user)
        {
            DateTime now = DateTime.Now;
            string timeString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            //opening database connection
            var conn = ConnectToDB.newConnection();
            string sqlQuery = $"UPDATE customer SET customerName='{customerName}', lastUpdate='{timeString}', lastUpdateBy='{user}' " +
                $"WHERE customerId={customer.customerID};";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();
            //addding new modified customer
            Customer modifiedCustomer = new Customer(customer.customerID, customerName, customer.addressID, customer.active, customer.dateCreated,
                customer.createdBy, now, user);
            int customerListIndex = Main.customerList.IndexOf(customer);
            //removing customer from list
            Main.customerList.RemoveAt(customerListIndex);
            //adding modified customer to list
            Main.customerList.Insert(customerListIndex, modifiedCustomer);
        }



        //address commands
        //getting address from database
        public static void getAddress()
        {
            string sqlQuery = "SELECT * FROM address";

            //opening connection to database
            var conn = ConnectToDB.newConnection();
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //converting info from database
            while (dataReader.Read())
            {
                int addressID = Convert.ToInt32(dataReader[0]);
                string addressLine1 = dataReader[1].ToString();
                string addressLine2 = dataReader[2].ToString();
                int cityID = Convert.ToInt32(dataReader[3]);
                string zipCode = dataReader[4].ToString();
                string phoneNumber = dataReader[5].ToString();
                DateTime dateCreated = Convert.ToDateTime(dataReader[6]).ToLocalTime();
                string createdBy = dataReader[7].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[8]).ToLocalTime();
                string lastUpdatedBy = dataReader[9].ToString();

                //adding address information to dictionary
                Main.dictionaryAddress.Add(addressID, new Address(addressID, addressLine1, addressLine2, cityID, zipCode,
                phoneNumber, dateCreated, createdBy, lastUpdate, lastUpdatedBy));
            }
            ConnectToDB.closeConnection();

        }

        //adding address
        public static int addAddress(string addressLine1, string addressLine2, int cityID, string zipCode, string phoneNumber, string userName)
        {
            DateTime now = DateTime.Now;
            var newAddress = new Address(addressLine1, addressLine2, cityID, zipCode, phoneNumber, now, userName, now, userName);

            //opening database connection
            var conn = ConnectToDB.newConnection();
            string sqlQuery = $"INSERT INTO `address` VALUES ({newAddress.addressID}, '{newAddress.addressLine1}', '{newAddress.addressLine2}'," +
                $"{newAddress.cityID},'{newAddress.zipCode}','{newAddress.phoneNumber}','{newAddress.dateCreated.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '" +
                $"{newAddress.createdBy}', '{newAddress.lastUpdate.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo)}', '{newAddress.lastUpdatedBy}')";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();

            //adding address to dictionary
            Main.dictionaryAddress.Add(newAddress.addressID, newAddress);
            return newAddress.addressID;
        }

        //delete address
        public static void deleteAddress(int addressID)
        {
            //opening database connection
            var conn = ConnectToDB.newConnection();
            string sqlQuery = $"DELETE FROM address WHERE addressId={addressID};";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();

            //removing address from dictionary
            Main.dictionaryAddress.Remove(addressID);
        }

        //modify address
        public static void modifyAddress(Address address, string addressLine1, string addressLine2, int cityID, string zipCode, string phoneNumber, string user)
        {
            DateTime now = DateTime.Now;
            string timeString = now.ToUniversalTime().ToString("yy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            //opening database connection
            var conn = ConnectToDB.newConnection();
            //sql query to update database
            string sqlQuery = $"UPDATE address SET address='{addressLine1}', address2='{addressLine2}', cityId={cityID}, postalCode='{zipCode}', " +
                $"phone='{phoneNumber}', lastUpdate='{timeString}', lastUpdateBy='{user}' WHERE addressId={address.addressID};";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();


            //updating address dictionary
            Main.dictionaryAddress[address.addressID] = new Address(address.addressID, addressLine1, addressLine2, cityID, address.zipCode, phoneNumber, address.dateCreated, address.createdBy, now, user);
        }

        //getting cities
        public static void getCities()
        {
            string sqlQuery = "SELECT * FROM city";
            var conn = ConnectToDB.newConnection();
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //converting information from database
            while (dataReader.Read())
            {
                int cityID = Convert.ToInt32(dataReader[0]);
                string city = dataReader[1].ToString();
                int countryID = Convert.ToInt32(dataReader[2]);
                DateTime dateCreated = Convert.ToDateTime(dataReader[3]).ToLocalTime();
                string createdBy = dataReader[4].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[5]).ToLocalTime();
                string lastUpdatedBy = dataReader[6].ToString();

                //adding information to dictionary
                Main.dictionaryCity.Add(cityID, new City(cityID, city, countryID, dateCreated, createdBy, lastUpdate, lastUpdatedBy));
            }
            ConnectToDB.closeConnection();
        }


        //getting countries
        public static void getCountries()
        {
            string sqlQuery = "SELECT * FROM country";

            //opening database connection
            var conn = ConnectToDB.newConnection();
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //converting info from database
            while (dataReader.Read())
            {
                int countryID = Convert.ToInt32(dataReader[0]);
                string countryName = dataReader[1].ToString();
                DateTime dateCreated = Convert.ToDateTime(dataReader[2]).ToLocalTime();
                string createdBy = dataReader[3].ToString();
                DateTime lastUpdate = Convert.ToDateTime(dataReader[4]).ToLocalTime();
                string lastUpdatedBy = dataReader[5].ToString();

                //adding to country dictionary
                Main.dictionaryCountry.Add(countryID, new Country(countryID, countryName, dateCreated, createdBy, lastUpdate, lastUpdatedBy));
            }
            ConnectToDB.closeConnection();

        }

      

       







       
       

       

      

    }

}
