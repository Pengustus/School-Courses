using System.Xml.Linq;

namespace MemoryGame
{
    internal class MemoryGame
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string input = Console.ReadLine();
            int count = 0;

            while (true)
            {
                input.Split(" ").Select(int.Parse).ToArray();
                int index1 = input[0];
                int index2 = input[1];
                
                if (index1 >= 0 && index2 >= 0 && index1 < nums.Count && index2 < nums.Count && index1 != index2)
                {
                    if (nums[index1] == nums[index2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {nums[index1]}!");

                        if (index1 > index2)
                        {
                            nums.RemoveAt(index1);
                            nums.RemoveAt(index2);
                        }
                        else
                        {
                            nums.RemoveAt(index2);
                            nums.RemoveAt(index1);
                        }

                        if (nums.Count == 0)
                        {
                            Console.WriteLine($"You have won in {count} turns!");
                            return;
                        }
                    }
                    else if (nums[index1] != nums[index2])
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    nums.Insert(nums.Count / 2, $"-{count}a");
                    nums.Insert(nums.Count / 2, $"-{count}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                count++;
            }
        }
    }
}