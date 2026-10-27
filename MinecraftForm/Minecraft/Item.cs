namespace MinecraftForm;

public abstract class Item
{
    public string Id { get; protected set; }
    public string Name { get; protected set; }
    public int Value { get; protected set; }
    public ItemRarity Rarity { get; protected set; }

    protected Item(string id, string name, int value, ItemRarity rarity)
    {
        Id = id;
        Name = name;
        Value = value;
        Rarity = rarity;
    }

    public abstract string GetDetails();
}