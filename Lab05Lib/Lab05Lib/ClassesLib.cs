using System;


namespace Town
{
    class Town
    {
        public string Name;
        public string Country;
        public string Region;

        public int Population;

        public double YearIncome;
        public double Square;

        public bool HasPort;
        public bool HasAirport;

        public double GetYearIncomePerInhabitant()
        {
            return YearIncome / Population;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть назву міста: ");
            string sName = Console.ReadLine();

            Console.Write("Введіть назву країни: ");
            string sCountry = Console.ReadLine();

            Console.Write("Введіть назву регіону: ");
            string sRegion = Console.ReadLine();

            Console.Write("Введіть кількість населення: ");
            string sPopulation = Console.ReadLine();

            Console.Write("Введіть річний дохід: ");
            string sYearIncome = Console.ReadLine();

            Console.Write("Введіть площу, кв. км: ");
            string sSquare = Console.ReadLine();

            Console.Write("Чи є у місті порт? (y-так, n-ні): ");
            ConsoleKeyInfo keyHasPort = Console.ReadKey();
            Console.WriteLine();

            Console.Write("Чи є у місті аеропорт? (y-так, n-ні): ");
            ConsoleKeyInfo keyHasAirport = Console.ReadKey();
            Console.WriteLine();

            Town OurTown = new Town();

            OurTown.Name = sName;
            OurTown.Country = sCountry;
            OurTown.Region = sRegion;
            OurTown.Population = int.Parse(sPopulation);
            OurTown.YearIncome = double.Parse(sYearIncome);
            OurTown.Square = double.Parse(sSquare);
            OurTown.HasPort = keyHasPort.Key == ConsoleKey.Y;
            OurTown.HasAirport = keyHasAirport.Key == ConsoleKey.Y;

            double YearIncomePerInhabitant = OurTown.GetYearIncomePerInhabitant();
            Console.WriteLine();
            Console.WriteLine("Дані про об‘єкт: ");
            Console.WriteLine("Назва: " + OurTown.Name);
            Console.WriteLine("Країна: " + OurTown.Country);
            Console.WriteLine("Регіон: " + OurTown.Region);
            Console.WriteLine("Кількість населення: " + OurTown.Population.ToString());
            Console.WriteLine("Річний дохід на одного мешканця: " + YearIncomePerInhabitant.ToString("0.00"));
            Console.WriteLine("Річний дохід: " + OurTown.YearIncome.ToString("0.00"));
            Console.WriteLine(OurTown.HasPort ? "У місті є порт" : "У місті нема порту");
            Console.WriteLine(OurTown.HasAirport ? "У місті є аеропорт" : "У місті нема аеропорту");

            Console.ReadKey();
        }
    }
}
