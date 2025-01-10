using Mono;
using UnityEngine;

namespace Business.Architecture.Services.Interfaces
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