namespace StorageKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double bigVolume = 0;
            string bestKeg = " ";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > bigVolume)
                {
                    bigVolume = volume;
                    bestKeg = model;
                }
            }

            Console.WriteLine(bestKeg);
        }
    }
}