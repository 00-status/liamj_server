public class WeaponEffect
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string[] Rarities { get; set; }
    public string Tags { get; set; }

    public WeaponEffect(int id, string name, string description, string[] rarities, string tags)
    {
        Id = id;
        Name = name;
        Description = description;
        Rarities = rarities;
        Tags = tags;
    }
}