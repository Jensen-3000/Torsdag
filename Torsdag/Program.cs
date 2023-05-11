// See https://aka.ms/new-console-template for more information
using Torsdag;
using Torsdag.Interfaces;

Console.WriteLine("Hello, World!");

//person = new Animal(); // Overskriver person med Animal
IPerson person = new Person();
IPerson animal = new Animal();

List<IPerson> list = new List<IPerson>();
list.Add(person);
list.Add(animal);


foreach (IPerson item in list) // IPerson definere typen list
{
    item.Create();
}