using Business.Architecture.Services.Interfaces;
using Business.CalculatorProgram.Error.Interfaces;
using Business.CalculatorProgram.Interfaces;
using Business.CalculatorProgram.Mediator.Interfaces;

namespace Business.CalculatorProgram.Mediator
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
            ICalculatorErrorWindow popup = _factory.CreateErrorPopup() as ICalculatorErrorWindow;
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