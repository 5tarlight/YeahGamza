using System;

namespace YeahGamza.Inv
{
  [Obsolete]
  class InventoryItem
  {
    public Material Material { get; set; }
    public int Count { get; set; } = 1;
    public int DataCode { get; set; } = 0;

    public InventoryItem(Material material, int count, int dataCode = 0)
    {
      Material = material;
      Count = count;
      DataCode = dataCode;
    }
  }
}
