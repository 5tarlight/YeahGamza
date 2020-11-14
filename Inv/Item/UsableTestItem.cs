using System;

namespace YeahGamza.Inv.Item
{
  [Serializable]
  class UsableTestItem : IItem, IUsable
  {
    public string Name => "UsableTestItem";

    public int Count { get; set; } = 0;
    public int CodeData { get; set; } = 0;

    public string Description => "체력을 20으로 지정합니다.";

    public void Use(ConsoleKey key)
    {
      Program.player.HP = 20;
    }
  }
}
