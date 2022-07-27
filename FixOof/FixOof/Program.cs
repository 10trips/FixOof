using System;
using System.IO;
using System.Net;
using System.Collections;





string s;
using (HttpClient client = new HttpClient())
{
    s = await client.GetStringAsync("https://raw.githubusercontent.com/10trips/FixOof/main/file.txt");
}

s = s.Trim();

string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + s;


File.Delete(path);

using (WebClient wc = new WebClient())
{
    wc.DownloadFileAsync(
        new System.Uri("https://github.com/10trips/FixOof/raw/main/ouch.ogg"),
        @path
    );
    Thread.Sleep(3000);

}

Console.WriteLine("Successfuly replaced death sound, enjoy!");
Thread.Sleep(3000);