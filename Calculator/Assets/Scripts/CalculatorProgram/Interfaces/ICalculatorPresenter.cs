﻿namespace CalculatorProgram.Interfaces
{
    public interface ICalculatorPresenter
    {
        void OnResultButtonClicked();
        void ShowCash();
        void ShowCurrentInput();
        void SaveCurrentInput();
    }
}