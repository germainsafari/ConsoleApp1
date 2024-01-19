using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

[Serializable]
class Administrator
{
    private List<Employee> users = new List<Employee>();

    public void AddUser(Employee user)
    {
        users.Add(user);
    }

    public void DisplayUsers()
    {
        foreach (Employee user in users)
        {
            user.DisplayInfo();
        }
    }

    public void SerializeEmployees()
    {
        try
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("employees.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, users);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error during serialization: " + ex.Message);
        }
    }

    public void DeserializeEmployees()
    {
        try
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("employees.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                users = (List<Employee>)formatter.Deserialize(stream);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error during deserialization: " + ex.Message);
        }
    }
}
