namespace C_study;

public class RPS
{
    public void RockPaperScissors() {
        Console.WriteLine("Player Choice {rock, paper, scissors}: ");
        string[] playerChoices = ["rock", "paper", "scissors"];

        string? playerChoice = Console.ReadLine()?.ToLower();
        int randomIndex = new Random().Next(1, 3);
        string botChoice = (playerChoices[randomIndex]);

        if (playerChoice != null && playerChoices.Contains(playerChoice)) {
            Console.WriteLine($"Player: {playerChoice}");
            Console.WriteLine($"Bot: {botChoice}");
            Play(playerChoice, botChoice);
        } else
        {
            Console.WriteLine("Please type among {rock, paper, scissors} only!");
        }

        static void Play(string playerChoice, string botChoice) {
            if (playerChoice ==  botChoice)
            {
                Console.WriteLine("It's a Draw!");
            }
            else if (playerChoice == "rock"
                && botChoice == "scissors"
                || playerChoice == "scissors"
                && botChoice == "paper"
                || playerChoice == "paper"
                && botChoice == "rock") {
                Console.WriteLine("You Won!");
            }
            else {
                Console.WriteLine("You Lost!");
            }
        }
    }
}