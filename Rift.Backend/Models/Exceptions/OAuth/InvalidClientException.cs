// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Exceptions.OAuth.InvalidClientException
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

namespace Rift.Backend.Models.Exceptions.OAuth
{
  internal class InvalidClientException : BaseException
  {
    public InvalidClientException()
      : base(1011, "It appears that your Authorization header may be invalid or not present, please verify that you are sending the correct headers.")
    {
      this.Status = 400;
    }
  }
}
