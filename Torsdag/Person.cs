using Torsdag.Interfaces;

namespace Torsdag;

public class Person : IPerson
{
    public string Name { get; set; }

    public void Create()
    {
        Console.WriteLine("This is a Person");
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Read()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}
