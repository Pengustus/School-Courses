namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            RaisedPower(num, power);
        }

        static void RaisedPower(double num, int power)
        {                      
            Console.WriteLine(Math.Pow(num, power));
        }
    }
}