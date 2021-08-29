// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.BattleRoyaleNewsMOTD
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class BattleRoyaleNewsMOTD : PagesMOTD
  {
    [JsonProperty("image")]
    public string Image { get; set; }

    [JsonProperty("tileImage")]
    public string TileImage { get; set; }

    public BattleRoyaleNewsMOTD(string title, string body, string image, string tileImage)
      : base(title, body)
    {
      this.Image = image;
      this.TileImage = tileImage;
    }
  }
}
