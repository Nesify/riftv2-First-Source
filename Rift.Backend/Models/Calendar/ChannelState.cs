// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Calendar.ChannelState
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rift.Backend.Models.Calendar
{
  public class ChannelState
  {
    [JsonProperty("validFrom")]
    public DateTime ValidFrom { get; set; } = DateTime.UtcNow;

    [JsonProperty("activeEvents")]
    public List<ChannelEvent> ActiveEvents { get; set; }

    [JsonProperty("state")]
    public object State { get; set; }
  }
}
