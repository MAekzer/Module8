string filepath = @"C:\Users\ekser\Desktop\BinaryFile.bin";

if (File.Exists(filepath))
{
    string stringvalue;

    using (BinaryWriter bw = new(File.Open(filepath, FileMode.Open)))
    {
        bw.Write($"Файл изменен {DateTime.Now} на компьютере Windows 10");
    }

    using (BinaryReader br = new(File.Open(filepath, FileMode.Open)))
    {
        stringvalue = br.ReadString();
    }

    Console.WriteLine(stringvalue);
}
