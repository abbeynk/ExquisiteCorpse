using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Would you like one auto generated, True or False?");
      string answer = Console.ReadLine();
      answer = answer.ToUpper();

      int head = 0;
      int body = 0;
      int feet = 0;

      while (answer != "TRUE" && answer != "FALSE")
      {
        Console.WriteLine("Sorry that input is incorrect.");
        Console.WriteLine("Would you like one auto generated, True or False?");
        answer = Console.ReadLine();
        answer = answer.ToUpper();
      }
      
      answer = answer.ToUpper();

      if (answer == "TRUE")
        {
          Random R = new Random();
          head = R.Next(1,3);
          body = R.Next(1,3);
          feet = R.Next(1,3);
        }
        else if (answer == "FALSE")
        {
          Console.WriteLine("Showing head options");
          Console.WriteLine("Option 1");
          Console.WriteLine("     ..-..");
          Console.WriteLine("    ( o o )");
          Console.WriteLine("    |  O  |");
          Console.WriteLine("Option 2");
          Console.WriteLine("     /   \\");
          Console.WriteLine("     \\. ./");
          Console.WriteLine("    (o + o)");
          Console.WriteLine("Option 3");
          Console.WriteLine("     _____");
          Console.WriteLine(" .-,;='';_),-.");
          Console.WriteLine("  \\_\\(),()/_/");
          Console.WriteLine("　  (,___,)");
          Console.WriteLine("Please select 1, 2 or 3:");
          head = Convert.ToInt32(Console.ReadLine());
          while (head != 1 && head != 2 && head !=3)
          {
            Console.WriteLine("Sorry that input was incorrect.");
            Console.WriteLine("Please enter again 1, 2 or 3:");
            head = Convert.ToInt32(Console.ReadLine());
          }
          Console.WriteLine("Showing body options");
          Console.WriteLine("Option 1");
          Console.WriteLine("   ,-/`~`\\-,___");
          Console.WriteLine("  / /).:.('--._)");
          Console.WriteLine(" {_[ (_,_)");
          Console.WriteLine("Option 2");
          Console.WriteLine("  --|  |  |--");
          Console.WriteLine("  --|  |  |--");
          Console.WriteLine("  --|  |  |--");
          Console.WriteLine("Option 3");
          Console.WriteLine("    |     |");
          Console.WriteLine("    |     |");
          Console.WriteLine("    |     |");
          Console.WriteLine("Please select 1, 2 or 3:");
          body = Convert.ToInt32(Console.ReadLine());
          while (body != 1 && body != 2 && body !=3)
          {
            Console.WriteLine("Sorry that input was incorrect.");
            Console.WriteLine("Please enter again 1, 2 or 3:");
            body = Convert.ToInt32(Console.ReadLine());
          }
          Console.WriteLine("Showing feet options");
          Console.WriteLine("Option 1");
          Console.WriteLine("     v   v");
          Console.WriteLine("     *****");
          Console.WriteLine("Option 2");
          Console.WriteLine("    |  Y  |");
          Console.WriteLine("   /   |   \\");
          Console.WriteLine("   \"\"\"\" \"\"\"\"");
          Console.WriteLine("Option 3");
          Console.WriteLine("    |     |");
          Console.WriteLine("    |     |");
          Console.WriteLine("    '~~~~~'");
          Console.WriteLine("Please select 1, 2 or 3:");
          feet = Convert.ToInt32(Console.ReadLine());
          while (feet != 1 && feet != 2 && feet !=3)
          {
            Console.WriteLine("Sorry that input was incorrect.");
            Console.WriteLine("Please enter again 1, 2 or 3:");
            feet = Convert.ToInt32(Console.ReadLine());
          }
        }

      switch(head)
      {
        case 1:
          Console.WriteLine("     ..-..");
          Console.WriteLine("    ( o o )");
          Console.WriteLine("    |  O  |");
            break;
        case 2:
          Console.WriteLine("     /   \\");
          Console.WriteLine("     \\. ./");
          Console.WriteLine("    (o + o)");
            break;
        case 3:
          Console.WriteLine("     _____");
          Console.WriteLine(" .-,;='';_),-.");
          Console.WriteLine("  \\_\\(),()/_/");
          Console.WriteLine("　  (,___,)");
            break;
      }
      switch(body)
      {
        case 1:
          Console.WriteLine("   ,-/`~`\\-,___");
          Console.WriteLine("  / /).:.('--._)");
          Console.WriteLine(" {_[ (_,_)");
            break;
        case 2:
          Console.WriteLine("  --|  |  |--");
          Console.WriteLine("  --|  |  |--");
          Console.WriteLine("  --|  |  |--");
            break;
        case 3:
          Console.WriteLine("    |     |");
          Console.WriteLine("    |     |");
          Console.WriteLine("    |     |");
            break;
      }
      switch(feet)
      {
        case 1:
          Console.WriteLine("     v   v");
          Console.WriteLine("     *****");
            break;
        case 2:
          Console.WriteLine("    |  Y  |");
          Console.WriteLine("   /   |   \\");
          Console.WriteLine("   \"\"\"\" \"\"\"\"");
            break;
        case 3:
          Console.WriteLine("    |     |");
          Console.WriteLine("    |     |");
          Console.WriteLine("    '~~~~~'");
            break;
      }


    }






  }
}
