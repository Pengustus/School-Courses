namespace MaxSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sequence = 1;
            int BestSequenceSize = 0;
            int BestSequenceNum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int rightNum = arr[j];

                    if (currentNum == rightNum)
                    {
                        sequence += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (sequence > BestSequenceNum)
                {
                    BestSequenceSize = sequence;
                    BestSequenceNum = arr[i];
                }

                sequence = 1;
            }

            for (int k = 0; k < BestSequenceSize; k++)
            {
                Console.Write($"{BestSequenceNum} ");
            }
        }
    }
}