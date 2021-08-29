// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Services.ProfileService
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Rift.Backend.Models.Fortnite;
using Rift.Backend.Models.Profile;
using System.Collections.Generic;

namespace Rift.Backend.Services
{
  public class ProfileService : IProfileService
  {
    public Rift.Backend.Models.Profile.Profile GenerateAthenaProfile(
      string id,
      int seasonNumber,
      Dictionary<string, object> cosmeticLoadout,
      string profileId = "athena")
    {
      ++Program.AthenaRvn;
      Rift.Backend.Models.Profile.Profile profile = new Rift.Backend.Models.Profile.Profile()
      {
        _Id = id,
        Id = id,
        Rvn = Program.AthenaRvn,
        ProfileId = profileId,
        Items = new Dictionary<string, object>(),
        Stats = new ProfileStats()
        {
          Attributes = (object) new AthenaProfileStats(seasonNumber, cosmeticLoadout)
        }
      };
      string[] strArray = new string[11]
      {
        "AthenaCharacter:cid_001_athena_commando_f_default",
        "AthenaCharacter:cid_002_athena_commando_f_default",
        "AthenaCharacter:cid_003_athena_commando_f_default",
        "AthenaCharacter:cid_004_athena_commando_f_default",
        "AthenaCharacter:cid_005_athena_commando_m_default",
        "AthenaCharacter:cid_006_athena_commando_m_default",
        "AthenaCharacter:cid_007_athena_commando_m_default",
        "AthenaCharacter:cid_008_athena_commando_m_default",
        "AthenaGlider:defaultglider",
        "AthenaPickaxe:defaultpickaxe",
        "AthenaDance:eid_dancemoves"
      };
      foreach (string str in strArray)
        profile.Items.Add(str, (object) new ProfileItem(str));
      profile.Items.Add("CosmeticLocker:cosmeticlocker_athena", (object) new ProfileItem("CosmeticLocker:cosmeticlocker_athena", (object) new AthenaCosmeticLocker()
      {
        LockerName = "Locker",
        BannerColor = "",
        BannerIcon = "",
        LockerSlotsData = new AthenaLockerSlotsData()
        {
          Slots = new Dictionary<string, AthenaLockerSlot>()
          {
            {
              "Character",
              new AthenaLockerSlot()
              {
                Items = new string[1]
                {
                  cosmeticLoadout["character"].ToString()
                }
              }
            },
            {
              "Backpack",
              new AthenaLockerSlot()
              {
                Items = new string[1]
                {
                  cosmeticLoadout["backpack"].ToString()
                }
              }
            },
            {
              "Pickaxe",
              new AthenaLockerSlot()
              {
                Items = new string[1]
                {
                  cosmeticLoadout["pickaxe"].ToString()
                }
              }
            },
            {
              "Glider",
              new AthenaLockerSlot()
              {
                Items = new string[1]
                {
                  cosmeticLoadout["glider"].ToString()
                }
              }
            },
            {
              "SkyDiveContrail",
              new AthenaLockerSlot()
              {
                Items = new string[1]
                {
                  cosmeticLoadout["skydivecontrail"].ToString()
                }
              }
            },
            {
              "LoadingScreen",
              new AthenaLockerSlot()
              {
                Items = new string[1]
                {
                  cosmeticLoadout["loadingscreen"].ToString()
                }
              }
            },
            {
              "MusicPack",
              new AthenaLockerSlot()
              {
                Items = new string[1]
                {
                  cosmeticLoadout["musicpack"].ToString()
                }
              }
            },
            {
              "Dance",
              new AthenaLockerSlot()
              {
                Items = (string[]) cosmeticLoadout["dance"]
              }
            },
            {
              "ItemWrap",
              new AthenaLockerSlot()
              {
                Items = (string[]) cosmeticLoadout["itemwrap"]
              }
            }
          }
        }
      }));
      return profile;
    }

    public Rift.Backend.Models.Profile.Profile GenerateCommonCoreProfile(
      string id,
      string profileId = "common_core")
    {
      ++Program.CommonCoreRvn;
      return new Rift.Backend.Models.Profile.Profile()
      {
        _Id = id,
        Id = id,
        Rvn = Program.CommonCoreRvn,
        ProfileId = profileId,
        Items = new Dictionary<string, object>(),
        Stats = new ProfileStats()
        {
          Attributes = (object) new CommonCoreProfileStats()
        }
      };
    }

    public Rift.Backend.Models.Profile.Profile GenerateBlankProfile(
      string id,
      string profileId)
    {
      ++Program.CommonCoreRvn;
      return new Rift.Backend.Models.Profile.Profile()
      {
        _Id = id,
        Id = id,
        Rvn = Program.CommonCoreRvn,
        ProfileId = profileId,
        Items = new Dictionary<string, object>(),
        Stats = new ProfileStats()
        {
          Attributes = (object) new{  }
        }
      };
    }
  }
}
