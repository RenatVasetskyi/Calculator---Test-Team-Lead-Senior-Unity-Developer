using System.Collections.Generic;
using CalculatorProgram.Interfaces;

namespace CalculatorProgram.Business
{
    public class CalculatorModel : ICalculator
    {
        private readonly ICalculatorValidator _calculatorValidator;
        private readonly IStringSplitter _stringSplitter;
        private readonly List<ICalculatorObserver> _observers = new();

        public CalculatorModel(ICalculatorValidator calculatorValidator, IStringSplitter stringSplitter)
        {
            _calculatorValidator = calculatorValidator;
            _stringSplitter = stringSplitter;
        }

        public string AddNumbers(string input)
        {
            if (!_calculatorValidator.IsAddExpressionValid(input))
            {
                NotifyObserversAboutError(input);
                return $"Error: {input}";
            }

            _stringSplitter.SplitBetweenPlusOperator(input, out int firstNumber, out int secondNumber);

            return (firstNumber + secondNumber).ToString();
        }
        
        public void Subscribe(ICalculatorObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnSubscribe(ICalculatorObserver observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObserversAboutError(string input)
        {
            foreach (ICalculatorObserver observer in _observers)
                observer.GetInfo($"Error: {input}");
        }
    }
}