using System;
using System.Collections.Generic;
using System.Text;

namespace Week13_Asset_Tracking
{
    public class Office
    {
        public string Country { get; set; }
        public string Currency { get; set; }

        public Office(string country, string currency)
        {
            Country = country;
            Currency = currency;
        }

        public static decimal GetPrice(string currancy, decimal price)
        {
            decimal currancyPrice = 0;

            // Rates Date : 27/3 - 2026
            switch (currancy)
            {
                case "USD":
                    currancyPrice = price * 0.9m;
                    break;
                case "EUR":
                    currancyPrice = price * 0.86m;
                    break;
                case "SEK":
                    currancyPrice = price * 9.44m;
                    break;

                default: break;
            }
            
            return currancyPrice;
        }
    }
}
