using Business.CalculatorProgram.Mediator.Interfaces;

namespace Business.CalculatorProgram.Error.Interfaces
{
    public interface ICalculatorErrorWindow : ICalculatorWindow
    {
        void DeleteMyself();
        void Initialize(ICalculatorWindowMediator mediator);
    }
}