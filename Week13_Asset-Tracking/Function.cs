using System;
using System.Collections.Generic;
using System.Text;

namespace Week13_Asset_Tracking
{
    class Function
    {
        public static void AddSampleAssets(List<Assets> assets)
        {
            //Offices
            //Office spain_office = new Office("Spain", "EUR");
            //Office sweden_office = new Office("Sweden", "SEK");
            //Office usa_office = new Office("USA", "USD");

            // Old Demo Devices
            
            Smartphone iphone8 = new Smartphone("iPhone", "8", 970, new DateTime(2018, 12, 29));
            Computer hp = new Computer("HP", "Elitebook", 1423, new DateTime(2019, 6, 1));
            Smartphone iphone11 = new Smartphone("iPhone", "11", 990, new DateTime(2020, 9, 25));
            Smartphone phoneX = new Smartphone("iPhone", "X", 1245, new DateTime(2018, 7, 15));
            Smartphone motorola = new Smartphone("Motorola", "Razr", 970, new DateTime(2020, 3, 16));
            Computer hp2 = new Computer("HP", "Elitebook", 588, new DateTime(2020, 10, 2));
            Computer asus = new Computer("Asus", "W234", 1200, new DateTime(2017, 4, 21));
            Computer lenovo = new Computer("Lenovo", "Yoga 730", 835, new DateTime(2018, 5, 28));
            Computer lenovo2 = new Computer("Lenovo", "Yoga 530", 1030, new DateTime(2019, 5, 21));

            assets.AddRange(iphone8, hp, iphone11, phoneX, motorola, hp2, asus, lenovo, lenovo2);

            // Newer Devices
            Computer macbook = new Computer("Apple", "MacBook Pro M1", 1800, new DateTime(2024, 12, 21));
            Smartphone samsung = new Smartphone("Samsung", "S26 Pro", 980, new DateTime(2023, 5, 19));

            assets.AddRange(macbook, samsung);

            Assets.ShowDevices(assets);
        }
    }
}
