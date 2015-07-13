using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipe03.LegacyWebApi.Models
{
    public class GetPhoneManager
    {
        public static List<CellPhone> GetPhones()
        {
            var list = new List<CellPhone>();
            list.Add(new CellPhone { Manufacturer="Samsung", ModelName="Galaxy S4", OperatingSystem="Android", Price=24.98 });
            list.Add(new CellPhone { Manufacturer = "Samsung", ModelName = "Galaxy S5", OperatingSystem = "Android", Price = 99.99 });
            list.Add(new CellPhone { Manufacturer = "Samsung", ModelName = "Galaxy S6", OperatingSystem = "Android", Price = 199.98 });
            list.Add(new CellPhone { Manufacturer = "Samsung", ModelName = "Galaxy S6 Edge", OperatingSystem = "Android", Price = 299.98 });
            list.Add(new CellPhone { Manufacturer = "Samsung", ModelName = "Galaxy S4", OperatingSystem = "Android", Price = 50.00 });
            list.Add(new CellPhone { Manufacturer = "Apple", ModelName = "iPhone 5C", OperatingSystem = "iOS", Price = 50.00 });
            list.Add(new CellPhone { Manufacturer = "Apple", ModelName = "iPhone 6", OperatingSystem = "iOS", Price = 199.99 });
            list.Add(new CellPhone { Manufacturer = "Apple", ModelName = "iPhone 6 Plus", OperatingSystem = "iOS", Price = 299.99 });
            list.Add(new CellPhone { Manufacturer = "Microsoft", ModelName = "Lumia 940", OperatingSystem = "Windows 10", Price = 0.99 });
            list.Add(new CellPhone { Manufacturer = "Microsoft", ModelName = "Lumia 940 XL", OperatingSystem = "Windows 10", Price = 99.99 });
            return list;
        }
    }

    public class CellPhone
    {
        public string ModelName { get; set; }
        public string Manufacturer { get; set; }
        public string OperatingSystem { get; set; }
        public double Price { get; set; }
    }
}