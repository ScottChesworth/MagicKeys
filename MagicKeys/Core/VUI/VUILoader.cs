using static MKLib;
using Microsoft.Collections.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUILoader(string File)
{
KeyUnReg();
VUIKeys.Clear();
VUIObjects.Clear();
ActiveObjects.Clear();
CurrentPlugin.Remove("Loader");
ThreadFunc = string.Empty;
SoundPlay("ChangeVUI", false);
CurrentPlugin["VUI"] = File;
ParamsLoader();
string[] AllVUIObjects = Ini.IniReadSections(API.GetCurrentVUI()).Where(ParamSections => ParamSections != "Params" && ParamSections != "Keys").ToArray();
ObjectsCount = AllVUIObjects.Length-1;
foreach(var ObjectName in AllVUIObjects)
{
VUIObjects.Add(ObjectName, new OrderedDictionary<string, string>());
List<string> Keys = Ini.IniReadKeys(API.GetCurrentVUI(), ObjectName);
List<string> Values = Ini.IniReadValues(API.GetCurrentVUI(), ObjectName);
VUIObjects.GetValueOrDefault(ObjectName).Add("Active", "true");
for(int I = 0; I <= Keys.Count-1; I++)
{
try
{
if(Keys[I] == "" || Values[I] == "")
{
throw new IndexOutOfRangeException();
}
VUIObjects.GetValueOrDefault(ObjectName).Add(Keys[I], Values[I]);
}
catch(IndexOutOfRangeException)
{
MKDebugForm("Object is not correct\r\n"+API.GetCurrentVUI()+" "+ObjectName);
}
}
}
VUIObjectsUpdate(true);
GetPluginType();
VUIPluginLoad();
KeyLoader();
KeyReg();
SoundPlay("PluginDetect", false);
}

}
}