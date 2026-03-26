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

            // Devices

            List<Device> devices = new List<Device>();

            Smartphone iphone8 =    new Smartphone("iPhone", "8");
            Computer hp =           new Computer("HP", "Elitebook");
            Smartphone iphone11 =   new Smartphone("iPhone", "11");
            Smartphone phoneX =     new Smartphone("iPhone", "X");
            Smartphone motorola =   new Smartphone("Motorola", "Razr");
            Computer hp2 =          new Computer("HP", "Elitebook");
            Computer asus =         new Computer("Asus", "W234");
            Computer lenovo =       new Computer("Lenovo", "Yoga 730");
            Computer lenovo2 =      new Computer("Lenovo", "Yoga 530");

            devices.AddRange(iphone8, hp, iphone11, phoneX, motorola, hp2, asus, lenovo, lenovo2);
            Device.ShowDevices(devices);
        }
    }
}
