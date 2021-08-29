// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Temp.Properties.Resources
// Assembly: Rift, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83C2E68F-8DD1-4DA0-AC4D-377BCA7F6114
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Rift.Frontend.Temp.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Rift.Frontend.Temp.Properties.Resources.resourceMan == null)
          Rift.Frontend.Temp.Properties.Resources.resourceMan = new ResourceManager("Rift.Frontend.Temp.Properties.Resources", typeof (Rift.Frontend.Temp.Properties.Resources).Assembly);
        return Rift.Frontend.Temp.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Rift.Frontend.Temp.Properties.Resources.resourceCulture;
      set => Rift.Frontend.Temp.Properties.Resources.resourceCulture = value;
    }

    internal static byte[] FortniteClient_Win64_Shipping_BE => (byte[]) Rift.Frontend.Temp.Properties.Resources.ResourceManager.GetObject(nameof (FortniteClient_Win64_Shipping_BE), Rift.Frontend.Temp.Properties.Resources.resourceCulture);

    internal static byte[] FortniteLauncher => (byte[]) Rift.Frontend.Temp.Properties.Resources.ResourceManager.GetObject(nameof (FortniteLauncher), Rift.Frontend.Temp.Properties.Resources.resourceCulture);
  }
}
