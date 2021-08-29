// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Commands.Mcp.PurchaseCatalogEntry
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Commands.Mcp
{
  public class PurchaseCatalogEntry
  {
    [JsonProperty("offerId")]
    public string OfferId { get; set; }

    [JsonProperty("purchaseQuantity")]
    public int PurchaseQuantity { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("currencySubType")]
    public string CurrencySubType { get; set; }

    [JsonProperty("expectedTotalPrice")]
    public int ExpectedTotalPrice { get; set; }

    [JsonProperty("gameContext")]
    public string GameContext { get; set; }
  }
}
