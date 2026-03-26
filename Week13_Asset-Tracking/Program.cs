namespace Week13_Asset_Tracking
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Smartphone phone = new Smartphone("Nokia", "3310");
            Console.WriteLine(phone.Info());

            Computer pc = new Computer("Dell", "3010");
            Console.WriteLine(pc.Info());

        }
    }
}
