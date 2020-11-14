using System;
using System.Collections.Generic;
using YeahGamza.Inv.Item;
using YeahGamza.User;

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
      if (items.Contains(item))
      {
        for (int i = 0; i < items.Count; i++)
        {
          if (items[i] == item)
          {
            items[i].Count++;
            UserManager.SaveProfile(Program.player);
          }
        }
      }

      items.Add(item);
    }

    public int Count { get => items.Count; }
  }
}
