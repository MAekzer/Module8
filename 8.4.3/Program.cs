using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Contact
{
    public string Name { get; set; }
    public long PhoneNumber { get; set; }
    public string Email { get; set; }

    public Contact(string name, long phoneNumber, string email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        string filepath = @"C:\Users\ekser\Desktop\BinaryClass.dat";
        Contact contact = new("Михаил", 86959406, "gma312@yandex.ru");

        BinaryFormatter form = new();

        using (FileStream fs = new(filepath, FileMode.OpenOrCreate))
        {
            form.Serialize(fs, contact);
        }

        using (FileStream fs = new(filepath, FileMode.OpenOrCreate))
        {

        }
    }
}
