using static System.Formats.Asn1.AsnWriter;

namespace ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            SortedDictionary<string, Dictionary<string, double>> supermarket = new SortedDictionary<string, Dictionary<string, double>>();

            while (input[0] != "Revision")
            {
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (supermarket.ContainsKey(shop))
                {
                    supermarket[shop].Add(product, price);
                }
                else
                {
                    supermarket.Add(shop, new Dictionary<string, double> { { product, price } });                  
                }

                input = Console.ReadLine().Split(", ");
            }

            foreach (var kvp in supermarket)
            {
                Console.WriteLine($"{kvp.Key}->");

                foreach (var product in kvp.Value)
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value:f1}");
            }
        }
    }
}