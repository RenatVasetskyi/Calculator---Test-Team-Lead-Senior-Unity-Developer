namespace Calculator.Interfaces
{
    public interface IStringSplitter
    {
        void SplitBetweenPlusOperator(string input, out int firstValue, out int secondValue);
    }
}