// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Fortnite.AthenaLockerSlot
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Fortnite
{
  public class AthenaLockerSlot
  {
    [JsonProperty("items")]
    public string[] Items { get; set; }

    [JsonProperty("activeVariants")]
    public object[] ActiveVariants { get; set; }
  }
}
