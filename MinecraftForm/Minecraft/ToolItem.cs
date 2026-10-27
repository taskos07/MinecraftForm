namespace MinecraftForm;

public class ToolItem : Item, ICraftable
{
    public int Durability { get; set; }
    public ToolType ToolType { get; set; }

    public ToolItem(string id, string name, int value, ItemRarity rarity, int durability, ToolType toolType)
        : base(id, name, value, rarity)
    {
        Durability = durability;
        ToolType = toolType;
    }

    public override string GetDetails()
    {
        return $"Tool: {Name} | Id: {Id} | Value: {Value} | Rarity: {Rarity} | " +
               $"ToolType: {ToolType} | Durability: {Durability}";
    }

    public bool CanCraft()
    {
        return Durability > 0;
    }

    public void Craft()
    {
        if (!CanCraft())
        {
            Console.WriteLine($"Non è possibile creare {Name}: durata insufficiente.");
            return;
        }

        Console.WriteLine($"Creato: {Name} ({ToolType})");
        Durability--;
    }
}