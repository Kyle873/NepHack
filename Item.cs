using System;

#pragma warning disable 169

namespace NepHack
{
    [Flags]
    public enum ItemFlags
    {
        New    = 0x01,
        Viewed = 0x03
    }

    /*
     * 0x00 - ID
     * 0x03 - Description String Table Index
     * 0x22 - Icon Index
     * 0x38 - Buy Price
     * 0x42 - Sell Price
     * 0x60 - Attack Base
     * 0x66 - Accuracy Balance
     * 0x70 - Radius
     * 0x74 - Skill Slots
     * 0x86 - Traits
     */
    public class ItemInfo
    {
        public short ID;
        int          padding;
        public long  NameDbIndex;
        public long  DescriptionDbIndex;
        public int   IconIndex;
        public int   MaxQuantity;
        public int   Flags;
        public int   Unknown;
        public int   BuyPrice;
        public int   SellPrice;

        public static int GetOffset(int index)
            => index * 0xA0;
    }

    public class Item
    {
        public ushort    ID;
        public ItemFlags Flags;
        public int       Quantity;

        public static int GetOffset(int index)
            => 4 + index * 0x08;
    }
}
