using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victoria_Brown_C969_PA
{
    public class Address
    {
        public int addressID { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public int cityID { get; set; }
        public string zipCode { get; set; }
        public string phoneNumber { get; set; }
        public DateTime dateCreated  { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdatedBy { get; set; }

        private static int count = 0;
        public Address(int addressID, string addressLine1, string addressLine2, int cityID, string zipCode, string phoneNumber, DateTime dateCreated, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            this.addressID = addressID;
                if (addressID > count)
            {
                count = addressID;
            }
            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.cityID = cityID;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.dateCreated = dateCreated;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdatedBy = lastUpdatedBy;
        }

        public Address(string addressLine1, string addressLine2, int cityID, string zipCode, string phoneNumber, DateTime dateCreated, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            count++;
            addressID = count;
            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.cityID = cityID;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.dateCreated = dateCreated;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdatedBy = lastUpdatedBy;
        }

        public Address()
        {
        }
    }

}
