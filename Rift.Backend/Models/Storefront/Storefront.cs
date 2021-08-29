// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Storefront.Storefront
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;

namespace Rift.Backend.Models.Storefront
{
  public class Storefront
  {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("catalogEntries")]
    public object[] CatalogEntries => Array.Empty<object>();

    public Storefront(string name) => this.Name = name;
  }
}
