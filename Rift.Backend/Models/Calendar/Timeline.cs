// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Calendar.Timeline
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rift.Backend.Models.Calendar
{
  public class Timeline
  {
    [JsonProperty("channels")]
    public Dictionary<string, TimelineChannel> Channels { get; set; }

    [JsonProperty("currentTime")]
    public DateTime CurrentTime => DateTime.UtcNow;

    [JsonProperty("cacheIntervalMins")]
    public double CacheIntervalMinutes => 15.0;
  }
}
