﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string GetHtmlCode(string URL)
{
using (HttpClient client = new HttpClient())
{
using (HttpResponseMessage response = client.GetAsync(URL).Result)
{
using (HttpContent content = response.Content)
{
string result = content.ReadAsStringAsync().Result.ToString();
return result;
}
}
}
}

}
}