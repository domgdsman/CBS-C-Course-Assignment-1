using System;
using System.Text.RegularExpressions;

namespace one
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to your Greetings App\nIf you tell me your name and time of the day. I am going to greet you smartly.\nPlease don’t forget to use 24 Hour time format (HHMM).");

      System.Console.WriteLine("Please type your name: ");
      string name = Console.ReadLine();

      Console.WriteLine("Please tell me what time it is: ");
      int time;
      while (!int.TryParse(Console.ReadLine(), out time))
      {
        Console.WriteLine("You are probably typing a string. Please provide a number in the valid time format following HHMM!");
      }

      Regex timeRx = new Regex(@"(?:[01]\d|2[0123])(?:[012345]\d)");

      if (!timeRx.IsMatch(time.ToString()))
      {
        Console.WriteLine($"Hi {name}, the number you entered does not have 4 digits or does not represent a humanly readable time format(e.g. 9999).\nRestart the application and try again.");
      }

      else if (time >= 0 && time < 1200)
      {
        Console.WriteLine($"Hi {name}, Welcome and Good Morning. Have a great day!");
      }

      else if (time >= 1200 && time < 1800)
      {
        Console.WriteLine($"Hi {name}, Welcome and Good Afternoon. Enjoy rest of the day!");
      }

      else if (time >= 1800 && time <= 2400)
      {
        Console.WriteLine($"Hi {name}, Welcome and Have a good night!");
      }
    }
  }
}
