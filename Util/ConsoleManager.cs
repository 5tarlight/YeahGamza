using System;
using System.Collections.Generic;
using static System.Console;

namespace YeahGamza.Util
{
  class ConsoleManager
  {
    public static void PrintLogo()
    {
      WriteColor(@"┏┓╋╋┏┓╋╋╋╋┏┓╋┏━━━┓
┃┗┓┏┛┃╋╋╋╋┃┃╋┃┏━┓┃
┗┓┗┛┏┻━┳━━┫┗━┫┃╋┗╋━━┳┓┏┳━━━┳━━┓
╋┗┓┏┫┃━┫┏┓┃┏┓┃┃┏━┫┏┓┃┗┛┣━━┃┃┏┓┃
╋╋┃┃┃┃━┫┏┓┃┃┃┃┗┻━┃┏┓┃┃┃┃┃━━┫┏┓┃
╋╋┗┛┗━━┻┛┗┻┛┗┻━━━┻┛┗┻┻┻┻━━━┻┛┗┛", ConsoleColor.Yellow);
      WriteLine();
      WriteLine();
    }

    public static void WriteColor(string msg, ConsoleColor fore)
    {
      ForegroundColor = fore;
      WriteLine(msg);
      ResetColor();
    }

    public static void WriteColor(string msg, ConsoleColor fore, ConsoleColor back)
    {
      ForegroundColor = fore;
      BackgroundColor = back;
      WriteLine(msg);
      ResetColor();
    }
    
    public static void Question(List<QuestionItem> questions)
    {
      Clear();
      WriteLine("\n무엇을 하시겠습니까?");
      
      for (int i = 0; i < questions.Count; i++)
      {
        WriteLine($"{i + 1}. {questions[i].Question}");
      }

      ConsoleKey key = ReadKey().Key;

      switch (key)
      {
        case ConsoleKey.D1:
          Execute(questions, 1, key);
          break;
        case ConsoleKey.D2:
          Execute(questions, 2, key);
          break;
        case ConsoleKey.D3:
          Execute(questions, 3, key);
          break;
        case ConsoleKey.D4:
          Execute(questions, 4, key);
          break;
        case ConsoleKey.D5:
          Execute(questions, 5, key);
          break;
        case ConsoleKey.D6:
          Execute(questions, 6, key);
          break;
        case ConsoleKey.D7:
          Execute(questions, 7, key);
          break;
        case ConsoleKey.D8:
          Execute(questions, 8, key);
          break;
        case ConsoleKey.D9:
          Execute(questions, 9, key);
          break;
        case ConsoleKey.D0:
          Execute(questions, 10, key);
          break;
        default:
          break;
      }
    }

    public static void QuestionArrow(List<QuestionItem> questions)
    {
      int index = 0;
      bool executed = false;

      while (!executed)
      {
        Clear();

        for (int i = 0; i < questions.Count; i++)
        {
          string msg = $"{i + 1}. {questions[i].Question}";

          if (i == index)
            WriteColor(msg, ConsoleColor.Black, ConsoleColor.White);
          else
            WriteColor(msg, ConsoleColor.White);
        }

        WriteLine();
        WriteLine(questions[index].Description);
        WriteLine("\n↑ ↓ Enter");
        
        ConsoleKey key = ReadKey().Key;

        switch (key)
        {
          case ConsoleKey.UpArrow:
            if (index != 0) index--;
            break;
          case ConsoleKey.DownArrow:
            if (index != questions.Count - 1) index++;
            break;
          case ConsoleKey.Enter:
            Execute(questions, index + 1, key);
            executed = true;
            break;
          default: break;
        }
      }
    }

    private static bool Execute(List<QuestionItem> questions, int index, ConsoleKey key)
    {
      if (questions.Count < index) return false;

      WriteLine();
      questions[index - 1].KeydownHandler?.Invoke(key);
      ReadKey();
      return true;
    }
  }
}
