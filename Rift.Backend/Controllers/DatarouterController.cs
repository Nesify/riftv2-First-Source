// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Controllers.DatarouterController
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Microsoft.AspNetCore.Mvc;

namespace Rift.Backend.Controllers
{
  [Route("[controller]/api/v1/public/data")]
  [ApiController]
  public class DatarouterController : ControllerBase
  {
    public ActionResult PostDatarouter() => (ActionResult) this.NoContent();
  }
}
