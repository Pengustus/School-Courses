namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            Sum(text, num);
        }

        static void Sum(string text, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(text);
            }
        }
    }
}