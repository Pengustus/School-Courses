namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = GetIntList();

            int capacity = int.Parse(Console.ReadLine());

            string[] command = GetStringArr();
            
            while (command[0]?.ToLower() != "end")
            {
                switch (command[0]?.ToLower())
                {
                    case "add":
                        nums.Add(int.Parse(command[1]));
                        break;

                    default:
                        AddNumberToListElement(nums, capacity, command[0]);
                        break;
                }
                
                command = GetStringArr();
            }

            Console.WriteLine(String.Join(" ", nums));
        }

        static List<int> GetIntList()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
        }

        static string[] GetStringArr()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
        }

        static List<int> AddNumberToListElement(List<int> list, int capacity, string number)
        {
            int convertedNumber = int.Parse(number);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] + convertedNumber <= capacity)
                {
                    list[i] += convertedNumber;
                    break;
                }
            }

            return list;
        }
    }
}