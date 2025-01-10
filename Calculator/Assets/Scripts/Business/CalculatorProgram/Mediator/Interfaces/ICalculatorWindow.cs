using UnityEngine;

namespace Business.CalculatorProgram.Mediator.Interfaces
{
    public interface ICalculatorWindow
    {
        void Hide();
        GameObject GameObject { get; }
    }
}