using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victoria_Brown_C969_PA
{
    public class City
    {
        public int cityID { get; set; }
        public string cityName { get; set; }
        public int countryID { get; set; }
        public DateTime dateCreated { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdatedBy { get; set; }

        //create city object
        public City(int cityID, string cityName, int countryID, DateTime dateCreated, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            this.cityID = cityID;
            this.cityName = cityName;
            this.countryID = countryID;
            this.dateCreated = dateCreated;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdatedBy = lastUpdatedBy;
        }
        public City()
        {
        }
    }
}
