using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Victoria_Brown_C969_PA
{
    public class Appointment
    {
        public int appointmentID { get; set; }
        public int customerID { get; set; }
        public int userID { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime dateCreated { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdatedBy { get; set; }

        static int count;
        

        //appointment object
        public Appointment(int appointmentID, int customerID, int userID, string title, string type, DateTime startDate, 
            DateTime endDate, DateTime dateCreated, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            //auto incrementing appointment ID
            this.appointmentID = Interlocked.Increment(ref count);
            this.customerID = customerID;
            this.userID = userID;
            this.title = title;
            this.type = type;
            this.startDate = startDate;
            this.endDate = endDate;
            this.dateCreated = dateCreated;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdatedBy = lastUpdatedBy;
        }

        public Appointment(int customerID, int userID, string title, string type, DateTime startDate, DateTime endDate, DateTime dateCreated, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            //auto incrementing appointment ID
            this.appointmentID = Interlocked.Increment(ref count);
            this.customerID = customerID;
            this.userID = userID;
            this.title = title;
            this.type = type;
            this.startDate = startDate;
            this.endDate = endDate;
            this.dateCreated = dateCreated;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdatedBy = lastUpdatedBy;
        }
    }
}
