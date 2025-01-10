using Business.Architecture.Services.Interfaces;
using Business.Architecture.States.Interfaces;
using Business.Data;
using Mono;
using UnityEngine;

namespace Business.Architecture.States
{
    public class ProgramState : IState
    {
        private const string ProgramScene = "Program";
        
        private readonly ISceneLoader _sceneLoader;
        private readonly ICalculatorFactory _factory;

        public ProgramState(ISceneLoader sceneLoader, ICalculatorFactory factory)
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
            Transform container = _factory.CreateContainer();
            Camera camera = _factory.CreateBaseWithContainer<Camera>(ResourcesLoadingPaths.Camera, container);
            Calculator calculatorUI = _factory.CreateCalculator();
        }
    }
}