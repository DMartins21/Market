using System;
using Market.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new();

            Console.WriteLine("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <=n; i++)
            {
                Console.WriteLine($"Product {i} data:");
                Console.WriteLine("Common, used or imported (c/u/i)?");
                char t = char.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Price:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(t == 'c')
                {
                    list.Add(new Product(name, price));
                }else if(t == 'u')
                {
                    Console.WriteLine("Manufacture date (DD/MM/yyyy):");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    Console.WriteLine("Customs fee:");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }
            Console.WriteLine("\nPrice Tags:");

            foreach(Product p in list)
            {
                Console.WriteLine(p.priceTag());
            }
        }
    }
}
