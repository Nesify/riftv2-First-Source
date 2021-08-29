// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Calendar.TimelineChannel
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rift.Backend.Models.Calendar
{
  public class TimelineChannel
  {
    [JsonProperty("states")]
    public List<ChannelState> States { get; set; }

    [JsonProperty("cacheExpire")]
    public DateTime CacheExpire => DateTime.UtcNow.AddMinutes(15.0);

    public TimelineChannel(params ChannelState[] states) => this.States = ((IEnumerable<ChannelState>) states).ToList<ChannelState>();
  }
}
