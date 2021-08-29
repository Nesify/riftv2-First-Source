// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Commands.Cosmetics.DeleteCosmeticLoadout
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Commands.Cosmetics
{
  public class DeleteCosmeticLoadout
  {
    [JsonRequired]
    [JsonProperty("index")]
    public int Index { get; set; }

    [JsonProperty("fallbackLoadoutIndex")]
    public int FallbackLoadoutIndex { get; set; }

    [JsonProperty("leaveNullSlot")]
    public bool LeaveNullSlot { get; set; }
  }
}
