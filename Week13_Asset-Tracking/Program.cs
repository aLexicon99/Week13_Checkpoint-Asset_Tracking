using System.Security.Cryptography.X509Certificates;

namespace Week13_Asset_Tracking
{
    internal class Program
    {
        public static List<Assets> assets = new List<Assets>();
        
        static void Main(string[] args)
        {
            Function.AddSampleAssets(assets);

            while (true)
            {
                AddNewDevice();
            }

        }
        public static void AddNewDevice()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Add New Asset by Pressing 1 or 2 to");
            Console.WriteLine("1) Add Smartphone\n2) Add Computer");

            string type = Console.ReadLine().Trim();

            switch (type)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Add NEW Smartphone");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Add NEW Computer");
                    break;
                default:
                    Console.Clear();
                    Assets.ShowDevices(assets);
                    break;
            }

            //Console.Write("Enter Brand: ");
            //string brand = Console.ReadLine().Trim();
            string brand = "HP";

            //Console.Write("Enter Model: ");
            //string model = Console.ReadLine().Trim();
            string model = "ProBook G1";

            Console.Write("Enter Purchase Date (ex yyyy-MM-dd): ");
            string date = Console.ReadLine().Trim();


            DateTime purchaseDate = new();

            // DATE TEST PARSE
            if (date != "")
            {
                bool isValidDate = DateTime.TryParse(date, out DateTime result);
                //Console.WriteLine($"isValidDate : {isValidDate} - Date : {result.ToString("yyyy-MM-dd")}");

                if (isValidDate)
                {
                    purchaseDate = result;
                }
                else
                {
                    Console.WriteLine($"Wrong format of Purchase Date : {date}");
                    return;
                }
            }


            //////////////////////////////////////////////
            if (int.Parse(type) == 1) // NEW Smartphone
            {
                assets.Add(new Smartphone(brand, model, purchaseDate));
            }
            if (int.Parse(type) == 2) // NEW Computer
            {
                assets.Add(new Computer(brand, model, purchaseDate));
            }
            //////////////////////////////////////////////


            string deviceInfo = $"{brand} {model}, {DateTime.Now}";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Added New Asset : {deviceInfo}");
            Console.ResetColor();

            Assets.ShowDevices(assets);
        }
    }
}
