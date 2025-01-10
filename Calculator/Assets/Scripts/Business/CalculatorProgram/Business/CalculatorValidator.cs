using System.Text.RegularExpressions;
using Business.CalculatorProgram.Interfaces;

namespace Business.CalculatorProgram.Business
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