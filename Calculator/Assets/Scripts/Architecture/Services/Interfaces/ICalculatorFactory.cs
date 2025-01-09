using CalculatorProgram;
using CalculatorProgram.Error;
using UnityEngine;

namespace Architecture.Services.Interfaces
{
    public interface ICalculatorFactory : IFactory
    {
        Transform Container { get; }
        Calculator Calculator { get; }
        CalculatorErrorWindow CalculatorErrorWindow { get; }
        Transform CreateContainer();
        Calculator CreateCalculator();
        CalculatorErrorWindow CreateErrorPopup();
    }
}