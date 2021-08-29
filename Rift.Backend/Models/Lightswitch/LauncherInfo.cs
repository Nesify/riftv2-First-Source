// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Lightswitch.LauncherInfo
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Lightswitch
{
  public class LauncherInfo
  {
    [JsonProperty("appName")]
    public string AppName => "Fortnite";

    [JsonProperty("catalogItemId")]
    public string CatalogItemId => "4fe75bbc5a674f4f9b356b5c90567da5";

    [JsonProperty("namespace")]
    public string Namespace => "fn";
  }
}
