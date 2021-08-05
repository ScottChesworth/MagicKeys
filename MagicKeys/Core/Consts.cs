using System;

namespace MagicKeys
{

public class MKC
{
[Flags] 
public enum ModKeys : uint 
{
No = 0,
Alt = 1, 
Ctrl = 2, 
Shift = 4, 
Win = 8 
}
[Flags] 
public enum ModKeysR : uint 
{
Alt = 0x0001,
Ctrl = 0x0002,
Shift = 0x0004,
Win = 0x0008
}

public const int WM_HOTKEY = 0x0312;
public const int NOMOD = 0x0000;
public const int ALT = 0x0001;
public const int CTRL = 0x0002;
public const int SHIFT = 0x0004;
public const int WIN = 0x0008;
public const int MOD_NOREPEAT = 0x4000;
public const short SWP_NOMOVE = 0X2;
public const short SWP_NOSIZE = 1;
public const short SWP_NOZORDER = 0X4;
public const int SWP_SHOWWINDOW = 0x0040;
public const int SWP_NOACTIVATE = 0x0010;
}
}