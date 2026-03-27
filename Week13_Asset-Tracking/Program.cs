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
            Console.WriteLine("Add New Asset by Pressing (1) or (2)");
            Console.WriteLine("1) Add Smartphone\n2) Add Computer");
            Console.Write(">> Select Option: ");

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

            Console.Write("Enter Brand: ");
            string brand = Console.ReadLine().Trim();

            Console.Write("Enter Model: ");
            string model = Console.ReadLine().Trim();

            Console.Write("Enter Price in USD: ");
            string price = Console.ReadLine().Trim();

            Console.Write("Enter Purchase Date (ex yyyy-MM-dd): ");
            string date = Console.ReadLine().Trim();

            if (brand == "" || model == "" || price == "")
            {
                Console.Clear();
                Console.WriteLine($"Wrong/Missing input, Try Again....");
                return;
            }

            decimal devicePrice = 0;
            bool isValidPrice = decimal.TryParse(price, out decimal decimalPrice);
            if (isValidPrice)
            {
                devicePrice = decimalPrice;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Wrong format of Price : { price }\nTry Again....");
                return;
            }

            DateTime purchaseDate = new DateTime();
            if (date != "")
            {
                bool isValidDate = DateTime.TryParse(date, out DateTime result);
                if (isValidDate) purchaseDate = result;
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Wrong format of Purchase Date : {date}\nTry Again....");
                    return;
                }
            }

            // Add Asset (Computer/Phone)
            if (int.Parse(type) == 1)
                assets.Add(new Smartphone(brand, model, devicePrice, purchaseDate));
            if (int.Parse(type) == 2)
                assets.Add(new Computer(brand, model, devicePrice, purchaseDate));


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Added New Asset : {brand} {model}");
            Console.ResetColor();

            Assets.ShowDevices(assets);
        }
    }
}
