using System.IO;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

// FILE, FILEINFO E IOEXCEPTION
string sourcePath = @"C:\Users\mathe\Desktop\file1.txt";
string targetPath = @"C:\Users\mathe\Desktop\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
} 

//=======================================================================================================================================

// FILESTREAM E STREAMREADER
string path = @"C:\Users\mathe\Desktop\file1.txt";
FileStream fs = null;
StreamReader sr = null;
try
{
    sr = File.OpenText(path);
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
finally
{
    if (sr != null) sr.Close();
} 

//=======================================================================================================================================

// BLOCO USING
string path = @"C:\Users\mathe\Desktop\file1.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
} 

//=======================================================================================================================================

// STREAMWRITER
string sourcePath = @"C:\Users\mathe\Desktop\file1.txt";
string targetPath = @"C:\Users\mathe\Desktop\file2.txt";

try
{
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
} 

//=======================================================================================================================================

// DIRECTORY, DIRECTORYINFO
string path = @"C:\Users\mathe\Desktop\myfolder";

try
{
    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // or var folders = 
    Console.WriteLine("FOLDERS:");
    foreach(string s in folders)
    {
        Console.WriteLine(s);
    }

    IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // or var files = 
    Console.WriteLine("FILES:");
    foreach (string s in files)
    {
        Console.WriteLine(s);
    }

    Directory.CreateDirectory(path + @"\newfolder"); // ou (@"C:\Users\mathe\Desktop\myfolder\newfolder"
}
catch (IOException e)
{
    Console.WriteLine("An error ocorred");
    Console.WriteLine(e.Message);
} 

//=======================================================================================================================================

// PATH
string path = @"C:\Users\mathe\Desktop\myfolder\file1.txt";

Console.WriteLine("PathSeparator: " + Path.PathSeparator);
Console.WriteLine("DirectorySeparetorChar: " + Path.DirectorySeparatorChar);
Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
Console.WriteLine("GetFileName: " + Path.GetFileName(path));
Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
Console.WriteLine("GetExtension: " + Path.GetExtension(path));
Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
Console.WriteLine("GetTempPath: " + Path.GetTempPath());