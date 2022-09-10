static long CountSize(string dirpath)
{
    if (Directory.Exists(dirpath))
    {
        DirectoryInfo dir = new(dirpath);
        long size = 0;

        foreach (FileInfo file in dir.GetFiles())
        {
            size += file.Length;
        }

        foreach (DirectoryInfo directory in dir.GetDirectories())
        {
            size += CountSize(directory.FullName);
        }

        return size;
    }
    else
    {
        Console.WriteLine($"Не существует директории по указанному пути {dirpath}");
        return 0;
    }
}

try
{
    Console.WriteLine(CountSize(Console.ReadLine()));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
