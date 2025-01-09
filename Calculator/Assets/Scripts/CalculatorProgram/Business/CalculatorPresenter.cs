﻿using CalculatorProgram.Interfaces;

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
            _model.AddNumbers(input);
            _view.ShowResult(_model.GetCash());
        }

        public void ShowCash()
        {
            _view.ShowResult(_model.GetCash());
        }

        public void ShowCurrentInput()
        {
            _view.ShowCurrentInput(_model.GetCurrentInput());
        }

        public void SaveCurrentInput()
        {
            _model.SaveCurrentInput(_view.InputText);
        }
    }
}