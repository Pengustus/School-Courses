namespace CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> deck2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Deck(deck1, deck2);

            if (deck1.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {deck1.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {deck2.Sum()}");
            }
        }

        static List<int> Deck(List<int> deck1, List<int> deck2)
        {
            while (deck1.Count > 0 && deck2.Count > 0)
            {
                int card1 = deck1[0];
                int card2 = deck2[0];

                if (card1 > card2)
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                    deck1.Add(card1);
                    deck1.Add(card2);
                }

                if (card1 < card2)
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                    deck2.Add(card2);
                    deck2.Add(card1);
                }

                if (card1 == card2)
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
            }

            return deck1;
            return deck2;
        }
    }
}