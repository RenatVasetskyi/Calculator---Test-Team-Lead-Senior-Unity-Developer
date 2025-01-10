using Business.Architecture.States;
using Business.Architecture.States.Interfaces;
using Mono.Menu.Interfaces;

namespace Mono.Menu
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