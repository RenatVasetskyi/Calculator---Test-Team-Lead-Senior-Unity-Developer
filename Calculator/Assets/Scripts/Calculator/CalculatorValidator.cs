using System.Text.RegularExpressions;
using Calculator.Interfaces;

namespace Calculator
{
    public class CalculatorValidator : ICalculatorValidator
    {
        public bool IsAddExpressionValid(string input)
        {
            string pattern = @"^\d+\+\d+$";
            return Regex.IsMatch(input, pattern);
        }
    }
}