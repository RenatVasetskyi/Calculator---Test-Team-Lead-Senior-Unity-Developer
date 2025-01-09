using Calculator.Interfaces;

namespace Calculator
{
    public class StringSplitter : IStringSplitter
    {
        private const char OperatorAdd = '+';
        
        public void SplitBetweenPlusOperator(string input, out int firstValue, out int secondValue)
        {
            string[] parts = input.Split(OperatorAdd);
            
            firstValue = int.Parse(parts[0]);
            secondValue = int.Parse(parts[1]);
        }
    }
}