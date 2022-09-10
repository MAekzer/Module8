public class Drive
{
    public string Name { get; set; }
    public long ToatalSpace { get; set; }
    public long FreeSpace { get; set; }

    public Drive(string name, long toatalSpace, long freeSpace)
    {
        Name = name;
        ToatalSpace = toatalSpace;
        FreeSpace = freeSpace;
    }
}

public class Folder
{
    public List<string> Files { get; set; } = new List<string>();

    public void AddFile(string file)
    {
        Files.Add(file);
        Console.WriteLine("Добавлена папка {0}", file);
    }
}

class Directory
{
    Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

    public void CreateFolder(string name)
    {
        Folders.Add(name, new Folder());
    }
}

