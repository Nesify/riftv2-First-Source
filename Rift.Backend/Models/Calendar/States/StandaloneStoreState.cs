// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Calendar.States.StandaloneStoreState
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;

namespace Rift.Backend.Models.Calendar.States
{
  public class StandaloneStoreState
  {
    [JsonProperty("activePurchaseLimitingEventIds")]
    public string[] ActivePurchaseLimitingEventIds => Array.Empty<string>();

    [JsonProperty("storefront")]
    public object Storefront => new object();

    [JsonProperty("rmtPromotionConfig")]
    public string[] RMTPromotionConfig => Array.Empty<string>();

    [JsonProperty("storeEnd")]
    public DateTime StoreEnd => DateTime.MinValue;
  }
}
