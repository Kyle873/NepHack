namespace NepHack
{
    public abstract class Addressable
    {
        protected int Offset;

        public abstract void Read(int offset);
        public abstract void Write();
    }
}
