namespace CheckStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> absent = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (text[2] == "not")
                {
                    if (absent.Contains(text[0]))
                    {
                        Console.WriteLine($"{text[0]} is already in the list!");
                    }
                    else
                    {
                        absent.Add(text[0]);
                    }
                }
                
                if (text[2] != "not" && absent.Contains(text[0]))
                {            
                        Console.WriteLine($"{text[0]} is in class!");
                        absent.Remove(text[0]); 
                }
            }

            foreach (string s in absent)
            {
                Console.WriteLine(s);
            }

        }
    }
}