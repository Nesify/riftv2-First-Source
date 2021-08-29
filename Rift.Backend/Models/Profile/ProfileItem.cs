// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Profile.ProfileItem
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;

namespace Rift.Backend.Models.Profile
{
  public class ProfileItem
  {
    [JsonProperty("templateId")]
    public string TemplateId { get; set; }

    [JsonProperty("attributes")]
    public object Attributes { get; set; }

    [JsonProperty("quantity")]
    public int Quantity { get; set; }

    public ProfileItem(string templateId, object attributes = null, int quantity = 1)
    {
      this.TemplateId = templateId;
      this.Attributes = attributes ?? (object) new ItemAttributes();
      this.Quantity = quantity;
    }
  }
}
