namespace Fredag;

internal class Animal : IPerson
{
    public int Id { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }

    public void Create()
    {
        Console.WriteLine("This is an Animal");
    }

    public List<Animal> AnimalListMethod()
    {
        List<Animal> animalList = new List<Animal>()
        {
            new Animal { Id = 1, Age = 5, Color = "red", Name = "Hansi" },
            new Animal { Id = 2, Age = 15, Color = "blue", Name = "Bo" },
            new Animal { Id = 3, Age = 25, Color = "yellow", Name = "Søren" },
            new Animal { Id = 4, Age = 95, Color = "red", Name = "Søren" },
            new Animal { Id = 5, Age = 55, Color = "orange", Name = "Gert" },
            new Animal { Id = 6, Age = 55, Color = "magenta", Name = "John" },
        };
        return animalList;
    }

    public void FindAnimalBlueColor(List<Animal> animals)
    {
        foreach (var item in animals)
        {
            if (item.Color == "blue")
            {
                Console.WriteLine($"  {item}");
            }
        }
    }

    public List<Animal> FindNameAndAddToList(List<Animal> listOfAnimals)
    {
        List<Animal> animalsNewList = new List<Animal>();
        foreach (var animal in listOfAnimals)
        {
            if (animal.Name == "Søren")
            {
                animalsNewList.Add(animal);
            }
        }
        return animalsNewList;
    }

    public List<Animal> FindNameAndAddToListLINQ(List<Animal> listoOfAnimals)
    {
        return listoOfAnimals.Where<Animal>(animal => animal.Name == "Søren").ToList();
    }

    public List<Animal> FindAnimalsAboveAge50LINQ(List<Animal> animals)
    {
        return animals.Where<Animal>(animal => animal.Age > 50).ToList();
    }


    public override string ToString()
    {
        //return string.Join(" | ", Id, Name, Age, Color);
        //return $"Id: {Id}\n- Name: {Name} \n- Age: {Age} \n- Color: {Color}";
        return $"Id: {Id}, Name: {Name}, Age: {Age}, Color: {Color}";
    }
}
