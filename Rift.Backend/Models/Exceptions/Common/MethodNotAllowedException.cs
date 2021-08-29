// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Exceptions.Common.MethodNotAllowedException
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

namespace Rift.Backend.Models.Exceptions.Common
{
  internal class MethodNotAllowedException : BaseException
  {
    public MethodNotAllowedException()
      : base(1009, "Sorry the resource you were trying to access cannot be accessed with the HTTP method you used.")
    {
      this.Status = 405;
    }
  }
}
