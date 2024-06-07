using System.Text;

namespace SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();
            Stack<string> commands = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] operation = Console.ReadLine()
                    .Split();

                switch (operation[0])
                {
                    case "1":

                        text.Append(operation[1]);
                        commands.Push($"2 {operation[1].Length}");

                        break;

                    case "2":

                        int count = int.Parse(operation[1]);
                        int start = Math.Max(0, text.Length - count);
                        string deleted = text.ToString(start, count);
                        text.Remove(start, count);
                        commands.Push($"1 {deleted}");

                        break;

                    case "3":

                        int index = int.Parse(operation[1]);
                        char result = text[index - 1];
                        Console.WriteLine(result);

                        break;

                    case "4":

                        if (commands.Count > 0)
                        {
                            string lastCommand = commands.Pop();
                            string[] parts = lastCommand.Split();
                            int operationType = int.Parse(parts[0]);

                            switch (operationType)
                            {
                                case 1:

                                    text.Append(parts[1]);
                                    break;
                                case 2:

                                    int undoCount = int.Parse(parts[1]);
                                    text.Remove(text.Length - undoCount, undoCount);
                                    break;
                            }
                        }

                        break;
                }         
            }
        }
    }
}