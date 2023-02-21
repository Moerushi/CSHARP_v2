// Вывести наименование страницы в консоле.

string GetHtml(string url, string path)
{
  string html = String.Empty;
  if (!File.Exists(path))
  {
    html = new HttpClient().GetStringAsync(url).Result;
    File.WriteAllText(path, html);
  }
  else
  {
    html = File.ReadAllText(path);
  }
  return html;
}

string url = "https://m.vk.com";
string localPath = "vkcom.html";

string html = GetHtml(url, localPath); //скачали или создали файл с кодом с сайта

//System.Console.WriteLine(html);
//s.IndexOf находим позицию начального символа текста в числовом выражении
//s.Substring // находим кусок текста определенной длины от точки положения начального символа текста.

string s = File.ReadAllText(localPath);

string start = "<title>";
string finish = "</title>";

int startPosition = s.IndexOf(start);
int finishPosition = s.IndexOf(finish);
int startWordSize = start.Length;

System.Console.WriteLine(s.Substring(startPosition + startWordSize, finishPosition - startPosition - startWordSize));