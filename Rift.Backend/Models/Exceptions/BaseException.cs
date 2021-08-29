// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Exceptions.BaseException
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Newtonsoft.Json;
using System;

namespace Rift.Backend.Models.Exceptions
{
  [JsonObject(MemberSerialization.OptIn)]
  public class BaseException : Exception
  {
    public int Status = 400;

    [JsonProperty("errorCode")]
    public string Code => "errors.com.rift" + this.GetType().FullName.ToLower().Replace("rift.backend.models.exceptions", "");

    [JsonProperty("errorMessage")]
    public override string Message => base.Message;

    [JsonProperty("messageVars")]
    public string[] Variables { get; private set; }

    [JsonProperty("numericErrorCode")]
    public int NumericCode { get; private set; }

    [JsonProperty("originatingService")]
    public string OriginatingService => "rift";

    [JsonProperty("intent")]
    public string Intent => "prod";

    public BaseException(int numericCode, string message, params string[] variables)
      : base(string.Format(message, (object[]) variables))
    {
      this.Variables = variables;
      this.NumericCode = numericCode;
    }
  }
}
