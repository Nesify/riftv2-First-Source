// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.Pages
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class Pages : BasePagesEntry
  {
    [JsonProperty("battleroyalenews", NullValueHandling = NullValueHandling.Ignore)]
    public BattleRoyaleNewsEntry BattleRoyaleNews { get; set; }

    [JsonProperty("battleroyalenewsv2", NullValueHandling = NullValueHandling.Ignore)]
    public BattleRoyaleNewsEntry BattleRoyaleNewsV2 => this.BattleRoyaleNews;

    [JsonProperty("emergencynotice", NullValueHandling = NullValueHandling.Ignore)]
    public EmergencyNoticeEntry EmergencyNotice { get; set; }

    [JsonProperty("emergencynoticev2", NullValueHandling = NullValueHandling.Ignore)]
    public EmergencyNoticeEntry EmergencyNoticeV2 => this.EmergencyNotice;

    [JsonProperty("subgameinfo", NullValueHandling = NullValueHandling.Ignore)]
    public SubgameInfoEntry SubgameInfo { get; set; }

    [JsonProperty("subgameselectdata", NullValueHandling = NullValueHandling.Ignore)]
    public SubgameSelectEntry SubgameSelect { get; set; }

    [JsonProperty("dynamicbackgrounds", NullValueHandling = NullValueHandling.Ignore)]
    public DynamicBackground DynamicBackgrounds { get; set; }

    public Pages()
      : base("Fortnite Game")
    {
    }
  }
}
