// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.SubgameSelectEntry
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class SubgameSelectEntry : BasePagesEntry
  {
    [JsonProperty("saveTheWorldUnowned", Order = -7)]
    public PagesMessage SaveTheWorldUnowned => this.SaveTheWorld;

    [JsonProperty("battleRoyale", Order = -7)]
    public PagesMessage BattleRoyale { get; set; }

    [JsonProperty("creative", Order = -7)]
    public PagesMessage Creative { get; set; }

    [JsonProperty("saveTheWorld", Order = -7)]
    public PagesMessage SaveTheWorld { get; set; }

    public SubgameSelectEntry()
      : base("subgameselectdata")
    {
    }
  }
}
