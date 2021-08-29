// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Commands.Mcp.RemoveGiftBox
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rift.Backend.Models.Commands.Mcp
{
  public class RemoveGiftBox
  {
    [JsonProperty("giftBoxItemIds")]
    public List<string> GiftBoxItemIds { get; set; }

    [JsonProperty("giftBoxItemId")]
    public string GiftBoxItemId { get; set; }
  }
}
