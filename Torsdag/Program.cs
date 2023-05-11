using Torsdag;
using Torsdag.Interfaces;

//person = new Animal(); // Overskriver person med Animal
IPerson person = new Person();
IPerson animal = new Animal();

person.Name = "John";
animal.Name = "Fnullergøj";

List<IPerson> list = new List<IPerson>
{
    person,
    animal
};


foreach (IPerson item in list) // IPerson definere typen list
{
    item.Create();
    DisplayName(item);
    Console.WriteLine();
}


void DisplayName(IPerson name)
{
    Console.WriteLine($"And my name is {name.Name}.");
}
