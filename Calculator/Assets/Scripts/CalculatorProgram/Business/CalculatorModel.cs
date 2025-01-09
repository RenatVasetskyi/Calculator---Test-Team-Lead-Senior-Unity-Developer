using CalculatorProgram.Interfaces;

namespace CalculatorProgram.Business
{
    public class CalculatorModel : ICalculator
    {
        private readonly ICalculatorValidator _calculatorValidator;
        private readonly IStringSplitter _stringSplitter;

        public CalculatorModel(ICalculatorValidator calculatorValidator, IStringSplitter stringSplitter)
        {
            _calculatorValidator = calculatorValidator;
            _stringSplitter = stringSplitter;
        }

        public int AddNumbers(string input)
        {
            if (!_calculatorValidator.IsAddExpressionValid(input))
            {
                throw new System.InvalidOperationException();
            }

            _stringSplitter.SplitBetweenPlusOperator(input, out int firstNumber, out int secondNumber);

            return firstNumber + secondNumber;
        }
    }
}