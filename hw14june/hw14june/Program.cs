using System;

namespace hw14june
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] humans = new Human[]
            {
                new Human(10, "Abbas", "Qulamov"),
                new Human(24, "Hikmet", "Abbasov"),
                new Human(44, "Nezrin", "Qulamov"),
            };

            string search;
            do
            {
                Console.WriteLine("Console deyerini daxil edin:");
                 search = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(search));


            foreach(var item in humans)
            {
                if(item.Name.Contains(search))
                Console.WriteLine($"{item.Name} {item.Surname} - {item.Age}");
            }

        }
    }
}
