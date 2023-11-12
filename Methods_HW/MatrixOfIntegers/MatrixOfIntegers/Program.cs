namespace MatrixOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Printing(num);
        }

        static void Printing(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 1; j < num; j++)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine(num);
            }
        }
    }
}