﻿using System;
using System.IO;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void ControlSearch()
{
KeyUnReg();
OptionKeyUnReg();
 string ModuleName = MagicKeys.InputTextBox(T._("Enter substring to search for a module."), T._("Control search"));
if (ModuleName == null)
{
OptionKeyReg();
return;
}
Module = ModuleName;
P = GetPluginCoord();
if (P[0] == 1)
{
MagicKeys.Speak("Module found");
MagicKeys.MouseMove(P[1], P[2], 0);
KeyReg();
OptionKeyReg();
MagicKeys.SoundPlay("WindowOpened", 0);
Directory.CreateDirectory(@".\DevSave\"+Module);
ModuleFound();
KeyUnReg();
MagicKeys.SoundPlay("WindowClosed", 0);
}
else
{
MagicKeys.Speak("Not found");
OptionKeyReg();
}
}

}
}