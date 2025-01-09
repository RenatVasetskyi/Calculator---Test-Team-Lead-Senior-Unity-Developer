using CalculatorProgram.Mediator.Interfaces;

namespace CalculatorProgram.Error.Interfaces
{
    public interface ICalculatorErrorWindow : ICalculatorWindow
    {
        void DeleteMyself();
        void Initialize(ICalculatorWindowMediator mediator);
    }
}