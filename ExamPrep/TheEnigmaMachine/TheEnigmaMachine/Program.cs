namespace TheEnigmaMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] split = input.Split("|");

                string command = split[0];

                switch (command)
                {
                    case "ChangeAll":
                        message = message.Replace(split[1], split[2]);
                        break;

                    case "Insert":
                        message = message.Insert(int.Parse(split[1]), split[2]);
                        break;

                    case "Move":
                        string subs = message.Substring(0, int.Parse(split[1]));
                        message = message.Remove(0, int.Parse(split[1]));
                        message += subs;
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}