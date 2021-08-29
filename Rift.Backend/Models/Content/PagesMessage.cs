// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.PagesMessage
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class PagesMessage
  {
    [JsonProperty("_type")]
    public string Type => "CommonUI Simple Message";

    [JsonProperty("message")]
    public PagesMessageBase Message { get; set; }

    public PagesMessage(string title, string body, string image = null, string adspace = null) => this.Message = new PagesMessageBase(title, body, image, adspace);
  }
}
