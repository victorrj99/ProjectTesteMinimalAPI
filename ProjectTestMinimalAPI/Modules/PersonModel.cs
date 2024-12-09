namespace ProjectTestMinimalAPI.Modules;

public class PersonModel
{
    public Guid Id { get; init; }
    public string Name { get; private set; }

    public PersonModel(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }
}