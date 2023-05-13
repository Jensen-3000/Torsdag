namespace Fredag.Select;

internal class SelectLINQ
{
    public IEnumerable<string> SelectAnimalColors(List<Animal> animals)
    {
        IEnumerable<string> colors = animals.Select(animal => animal.Color);
        return colors;
    }
}
