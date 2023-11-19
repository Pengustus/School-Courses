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

            Action(nums);
            
            Console.WriteLine(String.Join(" ", nums.ToArray()));
        }

        static List<int> Action(List<int> nums)
        {
            bool end = false;

            while (end != true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                switch (command[0])
                {
                    case "Add":
                        nums.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        nums.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        nums.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "end":
                        end = true;
                        break;
                }
            }

            return nums;
        }
    }
}