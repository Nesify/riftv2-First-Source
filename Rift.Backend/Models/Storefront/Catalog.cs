// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Storefront.Catalog
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rift.Backend.Models.Storefront
{
  public class Catalog
  {
    [JsonProperty("refreshIntervalHrs")]
    public int RefreshIntervalHrs => 24;

    [JsonProperty("dailyPurchaseHrs")]
    public int DailyPurchaseHrs => 24;

    [JsonProperty("expiration")]
    public DateTime Expiration => DateTime.MaxValue;

    [JsonProperty("storefronts")]
    public List<Rift.Backend.Models.Storefront.Storefront> Storefronts { get; set; }

    public Catalog() => this.Storefronts = new List<Rift.Backend.Models.Storefront.Storefront>()
    {
      new Rift.Backend.Models.Storefront.Storefront("BRDailyStorefront"),
      new Rift.Backend.Models.Storefront.Storefront("BRWeeklyStorefront")
    };
  }
}
