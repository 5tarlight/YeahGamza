using System;

namespace YeahGamza.Inv.Item
{
  [Serializable]
  class TestItem : IItem
  {
    public string Name { get => "TestItem"; }
    public int Count { get; set; } = 0;
    public int CodeData { get; set; } = 0;
    public string Description { get => "테스트용 아이템입니다."; }
  }
}
