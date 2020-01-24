using System;
using System.Collections.Generic;

namespace rpc_c
{
  class Program
  {
    static void Main(string[] args)
    {
      bool playing = true;
      String[] choices = new String[3];
      choices[0] = "rock";
      choices[1] = "paper";
      choices[2] = "scissors";
      while (playing)
      {
        Console.WriteLine("Choose rock, paper, or scissors");
        string playerChoice = Console.ReadLine();
        var rand = new Random();
        int randChoice = rand.Next(choices.Length);
        string computerChoice = choices[randChoice];
        Console.WriteLine(computerChoice);
        if (playerChoice == computerChoice)
        {
          Console.WriteLine("You tied");
        }
        else if (playerChoice == "rock" && computerChoice == "paper" || playerChoice == "paper" && computerChoice == "scissors" || playerChoice == "scissors" && computerChoice == "rock")
        {
          Console.WriteLine("You lose");
        }
        else if (playerChoice == "rock" && computerChoice == "scissors" || playerChoice == "paper" && computerChoice == "rock" || playerChoice == "scissors" && computerChoice == "paper")
        {
          Console.WriteLine("You win");
        }
        else
        {
          Console.WriteLine("");
          Console.WriteLine("                                   ¯¯");
          Console.WriteLine("|| ||  //  \\\\ || ||   //  || ||  //    ||  //");
          Console.WriteLine(" \\\\||  ||  || || ||   \\\\  || ||  ||    || //");
          Console.WriteLine("   ||  \\\\  // \\\\ //   //  \\\\ //  \\\\¯¯  || \\\\ o o o");
        }
        Console.WriteLine("Do you want to keep playing? Type N to exit, or Y to continue.");
        ConsoleKeyInfo tryAgain = Console.ReadKey();
        if (tryAgain.Key == ConsoleKey.N)
        {
          playing = false;
          Console.Clear();
        }
        else if (tryAgain.Key == ConsoleKey.Y)
        {
          Console.Clear();
        }
      }
    }
  }
}

