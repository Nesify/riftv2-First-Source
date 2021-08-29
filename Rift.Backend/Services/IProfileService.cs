// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Services.IProfileService
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using System.Collections.Generic;

namespace Rift.Backend.Services
{
  public interface IProfileService
  {
    Rift.Backend.Models.Profile.Profile GenerateAthenaProfile(
      string id,
      int seasonNumber,
      Dictionary<string, object> cosmeticLoadout,
      string profileId = "athena");

    Rift.Backend.Models.Profile.Profile GenerateCommonCoreProfile(
      string id,
      string profileId = "common_core");

    Rift.Backend.Models.Profile.Profile GenerateBlankProfile(string id, string profileId);
  }
}
