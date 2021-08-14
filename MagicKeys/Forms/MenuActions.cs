using System;
using System.Windows.Forms;

namespace MagicKeys
{

public partial class Menu : Form
{

public static SettingsForm WSettings;
public void Exit(object sender, EventArgs e)
{
MagicKeys.KeySwitch = 1;
MagicKeys.UnregisterHotKey(MagicKeys.HM.Handle, 0);
MagicKeys.UnregisterHotKey(MagicKeys.HM.Handle, 1);
Ni.Visible = false;
if (Settings.Exit == true)
{
DialogResult result;
result = MessageBox.Show(T._("Do you really want to exit MagicKeys?"), T._("Exit MagicKeys"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
if (result == DialogResult.OK)
{
MagicKeys.Speak(T._("Goodbye"));
Application.Exit();
return;
}
Ni.Visible = true;
MagicKeys.RegisterHotKey(MagicKeys.HM.Handle, 0, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F1);
MagicKeys.RegisterHotKey(MagicKeys.HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
MagicKeys.KeySwitch = 0;
}
else
{
MagicKeys.Speak(T._("Goodbye"));
Application.Exit();
}
}

public void Help(object sender, EventArgs e)
{
string commandText = @"Руководство пользователя.html";
var proc = new System.Diagnostics.Process();
proc.StartInfo.FileName = commandText;
proc.StartInfo.UseShellExecute = true;
proc.Start();
}

public void SettingsShow(object sender, EventArgs e)
{
if (WSettings == null || WSettings.IsDisposed == true)
{
WSettings = new SettingsForm();
WSettings.ShowDialog();
WSettings.Dispose();
WSettings = null;
}
else
{
WSettings.Activate();
}
}

public void CheckUpdates(object sender, EventArgs e)
{
MagicKeys.Update("true");
}

}
}