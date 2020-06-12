using System;
using System.Collections.Generic;
using System.IO;

namespace NepHack
{
    public static class Data
    {
        const int MaxItemData = 1886;

        public static List<ItemDef> ItemDefs     = new List<ItemDef>();
        public static List<IDRange> ItemIDRanges = new List<IDRange>();

        public static List<ParameterDef> ParamDefs = new List<ParameterDef>();

        public static List<string>   TraitCategories = new List<string>();
        public static List<TraitDef> TraitDefs       = new List<TraitDef>();

        public static string GetItemName(ushort id)
        {
            string name = ItemDefs.Find(i => i.ID == id)?.Name;

            if (string.IsNullOrEmpty(name))
                name = "Unknown";

            return name;
        }

        public static void ParseItemData()
        {
            for (int i = 0; i < MaxItemData; i++)
            {
                IntPtr nameAddress        = Program.Memory[Program.BaseAddress + Program.ItemDataOffset + ItemDef.GetOffset(i) + 6, false].Read<IntPtr>();
                IntPtr descriptionAddress = Program.Memory[Program.BaseAddress + Program.ItemDataOffset + ItemDef.GetOffset(i) + 150, false].Read<IntPtr>();

                ItemDefs.Add(new ItemDef
                {
                    ID          = Program.ItemDataPointer.Read<ushort>(ItemDef.GetOffset(i)),
                    Name        = Program.Memory.ReadString(nameAddress,        false),
                    Description = Program.Memory.ReadString(descriptionAddress, false),
                    StackSize   = Program.ItemDataPointer.Read<int>(ItemDef.GetOffset(i) + 26),
                    BuyPrice    = Program.ItemDataPointer.Read<int>(ItemDef.GetOffset(i) + 38),
                    SellPrice   = Program.ItemDataPointer.Read<int>(ItemDef.GetOffset(i) + 42)
                });
            }
        }

        public static void ParseIDRanges()
        {
            string[] lines = File.ReadAllLines("ID Ranges.txt");

            foreach (string line in lines)
            {
                if (line.StartsWith("//") || string.IsNullOrWhiteSpace(line))
                    continue;

                string[] split = line.Split(',');

                ItemIDRanges.Add(new IDRange
                {
                    Name    = split[0].Trim(),
                    StartID = ushort.Parse(split[1].Trim()),
                    EndID   = ushort.Parse(split[2].Trim())
                });
            }
        }

        public static void ParseParameters()
        {
            string[] lines = File.ReadAllLines("Parameters.txt");

            foreach (string line in lines)
            {
                if (line.StartsWith("//") || string.IsNullOrWhiteSpace(line))
                    continue;

                string[] split = line.Split(',');

                ParamDefs.Add(new ParameterDef
                {
                    ID       = ushort.Parse(split[1].Trim()),
                    Name     = split[0].Trim(),
                    Variance = (ushort)(split.Length > 2 ? ushort.Parse(split[2].Trim()) : 0)
                });
            }
        }

        public static void ParseTraits()
        {
            string[] lines    = File.ReadAllLines("Traits.txt");
            string   category = string.Empty;

            foreach (string line in lines)
            {
                if (line.StartsWith("//") || string.IsNullOrWhiteSpace(line))
                    continue;

                if (line.StartsWith("///"))
                {
                    category = line.Split(new[] { "//" }, StringSplitOptions.None)[1].Trim();
                    TraitCategories.Add(category);

                    continue;
                }

                string[] split = line.Split(',');

                TraitDefs.Add(new TraitDef
                {
                    ID       = ushort.Parse(split[1].Trim()),
                    Name     = split[0].Trim(),
                    Variance = (ushort)(split.Length > 2 ? ushort.Parse(split[2].Trim()) : 0),
                    Category = category
                });
            }
        }
    }
}
