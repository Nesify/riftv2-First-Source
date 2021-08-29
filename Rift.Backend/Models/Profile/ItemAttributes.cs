// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Profile.ItemAttributes
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;

namespace Rift.Backend.Models.Profile
{
  public class ItemAttributes
  {
    [JsonProperty("max_level_bonus")]
    public int MaxLevelBonus => 1;

    [JsonProperty("level")]
    public int Level => 1;

    [JsonProperty("item_seen")]
    public bool ItemSeen => true;

    [JsonProperty("xp")]
    public int Xp => 0;

    [JsonProperty("variants")]
    public object[] Variants => Array.Empty<object>();

    [JsonProperty("favorite")]
    public bool Favorite => false;
  }
}
