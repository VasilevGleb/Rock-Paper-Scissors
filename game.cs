using System;

Console.WriteLine("Welcome to the game!");

string[] option = { "Rock", "Scissors", "Paper" };
Console.WriteLine("Choose: Rock, Scissors, Paper");
string yourChoice = Console.ReadLine();
string yourChoiceLower = yourChoice.ToLower();

// Validate user input (проверка верности ввода)
while (true)
{
    if (Array.Exists(option, x => x.ToLower() == yourChoiceLower))
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid input.\nPlease choose: Rock, Scissors, Paper");
    
    }
}

Random action = new Random();
int number = action.Next(0, 3);
string computerChoice = option[number];
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

Console.WriteLine("Thanks for playing. Goodbye!");
Console.WriteLine("Press Enter to exit...");
Console.ReadLine();
