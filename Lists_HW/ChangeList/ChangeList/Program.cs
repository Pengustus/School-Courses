namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Numbers();

            Action(nums);
        }
        
        static List<int> Numbers()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
        }
        static void Action(List<int> nums)
        {
            bool end = false;

            while (end != true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (command[0])
                {
                    case "Delete":
                        nums.Remove(int.Parse(command[1]));
                        break;

                    case "Insert":
                        nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;

                    case "end":
                        end = true;
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}