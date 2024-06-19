using static System.Formats.Asn1.AsnWriter;

namespace ConsoleApp1
{
    internal class Program
    {
        public void Shoplist()
        {
            var shop1 = new Shop("Coop", "food", 2);
            var shop2 = new Shop("Netonet", "tech", 3);
            var shop3 = new Shop("Nille", "allrounder", 1);
            List<Shop> stores = new List<Shop>();
            stores.Add(shop1);
            stores.Add(shop2);
            stores.Add(shop3);
        }
        static void Main(string[] args)
        {
            var shop1 = new Shop("Coop", "food", 2);
            var shop2 = new Shop("Netonet", "tech", 3);
            var shop3 = new Shop("Nille", "allrounder", 1);
            List<Shop> stores = new List<Shop>();
            stores.Add(shop1);
            stores.Add(shop2);
            stores.Add(shop3);
            while (true)
            {
                Console.Clear();
                showMenu();
                Console.ReadKey();
            }
            void showMenu()
            {
                Console.WriteLine("For overview over all stores, press 1");
                Console.WriteLine("For all cheap stores, press 2");
                Console.WriteLine("For all middle class stores, press 3");
                Console.WriteLine("For all expensive stores, press 4");
                Console.WriteLine("To add a new store, press 5");
                Console.WriteLine("To exit the application, press 6");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ShowOverview();
                        break;
                    case "2":
                        ShowPrice(1);
                        break;
                    case "3":
                        ShowPrice(2);
                        break;
                    case "4":
                        ShowPrice(3);
                        break;
                    case "5":
                        AddShop();
                        break;
                    case "6":
                        Console.WriteLine("Until next time!");
                        System.Environment.Exit(0);
                        break;
                }
            }
            void ShowOverview()
            {
                foreach (Shop shop in stores)
                {
                    shop.show();
                }
            }
            void ShowPrice(int priceLevel)
            {
                /*for (int i = 0; i < stores.Count; i++) { 
                if (Shop.priceLevel == "1")
                {
                    for (int i = 0; i < Shop.Count; i++)
                    {
                        Console.WriteLine(Shop[i].Navn);
                    }
                    }
                }*/
                foreach (Shop shop in stores)
                {
                    if (shop.PriceLevel == priceLevel)
                    {
                        shop.show();
                    }
                }
            }


            void AddShop()
            {
                Console.WriteLine("Please assign a name for the shop");
                string Shopname = Console.ReadLine();
                Console.WriteLine("Please assign a speciality for the shop");
                string Shopspecification = Console.ReadLine();
                Console.WriteLine("Please assign a priceclass for the shop");
                int ShopPriceClass = int.Parse(Console.ReadLine());
                var shop = new Shop(Shopname, Shopspecification, ShopPriceClass);
                Console.WriteLine($"You have added {Shopname} in stores");
                stores.Add(shop);
            }
        }
    }
}