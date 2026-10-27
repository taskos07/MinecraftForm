namespace MinecraftForm;

public class BlockItem : Item
{
    public bool IsStackable { get; set; }
    public float Hardness { get; set; }

    public BlockItem(string id, string name, int value, ItemRarity rarity, bool isStackable, float hardness)
        : base(id, name, value, rarity)
    {
        IsStackable = isStackable;
        Hardness = hardness;
    }

    public override string GetDetails()
    {
        return $"Block: {Name} | Id: {Id} | Value: {Value} | Rarity: {Rarity} | " +
               $"Stackable: {IsStackable} | Hardness: {Hardness}";
    }
}