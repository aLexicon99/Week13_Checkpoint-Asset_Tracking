using System;
using System.Collections.Generic;
using System.Text;

namespace Week13_Asset_Tracking
{
    public class Smartphone : Device
    {
        public Smartphone(string brand, string model, DateTime? purchaseDate)
        {
            Brand = brand;
            Model = model;
            PurchaseDate = purchaseDate;
        }
    }
}
