using System;

namespace YeahGamza.Inv.Item
{
  [Serializable]
  class TestItem : IItem
  {
    public string Name { get; set; }
    public int Count { get; set; }
    public int CodeData { get; set; }
  }
}
