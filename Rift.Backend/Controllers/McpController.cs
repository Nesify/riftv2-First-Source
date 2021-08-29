// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Controllers.McpController
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rift.Backend.Models.Fortnite;
using Rift.Backend.Models.Profile;
using Rift.Backend.Models.Profile.Changes;
using Rift.Backend.Services;
using System;
using System.Collections.Generic;

namespace Rift.Backend.Controllers
{
  [Route("fortnite/api/game/v2/profile/{accountId}/client")]
  [ApiController]
  public class McpController : ControllerBase
  {
    private readonly IProfileService _profileService;
    private readonly string _profile;
    private readonly int _rvn;
    private readonly List<object> _changes;
    public static Action OnRiftRequested;

    public McpController(IProfileService profileService, IHttpContextAccessor accessor)
    {
      this._profileService = profileService;
      this._profile = accessor.HttpContext.Request.Query["profileId"].ToString() ?? "common_core";
      if (!int.TryParse((string) accessor.HttpContext.Request.Query["rvn"], out this._rvn))
        this._rvn = -1;
      this._changes = new List<object>();
    }

    [HttpPost("ClientQuestLogin")]
    public ActionResult<McpResponse> ClientQuestLogin(string accountId)
    {
      Action onRiftRequested = McpController.OnRiftRequested;
      if (onRiftRequested != null)
        onRiftRequested();
      McpController.OnRiftRequested = (Action) null;
      string profile = this._profile;
      return (ActionResult<McpResponse>) new McpResponse(profile == "profile0" ? this._profileService.GenerateCommonCoreProfile(accountId, this._profile) : (profile == "common_core" ? this._profileService.GenerateCommonCoreProfile(accountId, this._profile) : (profile == "athena" ? this._profileService.GenerateAthenaProfile(accountId, this.Request.GetSeasonNumber(), Program.CosmeticLoadout) : this._profileService.GenerateBlankProfile(accountId, this._profile))), this._rvn, this._profile, this._changes);
    }

    [HttpPost("QueryProfile")]
    [HttpPost("GetMcpTimeForLogin")]
    [HttpPost("RefreshExpeditions")]
    [HttpPost("IncrementNamedCounterStat")]
    public ActionResult<McpResponse> QueryProfile(string accountId)
    {
      string profile = this._profile;
      return (ActionResult<McpResponse>) new McpResponse(profile == "profile0" ? this._profileService.GenerateCommonCoreProfile(accountId, this._profile) : (profile == "common_core" ? this._profileService.GenerateCommonCoreProfile(accountId, this._profile) : (profile == "athena" ? this._profileService.GenerateAthenaProfile(accountId, this.Request.GetSeasonNumber(), Program.CosmeticLoadout) : this._profileService.GenerateBlankProfile(accountId, this._profile))), this._rvn, this._profile, this._changes);
    }

    [HttpPost("SetHardcoreModifier")]
    public ActionResult<McpResponse> SetHardcoreModifier(string accountId) => (ActionResult<McpResponse>) new McpResponse(this._profileService.GenerateAthenaProfile(accountId, this.Request.GetSeasonNumber(), Program.CosmeticLoadout), this._rvn, this._profile, this._changes);

    [HttpPost("SetMtxPlatform")]
    public ActionResult<McpResponse> SetMtxPlatform(
      [FromBody] Rift.Backend.Models.Commands.Currency.SetMtxPlatform body,
      string accountId)
    {
      this._changes.Add((object) new McpStatModified("current_mtx_platform", (object) body.NewPlatform.ToString()));
      return (ActionResult<McpResponse>) new McpResponse(this._profileService.GenerateCommonCoreProfile(accountId), this._rvn, this._profile, this._changes);
    }

    [HttpPost("EquipBattleRoyaleCustomization")]
    public ActionResult<McpResponse> EquipBattleRoyaleCustomization(
      [FromBody] Rift.Backend.Models.Commands.Cosmetics.EquipBattleRoyaleCustomization body,
      string accountId)
    {
      string lower = body.SlotName.ToString().ToLower();
      McpStatModified mcpStatModified;
      if (lower == "dance" || lower == "itemwrap")
      {
        if (body.IndexWithinSlot == -1)
        {
          for (int index = 0; index < 7; ++index)
            ((string[]) Program.CosmeticLoadout[lower])[index] = body.ItemToSlot;
        }
        ((string[]) Program.CosmeticLoadout[lower])[body.IndexWithinSlot] = body.ItemToSlot;
        mcpStatModified = new McpStatModified("favorite_" + lower, (object) (string[]) Program.CosmeticLoadout[lower]);
      }
      else
      {
        Program.CosmeticLoadout[lower] = (object) body.ItemToSlot;
        mcpStatModified = new McpStatModified("favorite_" + lower, (object) body.ItemToSlot);
      }
      this._changes.Add((object) mcpStatModified);
      return (ActionResult<McpResponse>) new McpResponse(this._profileService.GenerateAthenaProfile(accountId, this.Request.GetSeasonNumber(), Program.CosmeticLoadout), this._rvn, this._profile, this._changes, true);
    }

    [HttpPost("SetCosmeticLockerSlot")]
    public ActionResult<McpResponse> SetCosmeticLockerSlot(
      [FromBody] Rift.Backend.Models.Commands.Cosmetics.SetCosmeticLockerSlot body,
      string accountId)
    {
      string lower = body.Category.ToString().ToLower();
      if (lower == "dance" || lower == "itemwrap")
      {
        if (body.SlotIndex == -1)
        {
          for (int index = 0; index < 7; ++index)
            ((string[]) Program.CosmeticLoadout[lower])[index] = body.ItemToSlot;
        }
        ((string[]) Program.CosmeticLoadout[lower])[body.SlotIndex] = body.ItemToSlot;
      }
      else
        Program.CosmeticLoadout[lower] = (object) body.ItemToSlot;
      AthenaLockerSlotsData athenaLockerSlotsData = new AthenaLockerSlotsData()
      {
        Slots = new Dictionary<string, AthenaLockerSlot>()
        {
          {
            "Character",
            new AthenaLockerSlot()
            {
              Items = new string[1]
              {
                Program.CosmeticLoadout["character"].ToString()
              }
            }
          },
          {
            "Backpack",
            new AthenaLockerSlot()
            {
              Items = new string[1]
              {
                Program.CosmeticLoadout["backpack"].ToString()
              }
            }
          },
          {
            "Pickaxe",
            new AthenaLockerSlot()
            {
              Items = new string[1]
              {
                Program.CosmeticLoadout["pickaxe"].ToString()
              }
            }
          },
          {
            "Glider",
            new AthenaLockerSlot()
            {
              Items = new string[1]
              {
                Program.CosmeticLoadout["glider"].ToString()
              }
            }
          },
          {
            "SkyDiveContrail",
            new AthenaLockerSlot()
            {
              Items = new string[1]
              {
                Program.CosmeticLoadout["skydivecontrail"].ToString()
              }
            }
          },
          {
            "LoadingScreen",
            new AthenaLockerSlot()
            {
              Items = new string[1]
              {
                Program.CosmeticLoadout["loadingscreen"].ToString()
              }
            }
          },
          {
            "MusicPack",
            new AthenaLockerSlot()
            {
              Items = new string[1]
              {
                Program.CosmeticLoadout["musicpack"].ToString()
              }
            }
          },
          {
            "Dance",
            new AthenaLockerSlot()
            {
              Items = (string[]) Program.CosmeticLoadout["dance"]
            }
          },
          {
            "ItemWrap",
            new AthenaLockerSlot()
            {
              Items = (string[]) Program.CosmeticLoadout["itemwrap"]
            }
          }
        }
      };
      this._changes.Add((object) new McpItemAttrChanged(body.LockerItem, "locker_slots_data", (object) athenaLockerSlotsData));
      return (ActionResult<McpResponse>) new McpResponse(this._profileService.GenerateAthenaProfile(accountId, this.Request.GetSeasonNumber(), Program.CosmeticLoadout), this._rvn, this._profile, this._changes, true);
    }

    [HttpPost("SetItemFavoriteStatusBatch")]
    public ActionResult<McpResponse> SetItemFavoriteStatusBatch(
      [FromBody] Rift.Backend.Models.Commands.Cosmetics.SetItemFavoriteStatusBatch body,
      string accountId)
    {
      for (int index = 0; index < body.ItemIds.Count; ++index)
        this._changes.Add((object) new McpItemAttrChanged(body.ItemIds[index], "favorite", (object) body.ItemFavStatus[index]));
      return (ActionResult<McpResponse>) new McpResponse(this._profileService.GenerateAthenaProfile(accountId, this.Request.GetSeasonNumber(), Program.CosmeticLoadout), this._rvn, this._profile, this._changes, true);
    }
  }
}
