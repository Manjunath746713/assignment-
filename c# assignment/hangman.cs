using System;

class HangmanGame
{
    private string secretWord;
    private char[] guessedLetters;
    private int attemptsLeft;

    public HangmanGame(string word, int attempts)
    {
        secretWord = word.ToUpper();
        guessedLetters = new char[secretWord.Length];
        attemptsLeft = attempts;

        // Initialize guessed letters array with underscores
        for (int i = 0; i < secretWord.Length; i++)
        {
            guessedLetters[i] = '_';
        }
    }

    public void Play()
    {
        Console.WriteLine("Welcome to Hangman!");
        Console.WriteLine("Guess the word:");

        while (attemptsLeft > 0)
        {
            DisplayGuessedWord();
            Console.WriteLine($"Attempts left: {attemptsLeft}");

            char guess = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (secretWord.Contains(guess))
            {
                UpdateGuessedLetters(guess);
                if (secretWord == new string(guessedLetters))
                {
                    Console.WriteLine("Congratulations! You guessed the word.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Incorrect guess.");
                attemptsLeft--;
            }
        }

        Console.WriteLine("Out of attempts. The word was: " + secretWord);
    }

    private void DisplayGuessedWord()
    {
        foreach (char letter in guessedLetters)
        {
            Console.Write(letter + " ");
        }
        Console.WriteLine();
    }

    private void UpdateGuessedLetters(char guess)
    {
        for (int i = 0; i < secretWord.Length; i++)
        {
            if (secretWord[i] == guess)
            {
                guessedLetters[i] = guess;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string word = "Hangman";
        int attempts = 7;

        HangmanGame game = new HangmanGame(word, attempts);
        game.Play();
    }
}