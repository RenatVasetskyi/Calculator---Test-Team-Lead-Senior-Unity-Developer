using Architecture.Services.Interfaces;
using Architecture.States.Interfaces;
using Data;
using UnityEngine;

namespace Architecture.States
{
    public class MainMenuState : IState
    {
        private const string MainMenuScene = "Main Menu";
        
        private readonly ISceneLoader _sceneLoader;
        private readonly IFactory _factory;

        public MainMenuState(ISceneLoader sceneLoader, IFactory factory)
        {
            _sceneLoader = sceneLoader;
            _factory = factory;
        }
        
        public void Exit()
        {
        }

        public void Enter()
        {
            _sceneLoader.Load(MainMenuScene, Initialize);
        }

        private void Initialize()
        {
            Camera camera = _factory.CreateBaseWithContainer<Camera>(ResourcesLoadingPaths.Camera);
            Canvas menuUI = _factory.CreateBaseWithContainer<Canvas>(ResourcesLoadingPaths.MenuUI);
            menuUI.worldCamera = camera;
        }
    }
}