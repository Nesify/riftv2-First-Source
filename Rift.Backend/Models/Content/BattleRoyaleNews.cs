// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Content.BattleRoyaleNews
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rift.Backend.Models.Content
{
  public class BattleRoyaleNews
  {
    [JsonProperty("messages")]
    public List<PagesMessageBase> Messages { get; set; }

    [JsonProperty("motds")]
    public List<object> MOTDS { get; set; }

    public BattleRoyaleNews(params object[] motds)
    {
      this.Messages = ((IEnumerable<object>) motds).Select<object, PagesMessageBase>((Func<object, PagesMessageBase>) (x =>
      {
        BattleRoyaleNewsMOTD battleRoyaleNewsMotd = (BattleRoyaleNewsMOTD) x;
        return new PagesMessage(battleRoyaleNewsMotd.Title, battleRoyaleNewsMotd.Body, battleRoyaleNewsMotd.TileImage).Message;
      })).Where<PagesMessageBase>((Func<PagesMessageBase, bool>) (x => x != null)).ToList<PagesMessageBase>();
      this.MOTDS = ((IEnumerable<object>) motds).ToList<object>();
    }
  }
}
