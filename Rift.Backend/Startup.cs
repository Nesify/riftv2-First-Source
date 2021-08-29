// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Startup
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Rift.Backend.Filters;
using Rift.Backend.Services;
using System;
using System.IO;

namespace Rift.Backend
{
  public class Startup
  {
    public Startup(IConfiguration configuration) => this.Configuration = configuration;

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc().AddNewtonsoftJson((Action<MvcNewtonsoftJsonOptions>) (options =>
      {
        options.SerializerSettings.Converters.Add((JsonConverter) new IsoDateTimeConverter()
        {
          DateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fff'Z'"
        });
        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
      }));
      services.AddMvc((Action<MvcOptions>) (options => options.Filters.Add((IFilterMetadata) new BaseExceptionFilterAttribute())));
      services.AddSingleton<IProfileService, ProfileService>();
      services.AddHttpContextAccessor();
      services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
        app.UseDeveloperExceptionPage();
      app.UseEpicStatusErrors();
      app.UseRouting();
      app.UseAuthorization();
      string str = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Rift", "Cloudstorage");
      if (!Directory.Exists(str))
      {
        Directory.CreateDirectory(str);
        File.WriteAllText(Path.Join(str, "DefaultEngine.ini"), "[/Script/FortniteGame.FortPlayerController]\nTurboBuildInterval = 0.005f\nTurboBuildFirstInterval = 0.005f");
      }
      app.UseEndpoints((Action<IEndpointRouteBuilder>) (endpoints => endpoints.MapControllers()));
    }
  }
}
