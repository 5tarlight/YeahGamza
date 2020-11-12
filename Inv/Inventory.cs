using System;
using System.Collections.Generic;
using YeahGamza.Inv.Item;

namespace YeahGamza.Inv
{
  [Serializable]
  class Inventory
  {
    public List<IItem> items;
    
    public Inventory()
    {
      items = new List<IItem>();
    }

    public IItem this[int index]
    {
      get => items[index];
      set => items[index] = value;
    }

    public void Add(IItem item)
    {
      items.Add(item);
    }

    public int Count { get => items.Count; }
  }
}
