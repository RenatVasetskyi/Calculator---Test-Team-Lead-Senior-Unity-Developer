using UnityEngine;

namespace Architecture.Services.Interfaces
{
    public interface ICalculatorFactory : IFactory
    {
        Canvas CalculatorCanvas { get; }
        Canvas CreateCalculatorCanvas();
    }
}