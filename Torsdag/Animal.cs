using Torsdag.Interfaces;

namespace Torsdag;

public class Animal : IPerson
{
    public string Name { get; set; }

    public void Create()
    {
        Console.WriteLine("This is an Animal");
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
