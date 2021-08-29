// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.BackgroundData
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Content
{
  public class BackgroundData
  {
    [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
    public string Stage { get; set; }

    [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
    public string Key { get; set; }

    [JsonProperty("_type")]
    public string Type => "DynamicBackground";

    public BackgroundData(string stage = null, string key = null)
    {
      this.Stage = stage;
      this.Key = key;
    }
  }
}
