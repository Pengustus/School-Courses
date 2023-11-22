using System.Text;

namespace GameOfWar
{
    internal class GameOfWar
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string tutorial = @"
                            ================================================================================
                            ||                     Welcome to the Game of War!                            ||
                            ||                                                                            ||
                            || HOW TO PLAY:                                                               ||
                            || + Each of the two players are dealt one half of a shuffled deck of cards.  ||
                            || + Each turn, each player draws one card from their deck.                   ||
                            || + The player that drew the card with higher value gets both cards.         ||
                            || + Both cards return to the winner's deck.                                  ||
                            || + If there is a draw, both players place the next three cards face down    ||
                            ||        and then another card face-up. The owner of the higher face-up      ||
                            ||        card gets all the cards on the table.                               ||
                            ||                                                                            ||
                            || HOW TO WIN:                                                                ||
                            || + The player who collects all the cards wins.                              ||
                            ||                                                                            ||
                            || CONTROLS:                                                                  ||
                            || + Press [Enter] to draw a new card until we have a winner.                 ||
                            ||                                                                            ||
                            ||                              Have fun!                                     ||
                            ================================================================================";

            Console.WriteLine(tutorial);

            List<Card> deck = GenerateDeck();
            ShuffleDeck(deck);

            Queue<Card> deck1 = new Queue<Card>();
            Queue<Card> deck2 = new Queue<Card>();

            DealCardsToPlayers(deck, deck1, deck2);

            Card card1;
            Card card2;

            int totalMoves = 0;

            while (!GameHasWinner(deck1, deck2, totalMoves))
            {
                Console.ReadLine();

                DrawPlayersCards(deck1, deck2, card1, card2);

                Queue<Card> pool = new Queue<Card>();

                pool.Enqueue(deck1);
                pool.Enqueue(deck2);

                ProcessWar(pool, deck1, deck2, card1, card2);

                DetermineRoundWinner(pool, deck1, deck2, card1, card2);

                Console.WriteLine("================================================================================");
                Console.WriteLine($"First player currently has {deck1.Count} cards.");
                Console.WriteLine($"First player currently has {deck2.Count} cards.");
                Console.WriteLine("================================================================================");

                totalMoves++;
            }
        }

        static List<Card> GenerateDeck()
        {
            List<Card> deck = new List<Card>();

            CardFace[] faces = (CardFace[])Enum.GetValues(typeof(CardFace));

            CardSuit[] suits = (CardSuit[])Enum.GetValues(typeof(CardSuit));

            for (int suite = 0; suite < suits.Length; suite++)
            {
                for (int face = 0; face < faces.Length; face++)
                {
                    CardFace currentFace = faces[face];
                    CardSuit currentSuit = suits[suite];

                    deck.Add(new Card
                    {
                        Face = currentFace,
                        Suite = currentSuit
                    });
                }
            }

            return deck;
        }

        static void ShuffleDeck(List<Card> deck)
        {
            Random random = new Random();

            for (int i = 0; i < deck.Count; i++)
            {
                int card1index = random.Next(deck.Count);

                Card tempCard = deck[card1index];

                deck[card1index] = deck[i];
                deck[i] = tempCard;
            }
        }

        static void DealCardsToPlayers(List<Card> deck, Queue<Card> deck1, Queue<Card> deck2)
        {
            while (deck.Count > 0)
            {
                Card[] firstTwoDrawnCards = deck.Take(2).ToArray();
                deck.RemoveRange(0, 2);
                deck1.Enqueue(firstTwoDrawnCards[0]);
                deck2.Enqueue(firstTwoDrawnCards[1]);
            }
        }

        static bool GameHasWinner(Queue<Card> deck1, Queue<Card> deck2, int totalMoves)
        {
            if (!deck1.Any())
            {
                Console.WriteLine($"After a total of {totalMoves} moves, the second player has won!");
                return true;
            }

            if (!deck2.Any())
            {
                Console.WriteLine($"After a total of {totalMoves} moves, the first player has won!");
                return true;
            }

            return false;
        }

        static void DrawPlayersCards(Queue<Card> deck1, Queue<Card> deck2, Card card1, Card card2)
        {
            card1 = deck1.Dequeue();
            Console.WriteLine($"First player has drawn: {card1}");

            card2 = deck2.Dequeue();
            Console.WriteLine($"First player has drawn: {card2}");
        }

        static void ProcessWar(Queue<Card> pool, Queue<Card> deck1, Queue<Card> deck2, Card card1, Card card2)
        {
            while ((int)card1.Face == (int)card2.Face)
            {
                Console.WriteLine("WAR!");

                if (deck1.Count < 4)
                {
                    AddCardsToWinnerDeck(deck1, deck2);
                    Console.WriteLine($"First player does not have enough cards to continue playing...");
                    break;
                }

                if (deck2.Count < 4)
                {
                    AddCardsToWinnerDeck(deck1, deck2);
                    Console.WriteLine($"Second player does not have enough cards to continue playing...");
                    break;
                }

                AddWarCardsToPool(pool, deck1, deck2);

                card1 = deck1.Dequeue();
                Console.WriteLine($"First player has drawn: {card1}");

                card2 = deck2.Dequeue();
                Console.WriteLine($"First player has drawn: {card2}");

                pool.Enqueue(card1);
                pool.Enqueue(card2);
            }
        }

        static void AddCardsToWinnerDeck(Queue<Card> loserDeck, Queue<Card> winnerDeck)
        {
            while (loserDeck.Count > 0)
            {
                winnerDeck.Enqueue(loserDeck.Dequeue());
            }
        }

        static void AddWarCardsToPool(Queue<Card> pool, Queue<Card> deck1, Queue<Card> deck2)
        {
            for (int i = 0; i < 3; i++)
            {
                pool.Enqueue(deck1.Dequeue());
                pool.Enqueue(deck2.Dequeue());
            }
        }

        static void DetermineRoundWinner(Queue<Card> pool, Queue<Card> deck1, Queue<Card> deck2, Card card1, Card card2)
        {
            if ((int)card1.Face > (int)card2.Face)
            {
                Console.WriteLine("The first player has won the cards");

                foreach (var card in pool)
                {
                    deck1.Enqueue(card);    
                }
            }

            else
            {
                Console.WriteLine("The second player has won the cards");

                foreach (var card in pool)
                {
                    deck2.Enqueue(card);
                }
            }
        }
    }
}