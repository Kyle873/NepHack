namespace NepHack
{
    public class Character
    {
        public long   HP;
        public long   EXP;
        public int    SP;
        public int    AP;
        public int    PP;
        public int    BPLeft;
        public long   MaxHP;
        public ushort MaxSP;
        public ushort SCP;
        public ushort MaxAP;
        public ushort ACP;
        public ushort STR;
        public ushort VIT;
        public ushort INT;
        public ushort MEN;
        public ushort AGI;
        public ushort TEC;
        public ushort LUC;
        public ushort MOV;
        public ushort STRBonus;
        public ushort VITBonus;
        public ushort INTBonus;
        public ushort MENBonus;
        public ushort AGIBonus;
        public ushort TECBonus;

        public static int GetOffset(int index)
            => index * 0x358;

        public static int GetCalcOffset(int index)
            => index * 0x7E8;
    }
}
