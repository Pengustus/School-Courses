namespace SecretMessages
{
    internal class SecretMessages
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Read")
            {
                string[] split = input.Split("<->");
                string command = split[0];

                switch (command)
                {
                    case "ReplaceAll":
                        line = line.Replace(split[1], split[2]);
                        Console.WriteLine(line);
                        break;

                    case "Backward":
                        if (line.Contains(split[1]))
                        {
                            string reversed = "";
                            string wordToReverse = split[1];
                            for (int i = wordToReverse.Length - 1; i >= 0; i--)
                            {
                                reversed += wordToReverse[i];
                            }
                            line = line.Replace(split[1], reversed);
                            Console.WriteLine(line);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        
                        break;

                    case "Space":
                        int space = int.Parse(split[1]);
                        line = line.Insert(space, " ");
                        Console.WriteLine(line);
                        break;
                }
            }

            Console.WriteLine($"You have a secret text message: {line}");
        }
    }
}