using System;

Console.WriteLine("Welcome to the game!");

Console.WriteLine("Choose: Rock, Scissors, Paper");
string yourChoice = Console.ReadLine();

Random action = new Random();
string[] option = { "Rock", "Scissors", "Paper" };
int number = action.Next(0, 3);
string computerChoice = option[number];

string yourChoiceLower = yourChoice.ToLower();
string computerChoiceLower = computerChoice.ToLower();

Console.WriteLine($"Computer chose: {computerChoice}");
if (yourChoiceLower == computerChoiceLower)
{
    Console.WriteLine("It's a tie!");
}
else if ((yourChoiceLower == "scissors" && computerChoiceLower == "paper") ||
                (yourChoiceLower == "rock" && computerChoiceLower == "scissors") ||
                (yourChoiceLower == "paper" && computerChoiceLower == "rock"))
{
    Console.WriteLine("You win!");
}
else if ((yourChoiceLower == "scissors" && computerChoiceLower == "rock") ||
                (yourChoiceLower == "rock" && computerChoiceLower == "paper") ||
                (yourChoiceLower == "paper" && computerChoiceLower == "scissors"))
{
    Console.WriteLine("You lose!");
}
else
{
    Console.WriteLine("Invalid input. Please try again.");
}

Console.WriteLine("Thanks for playing. Goodbye!");
Console.WriteLine("Press Enter to exit...");
Console.ReadLine();