using System;

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
      int time = int.Parse(Console.ReadLine());

      if (time < 0 || time > 2400)
      {
        Console.WriteLine($"Hi {name}, don't try to fool me! Please provide a valid time in format HHMM!");
        time = int.Parse(Console.ReadLine());
      }

      if (time >= 0 && time < 1200)
      {
        Console.WriteLine($"Hi {name}, Welcome and Good Morning. Have a great day!");
      }

      if (time >= 1200 && time < 1800)
      {
        Console.WriteLine($"Hi {name}, Welcome and Good Afternoon. Enjoy rest of the day!");
      }

      if (time >= 1800 && time <= 2400)
      {
        Console.WriteLine($"Hi {name}, Welcome and Have a good night!");
      }
    }
  }
}
