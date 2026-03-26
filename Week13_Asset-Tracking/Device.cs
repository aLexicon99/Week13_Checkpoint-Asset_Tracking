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
            Console.WriteLine($"Type\t\tBrand\t\tModel\t\tPurchase Date");
            Console.WriteLine("----\t\t-----\t\t-----\t\t-------------");


            foreach (Device device in devices)
            {
                DateTime device_PurchaseDate = (DateTime)device.PurchaseDate;
                DateTime warrantyEnd = device_PurchaseDate.AddYears(3);
                DateTime warrany_warningStart = warrantyEnd.AddMonths(-6);

                DateTime sixMonthsFromNow = warrantyEnd.AddMonths(-6);
                DateTime threeMonthsFromNow = warrantyEnd.AddMonths(-3);

                if (device.PurchaseDate != null)
                {

                    if (DateTime.Now >= warrany_warningStart)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{device.GetType().Name}\t{device.Brand,-15}\t{device.Model,-15}\t{device_PurchaseDate,-15}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"{device.GetType().Name}\t{device.Brand,-15}\t{device.Model,-15}\t{device_PurchaseDate,-15}");

                    }

                }
            }
        }
    }
}
