// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Calendar.ChannelEvent
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;

namespace Rift.Backend.Models.Calendar
{
  public class ChannelEvent
  {
    [JsonProperty("eventType")]
    public string EventType { get; set; }

    [JsonProperty("activeUntil")]
    public DateTime ActiveUntil => DateTime.MaxValue;

    [JsonProperty("activeSince")]
    public DateTime ActiveSince => DateTime.UtcNow;

    public ChannelEvent(string eventType) => this.EventType = eventType;
  }
}
