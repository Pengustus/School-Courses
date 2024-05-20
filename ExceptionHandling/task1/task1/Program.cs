namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(num));
            } catch
            {
                Console.WriteLine("Invalid number");
            } finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}