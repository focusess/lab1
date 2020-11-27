using System;

namespace oop_lb2
{

    class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public string Index { get; set; }

    }

    class Program
    {
        static void Main()
        {
            Address address = new Address();

            address.Country = "Ukraine";
            address.City = "Pyriatyn";
            address.Street = "Evropeyskaya Street";
            address.House = "66";
            address.Apartment = "44";
            address.Index = "37000";

            Console.WriteLine("Country: " + address.Country); 
            Console.WriteLine("City: " + address.City);
            Console.WriteLine("Street: " + address.Street);
            Console.WriteLine("House: " + address.House);
            Console.WriteLine("Apartment: " + address.Apartment);
            Console.WriteLine("Index: " + address.Index);

            Console.ReadKey();
        }
    }
}