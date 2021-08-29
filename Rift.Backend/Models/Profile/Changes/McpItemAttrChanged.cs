// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Profile.Changes.McpItemAttrChanged
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Profile.Changes
{
  public class McpItemAttrChanged : McpChange
  {
    [JsonProperty("itemId")]
    public string ItemId { get; set; }

    [JsonProperty("attributeName")]
    public string AttributeName { get; set; }

    [JsonProperty("attributeValue")]
    public object AttributeValue { get; set; }

    public McpItemAttrChanged(string itemId, string attributeName, object attributeValue)
      : base("itemAttrChanged")
    {
      this.ItemId = itemId;
      this.AttributeName = attributeName;
      this.AttributeValue = attributeValue;
    }
  }
}
