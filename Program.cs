using System;

namespace NumberGuesser
{
  class Program
  {
    static void Main(string[] args)
    {
      var count = 0;
      var min = 0;
      var max = 100;
      var guess = 50;
      var guessing = true;
      string name;
      string input;

      Console.WriteLine("Welcome to Number Guesser!\n Enter your name here!");
      name = Console.ReadLine();
      Console.WriteLine($"Hi {name}!\n Think of a number between {min} and {max} and I will try to guess your number!");


      while (guessing == true)
      {
        Console.WriteLine($"Is your number {guess}?");
        input = Console.ReadLine();
        count++;
        if (input == "no")
        {
          //   count++;
          Console.WriteLine("higher or lower?");
          input = Console.ReadLine();
          if (input == "higher")
          {
            // count++;
            min = guess;
            guess = (min + max) / 2;
          }
          else if (input == "lower")
          {
            // count++;
            max = guess;
            guess = (min + max) / 2;
          }
        }
        else if (input == "yes")
        {
          guessing = false;
        }
      }
      Console.WriteLine($"Your number is {guess}! I guessed it in {count} tries!");
    }
  }
}
