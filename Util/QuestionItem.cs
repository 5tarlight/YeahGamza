using System;

namespace YeahGamza.Util
{
  class QuestionItem
  {
    public Action<ConsoleKey> KeydownHandler { get; set; }
    public string Question { get; set; }
    public string Description { get; set; }
  }
}
 