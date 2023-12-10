namespace TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] petrol = new int[n];
            int[] distance = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                petrol[i] = int.Parse(input[0]);
                distance[i] = int.Parse(input[1]);
            }

            int start = StartPoint(n, petrol, distance);

            Console.WriteLine(start);
        }

        static int StartPoint(int n, int[] petrol, int[] distance)
        {
            int start = 0;
            int currentFuel = 0;
            int allFuel = 0;
            int totalDistance = 0;

            for (int i = 0; i < n; i++)
            {
                allFuel += petrol[i] - distance[i];
                currentFuel += petrol[i] - distance[i];

                if (currentFuel < 0)
                {
                    currentFuel = 0;
                    start = i + 1;
                }

                totalDistance += distance[i];
            }

            if (allFuel >= 0 && totalDistance >= 0)
            {
                return start % n;
            }
            else
            {
                return -1;
            }
        }
    }
}