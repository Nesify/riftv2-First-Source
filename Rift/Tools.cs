// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Temp.Tools
// Assembly: Rift, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83C2E68F-8DD1-4DA0-AC4D-377BCA7F6114
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.dll

using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using System.Windows;

namespace Rift.Frontend.Temp
{
  public static class Tools
  {
    public static async Task UnpackResource(string resourceName)
    {
      Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Rift.Frontend.Temp.Resources." + resourceName);
      string str = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Rift");
      Directory.CreateDirectory(str);
      FileStream fileStream = File.Create(Path.Join(str, resourceName));
      object obj = (object) null;
      int num = 0;
      try
      {
        await manifestResourceStream.CopyToAsync((Stream) fileStream);
        num = 1;
      }
      catch (object ex)
      {
        obj = ex;
      }
      if (fileStream != null)
        await fileStream.DisposeAsync();
      object obj1 = obj;
      if (obj1 != null)
      {
        if (!(obj1 is Exception source2))
          throw obj1;
        ExceptionDispatchInfo.Capture(source2).Throw();
      }
      if (num == 1)
      {
        fileStream = (FileStream) null;
      }
      else
      {
        obj = (object) null;
        fileStream = (FileStream) null;
        fileStream = (FileStream) null;
      }
    }

    public static string ChooseGamePath()
    {
      CommonOpenFileDialog commonOpenFileDialog1 = new CommonOpenFileDialog();
      commonOpenFileDialog1.IsFolderPicker = true;
      commonOpenFileDialog1.EnsurePathExists = true;
      commonOpenFileDialog1.Title = "Choose Fortnite path";
      commonOpenFileDialog1.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
      CommonOpenFileDialog commonOpenFileDialog2 = commonOpenFileDialog1;
      if (commonOpenFileDialog2.ShowDialog() != CommonFileDialogResult.Ok)
        return (string) null;
      if (File.Exists(Path.Join(commonOpenFileDialog2.FileName, "FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe")))
        return commonOpenFileDialog2.FileName;
      int num = (int) MessageBox.Show("The path you provided doesn't have Fortnite installed! Make sure the path points to the folder that contains the FortniteGame and Engine folders.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
      return (string) null;
    }
  }
}
