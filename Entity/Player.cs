using System;
using YeahGamza.Inv;

namespace YeahGamza.Entity
{
  [Serializable]
  class Player : IEntity, IDamagable, ILevelable, IFightable, IPlayer
  {
    public string Name { get; set; }

    public int Level
    {
      get
      {
        long ex = Exp;
        int eff = 500;
        int lvl = 0;

        for (int i = 2; ex > i; i += eff)
        {
          ex -= i;
          lvl++;
        }

        return lvl + 1;
      }
    }

    public double MaxHP
    {
      get
      {
        int eff = 100;
        return 500 + eff * Level;
      }
    }

    public double HP { get; set; }

    public double Def
    {
      get
      {
        if (Level > 100) return 100;
        else return Level;
      }
    }

    public long Exp { get; set; } = 0;

    public double Offense
    {
      get
      {
        int eff = 100;
        return eff * Level;
      }
    }

    public Inventory Inventory { get; set; }
  }  
}
