namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            int swords = 0;
            int extraCarbon = 0;
            int carbonSum = 0;

            switch (carbon.Peek() + steel.Peek() + extraCarbon)
            {
                case 70:
                    
            }
        }
    }
}