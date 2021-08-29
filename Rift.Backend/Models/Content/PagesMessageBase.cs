// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.PagesMessageBase
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class PagesMessageBase
  {
    [JsonProperty("image")]
    public string Image { get; set; }

    [JsonProperty("hidden")]
    public bool IsHidden => false;

    [JsonProperty("_type")]
    public string Type => "CommonUI Simple Message Base";

    [JsonProperty("messagetype")]
    public string MessageType => "normal";

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("body")]
    public string Body { get; set; }

    [JsonProperty("adspace", NullValueHandling = NullValueHandling.Ignore)]
    public string Adspace { get; set; }

    [JsonProperty("spotlight")]
    public bool IsSpotlight => false;

    public PagesMessageBase(string title, string body, string image = null, string adspace = null)
    {
      this.Title = title;
      this.Body = body;
      this.Image = image;
      this.Adspace = adspace;
    }
  }
}
