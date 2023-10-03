using System.Reflection.Metadata;

namespace metersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string ex = Console.ReadLine();

                if (ex == "break")
                {
                    break;
                }

                switch (ex)
                {
                    case "one":
                        decimal num = decimal.Parse(Console.ReadLine());
                        decimal kilometer = num / 1000;
                        Console.WriteLine($"{kilometer:F2}");
                        break;

                    case "two":
                        decimal pound = decimal.Parse(Console.ReadLine());
                        decimal dollar = pound * 1.31m;
                        Console.WriteLine($"{dollar:F3}");
                        break;

                    case "three":
                        int n = int.Parse(Console.ReadLine());
                        decimal sum = 0;

                        for (int i = 0; i < n; i++)
                        {
                            decimal number = decimal.Parse(Console.ReadLine());;
                            sum += number;
                        }

                        Console.WriteLine($"{sum}");
                        break;

                    case "four":
                        int century = int.Parse(Console.ReadLine());
                        int years = century * 100;
                        double days = Math.Floor(years * 365.2422);
                        double hours = Math.Floor(days * 24);
                        double minutes = Math.Floor(hours * 60);

                        Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

                        break;

                    case "five":
                        int num1 = int.Parse(Console.ReadLine());
                        int sum1 = 0;
                        
                        for (int j = 1; j <= num1; j++)
                        {
                            int num01 = j;
                            while(num01 > 0)
                            {
                                sum1 += num01 % 10;
                                num01 /= 10;
                            }            
                            
                            if (sum1 == 5 || sum1 == 7 || sum1 == 11)
                            {
                                Console.WriteLine($"{j} -> True");
                            }
                            else
                            {
                                Console.WriteLine($"{j} -> False");
                            }

                            sum1 = 0;
                        }
                        break;

                    case "six":
                        char one = char.Parse(Console.ReadLine());
                        char two = char.Parse(Console.ReadLine());
                        char three = char.Parse(Console.ReadLine());

                        Console.Write($"{three} {two} {one}");
                        break;

                    case "seven":
                        string name1 = Console.ReadLine();
                        string name2 = Console.ReadLine();
                        string name3 = Console.ReadLine();

                        Console.WriteLine($"{name1}{name3}{name2}");
                        break;

                    case "eight":
                        string city = Console.ReadLine();
                        double population = double.Parse(Console.ReadLine());
                        double area = double.Parse(Console.ReadLine());

                        Console.WriteLine($"Town {city} has population of {population} and area {area} square km.");
                        break;

                    case "nine":
                        string first = Console.ReadLine();
                        string second = Console.ReadLine();
                        string third = Console.ReadLine();
                        
                        Console.WriteLine($"{first.ToString()}{second.ToString()}{third.ToString()}");
                        break;

                    case "ten":
                        char letter = char.Parse(Console.ReadLine());
                        if(char.IsUpper(letter))
                        {
                            Console.WriteLine("upper-case");
                        }
                        else
                        {
                            Console.WriteLine("lower-case");
                        }
                        break;
                }
            }
        }
    }
}