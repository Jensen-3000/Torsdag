using Logic.Models;

namespace Logic;

public class Animal : EntityBase
{
    public string Color { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Fullname: {FirstName} {LastName}, Age: {Age}, Color: {Color}";
    }
}
