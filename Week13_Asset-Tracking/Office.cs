using System;
using System.Collections.Generic;
using System.Text;

namespace Week13_Asset_Tracking
{
    internal class Office
    {
        public string Country { get; set; }
        public string Currency { get; set; }

        public Office(string country, string currency)
        {
            Country = country;
            Currency = currency;
        }
    }
}
