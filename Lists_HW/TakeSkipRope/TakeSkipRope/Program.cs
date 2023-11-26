namespace TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> nums = new List<int>();
            List<char> text = new List<char>();

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    nums.Add(int.Parse(c.ToString()));
                }
                else
                {
                    text.Add(c);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(nums[i]);
                }
                else
                {
                    skipList.Add(nums[i]);
                }
            }

            int skipCount = 0;
            string result = null;

            for (int i = 0; i < takeList.Count; i++)
            {
                int takeCount = takeList[i];
                int skipChars = skipList[i];

                skipCount += skipChars;

                if (skipCount < text.Count)
                {
                    result += new string(text.Skip(skipCount).Take(takeCount).ToArray());
                }

                skipCount += takeCount;
            }

            Console.WriteLine(result);
        }
    }
}