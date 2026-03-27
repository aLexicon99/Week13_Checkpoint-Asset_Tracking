namespace Week13_Asset_Tracking
{
    internal class Program
    {
        public static List<Assets> assets = new List<Assets>();
        
        static void Main(string[] args)
        {
            Function.AddSampleAssets(assets);
            while (true) AddNewDevice();
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
            //string brand = "NOKIA";

            Console.Write("Enter Model: ");
            string model = Console.ReadLine().Trim();
            //string model = "3310";

            Console.Write("Enter Price in USD: ");
            string price = Console.ReadLine().Trim();
            //string price = "100";

            Console.Write("Enter Purchase Date (ex yyyy-MM-dd): ");
            string date = Console.ReadLine().Trim();
            //string date = "23-6-5";

            Console.Write("Enter Office Country: ");
            string country = Console.ReadLine().Trim();
            //string country = "Germany";

            Console.Write("Enter Currancy (EUR / USD / SEK) : ");
            string currancy = Console.ReadLine().Trim();
            //string currancy = "EUR";

            if (brand == "" || model == "" || price == "" || date == "" || country == "")
            {
                Console.Clear();
                Console.WriteLine($"Wrong/Missing input, Try Again....");
                return;
            }

            // CURRANCY
            if(currancy.ToUpper() != "EUR" && currancy.ToUpper() != "SEK" && currancy.ToUpper() != "USD")
            {
                Console.Clear();
                Console.WriteLine($"Wrong Currancy\nValid Currancy is : EUR, SEK or USD\nTry Again....");
                return;
            }

            // PRICE
            decimal devicePrice = 0;
            bool isValidPrice = decimal.TryParse(price, out decimal decimalPrice);
            if (isValidPrice) devicePrice = decimalPrice;
            else
            {
                Console.Clear();
                Console.WriteLine($"Wrong format of Price : { price }\nTry Again....");
                return;
            }

            // DATE
            DateTime purchaseDate = new DateTime();
            if (date != "")
            {
                bool isValidDate = DateTime.TryParse(date, out DateTime dateResult);
                if (isValidDate) purchaseDate = dateResult;
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Wrong format of Purchase Date : {date}\nTry Again....");
                    return;
                }
            }

            // Add Asset (Computer/Phone)
            if (int.Parse(type) == 1)
                assets.Add(new Smartphone(brand, model, devicePrice, purchaseDate, new Office(country,currancy)));
            if (int.Parse(type) == 2)
                assets.Add(new Computer(brand, model, devicePrice, purchaseDate, new Office(country, currancy)));

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Added New Asset : {brand} {model}");
            Console.ResetColor();

            Assets.ShowDevices(assets);
        }
    }
}
