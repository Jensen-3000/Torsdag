using Torsdag.Interfaces;

namespace Torsdag;

public class Person : IPerson
{
    private int _age = 50;
    public string Name { get; set; }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

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
    public override string ToString()
    {
        return Name + " " + Age;
    }
}
