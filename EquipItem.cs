using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace NepHack
{
    public enum Rarity
    {
        Normal,
        Rare,
        SuperRare,
        UltraRare
    }

    public enum PropertyType
    {
        Parameter,
        Trait
    }

    public class EquipItemProperty
    {
        public PropertyType Type  { private get; set; }
        public ushort       ID    { get;         set; }
        public ushort       Power { get;         set; }

        public override string ToString()
        {
            List<PropertyDef> defs = null;

            switch (Type)
            {
                case PropertyType.Parameter:
                    defs = Data.ParamDefs.ToList<PropertyDef>();

                    break;
                case PropertyType.Trait:
                    defs = Data.TraitDefs.ToList<PropertyDef>();

                    break;
            }

            PropertyDef def = defs?.Find(t => t.Variance > 0 && ID >= t.ID && ID <= t.ID + t.Variance || t.Variance <= 0 && ID == t.ID);

            return def != null ? $"{def.Name} ({Power}%)" : $"Unknown ({Power}%)";
        }
    }

    public class EquipItem : Addressable
    {
        [Category("Basic")]
        [Description("The current slot in the equipment array the item is occupying.")]
        public ushort Slot { get; set; }
        [Category("Basic")]
        [Description("The ID of the item.")]
        public ushort ID { get; set; }
        [Category("Basic")]
        [Description("The flags of the item.")]
        public ItemFlags Flags { get; set; }
        [Category("Basic")]
        [Description("The rarity of the item.")]
        public Rarity Rarity { get; set; }
        [Category("Basic")]
        [Description("The number of upgrades done to the item.")]
        public int Upgrades { get; set; }
        [Category("Basic")]
        [Description("The current rank of the item.")]
        public int Rank { get; set; }
        [Category("Basic")]
        [Description("The name of the item.")]
        public string Name { get; private set; }

        [Category("Parameters/Traits")]
        [Description("The parameters of the item which affect it's attack or defense types.")]
        public EquipItemProperty[] Parameters { get; set; } = new EquipItemProperty[4];
        [Category("Parameters/Traits")]
        [Description("The traits of the item which affect various stats and abilities.")]
        public EquipItemProperty[] Traits { get; set; } = new EquipItemProperty[8];

        public static int GetOffset(int index)
            => 4 + index * 0x40;

        public override void Read(int offset)
        {
            Offset = GetOffset(offset);

            Slot     = Program.EquipPointer.Read<ushort>(Offset);
            ID       = Program.EquipPointer.Read<ushort>(Offset + 2);
            Flags    = (ItemFlags)Program.EquipPointer.Read<short>(Offset + 4);
            Rarity   = (Rarity)Program.EquipPointer.Read<short>(Offset    + 6);
            Upgrades = Program.EquipPointer.Read<int>(Offset + 8);
            Rank     = Program.EquipPointer.Read<int>(Offset + 12);
            Name     = Data.GetItemName(ID);

            for (int i = 0; i < Parameters.Length; i++)
                Parameters[i] = new EquipItemProperty
                {
                    Type  = PropertyType.Parameter,
                    ID    = Program.EquipPointer.Read<ushort>(Offset + 16         + i * 4),
                    Power = Program.EquipPointer.Read<ushort>(Offset + 16 + i * 4 + 2)
                };

            for (int i = 0; i < Traits.Length; i++)
                Traits[i] = new EquipItemProperty
                {
                    Type  = PropertyType.Trait,
                    ID    = Program.EquipPointer.Read<ushort>(Offset + 32         + i * 4),
                    Power = Program.EquipPointer.Read<ushort>(Offset + 32 + i * 4 + 2)
                };
        }

        public override void Write()
        {
            Program.EquipPointer.Write(Offset,      Slot);
            Program.EquipPointer.Write(Offset + 2,  ID);
            Program.EquipPointer.Write(Offset + 4,  (ushort)Flags);
            Program.EquipPointer.Write(Offset + 6,  (ushort)Rarity);
            Program.EquipPointer.Write(Offset + 8,  Upgrades);
            Program.EquipPointer.Write(Offset + 12, Rank);

            for (int i = 0; i < Parameters.Length; i++)
            {
                Program.EquipPointer.Write(Offset + 16         + i * 4, Parameters[i].ID);
                Program.EquipPointer.Write(Offset + 16 + i * 4 + 2,     Parameters[i].Power);
            }

            for (int i = 0; i < Traits.Length; i++)
            {
                Program.EquipPointer.Write(Offset + 32         + i * 4, Traits[i].ID);
                Program.EquipPointer.Write(Offset + 32 + i * 4 + 2,     Traits[i].Power);
            }
        }

        public override string ToString()
            => Data.GetItemName(ID);
    }
}
