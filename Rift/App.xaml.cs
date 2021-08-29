// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Temp.App
// Assembly: Rift, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83C2E68F-8DD1-4DA0-AC4D-377BCA7F6114
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.dll

using Microsoft.Extensions.Hosting;
using Rift.Backend;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;

namespace Rift.Frontend.Temp
{
  public partial class App : Application
  {
    public static IHost ApiHost;
    private bool _contentLoaded;

    private async void App_OnStartup(object sender, StartupEventArgs e)
    {
      ((IEnumerable<Process>) Process.GetProcessesByName("FortniteLauncher")).FirstOrDefault<Process>()?.Kill();
      ((IEnumerable<Process>) Process.GetProcessesByName("FortniteClient-Win64-Shipping_BE")).FirstOrDefault<Process>()?.Kill();
      new MainWindow().Show();
      App.ApiHost = Program.CreateHostBuilder(e.Args).Build();
      await App.ApiHost.RunAsync();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "5.0.6.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      this.Startup += new StartupEventHandler(this.App_OnStartup);
      Application.LoadComponent((object) this, new Uri("/Rift;component/app.xaml", UriKind.Relative));
    }

    [STAThread]
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "5.0.6.0")]
    public static void Main()
    {
      App app = new App();
      app.InitializeComponent();
      app.Run();
    }
  }
}
