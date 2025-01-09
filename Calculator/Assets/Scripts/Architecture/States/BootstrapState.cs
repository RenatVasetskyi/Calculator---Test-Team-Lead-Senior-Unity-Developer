using Architecture.Services.Interfaces;
using Architecture.States.Interfaces;
using UnityEngine.Device;
using IState = Architecture.States.Interfaces.IState;

namespace Architecture.States
{
    public class BootstrapState : IState
    {
        private const string BootSceneName = "Boot";

        private const int TargetFrameRate = 120;
        
        private readonly IStateMachine _stateMachine;
        private readonly ISceneLoader _sceneLoader;

        public BootstrapState(IStateMachine stateMachine, ISceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
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
            
            _stateMachine.Enter<LoadProgramState>();
        }
    }
}