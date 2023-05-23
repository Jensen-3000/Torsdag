namespace Logic.Models;

public abstract class EntityBase
{
    public int Id { get; set; }
    public int Age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
