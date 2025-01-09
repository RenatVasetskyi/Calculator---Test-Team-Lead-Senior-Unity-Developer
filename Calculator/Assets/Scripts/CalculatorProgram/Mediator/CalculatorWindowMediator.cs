using Architecture.Services.Interfaces;
using CalculatorProgram.Error;
using CalculatorProgram.Interfaces;
using CalculatorProgram.Mediator.Interfaces;
using UnityEngine;

namespace CalculatorProgram.Mediator
{
    public class CalculatorWindowMediator : ICalculatorWindowMediator, ICalculatorObserver
    {
        private readonly ICalculatorFactory _factory;

        public CalculatorWindowMediator(ICalculatorFactory factory)
        {
            _factory = factory;
        }

        public void ShowCalculatorWindow()
        {
            _factory.CreateCalculator();
            
            if (_factory.CalculatorErrorWindow != null)
                _factory.CalculatorErrorWindow.Hide();
        }

        public void ShowErrorWindow()
        {
            CalculatorErrorWindow popup = _factory.CreateErrorPopup();
            popup.Initialize(this);
            
            if (_factory.Calculator != null)
                _factory.Calculator.Hide();
        }

        public void OnError()
        {
            ShowErrorWindow();
        }
    }
}