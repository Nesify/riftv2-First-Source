// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.BattleRoyaleNewsWebsiteMOTD
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class BattleRoyaleNewsWebsiteMOTD : BattleRoyaleNewsMOTD
  {
    [JsonProperty("websiteURL")]
    public string WebsiteURL { get; set; }

    [JsonProperty("websiteButtonText")]
    public string WebsiteButtonText { get; set; }

    public BattleRoyaleNewsWebsiteMOTD(
      string title,
      string body,
      string image,
      string tileImage,
      string website,
      string websiteText = null)
      : base(title, body, image, tileImage)
    {
      this.WebsiteURL = website;
      this.WebsiteButtonText = websiteText;
    }
  }
}
