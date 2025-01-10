using Business.Architecture.Services.Interfaces;
using Business.Architecture.States.Interfaces;
using UnityEngine.Device;

namespace Business.Architecture.States
{
    using IState = Interfaces.IState;

    public class BootstrapState : IState
    {
        private const string BootSceneName = "Boot";

        private const int TargetFrameRate = 120;
        
        private readonly IStateMachine _stateMachine;
        private readonly ISceneLoader _sceneLoader;
        private readonly ICalculatorCashService _calculatorCashService;

        public BootstrapState(IStateMachine stateMachine, ISceneLoader sceneLoader, 
            ICalculatorCashService calculatorCashService)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
            _calculatorCashService = calculatorCashService;
        }

        public void Exit()
        {
        }

        public void Enter()
        {
            _sceneLoader.Load(BootSceneName, Initialize);
        }

        private void Initialize()
        {
            Application.targetFrameRate = TargetFrameRate; 
            
            _calculatorCashService.Load();
            
            _stateMachine.Enter<MainMenuState>();
        }
    }
}