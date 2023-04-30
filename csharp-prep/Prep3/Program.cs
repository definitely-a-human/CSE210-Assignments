using System;

class Program {
  static void Main(string[] args) {
    // Generate a random number between 1 and 100
    Random random = new Random();
    int magicNumber = random.Next(1, 101);

    int guessCount = 0; // keep track of how many guesses the user has made

    // Loop until the user guesses the magic number
    while (true) {
      Console.Write("What is your guess? ");
      int guess = int.Parse(Console.ReadLine());

      guessCount++;

      if (guess < magicNumber) {
        Console.WriteLine("Higher");

      } else if (guess > magicNumber) {
        Console.WriteLine("Lower");

      } else {
        Console.WriteLine("You guessed it in " + guessCount + " guesses!");

        Console.Write("Do you want to play again? (yes/no) ");
        string answer = Console.ReadLine().ToLower();

      if (answer == "yes") {
        // Generate a new magic number and reset the guess count
        magicNumber = random.Next(1, 101);
        guessCount = 0;

        // Play the game again
        continue;
      } else if (answer == "no") {
        // End the program
        Console.WriteLine("Thanks for playing!");
        
        break;
      }
      }
    }
  }
}