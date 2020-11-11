using System;
using System.Collections.Generic;
using YeahGamza.Util;

namespace YeahGamza
{
  class Program
  {
    static void Main(string[] args)
    {
      ConsoleManager.PrintLogo();

      while(true)
      {
        List<QuestionItem> questions = new List<QuestionItem>();
        questions.Add(new QuestionItem("캐릭터 정보 보기", key => { Console.WriteLine("first item"); }));
        questions.Add(new QuestionItem("인벤토리 열기", key => { }));
        questions.Add(new QuestionItem("게임 종료하기", key => { }));

        ConsoleManager.Question(questions);
      }
    }
  }
}
