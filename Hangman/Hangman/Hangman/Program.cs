﻿const string winScreen =
                            @"
                            ┌───────────────────────────┐
                            │                           │
                            │ WW       WW  **  NN   N   │
                            │ WW       WW  ii  NNN  N   │
                            │  WW  WW WW   ii  N NN N   │
                            │   WWWWWWW    ii  N  NNN   │
                            │    WW  W     ii  N   NN   │
                            │                           │
                            │         Good job!         │
                            │   You guessed the word!   │
                            └───────────────────────────┘
                            ";

const string lossScreen =
                @"
                            ┌────────────────────────────────────┐
                            │  LLL          OOOO    SSSS   SSSS  │
                            │  LLL         OO  OO  SS  SS SS  SS │
                            │  LLL        OO    OO SS     SS     │
                            │  LLL        OO    OO  SSSS   SSSS  │
                            │  LLL        OO    OO     SS     SS │
                            │  LLLLLLLLLL  OO  OO  SS  SS SS  SS │
                            │   LLLLLLLLL   OOOO    SSSS   SSSS  │
                            │                                    |
                            │        You were so close.          │
                            │ Next time you will guess the word! │
                            └────────────────────────────────────┘
                            ";

string[] wrongGuesses = {
                            @"      ╔═══╗   " + '\n' +
                            @"      |   ║   " + '\n' +
                            @"          ║   " + '\n' +
                            @"          ║   " + '\n' +
                            @"          ║   " + '\n' +
                            @"     ███  ║   " + '\n' +
                            @"    ══════╩═══",

                            @"      ╔═══╗   " + '\n' +
                            @"      |   ║   " + '\n' +
                            @"      O   ║   " + '\n' +
                            @"          ║   " + '\n' +
                            @"          ║   " + '\n' +
                            @"     ███  ║   " + '\n' +
                            @"    ══════╩═══",

                                @"      ╔═══╗   " + '\n' +
                            @"      |   ║   " + '\n' +
                            @"      O   ║   " + '\n' +
                            @"      |   ║   " + '\n' +
                            @"          ║   " + '\n' +
                            @"     ███  ║   " + '\n' +
                            @"    ══════╩═══",

                                @"      ╔═══╗   " + '\n' +
                            @"      |   ║   " + '\n' +
                            @"      O   ║   " + '\n' +
                            @"      |\  ║   " + '\n' +
                            @"          ║   " + '\n' +
                            @"     ███  ║   " + '\n' +
                            @"    ══════╩═══",

                                @"      ╔═══╗   " + '\n' +
                            @"      |   ║   " + '\n' +
                            @"      O   ║   " + '\n' +
                            @"     /|\  ║   " + '\n' +
                            @"          ║   " + '\n' +
                            @"     ███  ║   " + '\n' +
                            @"    ══════╩═══",

                                @"      ╔═══╗   " + '\n' +
                            @"      |   ║   " + '\n' +
                            @"      O   ║   " + '\n' +
                            @"     /|\  ║   " + '\n' +
                            @"       \  ║   " + '\n' +
                            @"     ███  ║   " + '\n' +
                            @"    ══════╩═══",

                                @"      ╔═══╗   " + '\n' +
                            @"      |   ║   " + '\n' +
                            @"      O   ║   " + '\n' +
                            @"     /|\  ║   " + '\n' +
                            @"     / \  ║   " + '\n' +
                            @"     ███  ║   " + '\n' +
                            @"    ══════╩═══"
                        };

string[] death = {
                                @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"     ███  ║   " + '\n' +
                                @"    ══════╩═══",

                                @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"     ███  ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"     ███  ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"      |\  ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"     ███  ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"     /|\  ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"     ███  ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"     /|\  ║   " + '\n' +
                                @"       \  ║   " + '\n' +
                                @"     ███  ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"     /|\  ║   " + '\n' +
                                @"     / \  ║   " + '\n' +
                                @"     ███  ║   " + '\n' +
                                @"    ══════╩═══",


                                @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"     /|\  ║   " + '\n' +
                                @"     / \  ║   " + '\n' +
                                @"     ███  ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"     /|\  ║   " + '\n' +
                                @"     / \  ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      o>  ║   " + '\n' +
                                @"     /|   ║   " + '\n' +
                                @"      >\  ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"     /|\  ║   " + '\n' +
                                @"     / \  ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"     <o   ║   " + '\n' +
                                @"      |\  ║   " + '\n' +
                                @"     /<   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"     /|\  ║   " + '\n' +
                                @"     / \  ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      o>  ║   " + '\n' +
                                @"     /|   ║   " + '\n' +
                                @"      >\  ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      o>  ║   " + '\n' +
                                @"     /|   ║   " + '\n' +
                                @"      >\  ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"     /|\  ║   " + '\n' +
                                @"     / \  ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"     <o   ║   " + '\n' +
                                @"      |\  ║   " + '\n' +
                                @"     /<   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"     <o   ║   " + '\n' +
                                @"      |\  ║   " + '\n' +
                                @"     /<   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"     <o   ║   " + '\n' +
                                @"      |\  ║   " + '\n' +
                                @"     /<   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"     /|\  ║   " + '\n' +
                                @"     / \  ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      o   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      o   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      o   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      o   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      o   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      o   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"      /   ║   " + '\n' +
                                @"      \   ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"      '   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    |__   ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"      .   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    \__   ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"      '   ║   " + '\n' +
                                @"   ____   ║   " + '\n' +
                                @"    ══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"      '   ║   " + '\n' +
                                @"      .   ║   " + '\n' +
                                @"    __    ║   " + '\n' +
                                @"   /══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"      .   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"    _ '   ║   " + '\n' +
                                @"  _/══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"      '   ║   " + '\n' +
                                @"      _   ║   " + '\n' +
                                @" __/══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"      '   ║   " + '\n' +
                                @"      .   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @" __/══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"      .   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"      '   ║   " + '\n' +
                                @" __/══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"      '   ║   " + '\n' +
                                @"      _   ║   " + '\n' +
                                @" __/══════╩═══",

                                    @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"      '   ║   " + '\n' +
                                @"      .   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @" __/══════╩═══",

                                @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"      .   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"      '   ║   " + '\n' +
                                @" __/══════╩═══",

                                @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"      '   ║   " + '\n' +
                                @"      _   ║   " + '\n' +
                                @" __/══════╩═══",

                                @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"      .   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @" __/══════╩═══",

                                @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"      '   ║   " + '\n' +
                                @" __/══════╩═══",

                                @"      ╔═══╗   " + '\n' +
                                @"      |   ║   " + '\n' +
                                @"      O   ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"          ║   " + '\n' +
                                @"      _   ║   " + '\n' +
                                @" __/══════╩═══"

                            };


string[] words = ReadWordsFromFile();
Console.CursorVisible = false;


while (true)
{
    string word = GetRandomWord(words);
    string wordToGuess = new('_', word.Length);

    int incorrectCuessCount = 0;
    List<char> playerUsedLetters = new List<char>();

    DrawCurrentGameState(false, incorrectCuessCount, wordToGuess, playerUsedLetters);

    PlayGame(word, wordToGuess, incorrectCuessCount, playerUsedLetters);

    string quitOrPlay = Console.ReadLine();

    if (quitOrPlay == "quit")
    {
        Console.WriteLine("Thank you for playing! Hangman was closed.");
        break;
    }
    Console.Clear();

}
static string[] ReadWordsFromFile()
{
    string currentDirectory = Directory.GetCurrentDirectory();
    string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
    const string WordsFileName = "words.txt";
    string path = $@"{projectDirectory}\{WordsFileName}";
    string[] words = File.ReadAllLines(path);
    return words;
}


static string GetRandomWord(string[] words)
{
    Random random = new Random();
    string word = words[random.Next(words.Length)];
    return word.ToLower();
}

void DrawCurrentGameState(bool inputIsInvalid, int incorrectGuess, string
        guessedWord, List<char> playerUsedLetters)
{
    Console.Clear();
    Console.WriteLine(wrongGuesses[incorrectGuess]);
    Console.WriteLine($"Guess: {guessedWord}");
    Console.WriteLine($"You have to guess {guessedWord.Length} symbols.");
    Console.WriteLine($"The following letters are used: {string.Join(", ", playerUsedLetters)}");
    
    if (inputIsInvalid)
    {
        Console.WriteLine("You should type only a single character!");
    }

    Console.WriteLine("Your symbol: ");

}

void PlayGame(string word, string wordToGuess, int incorrectGuessCount, List<char> playerUsedLetters)
{
    while (true)
    {
        string playerInput = Console.ReadLine().ToLower();
        
        if (playerInput.Length != 1)
        {
            DrawCurrentGameState(true, incorrectGuessCount, wordToGuess, playerUsedLetters);
            continue;    
        }

        char playerLetter = char.Parse(playerInput);
        playerUsedLetters.Add(playerLetter);
        bool playerLetterIsContained = CheckIfSymbolIsContained(word, playerLetter);
        
        if (playerLetterIsContained)
        {
            wordToGuess = AddLetterToGuessWord(word, playerLetter, wordToGuess);
        }
        else
        {
            incorrectGuessCount++;
        }

        DrawCurrentGameState(false, incorrectGuessCount, wordToGuess, playerUsedLetters);
        bool playerWins = CheckIfPlayerWins(wordToGuess);

        if (playerWins)
        {
            Console.Clear();
            Console.WriteLine(winScreen);
            Console.WriteLine($"The word you guessed is [{word}].");
            Console.Write("If you want to play again, press [Enter]. Else, type 'quit': ");
            break;
        }

        bool playerLoses = CheckIfPlayerLoses(incorrectGuessCount);

        if (playerLoses)
        {
            Console.SetCursorPosition(0, 0);
            DrawDeathAnimation(death);
            Console.Clear();
            Console.WriteLine(lossScreen);
            Console.WriteLine($"The exact word is [{word}].");
            Console.Write("If you want to play again, press [Enter]. Else, type 'quit': ");
            break;
        }

    }
}

static bool CheckIfSymbolIsContained(string word, char playerLetter)
{
    if (!word.Contains(playerLetter))
    {
        return false;
    }

    return true;
}

static string AddLetterToGuessWord(string word, char playerLetter, string wordToGuess)
{
    char[] wordToGuessCharArr = wordToGuess.ToCharArray();

    for (int i = 0; i < wordToGuess.Length; i++)
    {
        if (playerLetter == word[i])
        {
            wordToGuessCharArr[i] = playerLetter;
        }
    }
    
    return new String(wordToGuessCharArr);
}

static bool CheckIfPlayerWins(string wordToGuess)
{
    if (wordToGuess.Contains('_'))
    {
        return false;
    }

    return true;
}

static bool CheckIfPlayerLoses(int incorrectGuessCount)
{
    if (incorrectGuessCount == 6)
    {
        return true;
    }

    return false;
}

static void DrawDeathAnimation(string[] deathAnimation)
{
    for (int i = 0; i < deathAnimation.Length; i++)
    {
        Console.WriteLine(deathAnimation[i]);
        Thread.Sleep(200);
        Console.SetCursorPosition(0, 0);
    }
}

