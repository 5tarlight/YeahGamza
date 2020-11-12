using System;
using System.IO;
using YeahGamza.Entity;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Console;
using System.Collections.Generic;
using YeahGamza.Util;

namespace YeahGamza.User
{
  class UserManager
  {
    private static bool created = false;

    private static void CreateDirectory(string name)
    {
      Directory.CreateDirectory("users");
      Directory.CreateDirectory($"users/{name}");
    }

    public static void SaveProfile(Player player)
    {
      CreateDirectory(player.Name);

      Stream ws = new FileStream($"users/{player.Name}/profile.dat", FileMode.OpenOrCreate);
      BinaryFormatter serializer = new BinaryFormatter();

      serializer.Serialize(ws, player);
      ws.Close();
    }

    public static Player LoadProfile(string name)
    {
      CreateDirectory(name);

      string path = $"users/{name}/profile.dat";
      if (!File.Exists(path)) return null;
      Stream ws = new FileStream(path, FileMode.OpenOrCreate);
      BinaryFormatter deserializer = new BinaryFormatter();

      object profile = deserializer.Deserialize(ws);
      ws.Close();

      if (new Player().GetType().IsInstanceOfType(profile))
        return (Player)profile;
      else
        return null;
    }

    public static bool GetPlayer()
    {
      Clear();
      created = false;
      WriteLine("불러올 플레이어의 이름을 입력해주세요");
      string name = ReadLine().Trim();

      if (name == "" || name == null) return false;

      WriteLine("데이터를 불러오는 중입니다...");
      Player player = LoadProfile(name);

      if (player == null)
      {
        WriteLine("플레이어를 찾을 수 없습니다. 새로 생성하시겠습니까?");
        ReadKey();
        List<QuestionItem> questions = new List<QuestionItem>()
        {
          new QuestionItem()
          {
            Question = "만든다.",
            KeydownHandler = CreateUser,
            Description = "새로운 캐릭터를 생성합니다."
          },
          new QuestionItem()
          {
            Question = "만들지 않는다.",
            KeydownHandler = null,
            Description = "새로운 캐릭터를 만들지 않습니다."
          }
        };

        ConsoleManager.QuestionArrow(questions);
        return created;
      }
      else
      {
        Program.player = player;
        return true;
      }
    }

    private static void CreateUser(ConsoleKey key)
    {
      WriteLine("만들 플레이어의 이름을 입력해주세요.");
      string name = ReadLine().Trim();

      SaveProfile(new Player() { Name = name });
      created = true;
    }
  }
}
