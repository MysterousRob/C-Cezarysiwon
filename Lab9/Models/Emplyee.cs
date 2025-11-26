namespace Lab9.Models;

public class Employee : Person
{
    public decimal Salary { get; init; }
    public string Position { get; init; }
    public string Division { get; init; }
}