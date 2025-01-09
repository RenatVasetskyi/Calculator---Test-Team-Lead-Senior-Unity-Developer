using System;
using CalculatorProgram.Interfaces;

namespace CalculatorProgram.Business
{
    public class CalculatorPresenter : ICalculatorPresenter
    {
        private readonly ICalculatorView _view;
        private readonly ICalculator _model;

        public CalculatorPresenter(ICalculatorView view, ICalculator model)
        {
            _view = view;
            _model = model;
        }

        public void OnResultButtonClicked()
        {
            string input = _view.InputText;

            try
            {
                string result = _model.AddNumbers(input);
                _view.ShowResult(result);
            }
            catch (InvalidOperationException exception)
            {
                _view.ShowError(input);
            }
        }
    }
}