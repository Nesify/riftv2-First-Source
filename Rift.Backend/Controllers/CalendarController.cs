// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Controllers.CalendarController
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Microsoft.AspNetCore.Mvc;
using Rift.Backend.Models.Calendar;
using Rift.Backend.Models.Calendar.States;
using System.Collections.Generic;

namespace Rift.Backend.Controllers
{
  [Route("fortnite/api/[controller]/v1/timeline")]
  [ApiController]
  public class CalendarController : ControllerBase
  {
    public ActionResult<Timeline> GetTimeline()
    {
      int seasonNumber = this.Request.GetSeasonNumber();
      string str = seasonNumber == 2 ? "LobbyWinterDecor" : string.Format("LobbySeason{0}", (object) seasonNumber);
      Timeline timeline1 = new Timeline();
      Timeline timeline2 = timeline1;
      Dictionary<string, TimelineChannel> dictionary1 = new Dictionary<string, TimelineChannel>();
      dictionary1["standalone-store"] = new TimelineChannel(new ChannelState[1]
      {
        new ChannelState()
        {
          ActiveEvents = new List<ChannelEvent>(),
          State = (object) new StandaloneStoreState()
        }
      });
      dictionary1["client-events"] = new TimelineChannel(new ChannelState[1]
      {
        new ChannelState()
        {
          ActiveEvents = new List<ChannelEvent>()
          {
            new ChannelEvent("EventFlag." + str)
          },
          State = (object) new ClientEventsState(seasonNumber)
        }
      });
      Dictionary<string, TimelineChannel> dictionary2 = dictionary1;
      timeline2.Channels = dictionary2;
      return (ActionResult<Timeline>) timeline1;
    }
  }
}
