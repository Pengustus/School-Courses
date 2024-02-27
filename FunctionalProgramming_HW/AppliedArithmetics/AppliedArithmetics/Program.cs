namespace AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Action<List<int>> action = null;

            while (true)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "add":
                        action = Add;
                        break;

                    case "subtarct":
                        action = Sub;
                        break;
                    case "multiply":
                        action = Mul;
                        break;
                    case "print":
                        action = Print;
                        break;
                }

                if (command == "end")
                    break;

                action.Invoke(nums);
            }
        }

        static void Add(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] += 1;
            }
        }

        static void Sub(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] -= 1;
            }
        }
        static void Mul(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] *= 2;
            }
        }
        static void Print(List<int> nums)
        {
            Console.WriteLine($"{String.Join(" ", nums)}");
        }
    }
}