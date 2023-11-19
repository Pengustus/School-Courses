namespace ListOperations
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

            Console.WriteLine(string.Join(" ", nums));
        }

        static List<int> Action(List<int> nums)
        {
            bool end = false;

            while (end != true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (command[0])
                {
                    case "Add":
                        nums.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Remove":
                        nums.RemoveAt(int.Parse(command[1]));
                        break;
                    case "ShiftLeft":
                        nums.Insert(int.Parse(command[1]), nums[0]);
                        break;
                    case "ShiftRight":
                        nums.Insert(int.Parse(command[1]), nums[nums.Count]);
                        break;
                    case "End":
                        end = true;
                        break;
                }
            }

            return nums;
        }
    }
}