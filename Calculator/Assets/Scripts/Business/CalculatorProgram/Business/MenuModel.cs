using Business.Architecture.States;
using Business.Architecture.States.Interfaces;
using Business.CalculatorProgram.Interfaces;

namespace Business.CalculatorProgram.Business
{
    public class MenuModel : IMenu
    {
        private readonly IStateMachine _stateMachine;

        public MenuModel(IStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }
        
        public void EnterCalculatorProgram()
        {
            _stateMachine.Enter<ProgramState>();
        }
    }
}