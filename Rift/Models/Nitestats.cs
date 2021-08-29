// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Temp.Models.Nitestats
// Assembly: Rift, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83C2E68F-8DD1-4DA0-AC4D-377BCA7F6114
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.dll

using Newtonsoft.Json;

namespace Rift.Frontend.Temp.Models
{
  public class Nitestats
  {
    public class FLToken
    {
      [JsonProperty("version")]
      public string Version { get; set; }

      [JsonProperty("fltoken")]
      public string Token { get; set; }
    }
  }
}
