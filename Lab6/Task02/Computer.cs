using System.Dynamic;

namespace Lab06.Task02;
public class Computer
{
    public int RAM { get; set; }
    public int HDD { get; set; }
    public bool HasBacklitKeyboard { get; set; }

    public string INFO
    {
        get
        {
            return $"Komputer: RAM = {RAM} GB, HDD = {HDD} GB, Podświetlana klawiatura = {HasBacklitKeyboard}";
        }
    }
}