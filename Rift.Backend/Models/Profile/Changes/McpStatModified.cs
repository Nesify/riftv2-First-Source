// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Profile.Changes.McpStatModified
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Profile.Changes
{
  public class McpStatModified : McpChange
  {
    [JsonProperty("name")]
    public string Stat { get; set; }

    [JsonProperty("value")]
    public object Value { get; set; }

    public McpStatModified(string stat, object value)
      : base("statModified")
    {
      this.Stat = stat;
      this.Value = value;
    }
  }
}
