using Architecture.Services.Interfaces;
using Architecture.States.Interfaces;
using CalculatorProgram;
using Data;
using UnityEngine;

namespace Architecture.States
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