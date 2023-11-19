using System.Threading.Channels;

namespace ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            List<string> commands = new List<string>();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                commands.Add(input);
            }

            bool changed = false;

            foreach (var command in commands)
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                if (action == "Contains")
                {
                    int number = int.Parse(tokens[1]);
                    if (nums.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    List<int> evenNumbers = nums.Where(num => num % 2 == 0).ToList();
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (action == "PrintOdd")
                {
                    List<int> oddNumbers = nums.Where(num => num % 2 != 0).ToList();
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (action == "GetSum")
                {
                    int totalSum = nums.Sum();
                    Console.WriteLine(totalSum);
                }
                else if (action == "Filter")
                {
                    string condition = tokens[1];
                    int filterNumber = int.Parse(tokens[2]);

                    switch (condition)
                    {
                        case "<":
                            nums = nums.Where(num => num < filterNumber).ToList();
                            changed = true;
                            break;
                        case ">":
                            nums = nums.Where(num => num > filterNumber).ToList();
                            changed = true;
                            break;
                        case ">=":
                            nums = nums.Where(num => num >= filterNumber).ToList();
                            changed = true;
                            break;
                        case "<=":
                            nums = nums.Where(num => num <= filterNumber).ToList();
                            changed = true;
                            break;
                    }
                }
            }

            if (changed)
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}