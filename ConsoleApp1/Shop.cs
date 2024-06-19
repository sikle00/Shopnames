using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shop
    {
        public string Name { get; set; }
        public string Speciality { get; set; }
        public int PriceLevel { get; set; }
        public Shop(string name, string speciality, int priceLevel)
        {
            PriceLevel = priceLevel;
            Name = name;
            Speciality = speciality;
        }
        public class Stores
        {
            List<Shop> stores = new List<Shop>();
        }
        public void show()
        {
            Console.WriteLine($"Store name: {Name}, Speciality: {Speciality}, Priceclass: {PriceLevel}");
        }
    }
}
