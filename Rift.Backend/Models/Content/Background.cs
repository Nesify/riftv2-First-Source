// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.Background
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rift.Backend.Models.Content
{
  public class Background
  {
    [JsonProperty("backgrounds", Order = -7)]
    public List<BackgroundData> Backgrounds { get; set; }

    [JsonProperty("_type")]
    public string Type => "DynamicBackgroundList";

    public Background(params BackgroundData[] backgrounds) => this.Backgrounds = ((IEnumerable<BackgroundData>) backgrounds).Select<BackgroundData, BackgroundData>((Func<BackgroundData, BackgroundData>) (x => new BackgroundData(x.Stage, x.Key))).ToList<BackgroundData>();
  }
}
