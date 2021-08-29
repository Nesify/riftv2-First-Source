// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Profile.AthenaProfileStats
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rift.Backend.Models.Profile
{
  public class AthenaProfileStats
  {
    [JsonProperty("lifetime_wins")]
    public int LifetimeWins;

    [JsonProperty("past_seasons")]
    public object PastSeasons => (object) new{  };

    [JsonProperty("season")]
    public object Season => (object) new
    {
      numWins = 0,
      numLowBracket = 0,
      numHighBracket = 0
    };

    [JsonProperty("season_match_boost")]
    public int SeasonMatchBoost => 0;

    [JsonProperty("season_friend_match_boost")]
    public int SeasonFriendMatchBoost => 0;

    [JsonProperty("mfa_reward_claimed")]
    public bool MfaRewardClaimed => true;

    [JsonProperty("quest_manager")]
    public object QuestManager => (object) new
    {
      dailyLoginInterval = DateTime.UtcNow.AddDays(1.0),
      dailyQuestRerolls = 1
    };

    [JsonProperty("party_assist_quest")]
    public string PartyAssistQuest => "";

    [JsonProperty("season_num")]
    public int SeasonNum { get; set; }

    [JsonProperty("season_update")]
    public int SeasonUpdate => 0;

    [JsonProperty("book_level")]
    public int BookLevel => 1;

    [JsonProperty("book_xp")]
    public int BookXp => 0;

    [JsonProperty("book_purchased")]
    public bool BookPurchased => false;

    [JsonProperty("purchased_battle_pass_tier_offers")]
    public object PurchasedBattlePassTierOffers => (object) new
    {
    };

    [JsonProperty("permissions")]
    public string[] Permissions => Array.Empty<string>();

    [JsonProperty("vote_data")]
    public object VoteData => (object) new{  };

    [JsonProperty("accountLevel")]
    public int AccountLevel => 1;

    [JsonProperty("level")]
    public int Level => 1;

    [JsonProperty("xp")]
    public int Xp => 0;

    [JsonProperty("xp_overflow")]
    public int XpOverflow => 0;

    [JsonProperty("rested_xp")]
    public int RestedXp => 0;

    [JsonProperty("rested_xp_overflow")]
    public int RestedXpOverflow => 0;

    [JsonProperty("rested_xp_mult")]
    public double RestedXpMult => 1.0;

    [JsonProperty("rested_xp_exchange")]
    public double RestedXpExchange => 1.0;

    [JsonProperty("season_first_tracking_bits")]
    public string[] SeasonFirstTrackingBits => Array.Empty<string>();

    [JsonProperty("competitiveIdentity")]
    public object CompetitiveIdentity => (object) new{  };

    [JsonProperty("inventory_limit_bonus")]
    public int InventoryLimitBonus => 0;

    [JsonProperty("daily_rewards")]
    public object DailyRewards => (object) new{  };

    [JsonProperty("loadouts")]
    public List<string> Loadouts => new List<string>()
    {
      "CosmeticLocker:cosmeticlocker_athena"
    };

    [JsonProperty("last_applied_loadout")]
    public string LastAppliedLoadout => "CosmeticLocker:cosmeticlocker_athena";

    [JsonProperty("active_loadout_index")]
    public int ActiveLoadoutIndex => -1;

    [JsonProperty("use_random_loadout")]
    public bool UseRandomLoadout => false;

    [JsonProperty("favorite_character")]
    public string FavoriteCharacter { get; set; }

    [JsonProperty("favorite_backpack")]
    public string FavoriteBackpack { get; set; }

    [JsonProperty("favorite_pickaxe")]
    public string FavoritePickaxe { get; set; }

    [JsonProperty("favorite_glider")]
    public string FavoriteGlider { get; set; }

    [JsonProperty("favorite_skydivecontrail")]
    public string FavoriteSkyDiveContrail { get; set; }

    [JsonProperty("favorite_dance")]
    public string[] FavoriteDance { get; set; }

    [JsonProperty("favorite_itemwraps")]
    public string[] FavoriteItemWraps { get; set; }

    [JsonProperty("favorite_loadingscreen")]
    public string FavoriteLoadingScreen { get; set; }

    [JsonProperty("favorite_musicpack")]
    public string FavoriteMusicpack { get; set; }

    public AthenaProfileStats(int seasonNumber, Dictionary<string, object> cosmeticLoadout)
    {
      this.SeasonNum = seasonNumber;
      this.FavoriteCharacter = cosmeticLoadout["character"].ToString();
      this.FavoriteBackpack = cosmeticLoadout["backpack"].ToString();
      this.FavoritePickaxe = cosmeticLoadout["pickaxe"].ToString();
      this.FavoriteGlider = cosmeticLoadout["glider"].ToString();
      this.FavoriteSkyDiveContrail = cosmeticLoadout["skydivecontrail"].ToString();
      this.FavoriteDance = (string[]) cosmeticLoadout["dance"];
      this.FavoriteItemWraps = (string[]) cosmeticLoadout["itemwrap"];
      this.FavoriteLoadingScreen = cosmeticLoadout["loadingscreen"].ToString();
      this.FavoriteMusicpack = cosmeticLoadout["musicpack"].ToString();
    }
  }
}
