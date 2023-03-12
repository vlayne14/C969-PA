using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Victoria_Brown_C969_PA.Database;

namespace Victoria_Brown_C969_PA
{
    public class Customer
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
        public int addressID { get; set; }
        public int active { get; set; }
        public DateTime dateCreated { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdatedBy { get; set; }

        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public int zipCode { get; set; }
  



        public static int count;

        //customer object
        public Customer(int customerID, string customerName, int addressID, int active, DateTime dateCreated, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.addressID = addressID;
            this.active = active;
            this.dateCreated = dateCreated;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdatedBy = lastUpdatedBy;
        }
        public Customer(string customerName, int addressID, int active, DateTime dateCreated, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            //auto incrementing customer ID
            this.customerID = Interlocked.Increment(ref count);
            this.customerName = customerName;
            this.addressID = addressID;
            this.active = active;
            this.dateCreated = dateCreated;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdatedBy = lastUpdatedBy;
        }

        public Customer(string customerName, string addressLine1, string addressLine2, string city, int zipCode, string country, int active, DateTime dateCreated, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            this.customerName = customerName;
            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.city = city;
            this.zipCode = zipCode;
            this.country = country;
            this.active = active;
            this.dateCreated = dateCreated;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdatedBy = lastUpdatedBy;

        }

       
    }
}
