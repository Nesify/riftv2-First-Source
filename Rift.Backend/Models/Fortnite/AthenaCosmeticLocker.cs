// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Fortnite.AthenaCosmeticLocker
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Fortnite
{
  public class AthenaCosmeticLocker
  {
    [JsonProperty("locker_slots_data")]
    public AthenaLockerSlotsData LockerSlotsData { get; set; }

    [JsonProperty("use_count")]
    public int UseCount => 0;

    [JsonProperty("banner_icon_template")]
    public string BannerIcon { get; set; }

    [JsonProperty("banner_color_template")]
    public string BannerColor { get; set; }

    [JsonProperty("locker_name")]
    public string LockerName { get; set; }

    [JsonProperty("item_seen")]
    public bool ItemSeen => false;

    [JsonProperty("favorite")]
    public bool Favorite => false;
  }
}
