using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicPivotList
{
    public class StockLocationRepository
    {
        private List<StockLocation> locations = new List<StockLocation>();

        public StockLocationRepository()
        {
            locations.Add(new StockLocation { Id = 1, ProductId = 1, LocationId = 1, TotalQuantity = 4700 });
            locations.Add(new StockLocation { Id = 2, ProductId = 1, LocationId = 2, TotalQuantity = 4100 });
            locations.Add(new StockLocation { Id = 3, ProductId = 1, LocationId = 3, TotalQuantity = 200 });
            locations.Add(new StockLocation { Id = 4, ProductId = 1, LocationId = 4, TotalQuantity = 400 });
            locations.Add(new StockLocation { Id = 5, ProductId = 1, LocationId = 5, TotalQuantity = 850 });
            locations.Add(new StockLocation { Id = 6, ProductId = 2, LocationId = 1, TotalQuantity = 50 });
            locations.Add(new StockLocation { Id = 7, ProductId = 2, LocationId = 2, TotalQuantity = 520 });
            locations.Add(new StockLocation { Id = 8, ProductId = 2, LocationId = 3, TotalQuantity = 200 }); ;
            locations.Add(new StockLocation { Id = 9, ProductId = 2, LocationId = 5, TotalQuantity = 40 });
            locations.Add(new StockLocation { Id = 10, ProductId = 3, LocationId = 1, TotalQuantity = 412 });
            locations.Add(new StockLocation { Id = 11, ProductId = 3, LocationId = 5, TotalQuantity = 45 });
            locations.Add(new StockLocation { Id = 12, ProductId = 3, LocationId = 6, TotalQuantity = 34 });
        }

        public List<StockLocation> GetAll()
        {
            return locations;
        }
    }
}
