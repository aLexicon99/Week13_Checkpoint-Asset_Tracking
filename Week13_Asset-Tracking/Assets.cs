using System;
using System.Collections.Generic;
using System.Text;

namespace Week13_Asset_Tracking
{
    public class Assets
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime? PurchaseDate { get; set; }

        //public Office AssignedOffice { get; set; }
        public static void ShowDevices(List<Assets> assets)
        {
            Console.WriteLine($"Type\t\tBrand\t\tModel\t\tPurchase Date");
            Console.WriteLine("----\t\t-----\t\t-----\t\t-------------");


            foreach (Assets device in assets)
            {
                DateTime dateTime = DateTime.Now;
                DateTime device_PurchaseDate = (DateTime)device.PurchaseDate;
                string deviceDate = device_PurchaseDate.ToString("yyyy-MM-dd");

                DateTime warrantyEnd = device_PurchaseDate.AddYears(3);
                DateTime warrany_warningStart = warrantyEnd.AddMonths(-6);

                DateTime sixMonthsFromNow = warrantyEnd.AddMonths(-6);
                DateTime threeMonthsFromNow = warrantyEnd.AddMonths(-3);

                if (device.PurchaseDate.HasValue)
                {
                    if (dateTime >= warrany_warningStart)
                    {
                        if(dateTime >= warrantyEnd)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{device.GetType().Name}\t{device.Brand,-15}\t{device.Model,-15}\t{deviceDate,-15}");
                            Console.ResetColor();
                        }else if (DateTime.Now >= threeMonthsFromNow) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{device.GetType().Name}\t{device.Brand,-15}\t{device.Model,-15}\t{deviceDate,-15}");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{device.GetType().Name}\t{device.Brand,-15}\t{device.Model,-15}\t{deviceDate,-15}");

                    }
                }
            }
        }
    }
}
