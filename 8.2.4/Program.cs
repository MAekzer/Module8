static void DeleteFolder(string folderpath)
{
    try
    {
        string trashpath = @"C:\$RECYCLE.BIN\TestFolder";
        Directory.Move(folderpath, trashpath);
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

DeleteFolder(@"C:\Users\ekser\Desktop\TestFolder");