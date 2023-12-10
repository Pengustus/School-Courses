namespace Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string nums = "0123456789";
            bool what = false;
            
            if (name.Length > 2 && letters.Contains(name[0]))
            {               
                foreach (char c in nums)
                {
                    if (name.Contains(c))
                    {
                        Console.WriteLine("Invalid name!");
                        break;
                    }
                    else
                    {
                        what = true;
                        Console.WriteLine("valid");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid name!");
            }
        }
    }
}