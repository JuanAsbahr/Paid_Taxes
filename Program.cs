using Paid_Taxes.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        List<TaxPayer> list = new List<TaxPayer>();
        
        Console.Write("Enter the number of tax payers: ");
        int numberTax = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= numberTax; i++)
        {
            Console.WriteLine($"Tax payer #{i} data");
            Console.Write("Individual or company (i/c)? ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Anual Income: $ ");
            double anualIncome = double.Parse(Console.ReadLine());

            if (ch == i)
            {
                Console.Write("Health expenditures: $");
                double healthExpenditures = double.Parse(Console.ReadLine());
                list.Add(new Individual(name, anualIncome, healthExpenditures));
            }
            else
            {
                Console.Write("Number of employees: ");
                int numberOfEmployees = int.Parse(Console.ReadLine());
                list.Add(new Company(name, anualIncome, numberOfEmployees));
            }
            Console.WriteLine();
        }
        Console.WriteLine("TAXES PAID:");
        foreach (TaxPayer taxPayer in list)
        {
            Console.WriteLine(taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
        }


    }
}