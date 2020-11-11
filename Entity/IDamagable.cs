namespace YeahGamza.Entity
{
  interface IDamagable
  {
    double MaxHP { get; }
    double HP { get; set; }
    double Def { get; }
  }
}
