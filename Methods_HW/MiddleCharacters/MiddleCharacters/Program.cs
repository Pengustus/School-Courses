namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Check(name);
        }

        static void Check(string name)
        {
            int length = name.Length;
            
            if (length % 2 == 0)
            {
                int even1 = (int)Math.Ceiling((double)(length / 2)) - 1;
                int even2 = (int)Math.Ceiling((double)(length / 2));

                Console.WriteLine($"{name[even1]}{name[even2]}");
            }
            else
            {
                int odd = (int)Math.Ceiling((double)(length / 2));
                Console.WriteLine(name[odd]);
            }
        }
    }
}