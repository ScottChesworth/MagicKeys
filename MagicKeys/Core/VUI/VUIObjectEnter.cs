using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectEnter()
{
KeyUnReg();
if (API.GetPClass() == "MagicKeys")
{
List<string> VUFValues = Ini.IniReadValues(API.GetVUIPath()+API.GetVUI()+".vuf", API.GetFunc());
VUFInvoke(VUFValues);
KeyReg();
return;
}
if (API.GetParam() == null)
{
InvokeFromString(API.GetFunc());
KeyReg();
return;
}
InvokeFromString(API.GetFunc(), API.GetParam());
KeyReg();
}

}
}