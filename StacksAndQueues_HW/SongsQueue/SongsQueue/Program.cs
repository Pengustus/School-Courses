namespace SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ");

            Queue<string> songList = new Queue<string>(songs);

            while (songList.Count > 0)
            {
                string[] command = Console.ReadLine()
                    .Split(" ");

                switch (command[0])
                {
                    case "Play":

                        if (songList.Count > 0)
                        {
                            string currentSong = songList.Dequeue();
                            Console.WriteLine($"Now playing: {currentSong}");
                        }
                        else
                        {
                            Console.WriteLine("No more songs!");
                        }

                        break;

                    case "Add":

                        if (!songList.Contains(command[1]))
                        {
                            songList.Enqueue(command[1]);
                            Console.WriteLine($"{command[1]} has been added to the queue.");
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} is already contained!");
                        }

                        break;

                    case "Show":

                        Console.WriteLine("Songs in the queue: " + string.Join(", ", songList));
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}