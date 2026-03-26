using System;
using System.Collections.Generic;
using System.Text;

namespace Week13_Asset_Tracking
{
    public class Device
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime? PurchaseDate { get; set; }

        //public Office AssignedOffice { get; set; }
        public static void ShowDevices(List<Device> devices)
        {
            Console.WriteLine($"Type\t\tBrand\t\tModel\t\t");
            Console.WriteLine("----\t\t-----\t\t-----");

            foreach (Device device in devices)
            {
                Console.WriteLine($"{device.GetType().Name}\t{device.Brand,-15}\t{device.Model,-15}\t");
            }
        }
    }
}
