using System.Collections.Generic;
using Architecture.Services.Interfaces;
using CalculatorProgram.Interfaces;

namespace CalculatorProgram.Business
{
    public class CalculatorModel : ICalculator
    {
        private readonly ICalculatorValidator _calculatorValidator;
        private readonly IStringSplitter _stringSplitter;
        private readonly ICalculatorCashService _calculatorCashService;
        private readonly List<ICalculatorObserver> _observers = new();

        public CalculatorModel(ICalculatorValidator calculatorValidator, IStringSplitter stringSplitter, 
            ICalculatorCashService calculatorCashService)
        {
            _calculatorValidator = calculatorValidator;
            _stringSplitter = stringSplitter;
            _calculatorCashService = calculatorCashService;
        }

        public string AddNumbers(string input)
        {
            if (!_calculatorValidator.IsAddExpressionValid(input))
            {
                NotifyObserversAboutError();
                string errorText = $"Error: {input}";
                _calculatorCashService.Cash(errorText);
                return errorText;
            }

            _stringSplitter.SplitBetweenPlusOperator(input, out int firstNumber, out int secondNumber);

            string result = (firstNumber + secondNumber).ToString();
            _calculatorCashService.Cash(result);
            return result;
        }
        
        public string GetCash()
        {
            return _calculatorCashService.GetCash();
        }
        
        public void SaveCurrentInput(string input)
        {
            _calculatorCashService.CashCurrentInput(input);
        }

        public string GetCurrentInput()
        {
            return _calculatorCashService.CurrentInput;
        }

        public void Subscribe(ICalculatorObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnSubscribe(ICalculatorObserver observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObserversAboutError()
        {
            foreach (ICalculatorObserver observer in _observers)
                observer.OnError();
        }
    }
}