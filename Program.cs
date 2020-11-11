using System;
using System.Collections.Generic;
using YeahGamza.Util;

namespace YeahGamza
{
  class Program
  {
    private static void Unavailable(ConsoleKey key)
    {
      Console.WriteLine("공사중...");
    }

    private static void Terminate(ConsoleKey key)
    {
      Environment.Exit(0);
    }

    static void Main(string[] args)
    {
      ConsoleManager.PrintLogo();

      while(true)
      {
        List<QuestionItem> questions = new List<QuestionItem>
        {
          new QuestionItem("캐릭터 정보 보기", Unavailable),
          new QuestionItem("인벤토리 열기", Unavailable),
          new QuestionItem("게임 종료하기", Terminate)
        };

        ConsoleManager.Question(questions);
      }
    }
  }
}
