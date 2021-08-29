// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Temp.MainWindow
// Assembly: Rift, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83C2E68F-8DD1-4DA0-AC4D-377BCA7F6114
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.dll

using Bleak;
using Newtonsoft.Json;
using Rift.Backend.Controllers;
using Rift.Frontend.Temp.Models;
using Rift.Frontend.Temp.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;

namespace Rift.Frontend.Temp
{
  public partial class MainWindow : Window, IComponentConnector
  {
    private const string LAUNCHER_INFO_MESSAGE = "Rift\nMade by Makks\n\nLauncher by @omairma\nBackend by cyclonefreeze#0001\n\nThe launcher is a work in progress, expect a better design in the future.";
    private Process _fortniteProcess;
    private Process _fnLauncherProcess;
    private Process _fnAntiCheatProcess;
    internal TextBox UsernameBox;
    internal TextBox PathBox;
    private bool _contentLoaded;

    public MainWindow()
    {
      this.InitializeComponent();
      this.UsernameBox.Text = Settings.Default.Username;
      this.PathBox.Text = Settings.Default.GamePath;
    }

    private void Watermark_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
      int num = (int) MessageBox.Show("Rift\nMade by Makks\n\nLauncher by @omairma\nBackend by cyclonefreeze#0001\n\nThe launcher is a work in progress, expect a better design in the future.", "About Rift");
    }

    private async void PlayButton_Click(object sender, RoutedEventArgs e)
    {
      MainWindow mainWindow = this;
      // ISSUE: reference to a compiler-generated method
      McpController.OnRiftRequested = new Action(mainWindow.\u003CPlayButton_Click\u003Eb__6_0);
      string gamePath = mainWindow.PathBox.Text + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe";
      string tempPath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Rift");
      string args;
      Injector injector;
      if (!File.Exists(gamePath))
      {
        int num = (int) MessageBox.Show("The path you provided doesn't have Fortnite installed! Make sure the path points to the folder that contains the FortniteGame and Engine folders.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        gamePath = (string) null;
        tempPath = (string) null;
        args = (string) null;
        injector = (Injector) null;
      }
      else
      {
        args = "-epicapp=Fortnite -skippatchcheck -epicportal -noeac -nobe -fltoken=" + JsonConvert.DeserializeObject<Nitestats.FLToken>(await new WebClient().DownloadStringTaskAsync("https://api.nitestats.com/v1/epic/builds/fltoken")).Token + " -fromfl=none -AUTH_LOGIN=" + mainWindow.UsernameBox.Text + "@riftfn.xyz -AUTH_PASSWORD=unused -AUTH_TYPE=epic";
        if (!File.Exists(Path.Join(tempPath, "FortniteLauncher.exe")))
          await Tools.UnpackResource("FortniteLauncher.exe");
        if (!File.Exists(Path.Join(tempPath, "FortniteClient-Win64-Shipping_BE.exe")))
          await Tools.UnpackResource("FortniteClient-Win64-Shipping_BE.exe");
        mainWindow._fortniteProcess = Process.Start(gamePath, args);
        mainWindow._fnLauncherProcess = Process.Start(new ProcessStartInfo()
        {
          Arguments = args,
          CreateNoWindow = true,
          FileName = Path.Join(tempPath, "FortniteLauncher.exe")
        });
        mainWindow._fnAntiCheatProcess = Process.Start(new ProcessStartInfo()
        {
          Arguments = args,
          CreateNoWindow = true,
          FileName = Path.Join(tempPath, "FortniteClient-Win64-Shipping_BE.exe")
        });
        mainWindow.Hide();
        Thread.Sleep(200);
        injector = new Injector(mainWindow._fortniteProcess.ProcessName, Constants.CURL_CONTENT, InjectionMethod.CreateThread);
        try
        {
          injector.InjectDll();
          await mainWindow._fortniteProcess.WaitForExitAsync();
          mainWindow._fnLauncherProcess.Kill();
          mainWindow._fnAntiCheatProcess.Kill();
          mainWindow.Show();
          gamePath = (string) null;
          tempPath = (string) null;
          args = (string) null;
          injector = (Injector) null;
        }
        finally
        {
          injector?.Dispose();
        }
      }
    }

    private async void MainWindow_OnClosing(object sender, CancelEventArgs e)
    {
      MainWindow mainWindow = this;
      await App.ApiHost.StopAsync();
      mainWindow.Close();
    }

    private void UsernameBox_TextChanged(object sender, TextChangedEventArgs e)
    {
      Settings.Default.Username = this.UsernameBox.Text;
      Settings.Default.Save();
    }

    private void PathSelectionBtn_Click(object sender, RoutedEventArgs e)
    {
      string str = Tools.ChooseGamePath();
      if (str == null)
        return;
      Settings.Default.GamePath = str;
      Settings.Default.Save();
      this.PathBox.Text = str;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "5.0.6.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/Rift;component/mainwindow.xaml", UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "5.0.6.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      switch (connectionId)
      {
        case 1:
          ((Window) target).Closing += new CancelEventHandler(this.MainWindow_OnClosing);
          break;
        case 2:
          this.UsernameBox = (TextBox) target;
          this.UsernameBox.TextChanged += new TextChangedEventHandler(this.UsernameBox_TextChanged);
          break;
        case 3:
          this.PathBox = (TextBox) target;
          break;
        case 4:
          ((ButtonBase) target).Click += new RoutedEventHandler(this.PathSelectionBtn_Click);
          break;
        case 5:
          ((ButtonBase) target).Click += new RoutedEventHandler(this.PlayButton_Click);
          break;
        case 6:
          ((UIElement) target).MouseDown += new MouseButtonEventHandler(this.Watermark_OnMouseDown);
          break;
        default:
          this._contentLoaded = true;
          break;
      }
    }
  }
}
