namespace SoftuniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            HashSet<string> counts = new HashSet<string>();

            bool apres = false;

            while (name != "END")
            {
                if (name == "PARTY")
                {
                    apres = true;
                }
                
                if (apres)
                {
                    counts.Remove(name);    
                }
                else
                {
                    counts.Add(name);
                }

                name = Console.ReadLine();
            }

            Console.WriteLine(counts.Count);
            
            foreach (var count in counts)
            {
                Console.WriteLine(count);
            }
        }
    }
}