using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicPivotList
{
    public class LocationRepository
    {
        private List<Location> locations = new List<Location>();

        public LocationRepository()
        {
            locations.Add(new Location { Id = 1, Name = "Head Office" });
            locations.Add(new Location { Id = 2, Name = "Uttara" });
            locations.Add(new Location { Id = 3, Name = "MES" });
            locations.Add(new Location { Id = 4, Name = "Chittagong" });
            locations.Add(new Location { Id = 5, Name = "Rajshahi" });
            locations.Add(new Location { Id = 6, Name = "Sylhet" });
        }


        public List<Location> GetAll()
        {
            return locations;
        }
    }
}
