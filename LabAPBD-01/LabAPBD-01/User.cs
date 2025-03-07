namespace LabAPBD_01;

public class User
{

    public string username { get; private set; }
    public int age { get; private set; }

    public User(string username, int age)
    {
        this.username = username;
        this.age = age;
    }
    
}