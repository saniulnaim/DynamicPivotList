using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicPivotList
{
    public class ProductRepository
    {
        private List<Product> locations = new List<Product>();

        public ProductRepository()
        {
            locations.Add(new Product { Id = 1, Name = "Ravtop", Code = "R200154", Description = "M3 Plus Smart Bracelet Heart Rate Blood Pressure Health Waterproof Smart Watch M3 Pro Bluetooth", SalesPrice = 2250 });
            locations.Add(new Product { Id = 2, Name = "B57 Water Proof", Code = "B570021", Description = "B57 Smart watches Waterproof Sports for iphone phone Smartwatch Heart Rate Monitor Blood Pressure Functions For Women men kid", SalesPrice = 1850 });
            locations.Add(new Product { Id = 3, Name = "CHYCET", Code = "C220172", Description = "2019 Bluetooth Smart Watch Men Blood Pressure Round Smartwatch Women Watch Waterproof Sport", SalesPrice = 2400 });
            locations.Add(new Product { Id = 4, Name = "Kaihai H 69", Code = "KHSW69", Description = "KAIHAI H69 ECG PPG SpO2 HRV fitness health smart watch men electronic blood pressure measurement Heart rate monitor smartwatch", SalesPrice = 2800 });
            locations.Add(new Product { Id = 5, Name = "Lempo IP67", Code = "L5800AD", Description = "LEMFO Smart Watch Women OTA Update IP67 Waterproof Blood Pressure Heart Rate Call Message Reminder for Sports Watch", SalesPrice = 2800 });
            locations.Add(new Product { Id = 6, Name = "ZGPAX", Code = "2554223", Description = "Smart Watch Men Women 1.3 Inch Round Screen Smart Watch Blood Pressure Measurement Oxygen Smartwatch Watch Smart For IOS Andriod", SalesPrice = 1120 });
        }


        public List<Product> GetAll()
        {
            return locations;
        }

    }
}
