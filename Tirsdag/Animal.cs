namespace Tirsdag;

internal class Animal
{
    public int Id { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public string Name => $"{Firstname} {Lastname}";
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Color: {Color}, Name: {Name}, Age: {Age}";
    }
}
