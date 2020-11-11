using System.IO;
using YeahGamza.Entity;
using System.Runtime.Serialization.Formatters.Binary;

namespace YeahGamza.User
{
  class UserManager
  {
    public void SaveProfile(Player player)
    {
      Stream ws = new FileStream($"users/{player.Name}/profile", FileMode.OpenOrCreate);
      BinaryFormatter serializer = new BinaryFormatter();

      serializer.Serialize(ws, player);
      ws.Close();
    }

    public Player LoadProfile(string name)
    {
      string path = $"users/{name}/profile";
      if (File.Exists(path)) return null;
      Stream ws = new FileStream(path, FileMode.OpenOrCreate);
      BinaryFormatter deserializer = new BinaryFormatter();

      object profile = deserializer.Deserialize(ws);


      if (new Player().GetType().IsInstanceOfType(profile))
        return (Player)profile;
      else
        return null;
    }
  }
}
