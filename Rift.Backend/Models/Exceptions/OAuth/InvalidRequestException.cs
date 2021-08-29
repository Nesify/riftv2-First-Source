// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Exceptions.OAuth.InvalidRequestException
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

namespace Rift.Backend.Models.Exceptions.OAuth
{
  internal class InvalidRequestException : BaseException
  {
    public InvalidRequestException(string field)
      : base(1016, field + " is required.")
    {
      this.Status = 400;
    }
  }
}
