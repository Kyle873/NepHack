namespace NepHack
{
    public abstract class Def
    {
        public ushort ID;
        public string Name;
        public string Description;
    }

    public abstract class PropertyDef : Def
    {
        public ushort Variance;
    }

    public class ItemDef : Def
    {
        public int StackSize;
        public int BuyPrice;
        public int SellPrice;

        public static int GetOffset(int index)
            => index * 0xA0;
    }

    public class ParameterDef : PropertyDef
    {
    }

    public class TraitDef : PropertyDef
    {
        public string Category;
    }

    public class IDRange
    {
        public string Name;
        public ushort StartID;
        public ushort EndID;

        public IDRange()
        {
        }

        public IDRange(string name, ushort startID, ushort endID)
        {
            Name    = name;
            StartID = startID;
            EndID   = endID;
        }

        public override string ToString()
            => $"{Name} ({StartID} - {EndID})";
    }
}
