using Calculator.Interfaces;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        private readonly ICalculatorValidator _calculatorValidator;
        private readonly IStringSplitter _stringSplitter;

        public Calculator(ICalculatorValidator calculatorValidator, IStringSplitter stringSplitter)
        {
            _calculatorValidator = calculatorValidator;
            _stringSplitter = stringSplitter;
        }

        public int AddNumbers(string input)
        {
            if (!_calculatorValidator.IsAddExpressionValid(input))
            {
                throw new System.Exception("Invalid input");
            }

            _stringSplitter.SplitBetweenPlusOperator(input, out int firstNumber, out int secondNumber);

            return firstNumber + secondNumber;
        }
    }
}