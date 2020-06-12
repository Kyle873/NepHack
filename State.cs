namespace NepHack
{
    public static class State
    {
        public static bool InNeplunker()
            => (long)Program.NeplunkerPointer.BaseAddress != 0x44;
    }
}
