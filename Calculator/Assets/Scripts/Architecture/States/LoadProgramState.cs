using Architecture.Services.Interfaces;
using Architecture.States.Interfaces;

namespace Architecture.States
{
    public class LoadProgramState : IState
    {
        private const string MainMenuScene = "Program";
        
        private readonly ISceneLoader _sceneLoader;

        public LoadProgramState(ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
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
            
        }
    }
}