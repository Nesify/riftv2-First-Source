// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.EmergencyNoticeEntry
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rift.Backend.Models.Content
{
  public class EmergencyNoticeEntry : BasePagesEntry
  {
    [JsonProperty("news", Order = -7)]
    public BattleRoyaleNews News { get; set; }

    public EmergencyNoticeEntry(params PagesMessage[] messages)
      : base("emergencynotice")
    {
      this.News = new BattleRoyaleNews(Array.Empty<object>())
      {
        Messages = ((IEnumerable<PagesMessage>) messages).Select<PagesMessage, PagesMessageBase>((Func<PagesMessage, PagesMessageBase>) (x => new PagesMessage(x.Message.Title, x.Message.Body).Message)).ToList<PagesMessageBase>()
      };
    }
  }
}
