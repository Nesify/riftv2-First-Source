// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Cloudstorage.CloudstorageFile
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Rift.Backend.Models.Cloudstorage
{
  public class CloudstorageFile
  {
    [JsonProperty("uniqueFilename")]
    public string UniqueFilename { get; set; }

    [JsonProperty("fileName")]
    public string FileName { get; set; }

    [JsonProperty("hash")]
    public string Hash { get; }

    [JsonProperty("hash256")]
    public string Hash256 { get; }

    [JsonProperty("length")]
    public long Length { get; }

    [JsonProperty("contentType")]
    public string ContentType => "application/octet-stream";

    [JsonProperty("uploaded")]
    public DateTime Uploaded { get; }

    [JsonProperty("storageType")]
    public string StorageType => "S3";

    [JsonProperty("doNotCache")]
    public bool DoNotCache => false;

    public CloudstorageFile(string filePath)
    {
      FileInfo fileInfo = new FileInfo(filePath);
      this.FileName = fileInfo.Name;
      this.Hash = string.Concat(((IEnumerable<byte>) new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(File.ReadAllText(filePath)))).Select<byte, string>((Func<byte, string>) (b => b.ToString("x2"))));
      this.Hash256 = string.Concat(((IEnumerable<byte>) new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(File.ReadAllText(filePath)))).Select<byte, string>((Func<byte, string>) (b => b.ToString("x2"))));
      this.Length = fileInfo.Length;
      this.Uploaded = fileInfo.LastWriteTime;
    }
  }
}
