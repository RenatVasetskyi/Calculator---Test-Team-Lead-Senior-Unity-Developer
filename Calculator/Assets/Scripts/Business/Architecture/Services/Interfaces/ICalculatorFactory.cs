using Business.CalculatorProgram.Error.Interfaces;
using Business.CalculatorProgram.Mediator.Interfaces;
using UnityEngine;

namespace Business.Architecture.Services.Interfaces
{
    public interface ICalculatorFactory : IFactory
    {
        ICalculatorWindow Calculator { get; }
        ICalculatorErrorWindow CalculatorErrorWindow { get; }
        Transform CreateContainer();
        ICalculatorWindow CreateCalculator();
        ICalculatorErrorWindow CreateErrorPopup();
    }
}