namespace CSharper_1
{
    public abstract class Calculation2
    {
        public virtual int Add_5(int first, int second)
        {
            return first + second;
        }

        public abstract int Add_6(int first, int second);

        public sealed override string ToString()
        {
            return nameof(Calculation);
        }
    }
}