namespace Torsdag.Interfaces;

// An interface is always public in all OOP Languages
public interface IPerson
{
    public string Name { get; set; }
    void Create();
    void Read();
    void Update();
    void Delete();
}
