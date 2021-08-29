// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Exceptions.Common.UnhandledErrorException
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

namespace Rift.Backend.Models.Exceptions.Common
{
  internal class UnhandledErrorException : BaseException
  {
    public UnhandledErrorException(string message)
      : base(1012, "Sorry, an error occurred and we were unable to resolve it. Error: {0}", message)
    {
      this.Status = 500;
    }
  }
}
