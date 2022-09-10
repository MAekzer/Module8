string dirpath = Console.ReadLine();
DirectoryInfo dir = new(dirpath);

if (dir.Exists)
{
    try
    {
        CleanDir(dir);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
else
{
    Console.WriteLine($"Папки с именем {dirpath} не существует");
}

static void CleanDir(DirectoryInfo directory)
{
    DirectoryInfo[] subdirs = directory.GetDirectories();
    FileInfo[] files = directory.GetFiles();

    foreach (FileInfo file in files)
    {
        if ((DateTime.Now - file.LastAccessTime) > TimeSpan.FromMinutes(30))
            file.Delete();
    }

    foreach(DirectoryInfo subdir in subdirs)
    {
        if ((DateTime.Now - subdir.LastAccessTime) > TimeSpan.FromMinutes(30))
        {
            subdir.Delete(true);
        }
        else
        {
            CleanDir(subdir);
        }
    }
}