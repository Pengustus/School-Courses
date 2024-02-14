namespace RoadSafety
{
    internal class RoadSafety
    {
        static void Main(string[] args)
        {
            int green = int.Parse(Console.ReadLine());
            int window = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int count = 0;
            int crash = 0;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                if (input == "light")
                {
                    int light = green;

                    while (light > 0 && cars.Count > 0)
                    {
                        string car = cars.Dequeue();
                        int symbols = car.Length;

                        if (light - symbols >= 0)
                        {
                            light -= symbols;
                            count++;
                        }
                        else if (light - symbols + window >= 0)
                        {
                            count++;

                            break;
                        }
                        else
                        {
                            char hit = car[light + window];

                            Console.WriteLine("Accident!");
                            Console.WriteLine($"{car} was crushed at {hit}.");

                            crash++;

                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

                if (crash > 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (crash <= 0)
            {
                Console.WriteLine("Success!");
                Console.WriteLine($"{count} total cars are gone.");
            }
        }
    }
}