using System;
using System.Windows.Forms;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Serum
{

public static void PresetsMenu()
{
MouseClick("Left", P[1]+330, P[2]+5, 1, 0, 0, 10);
}

public static void PreviousPreset()
{
MouseClick("Left", P[1]+345, P[2]+5, 1, 0, 0, 10);
if (API.GetWClass() == "#32770")
{
Speak(ControlGetTextPoint(P[1]+100, P[2]-20));
}
}

public static void NextPreset()
{
MouseClick("Left", P[1]+355, P[2]+5, 1, 0, 0, 10);
if (API.GetWClass() == "#32770")
{
Speak(ControlGetTextPoint(P[1]+100, P[2]-20));
}
}

public static void Menu()
{
MouseClick("Left", P[1]+385, P[2]+5, 1, 0, 0, 10);
}

public static void SavePresetAs()
{
MouseClick("Left", P[1]+220, P[2]+5, 1, 0, 0, 10);
}

public static void Register()
{
MouseClick("Left", P[1]+170, P[2]+20, 1, 0, 0, 10);
MenuItemClick("Right", P[1]+170, P[2]+20, 4);
Thread.Sleep(50);
MouseClick("Left", P[1]+355, P[2]+170, 2, 0, 0, 10);
Speak("please reload the plugin");
}

}
}