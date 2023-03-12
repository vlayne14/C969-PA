using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victoria_Brown_C969_PA
{
    public class User
    {
        public int userID;
        public string userName;
        public string password;
        public int active;
        public DateTime dateCreated;
        public string createdBy;
        public DateTime lastUpdate;
        public string updatedBy;

        public User(int userID, string userName, string password, int active, DateTime dateCreated, string createdBy, DateTime lastUpdate, string updatedBy)
        {
            this.userID = userID;
            this.userName = userName;
            this.password = password;
            this.active = active;
            this.dateCreated = dateCreated;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.updatedBy = updatedBy;
        }
    }
}
