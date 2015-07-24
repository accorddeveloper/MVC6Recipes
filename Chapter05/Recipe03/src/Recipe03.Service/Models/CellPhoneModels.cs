using System.Collections.Generic;

namespace Recipe03.LegacyWebApi.Models
{
    public class GetPhoneManager
    {
        public static List<CellPhone> GetPhones()
        {
            var list = new List<CellPhone>();
            list.Add(new CellPhone
            { Manufacturer = "Samsung", ModelName = "Galaxy S4", OperatingSystem = "Android", Price = 24.98 });
            list.Add(new CellPhone
            { Manufacturer = "Samsung", ModelName = "Galaxy S5", OperatingSystem = "Android", Price = 99.99 });
            list.Add(new CellPhone
            { Manufacturer = "Samsung", ModelName = "Galaxy S6", OperatingSystem = "Android", Price = 199.98 });
            list.Add(new CellPhone
            { Manufacturer = "Samsung", ModelName = "Galaxy S6 Edge", OperatingSystem = "Android", Price = 299.98 });
            

//others objects removed for brevity
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
