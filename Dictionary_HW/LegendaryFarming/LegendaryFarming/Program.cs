namespace LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);

            SortedDictionary<string, int> junks = new SortedDictionary<string, int>();

            bool legendary = false;

            while (!legendary)
            {
                string[] loot = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();

                for (int i = 0; i < loot.Length; i += 2)
                {
                    int quantity = int.Parse(loot[i]);
                    string material = loot[i + 1];

                    if (materials.ContainsKey(material))
                    {
                        materials[material] += quantity;
                    }
                    else if (junks.ContainsKey(material))
                    {
                        junks[material] += quantity;
                    }
                    else
                    {
                        junks.Add(material, quantity);
                    }

                    if (materials["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne is obtained!");
                    }
                }
            }
        }
    }
}