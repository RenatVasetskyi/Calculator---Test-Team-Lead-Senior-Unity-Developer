using Architecture.Services.Interfaces;
using Architecture.States.Interfaces;
using Data;
using UnityEngine;

namespace Architecture.States
{
    public class ProgramState : IState
    {
        private const string ProgramScene = "Program";
        
        private readonly ISceneLoader _sceneLoader;
        private readonly IFactory _factory;

        public ProgramState(ISceneLoader sceneLoader, IFactory factory)
        {
            _sceneLoader = sceneLoader;
            _factory = factory;
        }
        
        public void Exit()
        {
        }

        public void Enter()
        {
            _sceneLoader.Load(ProgramScene, Initialize);
        }

        private void Initialize()
        {
            Camera camera = _factory.CreateBaseWithContainer<Camera>(ResourcesLoadingPaths.Camera);
            Canvas calculatorUI = _factory.CreateBaseWithContainer<Canvas>(ResourcesLoadingPaths.CalculatorUI);
            calculatorUI.worldCamera = camera;
        }
    }
}