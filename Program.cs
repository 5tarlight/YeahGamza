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
            new QuestionItem()
            {
              Question = "캐릭터 정보 보기",
              KeydownHandler = key =>
              {
                UserManager.PrintUserInfo(player);
              },
              Description = "현제 캐릭터의 정보를 확인합니다."
            },
            new QuestionItem()
            {
              Question = "인벤토리 열기",
              KeydownHandler = key => UserManager.ViewInventory(player),
              Description = "현제 캐릭터의 인벤토리를 확인합니다."
            },
            new QuestionItem()
            {
              Question = "게임 종료하기",
              KeydownHandler = Terminate,
              Description = "현제 캐릭터의 정보를 확인합니다."
            }
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
