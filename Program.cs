using System;
using System.Collections.Generic;
using YeahGamza.Entity;
using YeahGamza.User;
using YeahGamza.Util;

namespace YeahGamza
{
  class Program
  {
    public static bool login = false;
    public static Player player = null;
    
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

      while (true)
      {
        if (login)
        {
          List<QuestionItem> questions = new List<QuestionItem>
          {
            new QuestionItem("캐릭터 정보 보기", Unavailable),
            new QuestionItem("인벤토리 열기", Unavailable),
            new QuestionItem("게임 종료하기", Terminate)
          };

          ConsoleManager.QuestionArrow(questions);
        }
        else
        {
          login = UserManager.GetPlayer();
        }
      }
    }
  }
}
