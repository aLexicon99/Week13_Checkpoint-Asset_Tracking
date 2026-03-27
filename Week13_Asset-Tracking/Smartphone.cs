using System;
using System.Collections.Generic;
using System.Text;

namespace Week13_Asset_Tracking
{
    public class Smartphone : Assets
    {
        public Smartphone(string brand, string model, decimal price, DateTime purchaseDate)
        {
            Brand = brand;
            Model = model;
            Price = price;
            PurchaseDate = purchaseDate;
        }
    }
}
