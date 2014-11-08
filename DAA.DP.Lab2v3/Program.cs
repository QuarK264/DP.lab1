namespace DAA.DP.Lab2v3
{
    using DAA.DP.Lab2v3.Factory;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("In which country you would like to use Mazda? Now only avaliable Russia and Japan.");
            string country = InputCountry();
            if (country == "Russia")
            {
                MazdaFactory factory = new RussianMazdaFactory();

                Console.WriteLine();
                factory.GetCar("Mazda3");
                Console.WriteLine();

                factory.GetCar("Mazda6");
                Console.WriteLine();

                factory.GetCar("CX-5");
                Console.WriteLine();

                factory.GetCar("CX-9");
                Console.WriteLine();
            }
            else
            {
                MazdaFactory factory = new JapanMazdaFactory();

                Console.WriteLine();
                factory.GetCar("Mazda3");
                Console.WriteLine();

                factory.GetCar("Mazda6");
                Console.WriteLine();

                factory.GetCar("CX-5");
                Console.WriteLine();

                factory.GetCar("CX-9");
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static string InputCountry()
        {
            string country;
            do
            {
                country = Console.ReadLine();
            }
            while (!(country == "Russia" || country == "Japan"));
            return country;
        }
    }
}
