using System.Text.RegularExpressions;
using CalculatorProgram.Interfaces;

namespace CalculatorProgram.Business
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