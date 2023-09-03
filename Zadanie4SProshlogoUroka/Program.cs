using Microsoft.VisualBasic;
using System.IO;

var path = "C:/text-data.txt"; //путь к файлу, который уже существует

try
{
    var stringsFromPath = File.ReadLines(path).ToArray();
    
    using (StreamReader streamReaderForRead = File.OpenText(path))
    {
        for (int i = 0; i < stringsFromPath.Length; i++)
        {
            Console.Write($"{stringsFromPath[i]} -> ");

            for (int j = stringsFromPath[i].Length - 1; j >= 0; j--)
            {
                char ch = stringsFromPath[i][j];

                Console.Write($"{ch}");
            }

            Console.WriteLine("");
        }
    }
}
catch (Exception ex)
{
    var msg = ex.Message;
}