namespace BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isBalanced = Check(input);

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static bool Check(string sequence)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char skobi in sequence)
            {
                if (skobi == '(' || skobi == '{' || skobi == '[')
                {
                    stack.Push(skobi);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char openSkobi = stack.Pop();

                    if (!Match(openSkobi, skobi))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        static bool Match(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
    }
}