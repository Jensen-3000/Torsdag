namespace Fredag.FirstOrDefault;

internal class FirstOrDefaultLINQ
{
    public Animal FindFirstAnimalNamed(List<Animal> animals, string nameToSearch)
    {
        return animals.FirstOrDefault(animal => animal.Name == nameToSearch);
    }
}
