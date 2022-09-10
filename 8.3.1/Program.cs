string filepath = @"C:\Users\ekser\source\repos\Module8+\8.3.1\Program.cs";
var fileinfo = new FileInfo(filepath);
if (fileinfo.Exists)
{
    using (StreamWriter sw = fileinfo.AppendText())
    {
        sw.WriteLine($"//Время запуска: {DateTime.Now}");
    }

    using (StreamReader sr = fileinfo.OpenText())
    {
        string str = "";
        while ((str = sr.ReadLine()) != null)
        {
            Console.WriteLine(str);
        }
    }
}
//Время запуска: 10.09.2022 16:18:57
//Время запуска: 10.09.2022 16:19:12
