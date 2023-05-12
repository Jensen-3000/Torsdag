using Fredag;

void DisplaySeparator()
{
    Console.WriteLine(new string('-', 40));
}

#region start
Animal animal = new Animal();
List<Animal> animalList = animal.AnimalListMethod();
#endregion

#region Find Animal color
animal.FindAnimalBlueColor(animalList);
#endregion

DisplaySeparator();

#region Find Animal named Søren
void DisplayFindAnimalNamedSoren()
{
    List<Animal> animalsNamedSoren = animal.FindNameAndAddToList(animalList);
    foreach (Animal animal in animalsNamedSoren)
    {
        Console.WriteLine(animal);
    }
}
DisplayFindAnimalNamedSoren();
#endregion

DisplaySeparator();

void DisplayFindAnimalsNamedSorenLINQ()
{
    foreach (Animal animal in animal.FindNameAndAddToListLINQ(animalList))
    {
        Console.WriteLine(animal);
    }
}
DisplayFindAnimalsNamedSorenLINQ();

DisplaySeparator();