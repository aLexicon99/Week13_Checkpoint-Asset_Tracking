using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Week13_Asset_Tracking
{
    public class Assets
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public DateTime? PurchaseDate { get; set; }

        public static void ShowDevices(List<Assets> assets)
        {
            Console.WriteLine($"Type\t\tBrand\t\tModel\t\tPurchase Date\t\tPrice in USD");
            Console.WriteLine("----\t\t-----\t\t-----\t\t-------------\t\t------------");

            var sortedAssets = assets.OrderBy(a => a is Computer ? 0 : 1)
                .ThenBy(a => a.PurchaseDate).ToList();

            foreach (Assets device in sortedAssets)
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
                            PresentDeviceInfo(device, deviceDate, ConsoleColor.Red);
                        else if (DateTime.Now >= threeMonthsFromNow)
                            PresentDeviceInfo(device, deviceDate, ConsoleColor.Yellow);
                    }
                    else
                    {
                        PresentDeviceInfo(device, deviceDate);
                    }
                }
            }
        }

        public static void PresentDeviceInfo(Assets device, string date, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{device.GetType().Name}\t{device.Brand,-15}\t{device.Model,-15}\t{date,-15}\t\t{device.Price,-15}");
            if(color != ConsoleColor.White) Console.ResetColor();
            
        }
    }
}
