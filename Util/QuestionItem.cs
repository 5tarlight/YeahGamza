using System;

namespace YeahGamza.Util
{
  class QuestionItem
  {
    public Action<ConsoleKey> KeydownHandler { get; }
    public string Question { get; }

    public QuestionItem(string Question, Action<ConsoleKey> KeydownHandler)
    {
      this.Question = Question;
      this.KeydownHandler = KeydownHandler;
    }
  }
}
