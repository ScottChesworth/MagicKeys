using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void MouseMove (int GetX, int GetY, int TimeMove)
{
int X = GetX, Y = GetY;
if (GetX >= Width) X = Width-1;
if (GetY >= Height) Y = Height-1;
if (GetX <= 0) X = 0;
if (GetY <= 0) Y = 0;
INPUT mouseMoveInput = new INPUT();
int[] MP = GetMousePosition();
for (int MX = MP[0], MY = MP[1]; MX != X || MY != Y; MX = NumberAlign(MX, X), MY = NumberAlign(MY, Y))
{
Sleep(TimeMove);
Tuple<int, int> mouseEventCoords = VirtualScreenExtender.MouseEventCoords(MX, MY);
mouseMoveInput.type = SendInputEventType.InputMouse;
mouseMoveInput.m.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_MOVE | MouseEventFlags.MOUSEEVENTF_ABSOLUTE;
mouseMoveInput.m.mi.dx = mouseEventCoords.Item1;
mouseMoveInput.m.mi.dy = mouseEventCoords.Item2;
SendInput(1, ref mouseMoveInput, Marshal.SizeOf(new INPUT()));
}
while(true)
{
MP = GetMousePosition();
if (MP[0] == X & MP[1] ==Y)
{
return;
}
mouseMoveInput.type = SendInputEventType.InputMouse;
mouseMoveInput.m.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_MOVE;
if (MP[0] < X)
{
mouseMoveInput.m.mi.dx = 1;
}
else if (MP[0] > X)
{
mouseMoveInput.m.mi.dx = -1;
}
else if (MP[0] == X)
{
mouseMoveInput.m.mi.dx = 0;
}
if (MP[1] < Y)
{
mouseMoveInput.m.mi.dy = 1;
}
else if (MP[1] > Y)
{
mouseMoveInput.m.mi.dy = -1;
}
else if (MP[1] == Y)
{
mouseMoveInput.m.mi.dy = 0;
}
SendInput(1, ref mouseMoveInput, Marshal.SizeOf(new INPUT()));
}
}

}
}