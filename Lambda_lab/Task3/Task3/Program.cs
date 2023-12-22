using System.Data;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int window = int.Parse(Console.ReadLine());
            int count = 0;
            Queue<string> traffic = new Queue<string>();
            int[] greenTime = { greenLight, window };

            string input = Console.ReadLine();

            while (input != "END")
            {
                if (input == "green")
                {                    

                    while (traffic.Count > greenTime[0] + greenTime[1])
                    {
                        if (traffic.Count == 0)
                        {
                            break;
                        }

                        traffic.Dequeue();
                        count++;
                    }
                    
                }
               else
               {
                    Console.WriteLine($"{traffic.Dequeue} passed!");
                    traffic.Enqueue(input);
               }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{count} total cars passed the crossroads.");
        }
    }
}