using System.Collections.Generic;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var values = input.Split(' ');

            var stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1)
            {

                int first = int.Parse(stack.Pop());

                string opera = stack.Pop();

                int second = int.Parse(stack.Pop());

                switch (opera)
                {
                        case "+":
                        stack.Push((first + second).ToString());
                        break;

                        case "-":
                        stack.Push((first - second).ToString());
                        break;
                }

            }

            Console.WriteLine(stack.Pop());
        }
    }
}