// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Models.Exceptions.Cloudstorage.FileNotFoundException
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

namespace Rift.Backend.Models.Exceptions.Cloudstorage
{
  internal class FileNotFoundException : BaseException
  {
    public FileNotFoundException(string file)
      : base(12004, "Sorry, we couldn't find a system file for {0}", file)
    {
      this.Status = 404;
    }
  }
}
