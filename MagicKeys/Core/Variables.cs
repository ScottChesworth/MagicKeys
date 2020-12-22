using System;
using System.Drawing;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Text;

namespace MagicKeys
{
public partial class MagicKeys
{
public static readonly string Version = "1.5.4";
public static Size Display = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
public static int Width = Display.Width;
public static int Height = Display.Height;
// буфер для функции отслеживания изменений на экране.
public static Bitmap OneScreen;
// Флаг для включения/отключения MagicKeys.
public static int KeySwitch = 0;
public static int NavigationType = 0;
public static bool SoundTheme = true;
public static bool SpeakType = false;
public static bool Exit = true;
public static bool SendInfoFlag = true;
// Задержка в цикле обнаружения окон.
public static int TimeOut = 20;
// Объектная модель текущего интерфейса.
public static Dictionary<int, Dictionary<string, string>> VUIObjects = new Dictionary<int, Dictionary<string, string>>();
public static List<int> ActiveObjects = new List<int>();
// Количество объектов интерфейса.
public static int Count;
// Номер текущего объекта интерфейса.
public static int Section;
// состояние обнаружения, Координаты и размеры текущего контрола. Обновляется динамически.
public static int[] P = new int[10];
// Для хранения временных координат.
public static int[] DP = new int[10];
public static int nChars = 256;
public static StringBuilder Text = new StringBuilder(nChars);
public static StringBuilder Title = new StringBuilder(nChars);
public static StringBuilder Class = new StringBuilder(nChars);
public static string SubPath = string.Empty;
public static string CopyText = String.Empty;
}
}