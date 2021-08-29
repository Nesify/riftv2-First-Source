﻿// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Controllers.LightswitchController
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Microsoft.AspNetCore.Mvc;
using Rift.Backend.Models.Lightswitch;
using System.Collections.Generic;

namespace Rift.Backend.Controllers
{
  [Route("[controller]/api/service/bulk/status")]
  [ApiController]
  public class LightswitchController : ControllerBase
  {
    public ActionResult<List<LightswitchStatus>> GetLightswitchStatus(
      [FromQuery] string serviceId)
    {
      return (ActionResult<List<LightswitchStatus>>) new List<LightswitchStatus>()
      {
        new LightswitchStatus(serviceId.ToLower())
      };
    }
  }
}
