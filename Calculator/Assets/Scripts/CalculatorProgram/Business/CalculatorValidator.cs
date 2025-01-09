using System.Text.RegularExpressions;
using CalculatorProgram.Interfaces;

namespace CalculatorProgram.Business
{
    public class CalculatorValidator : ICalculatorValidator
    {
        private const string ValidationPattern = @"^\d+\+\d+$"; 
        
        public bool IsAddExpressionValid(string input)
        {
            return Regex.IsMatch(input, ValidationPattern);
        }
    }
}