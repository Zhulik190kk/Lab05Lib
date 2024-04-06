using System;

public class Town
{
    public string Name;
    public string Country;
    public string Region;
    public long Population;
    public double YearIncome;
    public double Square;
    public bool HasPort;
    public bool HasAirport;

    public double yearIncomePerInhabitant
    {
        get
        {
            return GetYearIncomePerInhabitant();
        }
    }

    public double GetYearIncomePerInhabitant()
    {
        return YearIncome / Population;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Town[] arrTowns;

        Console.Write("Введите количество городов: ");
        int cntTowns = int.Parse(Console.ReadLine());
        arrTowns = new Town[cntTowns];

        for (int i = 0; i < cntTowns; i++)
        {
            Console.Write("Введите название города: ");
            string sName = Console.ReadLine();

            Console.Write("Введите название страны: ");
            string sCountry = Console.ReadLine();

            Console.Write("Введите название региона: ");
            string sRegion = Console.ReadLine();

            Console.Write("Введите количество населения: ");
            long population = long.Parse(Console.ReadLine());

            Console.Write("Введите годовой доход (в $): ");
            double yearIncome = double.Parse(Console.ReadLine());

            Console.Write("Введите площадь, кв. км: ");
            double square = double.Parse(Console.ReadLine());

            Console.Write("Есть ли в городе порт? (y-да, n-нет): ");
            bool hasPort = Console.ReadLine().ToLower() == "y";

            Console.Write("Есть ли в городе аэропорт? (y-да, n-нет): ");
            bool hasAirport = Console.ReadLine().ToLower() == "y";

            Town theTown = new Town
            {
                Name = sName,
                Country = sCountry,
                Region = sRegion,
                Population = population,
                YearIncome = yearIncome,
                Square = square,
                HasPort = hasPort,
                HasAirport = hasAirport
            };

            arrTowns[i] = theTown;
        }

        foreach (Town t in arrTowns)
        {
            Console.WriteLine();
            Console.WriteLine("Данные про город {0}", t.Name);
            Console.WriteLine();
            Console.WriteLine("Страна: " + t.Country);
            Console.WriteLine("Регион: " + t.Region);
            Console.WriteLine("Количество населения: " + t.Population.ToString());
            Console.WriteLine("Годовой доход: $" + t.YearIncome.ToString("0.00"));
            Console.WriteLine("Площадь: " + t.Square.ToString("0.000") + " км²");
            Console.WriteLine(t.HasPort ? "В городе есть порт" : "В городе нет порта");
            Console.WriteLine(t.HasAirport ? "В городе есть аэропорт" : "В городе нет аэропорта");
            Console.WriteLine();
            Console.WriteLine("Средний годовой доход на одного гражданина: $" + t.yearIncomePerInhabitant.ToString("0.00"));
        }

        Console.ReadKey();
    }
}
