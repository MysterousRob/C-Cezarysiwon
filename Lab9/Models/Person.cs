namespace Lab9.Models;

public class Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public DateTime BirthDate { get; init; }


    protected string _password;


    public string Password
    {
        set { _password = value; }
    }

    public bool isPasswordValid(string password)
    {
        return password == _password;
    }
}