using System;

namespace Second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Виберіть категорію:");

            foreach (Type category in Enum.GetValues(typeof(Type)))
            {
                Console.WriteLine($"{category} - {(int)category}");
            }

            Type filterCategory = (Type)int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть максимальну ціну:");
            double filterPrice = double.Parse(Console.ReadLine());

            Predicate<Product> filter = p => p.Type == filterCategory && p.Price > filterPrice;

            Action<Product> display = p => Console.WriteLine($"{p.Name} - {p.Price}");

            for (int i = 1; i <= 3; i++)
            {
                string fileName = $"{i}.json";

                using (StreamReader reader = new StreamReader(fileName))
                {
                    string json = reader.ReadToEnd();
                    List<Product> products = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(json);

                    foreach (Product p in products)
                    {
                        if (filter(p))
                        {
                            display(p);
                        }
                    }
                }
            }
        }
    }
}
