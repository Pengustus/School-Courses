using System;

namespace NamingSir
{
    internal class NamingSir
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().ToArray();
            Action<string[]> sir = s =>
            {
                foreach (string name in names)
                {
                    Console.WriteLine("Sir " + name);
                }
            };
            sir(names);
        }
    }
}