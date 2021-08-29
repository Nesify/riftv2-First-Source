// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Lightswitch.LightswitchStatus
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;

namespace Rift.Backend.Models.Lightswitch
{
  public class LightswitchStatus
  {
    [JsonProperty("maintenanceUrl")]
    public string MaintenanceUrl;
    [JsonProperty("overrideCatalogIds")]
    public string[] OverrideCatalogIds = new string[1]
    {
      "a7f138b2e51945ffbfdacc1af0541053"
    };
    [JsonProperty("banned")]
    public bool Banned;

    [JsonProperty("serviceInstanceId")]
    public string ServiceInstanceId { get; set; }

    [JsonProperty("status")]
    public string Status => "UP";

    [JsonProperty("message")]
    public string Message => "Fortnite is UP";

    [JsonProperty("allowedActions")]
    public string[] AllowedActions => Array.Empty<string>();

    [JsonProperty("launcherInfoDTO")]
    public LauncherInfo LauncherInfoDTO => new LauncherInfo();

    public LightswitchStatus(string serviceId) => this.ServiceInstanceId = serviceId;
  }
}
