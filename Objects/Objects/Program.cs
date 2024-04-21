using System;

namespace HomeTask260123
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Notebook[] notes = new Notebook[5];

            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine("Brand of product: ");
                string Brand = Console.ReadLine();

                Console.WriteLine("Model of product: ");
                string Model = Console.ReadLine();

                double price;
                do
                {
                    Console.WriteLine("Price of product: ");
                    string Price = Console.ReadLine();
                    price = Convert.ToDouble(Price);

                } while (price <= 0);

                Notebook Pc = new Notebook(Brand, Model, price);
                notes[i] = Pc;
            }

            double sum = 0;
            for (int i = 0; i < notes.Length; i++)
            {
                sum += notes[i].Price;

            }
            double avarage = sum / notes.Length;

            Console.WriteLine(avarage);
        }
    }
}
