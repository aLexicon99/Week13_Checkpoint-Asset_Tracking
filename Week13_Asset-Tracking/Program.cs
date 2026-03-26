namespace Week13_Asset_Tracking
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Offices

            Office spain_office =   new Office("Spain", "EUR");
            Office sweden_office =  new Office("Sweden", "SEK");
            Office usa_office =     new Office("USA", "USD");

            // PurchaseDate
            //DateTime purchaseDate = new DateTime(2018, 12, 21);
            //Console.WriteLine(purchaseDate.ToShortDateString());

            //DateTime warrantyEnd = purchaseDate.AddYears(3);
            //Console.WriteLine("Warrany ends @ " + warrantyEnd);

            ////DateTime purchaseDate2 = DateTime.Parse("12/29/2018");
            //Console.ReadLine();


            // Devices

            List<Device> devices = new List<Device>();

            Smartphone iphone8 =    new Smartphone("iPhone", "8",       new DateTime(2018, 12, 29));
            Computer hp =           new Computer("HP", "Elitebook",     new DateTime(2019, 6, 1));
            Smartphone iphone11 =   new Smartphone("iPhone", "11",      new DateTime(2020, 9, 25));
            Smartphone phoneX =     new Smartphone("iPhone", "X",       new DateTime(2018, 7, 15));
            Smartphone motorola =   new Smartphone("Motorola", "Razr",  new DateTime(2020, 3, 16));
            Computer hp2 =          new Computer("HP", "Elitebook",     new DateTime(2020, 10, 2));
            Computer asus =         new Computer("Asus", "W234",        new DateTime(2017, 4, 21));
            Computer lenovo =       new Computer("Lenovo", "Yoga 730",  new DateTime(2018, 5, 28));
            Computer lenovo2 =      new Computer("Lenovo", "Yoga 530",  new DateTime(2019, 5, 21));
            Computer macbook =      new Computer("Apple", "MacBook",    new DateTime(2024, 12, 21));


            devices.AddRange(iphone8, hp, iphone11, phoneX, motorola, hp2, asus, lenovo, lenovo2, macbook);
            Device.ShowDevices(devices);
        }
    }
}
