﻿using System;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void Update()
{
if (File.Exists("NewMKUpdater.exe") == true)
{
File.Delete("MKUpdater.exe");
File.Move("NewMKUpdater.exe", "MKUpdater.exe");
}
if (File.Exists("MKUpdater.exe") == false) return;
var RunProc = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
if (RunProc.Count(p => p.ProcessName.Contains("MKUpdater")) > 0) return;
ProcessStartInfo startInfo = new ProcessStartInfo();
startInfo.FileName = "MKUpdater.exe";
startInfo.Arguments = ThisAssembly.Git.Tag+" "+UpdCH;
Process.Start(startInfo);
}

}
}