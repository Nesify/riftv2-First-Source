// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Temp.Properties.Settings
// Assembly: Rift, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83C2E68F-8DD1-4DA0-AC4D-377BCA7F6114
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.dll

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Rift.Frontend.Temp.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default => Settings.defaultInstance;

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("Player")]
    public string Username
    {
      get => (string) this[nameof (Username)];
      set => this[nameof (Username)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("C:\\Program Files\\Epic Games\\Fortnite")]
    public string GamePath
    {
      get => (string) this[nameof (GamePath)];
      set => this[nameof (GamePath)] = (object) value;
    }
  }
}
