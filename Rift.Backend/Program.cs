// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Program
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Rift.Backend
{
  public class Program
  {
    public static readonly Dictionary<string, object> CosmeticLoadout = new Dictionary<string, object>()
    {
      {
        "character",
        (object) "AthenaCharacter:cid_001_athena_commando_f_default"
      },
      {
        "backpack",
        (object) ""
      },
      {
        "pickaxe",
        (object) "AthenaPickaxe:defaultpickaxe"
      },
      {
        "glider",
        (object) "AthenaGlider:defaultglider"
      },
      {
        "skydivecontrail",
        (object) ""
      },
      {
        "loadingscreen",
        (object) ""
      },
      {
        "musicpack",
        (object) ""
      },
      {
        "dance",
        (object) new string[6]
        {
          "AthenaDance:eid_dancemoves",
          "",
          "",
          "",
          "",
          ""
        }
      },
      {
        "itemwrap",
        (object) new string[7]{ "", "", "", "", "", "", "" }
      }
    };

    public static string Id { get; set; }

    public static string DisplayName { get; set; }

    public static string ClientId { get; set; }

    public static int AthenaRvn { get; set; }

    public static int CommonCoreRvn { get; set; }

    public static void Main(string[] args) => Program.CreateHostBuilder(args).Build().Run();

    public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).ConfigureLogging((Action<ILoggingBuilder>) (logging => logging.ClearProviders())).ConfigureWebHostDefaults((Action<IWebHostBuilder>) (webBuilder =>
    {
      webBuilder.UseUrls("http://*:80");
      webBuilder.UseStartup<Startup>();
    }));
  }
}
