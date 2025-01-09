using Architecture.States;
using Architecture.States.Interfaces;
using Menu.Interfaces;

namespace Menu
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