namespace YeahGamza.Inv.Item
{
  interface IItem
  {
    string Name { get; }
    int Count { get; set; }
    int CodeData { get; set; }
    string Description { get; }
  }
}
