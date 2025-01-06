using System;

class Program
{
    static int Player = 0;
    static int Round = 1;
    static int Rival = 0;
    static int rivalScore = 0;
    static int playerScore = 0;

    public static void Main(string[] args)
    {
        Startup();
        End();
        Close();
    }

    public static void Startup()
    {
        Console.WriteLine("Dice Game");
        Console.WriteLine("");
        Console.WriteLine("In this game you and a computer Rival will play 10 rounds where you will each roll a 6 - sided dice, and the player with the highest dice value will win the round.The player who wins the most rounds wins the game. Good luck! ");
        Console.WriteLine("");
        Console.WriteLine("Press any key to start...");
        Console.ReadKey();
        Console.Write("\b \b");
        RivalTurn();
    }

    public static void RivalTurn()
    {
        Rival = new Random().Next(1, 7);
        Console.WriteLine("");
        Console.WriteLine("Round " + Round);
        Console.WriteLine("Rival rolled a " + Rival);
        Console.WriteLine("Press any key to roll the dice...");
        Console.ReadKey();
        Console.Write("\b \b");
        PlayerTurn();
    }

    public static void PlayerTurn()
    {
        Player = new Random().Next(1, 7);
        Console.WriteLine("You rolled a " + Player);
        Console.ReadKey();
        Console.Write("\b \b");
        Tally();
    }

    public static void Tally()
    {
        if (Rival > Player)
        {
            Console.WriteLine("The Rival won this round");
            rivalScore++;
        }
        else if (Rival == Player)
        {
            Console.WriteLine("This round is a draw!");
        }
        else
        {
            Console.WriteLine("You won this round.");
            playerScore++;
        }
        Console.WriteLine("THe score is now = You : " + playerScore + ". Rival : " + rivalScore + ".");
        Console.WriteLine("Press any key to continue...");
        Round++;
        Console.ReadKey();
        Console.Write("\b \b");
        End();
    }

    public static void End()
    {
        if (Round <= 10)
        {
            RivalTurn();
        }
        else
        {
            Console.WriteLine("Game over.");
            Console.WriteLine("The score is now = You : " + playerScore + ". Rival : " + rivalScore + ".");
            if (playerScore > rivalScore)
            {
                Console.WriteLine("You won!");
            }
            else if (rivalScore > playerScore)
            {
                Console.WriteLine("You lost!");
            }
            else
            {
                Console.WriteLine("It was a draw!");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.Write("\b \b");
        }
    }

    public static void Close()
    {
        Console.Clear();
        Console.WriteLine("Dice Game was Closed.");
    }
}