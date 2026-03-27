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

        public string GetPrice()
        {
            return Currency;
        }
    }
}
